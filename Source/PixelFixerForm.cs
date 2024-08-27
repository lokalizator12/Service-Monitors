using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using ServiceMonitorEVK.Main;
using ServiceMonitorEVK.Source.Main;
using ServiceMonitorEVK.Testing_Monitor;
using ServiceMonitorEVK.Util_Managers;

namespace ServiceMonitorEVK
{
    public partial class PixelFixerForm : MaterialForm
    {
        private const int MaxTimeInMilliseconds = 24 * 60 * 60 * 1000;

        private readonly MaterialSkinManager materialSkinManager;
        private Color currentColor = Color.Green;
        private readonly Form1 form1;
        private bool isFlashing, isSingleColor;
        private Overlay monitorForm;
        private readonly MonitorInfoManager monitorInfoManager;
        private Dictionary<string, string> monitorNameToIdentifierMap;


        private List<Color> repairColors = new List<Color>
            { Color.Red, Color.Green, Color.Blue, Color.White, Color.Black };

        private List<Rectangle> repairRegions = new List<Rectangle>(); // Список областей для ремонта

        private Screen selectedScreen;

        private readonly Stopwatch stopwatch;
        private int totalTimeInMilliseconds;

        

        public PixelFixerForm(Form1 form)
        {
            form1 = form;
            monitorInfoManager = new MonitorInfoManager();
            materialSkinManager = MaterialSkinManager.Instance;
            InitializeComponent();
            InitizializeCustomForm();
            stopwatch = new Stopwatch();
            InitializeCustomComponents();
            SystemEvents.DisplaySettingsChanged += OnDisplaySettingsChanged;
        }

        public void InitizializeCustomForm()
        {
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            CheckTheme();
            DrawerAutoShow = true;
        }

        private void CheckTheme()
        {
            materialSkinManager.Theme = form1.materialSwitch1.Checked ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey900 : Primary.BlueGrey800,
                materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey800 : Primary.BlueGrey900,
                materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey700 : Primary.BlueGrey500,
                Accent.Red400,
                TextShade.WHITE);

            materialCard1.BackColor = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK
                ? Color.FromArgb(0x21, 0x21, 0x21)
                : Color.FromArgb(0x37, 0x47, 0x4F);
        }

        private void OnDisplaySettingsChanged(object sender, EventArgs e)
        {
            FillMonitorComboBox();
        }

        private void FillMonitorComboBox()
        {
            monitorComboBox1.Items.Clear();

            monitorNameToIdentifierMap = new Dictionary<string, string>();
            var monitorNames = Screen.AllScreens.Select(screen => screen.DeviceName).ToList();
            var friendlyNames = monitorInfoManager.GetFriendlyMonitorNames();

            for (var i = 0; i < monitorNames.Count; i++)
            {
                var identifier = monitorNames[i];
                var friendlyName = friendlyNames[i];
                monitorNameToIdentifierMap[friendlyName] = identifier;
                monitorComboBox1.Items.Add(friendlyName);
            }

            var nonIntegratedIndex = monitorComboBox1.Items.Count > 1 ? 1 : 0;
            monitorComboBox1.SelectedIndex = nonIntegratedIndex;
            selectedScreen = Screen.AllScreens[nonIntegratedIndex];
        }

        private void InitializeCustomComponents()
        {
            FillMonitorComboBox();
            presetColorComboBox1.SelectedIndex = 0;
            testModeComboBox1.SelectedIndex = 0;
        }

        private void ShowOnMonitor()
        {
            monitorForm?.Close();


            monitorForm = new Overlay(currentColor, intervalTrackBar1.Value,
                multi_colorCheckBox1.Checked,
                isSingleColor, repairColors,
                repairRegions, testModeComboBox1.SelectedItem.ToString());
            monitorForm.StartPosition = FormStartPosition.Manual;
            monitorForm.Location = selectedScreen.Bounds.Location;
            monitorForm.Size = selectedScreen.Bounds.Size;
            monitorForm.FormBorderStyle = FormBorderStyle.None;
            monitorForm.WindowState = FormWindowState.Maximized;
            monitorForm.Show();
            monitorForm.StartFlashing();
        }


