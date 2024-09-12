using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using ServiceMonitorEVK.Localization;
using ServiceMonitorEVK.Properties;
using ServiceMonitorEVK.Source.Constants;
using ServiceMonitorEVK.Source.Database;
using ServiceMonitorEVK.Source.Forms;
using ServiceMonitorEVK.Source.Services;
using ServiceMonitorEVK.Source.Testing_Monitor;
using ServiceMonitorEVK.Source.Util_Managers;
using ServiceMonitorEVK.Util_Managers;
using ServiceMonitorEVK.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceMonitorEVK.Source.Main
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
        private AssetInformationPage assetInformationPage;
        private readonly OpenAIService _openAiService;
        private int previousMonitorCount;
        private string selectedDisplayMode;

        internal bool IsUpdatingComboBox = false;
        private readonly DisplayManager displayManager;
        private MonitorInfoForm monitorInfo;
        private readonly MonitorInfoManager monitorInfoManager;
        private Dictionary<string, string> monitorNameToIdentifierMap;
        private MonitorInfo[] monitors;
        private readonly ResolutionDisplayManager resolutionManager;
        internal string Tester;
        private MonitorInfo currentMonitor;

        public Form1(string testerFromMain)
        {
            assetInformationPage = new AssetInformationPage();
            _openAiService = new OpenAIService();
            uiUtil = new UiUtil(this);
            uiUtil.StartOpening();
            InitializeComponent();
            displayManager = new DisplayManager();
            monitorInfoManager = new MonitorInfoManager();
            resolutionManager = new ResolutionDisplayManager();
            databaseManager = new DatabaseManager();
            LocalizationHelper.ApplyLocalization(this);
            ///////////////////////
            materialSkinManager = MaterialSkinManager.Instance;
            InitizializeCustomForm();
            ////////////////////////////////
            FillMonitorComboBox();
            SystemEvents.DisplaySettingsChanged += OnDisplaySettingsChanged;
            SetMaxResolutionForAllMonitors();
            Tester = textBoxTester.Text = mainLabelTester.Text = testerFromMain;
            previousMonitorCount = Screen.AllScreens.Length;
        }


        private void OnDisplaySettingsChanged(object sender, EventArgs e)
        {
            FillMonitorComboBox();
            UpdateResolutionComboBox();

            SetMaxResolutionForAllMonitors();

            var connectedMonitors = Screen.AllScreens.Length;

            if (connectedMonitors > 1 && autoEnableColorTest)
            {
                ShowColorDialogForNewMonitor();
            }
            else if (connectedMonitors <= 1 && currentTestOverlay != null)
            {
                currentTestOverlay.Close();
                currentTestOverlay = null;
            }
            if (checkBoxAutoChangeMode.Checked)
            {
                ApplySelectedDisplayMode();
                int currentMonitorCount = Screen.AllScreens.Length;

                /* if (currentMonitorCount > previousMonitorCount)
                 {
                     ApplySelectedDisplayMode();
                 }*/

                previousMonitorCount = currentMonitorCount;
            }
        }

        private void ApplySelectedDisplayMode()
        {
            selectedDisplayMode = comboBoxTypeScreen.SelectedItem.ToString();
            DisplayManager.DisplayMode mode = selectedDisplayMode switch
            {
                DisplayModeConstants.PC_SCREEN_ONLY => DisplayManager.DisplayMode.PC_SCREEN_ONLY,
                DisplayModeConstants.DUPLICATE => DisplayManager.DisplayMode.DUPLICATE,
                DisplayModeConstants.EXTEND => DisplayManager.DisplayMode.EXTEND,
                DisplayModeConstants.SECOND_SCREEN_ONLY => DisplayManager.DisplayMode.SECOND_SCREEN_ONLY,
                _ => throw new ArgumentOutOfRangeException()
            };
            displayManager.SetDisplayMode(mode);
        }

        private void ShowColorDialogForNewMonitor()
        {
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

                //databaseManager = new DatabaseManager("localhost", "postgres", "moodle", "test_asset");
                var monitorExists = await databaseManager.MonitorExistsInDatabase(info.Manufacturer, info.SystemModel);
                if (!monitorExists)
                {
                    await databaseManager.InsertMonitorSpecs(info);
                    ShowSnackbar("New monitor added to the database.");
                }
                else
                {
                    ShowSnackbar("Monitor already exists in the database.");
                }
            }
            catch (Exception x)
            {
                ShowSnackbar($"Error: {x.Message}");
            }
        }




        private void FillMonitorComboBox()
        {

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
                if (string.IsNullOrWhiteSpace(friendlyName))
                {
                    continue;
                }
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
            materialMultiLineTextBox2.Text = monitorNames + "\n==============================\n"
                                                          + monitorInfoManager.GetDiagonal() +
                                                          "\n==============================\n"
                                                          + monitorInfoAsync + "\n==============================\n"
                                                          + monitorInfo1 + "\n==============================\n"
                                                          + edidInfo + "\n==============================\n";
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



        private async void showInfoPage_Enter(object sender, EventArgs e)
        {
            monitorInfo = new MonitorInfoForm(this);
            await FillPositionsInfo();
            if (checkBoxAutoShow.Checked)
                if (textBoxSerial.Text != null)
                    assetInformationPage.SearchInfoFromAsset(textBoxSerial.Text, "NumerSeryjny");
            databaseManager.FillCountryComboBox(comboBoxCountry);

        }

        private async Task FillPositionsInfo()
        {

            try
            {
                ShowSnackbar("Loading...");
                await SeedListView();
                if (materialComboBoxMonitors.SelectedIndex == -1 || monitors == null || monitors.Length == 0)
                {
                    ShowSnackbar("Please select a valid monitor.");
                    return;
                }

                var monitorInformation = currentMonitor = monitors[materialComboBoxMonitors.SelectedIndex];
                monitorInformation.EvkModel = labelEvkModel.Text = databaseManager.GetEvkModelFormSerialNumber(textBoxSerial.Text);

                var monitorExists = await databaseManager.MonitorExistsInDatabase(monitorInformation.Manufacturer, monitorInformation.SystemModel, monitorInformation.EvkModel);
                if (!monitorExists)
                {
                    await GetMonitorInfoFromOpenAi(monitorInformation);

                    using var customMessageBox = new NewMonitorFormat(monitorInformation);
                    var result = customMessageBox.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        monitorInformation = customMessageBox.monitor;

                        // После закрытия формы сохраняем данные в базу
                        await databaseManager.InsertOrUpdateMonitorSpecs(monitorInformation);
                        ShowSnackbar("New monitor information saved in the database.");
                    }
                    else
                    {
                        ShowSnackbar("Action canceled.");
                        return;
                    }
                }

                string monitorData = await databaseManager.GetMonitorInfoFromDatabase(monitorInformation.Manufacturer, monitorInformation.SystemModel, monitorInformation.EvkModel);
                ParseMonitorInfo(monitorInformation, monitorData);
                ShowSnackbar("Monitor information loaded from the database.");
                DisplayMonitorInfo(monitorInformation); // Обновление интерфейса
                ShowSnackbar("Monitor information loaded.");
            }
            catch (Exception ex)
            {
                ShowSnackbar($"Error: {ex.Message}");
            }
        }

        private void FillActualParameters()
        {

        }
        /// <summary>
        /// //////////////////////
        /// ЭТО НУЖНО БУДЕТ КУДА-ТО ДЕТЬ
        ///
        ///
        ///
        ///
        /// 
        /// </summary>
        /// <param name="monitorInfo"></param>
        /// <returns></returns>






        ////////////////////////
        ///
        ///
        ///
        ///
        ///
        ///


        public void ParseMonitorInfo(MonitorInfo monitorInfo, string monitorData)
        {
            monitorData = monitorData.Trim().Trim('\'');
            Console.WriteLine(monitorData);
            if (string.IsNullOrEmpty(monitorData))
            {
                Console.WriteLine("No data to parse.");
                return;
            }

            var fields = monitorData.Split(',').Select(f => f.Trim()).ToArray();

            if (fields.Length >= 10)
            {
                monitorInfo.PanelType = fields[0]; // Тип панели (например, IPS)
                monitorInfo.Diagonal1 = double.Parse(fields[1], CultureInfo.InvariantCulture); // Диагональ (например, 23.8)
                monitorInfo.CableTypes = UpdateCableInputs(fields[2]); // Кабели (VGA, HDMI, DisplayPort)
                monitorInfo.Resolution = fields[3]; // Разрешение (например, 1920x1080)
                monitorInfo.AspectRatio = fields[4]; // Соотношение сторон (например, 16:9)
                monitorInfo.Brightness = fields[5]; // Яркость (например, 250 nits)
                monitorInfo.ResponseTime = fields[6]; // Время отклика (например, 5ms)
                monitorInfo.ViewingAngles = fields[7]; // Углы обзора (например, 178/178)
                monitorInfo.Frequency = int.Parse(fields[8].Replace("Hz", "").Trim()); // Частота обновления (например, 60Hz)
                monitorInfo.Weight = fields[9]; // Вес (например, 4.5kg)
                monitorInfo.Dimensions = fields[10]; // Размеры (например, 54.1x32.4x5.9 cm)
            }
            else
            {
                Console.WriteLine("Insufficient data to parse.");
            }
        }

        private async Task GetMonitorInfoFromOpenAi(MonitorInfo monitorInfo)
        {
            /*var monitorQuery = $"{monitorInfo.Manufacturer}" + " " + $"{monitorInfo.EvkModel}" + " " +
                               $"({monitorInfo.SystemModel})";*/
            var monitorQuery =
                               $"-Manufacturer: {monitorInfo.Manufacturer} \n" +
                               $"-System Model: {monitorInfo.SystemModel} \n" +
                               $"-Model from monitor: {monitorInfo.EvkModel} \n" +
                               $"-Serial Number: {monitorInfo.SerialNumber}  \n" +
                               $"-Year of Production: {monitorInfo.YearOfProduction}";

            Console.WriteLine($"query chat: {monitorQuery}");
            var openAiResponse = await _openAiService.GetResponseAsync(monitorQuery, isInfoMonitors: true);
            ParseMonitorInfo(monitorInfo, openAiResponse);
        }



        private void tabPage4_Enter(object sender, EventArgs e)
        {
            ShowSnackbar("Loading...");
            ShowFullInfo();
        }


        private async Task SeedListView()
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
                    assetInformationPage.SearchInfoFromAsset(textBoxSerial.Text, "NumerSeryjny");
        }

        private void DisplayMonitorInfo(MonitorInfo monitorInformation)
        {
            materialLabelManufacturer.Text = monitorInformation.Manufacturer;
            systemModelLabel.Text = monitorInformation.SystemModel;
            textBoxSerial.Text = monitorInformation.SerialNumber;
            materialLabelYearOfProduction.Text = monitorInformation.YearOfProduction;
            materialLabelMonthOfProduction.Text = monitorInformation.MonthOfProduction;
            materialLabelProductCodeID.Text = monitorInformation.ProductCodeId;
            materialLabelDiagonal.Text = monitorInformation.Diagonal1.ToString();
            //materialLabelDiagonal2.Text = monitorInformation.Diagonal2;
            materialLabelResolution.Text = monitorInformation.Resolution;
            materialLabelFrequency.Text = monitorInformation.Frequency.ToString();
            materialLabelSizeMonitor.Text = monitorInformation.Dimensions;
            materialLabelBrightness.Text = monitorInformation.Brightness;
            materialLabelResponseTime.Text = monitorInformation.ResponseTime;
            materialLabelViewingAngles.Text = monitorInformation.ViewingAngles;
            materialLabelWeight.Text = monitorInformation.Weight;
            // materialLabelDimensions.Text = monitorInformation.Dimensions;
            materialLabelTypeMatrix.Text = monitorInformation.PanelType;
            textBoxIdEVK.Enabled = !string.IsNullOrEmpty(monitorInformation.Manufacturer) &
                                   !string.IsNullOrEmpty(monitorInformation.SystemModel);
            textBoxIdEVK.Text = monitorInformation.IdEVK;
            labelScreenFormat.Text = monitorInformation.AspectRatio;
            Refresh();
        }
        private string UpdateCableInputs(string cableInfo)
        {
            ResetCableInputs();
            Console.Write(cableInfo);
            var cables = cableInfo.Split(';') // Split by semicolons
                .Select(c => c.Trim())
                .Where(c => !string.IsNullOrEmpty(c))
                .ToDictionary(
                    c => c.Split(' ')[0],
                    c => int.Parse(c.Split('x')[1]));


            if (cables.ContainsKey("HDMI"))
            {
                checkBoxHDMI.Checked = true;
                numericUpDownHdmi.Value = cables["HDMI"];
            }

            if (cables.ContainsKey("VGA"))
            {
                checkBoxVGA.Checked = true;
                numericUpDownVga.Value = cables["VGA"];
            }

            if (cables.TryGetValue("DVI", out var cable))
            {
                checkBoxDVI.Checked = true;
                numericUpDownDvi.Value = cable;
            }

            if (cables.ContainsKey("DisplayPort"))
            {
                checkBoxDisplayPort.Checked = true;
                numericUpDownDisplayPort.Value = cables["DisplayPort"];
            }

            return cableInfo;
        }

        private void ResetCableInputs()
        {
            // Сбрасываем чекбоксы и отключаем числовые вводы
            checkBoxHDMI.Checked = false;
            numericUpDownHdmi.Value = 1;
            numericUpDownHdmi.Enabled = false;

            checkBoxVGA.Checked = false;
            numericUpDownVga.Value = 1;
            numericUpDownVga.Enabled = false;

            checkBoxDVI.Checked = false;
            numericUpDownDvi.Value = 1;
            numericUpDownDvi.Enabled = false;

            checkBoxDisplayPort.Checked = false;
            numericUpDownDisplayPort.Value = 1;
            numericUpDownDisplayPort.Enabled = false;
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
            if (textBoxIdEVK.Text != null && textBoxIdEVK.Text.Length > 6) assetInformationPage.SearchInfoFromAsset(textBoxIdEVK.Text);
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

                    assetInformationPage.SearchInfoFromAsset(barcode);

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
            if (textBoxSerial.Text != null) assetInformationPage.SearchInfoFromAsset(textBoxSerial.Text, "NumerSeryjny");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBoxSaveLanguage.Checked)
                UserSettingsManager.SetPreferredLanguage(LocalizationManager.Instance.GetCurrentCulture().Name);
            uiUtil.StartClosing();
            SystemEvents.DisplaySettingsChanged -= OnDisplaySettingsChanged;
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
            if (Tester.Equals("YS"))
            {
                materialSkinManager.ColorScheme = new ColorScheme(
                   materialSkinManager.Theme == MaterialSkinManager.Themes.DARK
                       ? Primary.Green900
                       : Primary.LightGreen800,
                   materialSkinManager.Theme == MaterialSkinManager.Themes.DARK
                       ? Primary.Green800
                       : Primary.Green700,
                   materialSkinManager.Theme == MaterialSkinManager.Themes.DARK
                       ? Primary.Green700
                       : Primary.Green600,
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


        private void textBoxSerial_KeyDown(object sender, KeyEventArgs e)
        {

            if (checkBoxSearchSerial.Checked)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var barcode = textBoxSerial.Text.Trim();

                    assetInformationPage.SearchInfoFromAsset(barcode);

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

        private void checkBoxAutoChangeMode_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxTypeScreen.Enabled = checkBoxAutoChangeMode.Checked;
        }

        private void aiButton_Click(object sender, EventArgs e)
        {
            new AiForm().Show();
        }

        private void showInfoPage_Leave(object sender, EventArgs e)
        {
            SystemEvents.DisplaySettingsChanged -= OnDisplaySettingsChanged;
        }

        private async void buttonChangeMonitor_Click(object sender, EventArgs e)
        {
            if (materialComboBoxMonitors.SelectedIndex == -1)
            {
                ShowSnackbar("Please select a valid monitor.");
                return;
            }


            var monitorExists = await databaseManager.MonitorExistsInDatabase(currentMonitor.Manufacturer, currentMonitor.SystemModel);
            if (monitorExists)
            {
                // Загружаем данные монитора из базы данных для редактирования
                string monitorData = await databaseManager.GetMonitorInfoFromDatabase(currentMonitor.Manufacturer, currentMonitor.SystemModel, currentMonitor.EvkModel);
                ParseMonitorInfo(currentMonitor, monitorData);

                // Открываем форму для редактирования монитора
                using var customMessageBox = new NewMonitorFormat(currentMonitor);
                var result = customMessageBox.ShowDialog();

                if (result == DialogResult.OK)
                {
                    currentMonitor = customMessageBox.monitor;

                    // Обновляем данные в базе после редактирования
                    await databaseManager.InsertOrUpdateMonitorSpecs(currentMonitor);
                    ShowSnackbar("Monitor information updated in the database.");
                    monitorData = await databaseManager.GetMonitorInfoFromDatabase(currentMonitor.Manufacturer, currentMonitor.SystemModel, currentMonitor.EvkModel);
                    ParseMonitorInfo(currentMonitor, monitorData);
                    ShowSnackbar("Monitor information loaded from the database.");
                    DisplayMonitorInfo(currentMonitor); // Обновление интерфейса
                    ShowSnackbar("Monitor information loaded.");
                }
                else
                {
                    ShowSnackbar("Action canceled.");
                }
            }
            else
            {
                ShowSnackbar("Monitor not found in the database.");
            }
        }
    }
}