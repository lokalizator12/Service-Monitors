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
        internal bool isMonitorFormExist = false;
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
            if (materialMultiLineTextBox2.Text.Length > 0)
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
            if (materialComboBoxMonitors.SelectedIndex != null)
            {
                try
                {

                    var monitorInfo = monitors[materialComboBoxMonitors.SelectedIndex];
                    databaseManager = new DatabaseManager("localhost", "postgres", "moodle", "test_asset");
                    await databaseManager.InsertMonitorInfoPostgres(monitorInfo);
                    monitorInfo.IdEVK = textBoxIdEVK.Text;
                    monitorInfo.TesterInitials = textBoxTester.Text;
                    ShowSnackbar($"Sended to database succesfully");

                }
                catch (Exception x)
                {
                    ShowSnackbar($"Error: {x.Message}");
                }
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
                ShowSnackbar($"Resolution changed: {width}x{height}");
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
                ShowSnackbar($"Max resolution: {maxResolution.Width}x{maxResolution.Height}");
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
            materialMultiLineTextBox2.Text = monitorNames + "\n==============================\n"
                + monitorInfoManager.GetDiagonal() + "\n==============================\n"
                + monitorInfo + "\n==============================\n"
                + monitorInfo1 + "\n==============================\n"
                + edidInfo + "\n==============================\n"
                + serialNumber + "\n==============================\n";
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


        private void showInfoPage_Enter(object sender, EventArgs e)
        {

            monitorInfo = new MonitorInfoForm(this);
            fillPostionsInfo();

        }


        private void tabPage4_Enter(object sender, EventArgs e)
        {
            ShowSnackbar("Loading...");
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
                ShowSnackbar("Loading...");
                try
                {
                    SeedListView();
                }
                catch (Exception ex)
                {
                    ShowSnackbar($"Error: {ex.Message}");
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
            ShowSnackbar("Copied to clipboard.");
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
                if (textBoxTester.Text.Length == 2) ShowSnackbar("Initials inited succesfully");
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

        private void buttonTestingMonitor_Click(object sender, EventArgs e)
        {
            MonitorTestForm monitorTest;
            if (!isMonitorFormExist)
            {
                monitorTest = new MonitorTestForm(this);
                monitorTest.Show();
                isMonitorFormExist = true;
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            PixelFixerForm pixelFixerForm = new PixelFixerForm(this);
            pixelFixerForm.Show();
        }

        private void searchAssetButton_Click(object sender, EventArgs e)
        {


            string query =
     "SELECT aa.Marka, " +
     "aa.Model, " +
     "aa.NumerSeryjny, " +
     "aa.KlasaEvk, " +
     "aa.MiejsceMagazynowe, " +
     "CONCAT(p1.Imie, ' ', p1.Nazwisko) AS TestowaniePracownik, " +
     "aa.TestowanieData, " +
     "CONCAT(p2.Imie, ' ', p2.Nazwisko) AS CzyszczeniePracownik, " +
     "aa.CzyszczenieData, " +
     "CASE WHEN aa.CzyTestowany = 1 THEN 'Yes' ELSE 'No' END AS CzyTestowany, " +
     "CASE WHEN aa.CzyCzyszczony = 1 THEN 'Yes' ELSE 'No' END AS CzyCzyszczony, " +
     "aa.IdEvk, " +
     "aa.Zdjecia " +
     "FROM admin_asset.sprzet AS aa " +
     "LEFT JOIN admin_asset.pracownik AS p1 ON aa.EtapTestowanie = p1.IdPracownik " +
     "LEFT JOIN admin_asset.pracownik AS p2 ON aa.EtapCzyszczenie = p2.IdPracownik " +
     $"WHERE aa.IdEvk = '{textBoxIdEVK.Text}'";


            databaseManager = new DatabaseManager("localhost", "root", "moodle", "admin_asset");
            Dictionary<string, string> parameters = databaseManager.ExecuteQuery(query);
            if (parameters == null || parameters.Count == 0)
            {
                ShowSnackbar("No data found in the database for the provided IdEvk.");
            }
            else
            {
                foreach (var kvp in parameters)
                {
                    switch (kvp.Key)
                    {
                        case "Manufacturer":
                            labelAssetManufacturer.Text = kvp.Value;
                            break;
                        case "Model":
                            labelAssetModel.Text = kvp.Value;
                            break;
                        case "SerialNumber":
                            labelAssetSerialNumber.Text = kvp.Value;
                            break;
                        case "Class":
                            labelAssetClass.Text = kvp.Value;
                            break;
                        case "TestowaniePracownik":
                            labelAssetTester.Text = kvp.Value;
                            break;
                        case "TestowanieData":
                            labelAssetDateTesting.Text = kvp.Value;
                            break;
                        case "CzyszczeniePracownik":
                            labelAssetCleaner.Text = kvp.Value;
                            break;
                        case "CzyszczenieData":
                            labelAssetDateCleaning.Text = kvp.Value;
                            break;
                        case "CzyTestowany":
                            labelAssetIsTested.Text = kvp.Value;
                            break;
                        case "MiejsceMagazynowe":
                            labelAssetPlace.Text = kvp.Value;
                            break;
                        case "CzyCzyszczony":
                            labelAssetIsCleaned.Text = kvp.Value;
                            break;
                        case "IdEvk":
                            labelAssetIdEvk.Text = kvp.Value;
                            break;

                    }
                }
            }

        }
        private void ShowSnackbar(string message)
        {
            var snackbar = new MaterialSnackBar(message, 3000);
            snackbar.Show(this);
        }
    }


}

