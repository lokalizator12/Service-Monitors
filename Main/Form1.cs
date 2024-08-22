using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using ServiceMonitorEVK.Database;
using ServiceMonitorEVK.Localization;
using ServiceMonitorEVK.Properties;
using ServiceMonitorEVK.Testing_Monitor;
using ServiceMonitorEVK.Util_Managers;
using ServiceMonitorEVK.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ServiceMonitorEVK.Main
{
    public partial class Form1 : MaterialForm
    {
        private TestOverlay currentTestOverlay;
        private readonly UiUtil uiUtil;
        private readonly MaterialSkinManager materialSkinManager;
        private bool autoEnableColorTest;
        private Color selectedAutoTestColor;
        private DatabaseManager databaseManager;
        internal bool IsMonitorFormExist;
        internal bool IsUpdatingComboBox = false;
        private readonly DisplayManager displayManager;
        private MonitorInfoForm monitorInfo;
        private readonly MonitorInfoManager monitorInfoManager;
        private Dictionary<string, string> monitorNameToIdentifierMap;
        private MonitorInfo[] monitors;
        private readonly ResolutionDisplayManager resolutionManager;
        internal string Tester;

        public Form1(string testerFromMain)
        {
            uiUtil = new UiUtil(this);
            uiUtil.StartOpening();
            InitializeComponent();
            displayManager = new DisplayManager();
            monitorInfoManager = new MonitorInfoManager();
            resolutionManager = new ResolutionDisplayManager();
            databaseManager = new DatabaseManager("localhost", "root", "moodle", "admin_asset");
            LocalizationHelper.ApplyLocalization(this);
            ///////////////////////
            materialSkinManager = MaterialSkinManager.Instance;
            InitizializeCustomForm();
            ////////////////////////////////
            FillMonitorComboBox();
            SystemEvents.DisplaySettingsChanged += OnDisplaySettingsChanged;
            SetMaxResolutionForAllMonitors();
            Tester = textBoxTester.Text = mainLabelTester.Text = testerFromMain;

        }


        private void OnDisplaySettingsChanged(object sender, EventArgs e)
        {
            FillMonitorComboBox();
            UpdateResolutionComboBox();

            SetMaxResolutionForAllMonitors();
            if (materialMultiLineTextBox2.Text.Length > 0) ShowFullInfo();
            foreach (var VARIABLE in MonitorComboBox.Items)
            {
                Console.WriteLine(VARIABLE);
            }
            var connectedMonitors = Screen.AllScreens.Length;

            if (connectedMonitors > 1 && autoEnableColorTest)
            {
                // Если был подключен новый монитор
                ShowColorDialogForNewMonitor();
            }
            else if (connectedMonitors <= 1 && currentTestOverlay != null)
            {
                // Если был отключен монитор и текущий оверлей активен
                currentTestOverlay.Close();
                currentTestOverlay = null;
            }
        }
        private void ShowColorDialogForNewMonitor()
        {
            // Выбираем последний монитор (новый подключенный)
            MonitorComboBox.SelectedIndex = MonitorComboBox.Items.Count - 1;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedAutoTestColor = colorDialog1.Color;
                StartOrUpdateTestOverlay(selectedAutoTestColor);
            }
        }
        public void InitizializeCustomForm()
        {
            comboBoxCountry.DropDownStyle = ComboBoxStyle.DropDown;
            uiUtil.InitializeTheme();
            UiUtil.RegisterLogoForThemeChange(pictureBoxLogo);
            ThemeManager.IsDarkTheme = materialSwitch1.Checked;

            DrawerAutoShow = true;
        }
        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.IsDarkTheme = materialSwitch1.Checked;
        }


        private async void SendMonitorInfoToDatabase()
        {
            if (materialComboBoxMonitors.SelectedIndex == null) return;
            try
            {
                var info = monitors[materialComboBoxMonitors.SelectedIndex];
                var cables = new Dictionary<string, int>();


                if (checkBoxHDMI.Checked)
                    cables.Add("HDMI", (int)numericUpDownHdmi.Value);
                if (checkBoxVGA.Checked)
                    cables.Add("VGA", (int)numericUpDownVga.Value);
                if (checkBoxDVI.Checked)
                    cables.Add("DVI", (int)numericUpDownDvi.Value);
                if (checkBoxDisplayPort.Checked)
                    cables.Add("DisplayPort", (int)numericUpDownDisplayPort.Value);
                info.UpdateCableTypes(cables);
                info.IdEVK = textBoxIdEVK.Text;
                info.Country = comboBoxCountry.SelectedItem?.ToString();
                info.TesterInitials = textBoxTester.Text;

                databaseManager = new DatabaseManager("localhost", "postgres", "moodle", "test_asset");
                await databaseManager.InsertMonitorInfoPostgres(info);
                ShowSnackbar("Sended to database succesfully");
            }
            catch (Exception x)
            {
                ShowSnackbar($"Error: {x.Message}");
            }
        }

        private void FillMonitorComboBox()
        {

            MonitorComboBox.Items.Clear();

            MonitorComboBox.Items.Clear();
            monitorNameToIdentifierMap = new Dictionary<string, string>();

            var monitorNames = resolutionManager.GetMonitorNames();
            var friendlyNames =
                monitorInfoManager
                    .GetFriendlyMonitorNames(); // This method should return a list of friendly names in the same order as `monitorNames`

            for (var i = 0; i < monitorNames.Count; i++)
            {
                var identifier = monitorNames[i];
                var friendlyName = friendlyNames[i];
                monitorNameToIdentifierMap[friendlyName] = identifier;
                MonitorComboBox.Items.Add(friendlyName);
            }

            if (MonitorComboBox.Items.Count > 0) MonitorComboBox.SelectedIndex = 0;
        }


        private void UpdateResolutionComboBox()
        {
            ResolutionComboBox.Items.Clear();

            var selectedFriendlyName = MonitorComboBox.SelectedItem.ToString();
            var identifier = monitorNameToIdentifierMap[selectedFriendlyName];

            var resolutions = resolutionManager.GetAvailableResolutions(identifier).OrderBy(r =>
            {
                var parts = r.Split('x');
                var width = int.Parse(parts[0]);
                var height = int.Parse(parts[1]);
                return width * height;
            }).ToList();

            foreach (var resolution in resolutions) ResolutionComboBox.Items.Add(resolution);

            if (ResolutionComboBox.Items.Count > 0) ResolutionComboBox.SelectedIndex = 0;
        }


        private void SetResolution1_Click(object sender, EventArgs e)
        {
            if (ResolutionComboBox.SelectedItem != null)
            {
                var selectedResolution = ResolutionComboBox.SelectedItem.ToString();
                var parts = selectedResolution.Split('x');

                var width = int.Parse(parts[0].Trim());
                var height = int.Parse(parts[1].Trim());

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
                    resolutionManager.SetResolution(identifier, maxResolution.Width, maxResolution.Height);
            }
        }

        private async void ShowFullInfo()
        {
            var monitorNames = await monitorInfoManager.GetMonitorNamesAsync();
            var monitorInfoAsync = await monitorInfoManager.GetMonitorInfoAsync();
            var monitorInfo1 = await monitorInfoManager.GetDisplayInfo1Async();
            var edidInfo = await monitorInfoManager.GetEdidInfoAsync();
            var serialNumber = await monitorInfoManager.GetMonitorSerialNumberAsync();
            materialMultiLineTextBox2.Text = monitorNames + "\n==============================\n"
                                                          + monitorInfoManager.GetDiagonal() +
                                                          "\n==============================\n"
                                                          + monitorInfoAsync + "\n==============================\n"
                                                          + monitorInfo1 + "\n==============================\n"
                                                          + edidInfo + "\n==============================\n"
                                                          + serialNumber + "\n==============================\n";
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != Keys.Escape) return base.ProcessCmdKey(ref msg, keyData);
            var materialDialog = new MaterialDialog(this, "Exit from app", "Are you sure you want to exit the app?",
                "Yes", true, "Cancel", true);
            var result = materialDialog.ShowDialog(this);
            if (result == DialogResult.OK) uiUtil.StartClosing();
            return true;
        }

        private void MonitorComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateResolutionComboBox();
        }



        private void showInfoPage_Enter(object sender, EventArgs e)
        {
            monitorInfo = new MonitorInfoForm(this);
            FillPositionsInfo();
            if (checkBoxAutoShow.Checked)
                if (textBoxSerial.Text != null)
                    SearchInfoFromAsset(textBoxSerial.Text, "NumerSeryjny");

            if (checkBoxCountry.Checked) databaseManager.FillCountryComboBox(comboBoxCountry);
        }

        private void FillPositionsInfo()
        {
            try
            {
                SeedListView();
                ShowSnackbar("Loading...");
            }
            catch (Exception ex)
            {
                ShowSnackbar($"Error: {ex.Message}");
            }
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            ShowSnackbar("Loading...");
            ShowFullInfo();
        }


        private void SeedListView()
        {
            monitors = monitorInfo.Monitors;

            if (monitors == null || monitors.Length == 0)
            {
                ShowSnackbar("No monitors found.");
                return;
            }

            if (materialComboBoxMonitors.SelectedIndex == -1 ||
                materialComboBoxMonitors.SelectedIndex >= monitors.Length)
            {
                ShowSnackbar("Please select a valid monitor.");
                return;
            }

            DisplayMonitorInfo(monitors[materialComboBoxMonitors.SelectedIndex]);
        }

        private void searchInfoPage_Enter(object sender, EventArgs e)
        {
            new MaterialSnackBar("coming soon or will be deleted this page...", "OK", true).Show(this);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            new SearchInformationForm(this).Show();
        }


        private void materialComboBoxMonitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPositionsInfo();
            if (checkBoxAutoShow.Checked)
                if (textBoxSerial.Text != null)
                    SearchInfoFromAsset(textBoxSerial.Text, "NumerSeryjny");
        }

        private void DisplayMonitorInfo(MonitorInfo monitorInformation)
        {
            materialLabelManufacturer.Text = monitorInformation.Manufacturer;
            materialLabelModel.Text = monitorInformation.Model;
            textBoxSerial.Text = monitorInformation.SerialNumber;
            materialLabelYearOfProduction.Text = monitorInformation.YearOfProduction;
            materialLabelMonthOfProduction.Text = monitorInformation.MonthOfProduction;
            materialLabelProductCodeID.Text = monitorInformation.ProductCodeId;
            materialLabelDiagonal1.Text = monitorInformation.Diagonal1.ToString();
            materialLabelDiagonal2.Text = monitorInformation.Diagonal2;
            materialLabelResolution.Text = monitorInformation.Resolution;
            materialLabelFrequency.Text = monitorInformation.Frequency.ToString();
            materialLabelPPI.Text = monitorInformation.PPI;
            materialLabelSizeMonitor.Text = monitorInformation.SizeMonitor;
            textBoxIdEVK.Enabled = !string.IsNullOrEmpty(monitorInformation.Manufacturer) &
                                   !string.IsNullOrEmpty(monitorInformation.Model);
            textBoxIdEVK.Text = monitorInformation.IdEVK;

            Refresh();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            SendMonitorInfoToDatabase();
        }

        private void textBoxIdEVK_TextChanged(object sender, EventArgs e)
        {
            if (materialComboBoxMonitors.SelectedIndex != -1 && monitors != null && monitors.Length > 0)
                monitors[materialComboBoxMonitors.SelectedIndex].IdEVK = textBoxIdEVK.Text;
        }

        private void textBoxTester_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTester.Text.Length == 2)
            {
                mainLabelTester.Text = Tester = textBoxTester.Text;
                ShowSnackbar("Initials inited succesfully");
            }
        }

        private void materialSliderOpasity_onValueChanged(object sender, int newValue)
        {
            if (newValue > 1)
            {
                Opacity = newValue / 100.0;
                Invalidate();
            }
        }

        private void buttonTestingMonitor_Click(object sender, EventArgs e)
        {
            if (!IsMonitorFormExist)
            {
                var monitorTest = new MonitorTestForm(this);
                monitorTest.Show();
                IsMonitorFormExist = true;
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            var pixelFixerForm = new PixelFixerForm(this);
            pixelFixerForm.Show();
        }

        private void searchAssetButton_Click(object sender, EventArgs e)
        {
            if (textBoxIdEVK.Text != null && textBoxIdEVK.Text.Length > 6) SearchInfoFromAsset(textBoxIdEVK.Text);
        }

        private void SearchInfoFromAsset(string searchValue, string searchBy = "IdEvk")
        {
            var whereClause = searchBy == "NumerSeryjny" ? "NumerSeryjny" : "IdEvk";

            var query =
                "SELECT aa.Marka, " +
                "aa.Model, " +
                "aa.NumerSeryjny, " +
                "aa.KlasaEvk, " +
                "aa.MiejsceMagazynowe, " +
                "CONCAT(p1.Imie, ' ', p1.Nazwisko) AS TestowaniePracownik, " +
                "aa.TestowanieData, " +
                "CONCAT(p2.Imie, ' ', p2.Nazwisko) AS CzyszczeniePracownik, " +
                "aa.CzyszczenieData, " +
                "m.TypWyswietlacz AS Type, " +
                "m.WielkoscMonitor AS Diagonal, " +
                "c.CountryName AS Country, " +
                "CASE WHEN aa.CzyTestowany = 1 THEN 'Yes' ELSE 'No' END AS CzyTestowany, " +
                "CASE WHEN aa.CzyCzyszczony = 1 THEN 'Yes' ELSE 'No' END AS CzyCzyszczony, " +
                "aa.IdEvk, " +
                "aa.Zdjecia " +
                "FROM admin_asset.sprzet AS aa " +
                "LEFT JOIN admin_asset.pracownik AS p1 ON aa.EtapTestowanie = p1.IdPracownik " +
                "LEFT JOIN admin_asset.pracownik AS p2 ON aa.EtapCzyszczenie = p2.IdPracownik " +
                "LEFT JOIN admin_asset.monitor AS m ON aa.IdSprzet = m.IdSprzet " +
                "LEFT JOIN admin_asset.slownikcountry AS c ON aa.IdCountry = c.IdCountry " +
                $"WHERE aa.{whereClause} = '{searchValue}'";


            var parameters = databaseManager.ExecuteQueryFindProductAndGet(query);

            if (parameters == null || parameters.Count == 0)
                ShowSnackbar($"No data found in the database for the provided {searchBy}: {searchValue}");
            else
                FillParametersToLabels(parameters);
        }


        private void FillParametersToLabels(Dictionary<string, string> parameters)
        {
            foreach (var kvp in parameters)
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
                    case "Zdjecia":
                        labelAssetIsPictured.Text = CheckImageUrls(kvp.Value);
                        break;
                    case "Type":
                        labelAssetType.Text = kvp.Value;
                        break;
                    case "Diagonal":
                        labelAssetDiagonalDB.Text = kvp.Value;
                        break;
                    case "Country":
                        labelAssetCountry.Text = kvp.Value;
                        break;
                }
        }


        private string CheckImageUrls(string imageUrls)
        {
            var urls = imageUrls.Split(' ');
            var y = urls.Select(t => t.Trim()).Count(url => !string.IsNullOrEmpty(url));

            return $"Images available: {y}";
        }

        private void ShowSnackbar(string message)
        {
            var snackbar = new MaterialSnackBar(message, 1000);
            snackbar.Show(this);
        }

        private void textBoxIdEVK_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkBoxSearchEVK_ID.Checked)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var barcode = textBoxIdEVK.Text.Trim();

                    SearchInfoFromAsset(barcode);

                    textBoxIdEVK.Clear();

                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void labelAssetClass_Click(object sender, EventArgs e)
        {
            var clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                Clipboard.SetText(clickedLabel.Text);

                ShowSnackbar($"{clickedLabel.Text} copied to clipboard.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBoxSerial.Text != null) SearchInfoFromAsset(textBoxSerial.Text, "NumerSeryjny");
        }

        private void materialCheckbox17_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownDisplayPort.Enabled = checkBoxDisplayPort.Checked;
        }

        private void CheckBoxDVI_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownDvi.Enabled = checkBoxDVI.Checked;
        }

        private void CheckboxVGA_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownVga.Enabled = checkBoxVGA.Checked;
        }

        private void checkBoxHDMI_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownHdmi.Enabled = checkBoxHDMI.Checked;
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBoxSaveLanguage.Checked)
                UserSettingsManager.SetPreferredLanguage(LocalizationManager.Instance.GetCurrentCulture().Name);
            uiUtil.StartClosing();
        }

        private void SetLanguage(string cultureCode)
        {
            var currentCulture = LocalizationManager.Instance.GetCurrentCulture().Name;

            if (currentCulture != cultureCode)
            {
                LocalizationManager.Instance.SetLanguage(cultureCode);

                checkBoxSaveLanguage.Enabled = true;
            }
            else
            {
                checkBoxSaveLanguage.Enabled = false;
            }

            LocalizationHelper.ApplyLocalization(this);
        }

        private void picturePlLang_Click(object sender, EventArgs e)
        {
            SetLanguage("pl-PL");
        }

        private void pictureUSEng_Click(object sender, EventArgs e)
        {
            SetLanguage("en-US");
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            SetLanguage("uk-UA");

        }

        private void rusLang_Click(object sender, EventArgs e)
        {
            SetLanguage("ru-RU");
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            SetLanguage("be-BY");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var preferredLanguage = UserSettingsManager.GetPreferredLanguage();

            if (string.IsNullOrEmpty(preferredLanguage))
            {
                preferredLanguage = "pl-PL";
                UserSettingsManager.SetPreferredLanguage(preferredLanguage);
            }

            SetLanguage(preferredLanguage);
        }

        private void textBoxTester_Leave(object sender, EventArgs e)
        {
            if (textBoxTester.Text.Length < 2) textBoxTester.Text = Tester;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (Opacity > 0)
            {
                e.Cancel = true;
                uiUtil.StartClosing();
            }
            else
            {
                base.OnFormClosing(e);
            }
        }

        private void pictureBox36_DoubleClick(object sender, EventArgs e)
        {
            if (Tester.Equals("JS"))
            {
                materialSkinManager.ColorScheme = new ColorScheme(
                   materialSkinManager.Theme == MaterialSkinManager.Themes.DARK
                       ? Primary.Green900
                       : Primary.LightGreen800,
                   materialSkinManager.Theme == MaterialSkinManager.Themes.DARK
                       ? Primary.Green800
                       : Primary.LightGreen900,
                   materialSkinManager.Theme == MaterialSkinManager.Themes.DARK
                       ? Primary.Green700
                       : Primary.LightGreen500,
                   Accent.Red400,
                   TextShade.WHITE);
                rusLang.Visible = false;
                RusLabel.Visible = false;
                Invalidate();
            }
            else if (Tester.Equals("AF"))
            {
                materialSkinManager.ColorScheme = new ColorScheme(
                    materialSkinManager.Theme == MaterialSkinManager.Themes.DARK
                        ? Primary.Brown900
                        : Primary.Brown200,
                    materialSkinManager.Theme == MaterialSkinManager.Themes.DARK
                        ? Primary.Brown800
                        : Primary.Brown100,
                    materialSkinManager.Theme == MaterialSkinManager.Themes.DARK
                        ? Primary.Brown700
                        : Primary.Brown50,
                    Accent.Red400,
                    TextShade.WHITE);

                Invalidate();
            }

        }

        private void materialCheckbox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSerial_KeyDown(object sender, KeyEventArgs e)
        {

            if (checkBoxSearchSerial.Checked)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var barcode = textBoxSerial.Text.Trim();

                    SearchInfoFromAsset(barcode);

                    // textBoxIdEVK.Clear();

                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void checkBoxConnectMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxConnectMonitor.Checked)
            {
                using (var colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        autoEnableColorTest = true;
                        selectedAutoTestColor = selectedColorAutoShow.BackColor = colorDialog.Color;

                    }
                    else
                    {
                        checkBoxConnectMonitor.Checked = false;
                    }
                }
            }
            else
            {
                autoEnableColorTest = false;
            }
        }

        private void StartOrUpdateTestOverlay(Color selectedColor)
        {
            if (currentTestOverlay == null || currentTestOverlay.IsDisposed)
            {
                currentTestOverlay = new TestOverlay(selectedColor);
                currentTestOverlay.Show();
            }
            else
            {
                currentTestOverlay.BackColor = selectedColor;
            }
        }
      
        private void btnExtend_Click(object sender, EventArgs e)
        {
            displayManager.SetDisplayMode(DisplayManager.DisplayMode.EXTEND);
        }

        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            displayManager.SetDisplayMode(DisplayManager.DisplayMode.DUPLICATE);
        }

        private void btnOnlyPC_Click(object sender, EventArgs e)
        {
            displayManager.SetDisplayMode(DisplayManager.DisplayMode.PC_SCREEN_ONLY);
        }

        private void btnOnlySecond_Click(object sender, EventArgs e)
        {
            displayManager.SetDisplayMode(DisplayManager.DisplayMode.SECOND_SCREEN_ONLY);
        }

        private void btnDisplaySettings_Click(object sender, EventArgs e)
        {
            Process.Start("ms-settings:display");
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Process.Start("ms-settings:about");
        }

        private void materialButton3_Click_1(object sender, EventArgs e)
        {
            Process.Start("ms-settings:personalization");
        }
    }
}