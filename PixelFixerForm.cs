using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.Adapters;

namespace changeResolution1
{
    public partial class PixelFixerForm : Form
    {

        private bool isFlashing = false;
        private Color currentColor = Color.Black;
        private Overlay monitorForm;
        private List<Color> repairColors = new List<Color> { Color.Red, Color.Green, Color.Blue, Color.White, Color.Black };
        private List<Rectangle> repairRegions = new List<Rectangle>();


        public PixelFixerForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }


        private void InitializeCustomComponents()
        {
            foreach (var screen in Screen.AllScreens)
            {
                monitorComboBox.Items.Add(screen.DeviceName);
            }
            monitorComboBox.SelectedIndex = 0;
        }

        private void ShowOnMonitor()
        {
            if (monitorForm != null)
            {
                monitorForm.Close();
            }

            Screen selectedScreen = Screen.AllScreens[monitorComboBox.SelectedIndex];
            monitorForm = new Overlay(currentColor, intervalTrackBar.Value, isMulticolor: multi_colorCheckBox.Checked, repairColors: repairColors, repairRegions: repairRegions);
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
            intervalLabel.Text = intervalTrackBar.Value.ToString();
            timer1.Interval = intervalTrackBar.Value;
            if (monitorForm != null)
            {
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
                }
            }
        }

        private void startStopButton_Click_1(object sender, EventArgs e)
        {
            isFlashing = !isFlashing;
            if (isFlashing)
            {
                timer1.Start();
                ShowOnMonitor();
                (sender as Button).Text = "Stop";
            }
            else
            {
                timer1.Stop();
                this.BackColor = currentColor;
                if (monitorForm != null)
                {
                    monitorForm.StopFlashing();
                    monitorForm.Close();
                }
                (sender as Button).Text = "Start";
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
    }
}
