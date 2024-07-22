using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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

        private int progressValue = 0;
        private int totalTimeInMilliseconds;
        private const int MaxTimeInMilliseconds = 24 * 60 * 60 * 1000;

        public PixelFixerForm()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            InitializeCustomComponents();
        }
        private void InitializeCustomComponents()
        {
            intervalLabel.Text = intervalTrackBar.Value.ToString() + "ms.";
            foreach (var screen in Screen.AllScreens)
            {
                monitorComboBox.Items.Add(screen.DeviceName);
            }
            presetColorComboBox.SelectedIndex = 0;
            testModeComboBox.SelectedIndex = 0;
            monitorComboBox.SelectedIndex = 0;
        }

        private void ShowOnMonitor()
        {
            if (monitorForm != null)
            {
                monitorForm.Close();
            }

            Screen selectedScreen = Screen.AllScreens[monitorComboBox.SelectedIndex];
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
                    MessageBox.Show("Max. czas wykonania выполнения - 24 часа и минимум 1 секунда.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void monitorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void locateButton_Click(object sender, EventArgs e)
        {
            Screen selectedScreen = Screen.AllScreens[monitorComboBox.SelectedIndex];
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

    }
    }
