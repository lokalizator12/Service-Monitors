using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using ServiceMonitorEVK.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace changeResolution1
{
    public partial class Form1 : MaterialForm
    {
        private DatabaseManager databaseManager;
        private DisplayManager displayManager;
        private MonitorInfoManager monitorInfoManager;
        private ResolutionDisplayManager resolutionManager;
        private Dictionary<string, string> monitorNameToIdentifierMap;
        private readonly MaterialSkinManager materialSkinManager;
        MonitorInfo[] monitors;

        MonitorInfoForm monitorInfo;
        public bool isUpdatingComboBox = false;

        private int colorSchemeIndex;
        public Form1()
        {
            InitializeComponent();
            displayManager = new DisplayManager();
            monitorInfoManager = new MonitorInfoManager();
            resolutionManager = new ResolutionDisplayManager();
            databaseManager = new DatabaseManager("localhost", "postgres", "moodle", "test_asset");

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
            checkTheme();
            DrawerAutoShow = true;
        }
        private async void SendMonitorInfoToDatabase()
        {
            try
            {
                var monitorInfo = monitors[materialComboBoxMonitors.SelectedIndex];
                await databaseManager.InsertMonitorInfo(monitorInfo);
                monitorInfo.IdEVK = textBoxIdEVK.Text;
                monitorInfo.TesterInitials = textBoxTester.Text;
                new MaterialSnackBar($"Sended to database succesfully").Show(this);
            }
            catch (Exception x)
            {
                new MaterialSnackBar($"Error: {x.Message}").Show(this);
            }
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

                MaterialDialog materialDialog = new MaterialDialog(this, "Exit from app", "Are you sure you want to exit the app?", "Yes", true, "Cancel", true);
                DialogResult result = materialDialog.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
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
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey900 : Primary.BlueGrey800,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey800 : Primary.BlueGrey900,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey700 : Primary.BlueGrey500,
                        Accent.Red400,
                        TextShade.WHITE);
                    pictureBoxLogo.BackColor = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK
                ? Color.FromArgb(0x21, 0x21, 0x21)
                : Color.FromArgb(0x37, 0x47, 0x4F);
                    break;

                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Green600,
                        Primary.Green700,
                        Primary.Green200,
                        Accent.Red100,
                        TextShade.WHITE);
                    pictureBoxLogo.BackColor = Color.Blue;
                    break;

                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.BlueGrey800,
                        Primary.BlueGrey900,
                        Primary.BlueGrey500,
                        Accent.LightBlue200,
                        TextShade.WHITE);
                    pictureBoxLogo.BackColor = Color.White;
                    break;
            }
            Invalidate();
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            checkTheme();
        }

        private void checkTheme()
        {
            if (materialSwitch1.Checked)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                pictureBoxLogo.BackColor = Color.Black;

            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                pictureBoxLogo.BackColor = Color.White;

            }
            updateColor();
        }

        private void tabPage7_Enter(object sender, EventArgs e)
        {
            MonitorTestForm monitorTest = new MonitorTestForm(this);
            monitorTest.Show();

        }

        private void showInfoPage_Enter(object sender, EventArgs e)
        {

            monitorInfo = new MonitorInfoForm(this);
            fillPostionsInfo();

        }

        private void fixPixelPage_Enter(object sender, EventArgs e)
        {
            PixelFixerForm pixelFixerForm = new PixelFixerForm(this);
            pixelFixerForm.Show();
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Loading...");
            SnackBarMessage.Show(this);
            showFullInfo();
        }


        private void SeedListView()
        {
            monitors = monitorInfo.monitors;

            if (monitors == null || monitors.Length == 0)
            {
                MessageBox.Show("No monitors found.");
                return;
            }

            if (materialComboBoxMonitors.SelectedIndex == -1 || materialComboBoxMonitors.SelectedIndex >= monitors.Length)
            {
                MessageBox.Show("Please select a valid monitor.");
                return;
            }
            MonitorInfo monitor = monitors[materialComboBoxMonitors.SelectedIndex];

            DisplayMonitorInfo(monitor);
        }

        private void searchInfoPage_Enter(object sender, EventArgs e)
        {
            new MaterialSnackBar("coming soon or will be deleted this page...", "OK", true).Show(this);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            new SearchInformationForm(this).Show();

        }


        private void fillPostionsInfo()
        {
            if (!isUpdatingComboBox)
            {
                new MaterialSnackBar("Loading...").Show(this);
                try
                {
                    SeedListView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        private void materialComboBoxMonitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPostionsInfo();
        }

        private void DisplayMonitorInfo(MonitorInfo monitorInfo)
        {
            materialLabelManufacturer.Text = monitorInfo.Manufacturer;
            materialLabelModel.Text = monitorInfo.Model;
            materialLabelSerialNo.Text = monitorInfo.SerialNumber;
            materialLabelYearOfProduction.Text = monitorInfo.YearOfProduction;
            materialLabelMonthOfProduction.Text = monitorInfo.MonthOfProduction;
            materialLabelProductCodeID.Text = monitorInfo.ProductCodeID;
            materialLabelDiagonal1.Text = monitorInfo.Diagonal1.ToString();
            materialLabelDiagonal2.Text = monitorInfo.Diagonal2;
            materialLabelResolution.Text = monitorInfo.Resolution;
            materialLabelFrequency.Text = monitorInfo.Frequency.ToString();
            materialLabelPPI.Text = monitorInfo.PPI;
            materialLabelSizeMonitor.Text = monitorInfo.SizeMonitor;
            textBoxIdEVK.Enabled = !string.IsNullOrEmpty(monitorInfo.Manufacturer) &
                            !string.IsNullOrEmpty(monitorInfo.Model);
            textBoxIdEVK.Text = monitorInfo.IdEVK;

            this.Refresh();
        }

        private void materialLabelPPI_Click(object sender, EventArgs e)
        {
            CopyToClipboard(materialLabelPPI.Text);
        }

        private void CopyToClipboard(string text)
        {
            Clipboard.SetText(text);
            new MaterialSnackBar("Copied to clipboard.").Show(this);

        }

        private void materialLabelManufacturer_Click(object sender, EventArgs e)
        {
            CopyToClipboard(materialLabelManufacturer.Text);
        }

        private void materialLabelModel_Click(object sender, EventArgs e)
        {
            CopyToClipboard(materialLabelModel.Text);
        }

        private void materialLabelYearOfProduction_Click(object sender, EventArgs e)
        {
            CopyToClipboard(materialLabelYearOfProduction.Text);
        }

        private void materialLabelMonthOfProduction_Click(object sender, EventArgs e)
        {
            CopyToClipboard(materialLabelMonthOfProduction.Text);
        }

        private void materialLabelProductCodeID_Click(object sender, EventArgs e)
        {
            CopyToClipboard(materialLabelProductCodeID.Text);
        }

        private void materialLabelDiagonal1_Click(object sender, EventArgs e)
        {
            CopyToClipboard(materialLabelDiagonal1.Text);
        }

        private void materialLabelDiagonal2_Click(object sender, EventArgs e)
        {
            CopyToClipboard(materialLabelDiagonal2.Text);
        }

        private void materialLabelSerialNo_Click(object sender, EventArgs e)
        {
            CopyToClipboard(materialLabelSerialNo.Text);
        }

        private void materialLabelFrequency_Click(object sender, EventArgs e)
        {
            CopyToClipboard(materialLabelFrequency.Text);
        }

        private void materialLabelSizeMonitor_Click(object sender, EventArgs e)
        {
            CopyToClipboard(materialLabelSizeMonitor.Text);
        }

        private void materialLabelResolution_Click(object sender, EventArgs e)
        {
            CopyToClipboard(materialLabelResolution.Text);
        }

        private void materialLabelPPI_Click_1(object sender, EventArgs e)
        {
            CopyToClipboard(materialLabelPPI.Text);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            SendMonitorInfoToDatabase();
        }

        private void textBoxIdEVK_TextChanged(object sender, EventArgs e)
        {
            if (materialComboBoxMonitors.SelectedIndex != -1 && monitors != null && monitors.Length > 0)
            {
                monitors[materialComboBoxMonitors.SelectedIndex].IdEVK = textBoxIdEVK.Text;
            }
        }

        private void textBoxTester_TextChanged(object sender, EventArgs e)
        {
            if (materialComboBoxMonitors.SelectedIndex != -1 && monitors != null && monitors.Length > 0)
            {
                monitors[materialComboBoxMonitors.SelectedIndex].TesterInitials = textBoxTester.Text;
                if (textBoxTester.Text.Length == 2) new MaterialSnackBar("Initials inited succesfully").Show(this);
            }
        }

        private void materialSliderOpasity_onValueChanged(object sender, int newValue)
        {
            if (newValue > 1)
            {
                this.Opacity = newValue / 100.0;
                this.Invalidate();
            }
        }
    }
}

