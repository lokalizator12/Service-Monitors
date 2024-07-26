using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace changeResolution1
{
    public partial class PixelFixerForm : Form
    {
        private bool isFlashing = false;
        private Color currentColor = Color.Green;
        private Overlay monitorForm;
        private List<Color> repairColors = new List<Color> { Color.Red, Color.Green, Color.Blue, Color.White, Color.Black };
        private List<Rectangle> repairRegions = new List<Rectangle>(); // Список областей для ремонта
        //private ToolTip toolTip;
        private Stopwatch stopwatch;
        private Screen selectedScreen;
        private Dictionary<string, string> monitorNameToIdentifierMap;
        MonitorInfoManager monitorInfoManager;

        private int progressValue = 0;
        private int totalTimeInMilliseconds;
        private const int MaxTimeInMilliseconds = 24 * 60 * 60 * 1000;

        public PixelFixerForm()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            monitorInfoManager = new MonitorInfoManager();
            InitializeCustomComponents();
        }
        private void InitializeCustomComponents()
        {
            intervalLabel.Text = intervalTrackBar.Value.ToString() + "ms.";
            monitorNameToIdentifierMap = new Dictionary<string, string>();

            var monitorNames = Screen.AllScreens.Select(screen => screen.DeviceName).ToList();
            var friendlyNames = monitorInfoManager.GetFriendlyMonitorNames();

            for (int i = 0; i < monitorNames.Count; i++)
            {
                var identifier = monitorNames[i];
                var friendlyName = friendlyNames[i];
                monitorNameToIdentifierMap[friendlyName] = identifier;
                monitorComboBox.Items.Add(friendlyName);
            }

            // Select the first non-integrated monitor
            int nonIntegratedIndex = monitorComboBox.Items.Count > 1 ? 1 : 0;
            monitorComboBox.SelectedIndex = nonIntegratedIndex;
            selectedScreen = Screen.AllScreens[nonIntegratedIndex];

            presetColorComboBox.SelectedIndex = 0;
            testModeComboBox.SelectedIndex = 0;
            siticoneTextBox1.Text = "OSTRZEŻENIE: Proces ten spowoduje miganie świateł, które mogą wywołać drgawki u osób cierpiących na padaczkę światłoczułą. Postępuj ostrożnie.";
        }

        private void ShowOnMonitor()
        {
            if (monitorForm != null)
            {
                monitorForm.Close();
            }

            
            monitorForm = new Overlay(currentColor, intervalTrackBar.Value,
                isMulticolor: multi_colorCheckBox.Checked, repairColors: repairColors,
                repairRegions: repairRegions, testMode: testModeComboBox.SelectedItem.ToString());
            monitorForm.StartPosition = FormStartPosition.Manual;
            monitorForm.Location = selectedScreen.Bounds.Location;
            monitorForm.Size = selectedScreen.Bounds.Size;
            monitorForm.FormBorderStyle = FormBorderStyle.None;
            monitorForm.WindowState = FormWindowState.Maximized;
            monitorForm.Show();
            monitorForm.StartFlashing();
        }

        private void intervalTrackBar_Scroll_1(object sender, EventArgs e)
        {
            intervalLabel.Text = intervalTrackBar.Value.ToString() + "ms.";
            timer1.Interval = intervalTrackBar.Value;

            if (monitorForm != null)
            {
                monitorForm.currentInterval = intervalTrackBar.Value;
                monitorForm.StopFlashing();
                monitorForm.StartFlashing();
            }
        }

        private void colorPickerButton_Click_1(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    currentColor = colorDialog.Color;
                    repairColors = new List<Color> { currentColor };
                }
            }
        }


        private void startStopButton_Click_1(object sender, EventArgs e)
        {
            isFlashing = !isFlashing;
            if (isFlashing)
            {
                stopwatch.Reset();
                stopwatch.Start();

                int hours = (int)hoursUpDown.Value;
                int minutes = (int)minutesUpDown.Value;
                int seconds = (int)secondsUpDown.Value;
                totalTimeInMilliseconds = (hours * 3600 + minutes * 60 + seconds) * 1000;

                if (hours == 0 && minutes == 0 && seconds == 0)
                {
                    totalTimeInMilliseconds = 0;
                }
                if (totalTimeInMilliseconds > MaxTimeInMilliseconds )
                {
                    MessageBox.Show("Max. czas wykonania  - 24 godziny ", "błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isFlashing = false;
                    (sender as Button).Text = "Start";
                    return;
                }

                progressBar.Maximum = totalTimeInMilliseconds / 1000;
                progressBar.Value = 0;
                timer1.Interval = 1000;
                timer1.Start();
                ShowOnMonitor();
                (sender as Button).Text = "Stop";
            }
            else
            {
                timer1.Stop();
                stopwatch.Stop();
                if (monitorForm != null)
                {
                    monitorForm.StopFlashing();
                    monitorForm.Close();
                }
                (sender as Button).Text = "Start";
                progressBar.Value = 0;
                timeLeftLabel.Text = string.Empty;
                hoursUpDown.Value = 0;
                minutesUpDown.Value = 0;
                secondsUpDown.Value = 0;
            }
        }

      

        private void locateButton_Click(object sender, EventArgs e)
        {
            using (RegionSelectorForm regionSelector = new RegionSelectorForm(selectedScreen))
            {
                if (regionSelector.ShowDialog() == DialogResult.OK)
                {
                    repairRegions = regionSelector.SelectedRegions;
                }
            }
        }

        private void multi_colorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = multi_colorCheckBox.Checked;
            colorPickerButton.Enabled = !isChecked;
            presetColorComboBox.Enabled = isChecked;
        }

        private void presetColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (presetColorComboBox.SelectedItem.ToString())
            {
                case "RGB Cycle":
                    repairColors = new List<Color> { Color.Red, Color.Green, Color.Blue };
                    break;
                case "Black & White":
                    repairColors = new List<Color> { Color.Black, Color.White };
                    break;
                case "Red & Green & Blue":
                    repairColors = new List<Color> { Color.Red, Color.Green, Color.Blue };
                    break;
                default:
                    repairColors = new List<Color> { currentColor };
                    break;
            }
        }

        private void UpdateProgress()
        {
            if (progressBar.InvokeRequired)
            {
                progressBar.Invoke(new Action(() =>
                {
                    if (totalTimeInMilliseconds > 0)
                    {
                        int elapsedMilliseconds = (int)stopwatch.ElapsedMilliseconds;
                        progressBar.Value = elapsedMilliseconds / 1000;

                        if (progressBar.Value < progressBar.Maximum)
                        {
                            UpdateTimeLeft(elapsedMilliseconds);
                        }
                        else
                        {
                            CompleteFlashing();
                        }
                    }
                }));
            }
            else
            {
                if (totalTimeInMilliseconds > 0)
                {
                    int elapsedMilliseconds = (int)stopwatch.ElapsedMilliseconds;
                    progressBar.Value = elapsedMilliseconds / 1000;

                    if (progressBar.Value < progressBar.Maximum)
                    {
                        UpdateTimeLeft(elapsedMilliseconds);
                    }
                    else
                    {
                        CompleteFlashing();

                    }
                }
            }
        }


            private void UpdateTimeLeft(int elapsedMilliseconds)
            {
                int remainingTime = totalTimeInMilliseconds - elapsedMilliseconds;
                TimeSpan timeSpan = TimeSpan.FromMilliseconds(remainingTime);
                timeLeftLabel.Text = $"Zostało {timeSpan.Hours}g. {timeSpan.Minutes}m. {timeSpan.Seconds}sek.";
            }

            private void CompleteFlashing()
            {
                timer1.Stop();
                if (monitorForm != null)
                {
                    monitorForm.StopFlashing();
                    monitorForm.Close();
                }
                startStopButton.Text = "Start";
                isFlashing = false;
                progressBar.Value = 0;
                timeLeftLabel.Text = string.Empty;
                MessageBox.Show("Naprawa skończona", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            private void hoursUpDown_ValueChanged(object sender, EventArgs e)
            {

            }

            private void timer1_Tick(object sender, EventArgs e)
            {
                UpdateProgress();
            }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }
