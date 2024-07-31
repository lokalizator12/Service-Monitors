using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
        private Dictionary<string, string> monitorNameToIdentifierMap;
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
            monitorNameToIdentifierMap = new Dictionary<string, string>();

            var monitorNames = resolutionManager.GetMonitorNames();
            Console.WriteLine(monitorNames);
            var friendlyNames = monitorInfoManager.GetFriendlyMonitorNames(); // This method should return a list of friendly names in the same order as `monitorNames`

            for (int i = 0; i < monitorNames.Count; i++)
            {
                var identifier = monitorNames[i];
                var friendlyName = friendlyNames[i];
                monitorNameToIdentifierMap[friendlyName] = identifier;
                MonitorComboBox.Items.Add(friendlyName);
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

            var selectedFriendlyName = MonitorComboBox.SelectedItem.ToString();
            var identifier = monitorNameToIdentifierMap[selectedFriendlyName];

            var resolutions = resolutionManager.GetAvailableResolutions(identifier).OrderBy(r =>
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

                var selectedFriendlyName = MonitorComboBox.SelectedItem.ToString();
                var identifier = monitorNameToIdentifierMap[selectedFriendlyName];

                resolutionManager.SetResolution(identifier, width, height);
            }
        }

        private void SetMaxResolution_Click(object sender, EventArgs e)
        {
            var selectedFriendlyName = MonitorComboBox.SelectedItem.ToString();
            var identifier = monitorNameToIdentifierMap[selectedFriendlyName];
            var maxResolution = resolutionManager.GetMaxResolution(identifier);

            if (maxResolution != default)
            {
                MessageBox.Show($"Max resolution: {maxResolution.Width}x{maxResolution.Height}");
                resolutionManager.SetResolution(identifier, maxResolution.Width, maxResolution.Height);
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
            var edidInfo = await monitorInfoManager.GetEdidInfoAsync();
            var serialNumber = await monitorInfoManager.GetMonitorSerialNumberAsync();
            label3.Text = monitorNames;
            label4.Text = monitorInfo;
            label5.Text = monitorInfo1;
            label9.Text = monitorInfoManager.GetDiagonal();
            label7.Text = edidInfo;
            label8.Text = serialNumber;

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
            try
            {
                displayManager.SetDisplayMode(DisplayManager.DisplayMode.SecondaryOnly);
                MessageBox.Show("Display mode set to Secondary Only.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

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

        private void button6_Click(object sender, EventArgs e)
        {
            SearchInformationForm brightness = new SearchInformationForm();
            brightness.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MonitorInfoSerachForm monitorInfoSerach = new MonitorInfoSerachForm();
            monitorInfoSerach.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://systemy.evk.pl/",
                UseShellExecute = true
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MonitorInfoForm monitorInfo = new MonitorInfoForm();
            monitorInfo.ShowDialog();
        }
    }
}

