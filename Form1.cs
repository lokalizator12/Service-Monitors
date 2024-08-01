using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
namespace changeResolution1
{
    public partial class Form1 : MaterialForm
    {

        private DisplayManager displayManager;
        private MonitorInfoManager monitorInfoManager;
        private ResolutionDisplayManager resolutionManager;
        private Dictionary<string, string> monitorNameToIdentifierMap;
        private readonly MaterialSkinManager materialSkinManager;
        private int colorSchemeIndex;
        public Form1()
        {
            InitializeComponent();
            displayManager = new DisplayManager();
            monitorInfoManager = new MonitorInfoManager();
            resolutionManager = new ResolutionDisplayManager();
            ///////////////////////
            materialSkinManager = MaterialSkinManager.Instance;
            InitizializeCustomForm();
            ////////////////////////////////
            FillMonitorComboBox();
            SystemEvents.DisplaySettingsChanged += OnDisplaySettingsChanged;
            SetMaxResolutionForAllMonitors();
        }
        private void OnDisplaySettingsChanged(object sender, EventArgs e)
        {
            FillMonitorComboBox();
            UpdateResolutionComboBox();

            SetMaxResolutionForAllMonitors();
            if (materialMultiLineTextBox4.Text.Length > 0 && materialMultiLineTextBox5.Text.Length > 0 && materialMultiLineTextBox2.Text.Length > 0)
            {
                showFullInfo();
            }

        }

        public void InitizializeCustomForm()
        {

            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            DrawerAutoShow = true;

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
                new MaterialSnackBar($"Resolution changed: {width}x{height}").Show(this);
            }
        }

        private void SetMaxResolution_Click(object sender, EventArgs e)
        {

            var selectedFriendlyName = MonitorComboBox.SelectedItem.ToString();
            var identifier = monitorNameToIdentifierMap[selectedFriendlyName];
            var maxResolution = resolutionManager.GetMaxResolution(identifier);

            if (maxResolution != default)
            {
                resolutionManager.SetResolution(identifier, maxResolution.Width, maxResolution.Height);
                new MaterialSnackBar($"Max resolution: {maxResolution.Width}x{maxResolution.Height}").Show(this);
            }
            else
            {
                new MaterialSnackBar("Not valid resolution", "ok", true).Show(this);
            }

        }
        private void SetMaxResolutionForAllMonitors()
        {
            foreach (var friendlyName in monitorNameToIdentifierMap.Keys)
            {
                var identifier = monitorNameToIdentifierMap[friendlyName];
                var currentResolution = resolutionManager.GetCurrentResolution(identifier);
                var maxResolution = resolutionManager.GetMaxResolution(identifier);

                if (currentResolution.Width < maxResolution.Width || currentResolution.Height < maxResolution.Height)
                {
                    resolutionManager.SetResolution(identifier, maxResolution.Width, maxResolution.Height);
                }
            }
        }

        private async void showFullInfo()
        {
            var monitorNames = await monitorInfoManager.GetMonitorNamesAsync();
            var monitorInfo = await monitorInfoManager.GetMonitorInfoAsync();
            var monitorInfo1 = await monitorInfoManager.GetDisplayInfo1Async();
            var edidInfo = await monitorInfoManager.GetEdidInfoAsync();
            var serialNumber = await monitorInfoManager.GetMonitorSerialNumberAsync();
            materialMultiLineTextBox2.Text = monitorNames;
            materialMultiLineTextBox3.Text = monitorInfoManager.GetDiagonal(); ;
            materialMultiLineTextBox4.Text = monitorInfo;
            materialMultiLineTextBox1.Text = monitorInfo1;
            materialMultiLineTextBox5.Text = edidInfo;
            materialMultiLineTextBox6.Text = serialNumber;
        }
        private void button1_Click(object sender, EventArgs e)
        {


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

        }

        private void testFormButton_Click(object sender, EventArgs e)
        {
            MonitorTestForm testForm = new MonitorTestForm();
            testForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

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

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ResolutionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MonitorComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateResolutionComboBox();
        }


        private void updateColor()
        {
            //These are just example color schemes
            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal500 : Primary.BlueGrey800,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal700 : Primary.BlueGrey900,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal200 : Primary.BlueGrey500,
                        Accent.Pink200,
                        TextShade.WHITE);
                    break;

                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Green600,
                        Primary.Green700,
                        Primary.Green200,
                        Accent.Red100,
                        TextShade.WHITE);
                    break;

                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.BlueGrey800,
                        Primary.BlueGrey900,
                        Primary.BlueGrey500,
                        Accent.LightBlue200,
                        TextShade.WHITE);
                    break;
            }
            Invalidate();
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            }
            updateColor();
        }


        private void tabPage7_Enter(object sender, EventArgs e)
        {
            MaterialSnackBar SnackBarMessage = new MaterialSnackBar("SnackBar started succesfully", "OK", true);
            SnackBarMessage.Show(this);
        }

        private void showInfoPage_Enter(object sender, EventArgs e)
        {

            seedListView();
            //  
        }

        private void fixPixelPage_Enter(object sender, EventArgs e)
        {
            PixelFixerForm pixelFixerForm = new PixelFixerForm();
            pixelFixerForm.ShowDialog();
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Loading...");
            SnackBarMessage.Show(this);
            showFullInfo();
        }


        private async void seedListView()
        {
            MonitorInfoForm monitorInfo = new MonitorInfoForm();
            MonitorInfo[] monitors = await monitorInfo.GetMonitorInfosAsync();

            foreach (MonitorInfo monitor in monitors)
            {
                var item = new ListViewItem(monitor.ToString());
                materialListView2.Items.Add(item);
            }
        }

        private void searchInfoPage_Enter(object sender, EventArgs e)
        {
            SearchInformationForm brightness = new SearchInformationForm();
            brightness.ShowDialog();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            new MonitorInfoForm().ShowDialog();

        }
    }
}

