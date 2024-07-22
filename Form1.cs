using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace changeResolution1
{
    public partial class Form1 : Form
    {
        private ComboBox MonitorComboBox;
        private ComboBox ResolutionComboBox;
        private Button SetResolution1;

        private DisplayManager displayManager;
        private MonitorInfoManager monitorInfoManager;
        private ResolutionDisplayManager resolutionManager;

        public Form1()
        {
            InitializeComponent();
            displayManager = new DisplayManager();
            monitorInfoManager = new MonitorInfoManager();
            resolutionManager = new ResolutionDisplayManager();
            FillMonitorComboBox();
        }

        private void FillMonitorComboBox()
        {
            MonitorComboBox.Items.Clear();

            var monitorNames = resolutionManager.GetMonitorNames();
            foreach (var name in monitorNames)
            {
                MonitorComboBox.Items.Add(name);
            }

            if (MonitorComboBox.Items.Count > 0)
            {
                MonitorComboBox.SelectedIndex = 0;
            }
        }

        private void MonitorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResolutionComboBox();
        }

        private void UpdateResolutionComboBox()
        {
            ResolutionComboBox.Items.Clear();
            var resolutions = resolutionManager.GetAvailableResolutions(MonitorComboBox.SelectedIndex).OrderBy(r =>
            {
                var parts = r.Split('x');
                int width = int.Parse(parts[0]);
                int height = int.Parse(parts[1]);
                return width * height;
            }).ToList();
            foreach (var resolution in resolutions)
            {
                ResolutionComboBox.Items.Add(resolution);
            }
            if (ResolutionComboBox.Items.Count > 0)
            {
                ResolutionComboBox.SelectedIndex = 0;
            }
        }


        private void SetResolution1_Click(object sender, EventArgs e)
        {
            if (ResolutionComboBox.SelectedItem != null)
            {
                string selectedResolution = ResolutionComboBox.SelectedItem.ToString();
                string[] parts = selectedResolution.Split('x');

                int width = int.Parse(parts[0].Trim());
                int height = int.Parse(parts[1].Trim());

                resolutionManager.SetResolution(MonitorComboBox.SelectedIndex, width, height);
            }
        }

        private void SetMaxResolution_Click(object sender, EventArgs e)
        {
            var maxResolution = resolutionManager.GetMaxResolution(MonitorComboBox.SelectedIndex);

            if (maxResolution != default)
            {
                MessageBox.Show($"Max resolution: {maxResolution.Width}x{maxResolution.Height}");
                resolutionManager.SetResolution(MonitorComboBox.SelectedIndex, maxResolution.Width, maxResolution.Height);
            }
            else
            {
                MessageBox.Show("No valid resolution found.");
            }
        }



        private async void button1_Click(object sender, EventArgs e)
        {

            var monitorNames = await monitorInfoManager.GetMonitorNamesAsync();
            var monitorInfo = await monitorInfoManager.GetMonitorInfoAsync();
            var monitorInfo1 = await monitorInfoManager.GetDisplayInfo1Async();
            label3.Text = monitorNames;
            label4.Text = monitorInfo;
            label5.Text = monitorInfo1;
            label6.Text = monitorInfoManager.GetDiagonal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                displayManager.SetDisplayMode(DisplayManager.DisplayMode.Duplicate);
                MessageBox.Show("Display mode set to Duplicate.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                displayManager.SetDisplayMode(DisplayManager.DisplayMode.Extend);
                MessageBox.Show("Display mode set to Extend.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                displayManager.SetDisplayMode(DisplayManager.DisplayMode.PrimaryOnly);
                MessageBox.Show("Display mode set to Primary Only.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void fixDisplayButton_Click(object sender, EventArgs e)
        {
            PixelFixerForm pixelFixerForm = new PixelFixerForm();
            pixelFixerForm.ShowDialog();
        }

        private void testFormButton_Click(object sender, EventArgs e)
        {
            MonitorTestForm testForm = new MonitorTestForm();
            testForm.ShowDialog();
        }
    }
}