        private void colorPickerButton_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog1.Color;
                isSingleColor = true;
                repairColors = new List<Color> { currentColor };
            }
        }


        private void startStopButton_Click_1(object sender, EventArgs e)
        {
            isFlashing = !isFlashing;
            if (isFlashing)
            {
                stopwatch.Reset();
                stopwatch.Start();

                var hours = (int)hoursUpDown.Value;
                var minutes = (int)minutesUpDown.Value;
                var seconds = (int)secondsUpDown.Value;
                totalTimeInMilliseconds = (hours * 3600 + minutes * 60 + seconds) * 1000;

                if (hours == 0 && minutes == 0 && seconds == 0) totalTimeInMilliseconds = 0;
                if (totalTimeInMilliseconds > MaxTimeInMilliseconds)
                {
                    MessageBox.Show(@"Max. czas wykonania  - 24 godziny ", "błąd", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    isFlashing = false;
                    (sender as Button).Text = @"Start";
                    return;
                }

                progressBar1.Maximum = totalTimeInMilliseconds / 1000;
                progressBar1.Value = 0;
                timer1.Interval = 1000;
                timer1.Start();
                ShowOnMonitor();
                ((Button)sender).Text = @"Stop";
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

                ((Button)sender).Text = @"Start";
                isSingleColor = false;
                progressBar1.Value = 0;
                timeLeftLabel1.Text = string.Empty;
                hoursUpDown.Value = 0;
                minutesUpDown.Value = 0;
                secondsUpDown.Value = 0;
            }
        }


        private void locateButton_Click(object sender, EventArgs e)
        {
            using (var regionSelector = new RegionSelectorForm(selectedScreen))
            {
                regionSelector.Cursor = Cursors.Cross;
                if (regionSelector.ShowDialog() == DialogResult.OK)
                {
                    regionSelector.Cursor = Cursors.Default;
                    repairRegions = regionSelector.SelectedRegions;
                }
            }
        }


        private void presetColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (presetColorComboBox1.SelectedItem.ToString())
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
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(new Action(() =>
                {
                    if (totalTimeInMilliseconds > 0)
                    {
                        var elapsedMilliseconds = (int)stopwatch.ElapsedMilliseconds;
                        progressBar1.Value = elapsedMilliseconds / 1000;

                        if (progressBar1.Value < progressBar1.Maximum)
                            UpdateTimeLeft(elapsedMilliseconds);
                        else
                            CompleteFlashing();
                    }
                }));
            }
            else
            {
                if (totalTimeInMilliseconds > 0)
                {
                    var elapsedMilliseconds = (int)stopwatch.ElapsedMilliseconds;
                    progressBar1.Value = elapsedMilliseconds / 1000;

                    if (progressBar1.Value < progressBar1.Maximum)
                        UpdateTimeLeft(elapsedMilliseconds);
                    else
                        CompleteFlashing();
                }
            }
        }


        private void UpdateTimeLeft(int elapsedMilliseconds)
        {
            var remainingTime = totalTimeInMilliseconds - elapsedMilliseconds;
            var timeSpan = TimeSpan.FromMilliseconds(remainingTime);
            timeLeftLabel1.Text = $@"Zostało {timeSpan.Hours}g. {timeSpan.Minutes}m. {timeSpan.Seconds}sek.";
        }

        private void CompleteFlashing()
        {
            timer1.Stop();
            if (monitorForm != null)
            {
                monitorForm.StopFlashing();
                monitorForm.Close();
            }

            startStopButton1.Text = @"Start";
            isFlashing = false;
            progressBar1.Value = 0;
            timeLeftLabel1.Text = string.Empty;
            MessageBox.Show(@"Naprawa skończona", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void intervalTrackBar_Scroll_1(object sender, int newValue)
        {
            if (intervalTrackBar1.Value > 1)
            {
                timer1.Interval = intervalTrackBar1.Value;

                if (monitorForm != null)
                {
                    monitorForm.CurrentInterval = intervalTrackBar1.Value;
                    monitorForm.StopFlashing();
                    monitorForm.StartFlashing();
                }
            }
        }

        private void multi_colorCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = multi_colorCheckBox1.Checked;
            colorPickerButton1.Enabled = !isChecked;
            presetColorComboBox1.Enabled = isChecked;

            multi_colorCheckBox1.Text = !multi_colorCheckBox1.Checked ? "Single color" : "Multicolor";
        }

        private void materialComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (presetColorComboBox1.SelectedItem.ToString())
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

    }
}