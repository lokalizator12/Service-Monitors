using System.Windows.Forms;
using MaterialSkin.Controls;

namespace ServiceMonitorEVK.Main
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelMonitor = new MaterialSkin.Controls.MaterialLabel();
            this.lableChanRes = new MaterialSkin.Controls.MaterialLabel();
            this.MonitorComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.ResolutionComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SetMaxResolution = new MaterialSkin.Controls.MaterialButton();
            this.SetResolution = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxConnectMonitor = new MaterialSkin.Controls.MaterialCheckbox();
            this.selectedColorAutoShow = new System.Windows.Forms.PictureBox();
            this.checkBoxSearchSerial = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkBoxSearchEVK_ID = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.RusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.LabelUkr = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.rusLang = new System.Windows.Forms.PictureBox();
            this.UsEng = new System.Windows.Forms.PictureBox();
            this.PlLang = new System.Windows.Forms.PictureBox();
            this.materialSliderOpasity = new MaterialSkin.Controls.MaterialSlider();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.textBoxTester = new MaterialSkin.Controls.MaterialTextBox2();
            this.checkBoxAutoShow = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkBoxSaveLanguage = new MaterialSkin.Controls.MaterialCheckbox();
            this.fullInfoPage = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialMultiLineTextBox2 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.showInfoPage = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.labelAssetIdEvk = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel46 = new MaterialSkin.Controls.MaterialLabel();
            this.labelAsCable = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelAssetCountry = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelAsManufact = new MaterialSkin.Controls.MaterialLabel();
            this.labelAsCountry = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetManufacturer = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.labelAssetClass = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.labelAssetModel = new MaterialSkin.Controls.MaterialLabel();
            this.labelAsClass = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.labelAssetPlace = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.labelAsModel = new MaterialSkin.Controls.MaterialLabel();
            this.labelAsPlace = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetDateCleaning = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetIsPictured = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.labelAsPicture = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.labelAssetTester = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.labelAssetCleaner1 = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetIsCleaned = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetDateTesting = new MaterialSkin.Controls.MaterialLabel();
            this.labelAsType = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetDiagonalDB = new MaterialSkin.Controls.MaterialLabel();
            this.labelAsCleaned = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.labelAssetType = new MaterialSkin.Controls.MaterialLabel();
            this.labelAsDiagonal = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetCleaner = new MaterialSkin.Controls.MaterialLabel();
            this.labelAsProductId = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetProductCode = new MaterialSkin.Controls.MaterialLabel();
            this.labelAsDIagHW = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetDiagonal = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetIsTested = new MaterialSkin.Controls.MaterialLabel();
            this.labelAsTester = new MaterialSkin.Controls.MaterialLabel();
            this.labelAsSerial = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetSerialNumber = new MaterialSkin.Controls.MaterialLabel();
            this.labelAsResolution = new MaterialSkin.Controls.MaterialLabel();
            this.labelAsTested = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetResolution = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSerial = new MaterialSkin.Controls.MaterialTextBox2();
            this.comboBoxCountry = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCheckbox6 = new MaterialSkin.Controls.MaterialCheckbox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.searchAssetButton = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.textBoxIdEVK = new MaterialSkin.Controls.MaterialTextBox2();
            this.checkBoxCountry = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox7 = new MaterialSkin.Controls.MaterialCheckbox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelManufacturer = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.materialLabelManufacturer = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelPPI = new MaterialSkin.Controls.MaterialLabel();
            this.labelCountry = new MaterialSkin.Controls.MaterialLabel();
            this.labelPPI = new MaterialSkin.Controls.MaterialLabel();
            this.labelModel = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.materialCheckbox9 = new MaterialSkin.Controls.MaterialCheckbox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.materialLabelDiagonal2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckbox12 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabelSizeMonitor = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelModel = new MaterialSkin.Controls.MaterialLabel();
            this.labelSerial = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckbox13 = new MaterialSkin.Controls.MaterialCheckbox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.labelSize = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckbox14 = new MaterialSkin.Controls.MaterialCheckbox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.materialLabelDiagonal1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.materialCheckbox11 = new MaterialSkin.Controls.MaterialCheckbox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.labelFrequency = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelProductCodeID = new MaterialSkin.Controls.MaterialLabel();
            this.labelDiagonal = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckbox10 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabelFrequency = new MaterialSkin.Controls.MaterialLabel();
            this.labelProductCode = new MaterialSkin.Controls.MaterialLabel();
            this.ResolutionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckbox5 = new MaterialSkin.Controls.MaterialCheckbox();
            this.labelMonth = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckbox8 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabelMonthOfProduction = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelResolution = new MaterialSkin.Controls.MaterialLabel();
            this.labelYear = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelYearOfProduction = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxHDMI = new MaterialSkin.Controls.MaterialCheckbox();
            this.numericUpDownHdmi = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxVGA = new MaterialSkin.Controls.MaterialCheckbox();
            this.numericUpDownVga = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxDisplayPort = new MaterialSkin.Controls.MaterialCheckbox();
            this.numericUpDownDisplayPort = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxDVI = new MaterialSkin.Controls.MaterialCheckbox();
            this.numericUpDownDvi = new System.Windows.Forms.NumericUpDown();
            this.sendButton = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBoxMonitors = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.searchInfoPage = new System.Windows.Forms.TabPage();
            this.testMonitorPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDisplaySettings = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExtend = new MaterialSkin.Controls.MaterialButton();
            this.btnDuplicate = new MaterialSkin.Controls.MaterialButton();
            this.btnOnlyPC = new MaterialSkin.Controls.MaterialButton();
            this.btnOnlySecond = new MaterialSkin.Controls.MaterialButton();
            this.buttonServiceFixPixel = new MaterialSkin.Controls.MaterialButton();
            this.buttonTestingMonitor = new MaterialSkin.Controls.MaterialButton();
            this.resolutionPage = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.testMonitorKnPage = new System.Windows.Forms.TabPage();
            this.materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.instructionKnPage = new System.Windows.Forms.TabPage();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.item1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.disabledItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.item3ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.mainLabelTester = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxTypeScreen = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTabControl1.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedColorAutoShow)).BeginInit();
            this.materialCard5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rusLang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsEng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlLang)).BeginInit();
            this.fullInfoPage.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.showInfoPage.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchAssetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHdmi)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVga)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisplayPort)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDvi)).BeginInit();
            this.testMonitorPage.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.resolutionPage.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.testMonitorKnPage.SuspendLayout();
            this.instructionKnPage.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMonitor
            // 
            this.labelMonitor.AutoSize = true;
            this.labelMonitor.Depth = 0;
            this.labelMonitor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelMonitor.Location = new System.Drawing.Point(81, 47);
            this.labelMonitor.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(54, 19);
            this.labelMonitor.TabIndex = 24;
            this.labelMonitor.Text = "Display";
            // 
            // lableChanRes
            // 
            this.lableChanRes.AutoSize = true;
            this.lableChanRes.Depth = 0;
            this.lableChanRes.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lableChanRes.Location = new System.Drawing.Point(50, 124);
            this.lableChanRes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lableChanRes.Name = "lableChanRes";
            this.lableChanRes.Size = new System.Drawing.Size(129, 19);
            this.lableChanRes.TabIndex = 25;
            this.lableChanRes.Text = "Change resolution";
            // 
            // MonitorComboBox
            // 
            this.MonitorComboBox.AutoResize = false;
            this.MonitorComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MonitorComboBox.Depth = 0;
            this.MonitorComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MonitorComboBox.DropDownHeight = 118;
            this.MonitorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonitorComboBox.DropDownWidth = 121;
            this.MonitorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.MonitorComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MonitorComboBox.FormattingEnabled = true;
            this.MonitorComboBox.IntegralHeight = false;
            this.MonitorComboBox.ItemHeight = 29;
            this.MonitorComboBox.Location = new System.Drawing.Point(210, 31);
            this.MonitorComboBox.MaxDropDownItems = 4;
            this.MonitorComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.MonitorComboBox.Name = "MonitorComboBox";
            this.MonitorComboBox.Size = new System.Drawing.Size(283, 35);
            this.MonitorComboBox.StartIndex = 0;
            this.MonitorComboBox.TabIndex = 26;
            this.MonitorComboBox.UseTallSize = false;
            this.MonitorComboBox.SelectedIndexChanged += new System.EventHandler(this.MonitorComboBox_SelectedIndexChanged_1);
            // 
            // ResolutionComboBox
            // 
            this.ResolutionComboBox.AutoResize = false;
            this.ResolutionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ResolutionComboBox.Depth = 0;
            this.ResolutionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ResolutionComboBox.DropDownHeight = 118;
            this.ResolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResolutionComboBox.DropDownWidth = 121;
            this.ResolutionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ResolutionComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ResolutionComboBox.FormattingEnabled = true;
            this.ResolutionComboBox.IntegralHeight = false;
            this.ResolutionComboBox.ItemHeight = 29;
            this.ResolutionComboBox.Location = new System.Drawing.Point(210, 108);
            this.ResolutionComboBox.MaxDropDownItems = 4;
            this.ResolutionComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ResolutionComboBox.Name = "ResolutionComboBox";
            this.ResolutionComboBox.Size = new System.Drawing.Size(283, 35);
            this.ResolutionComboBox.StartIndex = 0;
            this.ResolutionComboBox.TabIndex = 27;
            this.ResolutionComboBox.UseTallSize = false;
            // 
            // SetMaxResolution
            // 
            this.SetMaxResolution.AutoSize = false;
            this.SetMaxResolution.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SetMaxResolution.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SetMaxResolution.Depth = 0;
            this.SetMaxResolution.HighEmphasis = true;
            this.SetMaxResolution.Icon = null;
            this.SetMaxResolution.Location = new System.Drawing.Point(45, 172);
            this.SetMaxResolution.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SetMaxResolution.MouseState = MaterialSkin.MouseState.HOVER;
            this.SetMaxResolution.Name = "SetMaxResolution";
            this.SetMaxResolution.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SetMaxResolution.Size = new System.Drawing.Size(134, 36);
            this.SetMaxResolution.TabIndex = 28;
            this.SetMaxResolution.Text = "Set. Max. Resolution";
            this.SetMaxResolution.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SetMaxResolution.UseAccentColor = false;
            this.SetMaxResolution.UseVisualStyleBackColor = true;
            this.SetMaxResolution.Click += new System.EventHandler(this.SetMaxResolution_Click);
            // 
            // SetResolution
            // 
            this.SetResolution.AutoSize = false;
            this.SetResolution.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SetResolution.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SetResolution.Depth = 0;
            this.SetResolution.HighEmphasis = true;
            this.SetResolution.Icon = null;
            this.SetResolution.Location = new System.Drawing.Point(287, 172);
            this.SetResolution.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SetResolution.MouseState = MaterialSkin.MouseState.HOVER;
            this.SetResolution.Name = "SetResolution";
            this.SetResolution.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SetResolution.Size = new System.Drawing.Size(134, 36);
            this.SetResolution.TabIndex = 29;
            this.SetResolution.Text = "Set. Resolution";
            this.SetResolution.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SetResolution.UseAccentColor = false;
            this.SetResolution.UseVisualStyleBackColor = true;
            this.SetResolution.Click += new System.EventHandler(this.SetResolution1_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageMain);
            this.materialTabControl1.Controls.Add(this.fullInfoPage);
            this.materialTabControl1.Controls.Add(this.showInfoPage);
            this.materialTabControl1.Controls.Add(this.searchInfoPage);
            this.materialTabControl1.Controls.Add(this.testMonitorPage);
            this.materialTabControl1.Controls.Add(this.resolutionPage);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1515, 969);
            this.materialTabControl1.TabIndex = 35;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.materialCard4);
            this.tabPageMain.ImageKey = "homepage.png";
            this.tabPageMain.Location = new System.Drawing.Point(4, 39);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(1507, 926);
            this.tabPageMain.TabIndex = 7;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.flowLayoutPanel12);
            this.materialCard4.Controls.Add(this.flowLayoutPanel9);
            this.materialCard4.Controls.Add(this.checkBoxSearchSerial);
            this.materialCard4.Controls.Add(this.checkBoxSearchEVK_ID);
            this.materialCard4.Controls.Add(this.materialCard5);
            this.materialCard4.Controls.Add(this.materialSliderOpasity);
            this.materialCard4.Controls.Add(this.materialCheckbox1);
            this.materialCard4.Controls.Add(this.materialSwitch1);
            this.materialCard4.Controls.Add(this.textBoxTester);
            this.materialCard4.Controls.Add(this.checkBoxAutoShow);
            this.materialCard4.Controls.Add(this.checkBoxSaveLanguage);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(317, 101);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(677, 426);
            this.materialCard4.TabIndex = 47;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.AutoSize = true;
            this.flowLayoutPanel9.Controls.Add(this.checkBoxConnectMonitor);
            this.flowLayoutPanel9.Controls.Add(this.selectedColorAutoShow);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(14, 201);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(550, 37);
            this.flowLayoutPanel9.TabIndex = 51;
            // 
            // checkBoxConnectMonitor
            // 
            this.checkBoxConnectMonitor.AutoSize = true;
            this.checkBoxConnectMonitor.Depth = 0;
            this.checkBoxConnectMonitor.Location = new System.Drawing.Point(0, 0);
            this.checkBoxConnectMonitor.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxConnectMonitor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxConnectMonitor.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxConnectMonitor.Name = "checkBoxConnectMonitor";
            this.checkBoxConnectMonitor.ReadOnly = false;
            this.checkBoxConnectMonitor.Ripple = true;
            this.checkBoxConnectMonitor.Size = new System.Drawing.Size(504, 37);
            this.checkBoxConnectMonitor.TabIndex = 50;
            this.checkBoxConnectMonitor.Text = "Automatically enable color testing when connecting a new monitor";
            this.checkBoxConnectMonitor.UseVisualStyleBackColor = true;
            this.checkBoxConnectMonitor.CheckedChanged += new System.EventHandler(this.checkBoxConnectMonitor_CheckedChanged);
            // 
            // selectedColorAutoShow
            // 
            this.selectedColorAutoShow.Location = new System.Drawing.Point(514, 6);
            this.selectedColorAutoShow.Margin = new System.Windows.Forms.Padding(10, 6, 3, 3);
            this.selectedColorAutoShow.Name = "selectedColorAutoShow";
            this.selectedColorAutoShow.Size = new System.Drawing.Size(23, 20);
            this.selectedColorAutoShow.TabIndex = 51;
            this.selectedColorAutoShow.TabStop = false;
            // 
            // checkBoxSearchSerial
            // 
            this.checkBoxSearchSerial.AutoSize = true;
            this.checkBoxSearchSerial.Depth = 0;
            this.checkBoxSearchSerial.Location = new System.Drawing.Point(14, 165);
            this.checkBoxSearchSerial.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxSearchSerial.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxSearchSerial.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxSearchSerial.Name = "checkBoxSearchSerial";
            this.checkBoxSearchSerial.ReadOnly = false;
            this.checkBoxSearchSerial.Ripple = true;
            this.checkBoxSearchSerial.Size = new System.Drawing.Size(626, 37);
            this.checkBoxSearchSerial.TabIndex = 49;
            this.checkBoxSearchSerial.Text = "Automatic search for a monitor in an asset by reading the Serial No.(Reader\\Enter" +
    ")\r\n";
            this.checkBoxSearchSerial.UseVisualStyleBackColor = true;
            // 
            // checkBoxSearchEVK_ID
            // 
            this.checkBoxSearchEVK_ID.AutoSize = true;
            this.checkBoxSearchEVK_ID.Depth = 0;
            this.checkBoxSearchEVK_ID.Location = new System.Drawing.Point(14, 128);
            this.checkBoxSearchEVK_ID.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxSearchEVK_ID.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxSearchEVK_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxSearchEVK_ID.Name = "checkBoxSearchEVK_ID";
            this.checkBoxSearchEVK_ID.ReadOnly = false;
            this.checkBoxSearchEVK_ID.Ripple = true;
            this.checkBoxSearchEVK_ID.Size = new System.Drawing.Size(610, 37);
            this.checkBoxSearchEVK_ID.TabIndex = 48;
            this.checkBoxSearchEVK_ID.Text = "Automatic search for a monitor in an asset by reading the EVK ID (Reader\\Enter)\r\n" +
    "";
            this.checkBoxSearchEVK_ID.UseVisualStyleBackColor = true;
            this.checkBoxSearchEVK_ID.CheckedChanged += new System.EventHandler(this.materialCheckbox2_CheckedChanged);
            // 
            // materialCard5
            // 
            this.materialCard5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.materialLabel25);
            this.materialCard5.Controls.Add(this.pictureBox37);
            this.materialCard5.Controls.Add(this.materialLabel4);
            this.materialCard5.Controls.Add(this.materialLabel3);
            this.materialCard5.Controls.Add(this.RusLabel);
            this.materialCard5.Controls.Add(this.LabelUkr);
            this.materialCard5.Controls.Add(this.pictureBox36);
            this.materialCard5.Controls.Add(this.rusLang);
            this.materialCard5.Controls.Add(this.UsEng);
            this.materialCard5.Controls.Add(this.PlLang);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(14, 329);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(284, 56);
            this.materialCard5.TabIndex = 46;
            // 
            // materialLabel25
            // 
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel25.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.materialLabel25.Location = new System.Drawing.Point(10, 39);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(20, 13);
            this.materialLabel25.TabIndex = 54;
            this.materialLabel25.Text = "БЕЛ";
            // 
            // pictureBox37
            // 
            this.pictureBox37.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.belarus;
            this.pictureBox37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox37.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox37.Location = new System.Drawing.Point(5, 7);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(36, 22);
            this.pictureBox37.TabIndex = 53;
            this.pictureBox37.TabStop = false;
            this.pictureBox37.Click += new System.EventHandler(this.pictureBox37_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.materialLabel4.Location = new System.Drawing.Point(248, 40);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(21, 13);
            this.materialLabel4.TabIndex = 51;
            this.materialLabel4.Text = "ENG";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.materialLabel3.Location = new System.Drawing.Point(192, 39);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(12, 13);
            this.materialLabel3.TabIndex = 50;
            this.materialLabel3.Text = "PL";
            // 
            // RusLabel
            // 
            this.RusLabel.AutoSize = true;
            this.RusLabel.Depth = 0;
            this.RusLabel.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RusLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.RusLabel.Location = new System.Drawing.Point(128, 39);
            this.RusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RusLabel.Name = "RusLabel";
            this.RusLabel.Size = new System.Drawing.Size(20, 13);
            this.RusLabel.TabIndex = 49;
            this.RusLabel.Text = "РУС";
            // 
            // LabelUkr
            // 
            this.LabelUkr.AutoSize = true;
            this.LabelUkr.Depth = 0;
            this.LabelUkr.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelUkr.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.LabelUkr.Location = new System.Drawing.Point(70, 40);
            this.LabelUkr.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelUkr.Name = "LabelUkr";
            this.LabelUkr.Size = new System.Drawing.Size(19, 13);
            this.LabelUkr.TabIndex = 48;
            this.LabelUkr.Text = "УКР";
            // 
            // pictureBox36
            // 
            this.pictureBox36.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.ukraine;
            this.pictureBox36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox36.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox36.Location = new System.Drawing.Point(61, 0);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(36, 36);
            this.pictureBox36.TabIndex = 47;
            this.pictureBox36.TabStop = false;
            this.pictureBox36.Click += new System.EventHandler(this.pictureBox36_Click);
            this.pictureBox36.DoubleClick += new System.EventHandler(this.pictureBox36_DoubleClick);
            // 
            // rusLang
            // 
            this.rusLang.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.russia;
            this.rusLang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rusLang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rusLang.Location = new System.Drawing.Point(122, 0);
            this.rusLang.Name = "rusLang";
            this.rusLang.Size = new System.Drawing.Size(36, 36);
            this.rusLang.TabIndex = 46;
            this.rusLang.TabStop = false;
            this.rusLang.Click += new System.EventHandler(this.rusLang_Click);
            // 
            // UsEng
            // 
            this.UsEng.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.map;
            this.UsEng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UsEng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsEng.Location = new System.Drawing.Point(240, 1);
            this.UsEng.Name = "UsEng";
            this.UsEng.Size = new System.Drawing.Size(36, 36);
            this.UsEng.TabIndex = 45;
            this.UsEng.TabStop = false;
            this.UsEng.Click += new System.EventHandler(this.pictureUSEng_Click);
            // 
            // PlLang
            // 
            this.PlLang.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.poland;
            this.PlLang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlLang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlLang.Location = new System.Drawing.Point(181, 0);
            this.PlLang.Name = "PlLang";
            this.PlLang.Size = new System.Drawing.Size(36, 36);
            this.PlLang.TabIndex = 44;
            this.PlLang.TabStop = false;
            this.PlLang.Click += new System.EventHandler(this.picturePlLang_Click);
            // 
            // materialSliderOpasity
            // 
            this.materialSliderOpasity.Depth = 0;
            this.materialSliderOpasity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSliderOpasity.Location = new System.Drawing.Point(199, 386);
            this.materialSliderOpasity.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSliderOpasity.Name = "materialSliderOpasity";
            this.materialSliderOpasity.Size = new System.Drawing.Size(231, 40);
            this.materialSliderOpasity.TabIndex = 41;
            this.materialSliderOpasity.Text = "Opasity";
            this.materialSliderOpasity.UseAccentColor = true;
            this.materialSliderOpasity.Value = 100;
            this.materialSliderOpasity.ValueMax = 100;
            this.materialSliderOpasity.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.materialSliderOpasity_onValueChanged);
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(14, 241);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(227, 37);
            this.materialCheckbox1.TabIndex = 39;
            this.materialCheckbox1.Text = "Automatically sent to asset";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.BackColor = System.Drawing.Color.RosyBrown;
            this.materialSwitch1.Checked = true;
            this.materialSwitch1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(0, 386);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(137, 37);
            this.materialSwitch1.TabIndex = 38;
            this.materialSwitch1.Text = "dark theme";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // textBoxTester
            // 
            this.textBoxTester.AnimateReadOnly = false;
            this.textBoxTester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxTester.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxTester.Depth = 0;
            this.textBoxTester.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxTester.HideSelection = true;
            this.textBoxTester.Hint = "Initials (AF)";
            this.textBoxTester.LeadingIcon = null;
            this.textBoxTester.Location = new System.Drawing.Point(147, 17);
            this.textBoxTester.MaxLength = 2;
            this.textBoxTester.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxTester.Name = "textBoxTester";
            this.textBoxTester.PasswordChar = '\0';
            this.textBoxTester.PrefixSuffixText = null;
            this.textBoxTester.ReadOnly = false;
            this.textBoxTester.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTester.SelectedText = "";
            this.textBoxTester.SelectionLength = 0;
            this.textBoxTester.SelectionStart = 0;
            this.textBoxTester.ShortcutsEnabled = true;
            this.textBoxTester.Size = new System.Drawing.Size(371, 48);
            this.textBoxTester.TabIndex = 0;
            this.textBoxTester.TabStop = false;
            this.textBoxTester.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxTester.TrailingIcon = global::ServiceMonitorEVK.Properties.Resources.web;
            this.textBoxTester.UseSystemPasswordChar = false;
            this.textBoxTester.Leave += new System.EventHandler(this.textBoxTester_Leave);
            this.textBoxTester.TextChanged += new System.EventHandler(this.textBoxTester_TextChanged);
            // 
            // checkBoxAutoShow
            // 
            this.checkBoxAutoShow.AutoSize = true;
            this.checkBoxAutoShow.Depth = 0;
            this.checkBoxAutoShow.Location = new System.Drawing.Point(14, 278);
            this.checkBoxAutoShow.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxAutoShow.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxAutoShow.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxAutoShow.Name = "checkBoxAutoShow";
            this.checkBoxAutoShow.ReadOnly = false;
            this.checkBoxAutoShow.Ripple = true;
            this.checkBoxAutoShow.Size = new System.Drawing.Size(503, 37);
            this.checkBoxAutoShow.TabIndex = 40;
            this.checkBoxAutoShow.Text = "Automatically show info from serial number (only for one monitor)";
            this.checkBoxAutoShow.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveLanguage
            // 
            this.checkBoxSaveLanguage.AutoSize = true;
            this.checkBoxSaveLanguage.Depth = 0;
            this.checkBoxSaveLanguage.Location = new System.Drawing.Point(312, 336);
            this.checkBoxSaveLanguage.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxSaveLanguage.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxSaveLanguage.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxSaveLanguage.Name = "checkBoxSaveLanguage";
            this.checkBoxSaveLanguage.ReadOnly = false;
            this.checkBoxSaveLanguage.Ripple = true;
            this.checkBoxSaveLanguage.Size = new System.Drawing.Size(35, 37);
            this.checkBoxSaveLanguage.TabIndex = 47;
            this.checkBoxSaveLanguage.UseVisualStyleBackColor = true;
            // 
            // fullInfoPage
            // 
            this.fullInfoPage.BackColor = System.Drawing.Color.Transparent;
            this.fullInfoPage.Controls.Add(this.materialCard1);
            this.fullInfoPage.ImageKey = "info (2).png";
            this.fullInfoPage.Location = new System.Drawing.Point(4, 39);
            this.fullInfoPage.Name = "fullInfoPage";
            this.fullInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.fullInfoPage.Size = new System.Drawing.Size(1491, 887);
            this.fullInfoPage.TabIndex = 3;
            this.fullInfoPage.Text = "Show full info";
            this.fullInfoPage.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialMultiLineTextBox2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1266, 616);
            this.materialCard1.TabIndex = 35;
            // 
            // materialMultiLineTextBox2
            // 
            this.materialMultiLineTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox2.Depth = 0;
            this.materialMultiLineTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox2.Location = new System.Drawing.Point(6, 6);
            this.materialMultiLineTextBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox2.Name = "materialMultiLineTextBox2";
            this.materialMultiLineTextBox2.ReadOnly = true;
            this.materialMultiLineTextBox2.Size = new System.Drawing.Size(1243, 592);
            this.materialMultiLineTextBox2.TabIndex = 30;
            this.materialMultiLineTextBox2.Text = "";
            // 
            // showInfoPage
            // 
            this.showInfoPage.BackColor = System.Drawing.Color.White;
            this.showInfoPage.Controls.Add(this.materialCard3);
            this.showInfoPage.Controls.Add(this.materialCard2);
            this.showInfoPage.Controls.Add(this.sendButton);
            this.showInfoPage.Controls.Add(this.materialComboBoxMonitors);
            this.showInfoPage.Controls.Add(this.materialButton1);
            this.showInfoPage.ImageKey = "computer.png";
            this.showInfoPage.Location = new System.Drawing.Point(4, 39);
            this.showInfoPage.Name = "showInfoPage";
            this.showInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.showInfoPage.Size = new System.Drawing.Size(1491, 887);
            this.showInfoPage.TabIndex = 1;
            this.showInfoPage.Text = "Show info";
            this.showInfoPage.Enter += new System.EventHandler(this.showInfoPage_Enter);
            // 
            // materialCard3
            // 
            this.materialCard3.AutoSize = true;
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.tableLayoutPanel1);
            this.materialCard3.Controls.Add(this.materialLabel11);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(601, 58);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(294, 593);
            this.materialCard3.TabIndex = 72;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.materialLabel17, 2, 22);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox35, 0, 22);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetIdEvk, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel46, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelAsCable, 1, 22);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetCountry, 2, 21);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox34, 0, 21);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAsManufact, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAsCountry, 1, 21);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetManufacturer, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox15, 0, 20);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox20, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetClass, 2, 20);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox14, 0, 19);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox17, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetModel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelAsClass, 1, 20);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetPlace, 2, 19);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox18, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox16, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.labelAsModel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelAsPlace, 1, 19);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetDateCleaning, 3, 16);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetIsPictured, 2, 18);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox7, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelAsPicture, 1, 18);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox11, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetTester, 2, 17);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox8, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox10, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetCleaner1, 1, 17);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetIsCleaned, 2, 16);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetDateTesting, 3, 14);
            this.tableLayoutPanel1.Controls.Add(this.labelAsType, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetDiagonalDB, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.labelAsCleaned, 1, 16);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox9, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetType, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.labelAsDiagonal, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetCleaner, 2, 15);
            this.tableLayoutPanel1.Controls.Add(this.labelAsProductId, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetProductCode, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.labelAsDIagHW, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetDiagonal, 2, 13);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetIsTested, 2, 14);
            this.tableLayoutPanel1.Controls.Add(this.labelAsTester, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.labelAsSerial, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetSerialNumber, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelAsResolution, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelAsTested, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.labelAssetResolution, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox19, 0, 18);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 23;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 534);
            this.tableLayoutPanel1.TabIndex = 80;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.HighEmphasis = true;
            this.materialLabel17.Location = new System.Drawing.Point(187, 459);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(19, 19);
            this.materialLabel17.TabIndex = 104;
            this.materialLabel17.Text = "33";
            this.materialLabel17.UseAccent = true;
            // 
            // pictureBox35
            // 
            this.pictureBox35.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox35.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox35.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox35.Location = new System.Drawing.Point(3, 462);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(24, 21);
            this.pictureBox35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox35.TabIndex = 105;
            this.pictureBox35.TabStop = false;
            // 
            // labelAssetIdEvk
            // 
            this.labelAssetIdEvk.AutoSize = true;
            this.labelAssetIdEvk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetIdEvk.Depth = 0;
            this.labelAssetIdEvk.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetIdEvk.HighEmphasis = true;
            this.labelAssetIdEvk.Location = new System.Drawing.Point(187, 0);
            this.labelAssetIdEvk.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetIdEvk.Name = "labelAssetIdEvk";
            this.labelAssetIdEvk.Size = new System.Drawing.Size(19, 19);
            this.labelAssetIdEvk.TabIndex = 85;
            this.labelAssetIdEvk.Text = "33";
            this.labelAssetIdEvk.UseAccent = true;
            // 
            // materialLabel46
            // 
            this.materialLabel46.AutoSize = true;
            this.materialLabel46.Depth = 0;
            this.materialLabel46.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel46.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel46.ImageKey = "(none)";
            this.materialLabel46.Location = new System.Drawing.Point(33, 0);
            this.materialLabel46.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel46.Name = "materialLabel46";
            this.materialLabel46.Size = new System.Drawing.Size(67, 24);
            this.materialLabel46.TabIndex = 35;
            this.materialLabel46.Text = "ID EVK:";
            // 
            // labelAsCable
            // 
            this.labelAsCable.AutoSize = true;
            this.labelAsCable.Depth = 0;
            this.labelAsCable.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsCable.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsCable.Location = new System.Drawing.Point(33, 459);
            this.labelAsCable.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsCable.Name = "labelAsCable";
            this.labelAsCable.Size = new System.Drawing.Size(57, 24);
            this.labelAsCable.TabIndex = 103;
            this.labelAsCable.Text = "Cable:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::ServiceMonitorEVK.Properties.Resources.id;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 80;
            this.pictureBox3.TabStop = false;
            // 
            // labelAssetCountry
            // 
            this.labelAssetCountry.AutoSize = true;
            this.labelAssetCountry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetCountry.Depth = 0;
            this.labelAssetCountry.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetCountry.HighEmphasis = true;
            this.labelAssetCountry.Location = new System.Drawing.Point(187, 432);
            this.labelAssetCountry.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetCountry.Name = "labelAssetCountry";
            this.labelAssetCountry.Size = new System.Drawing.Size(19, 19);
            this.labelAssetCountry.TabIndex = 101;
            this.labelAssetCountry.Text = "33";
            this.labelAssetCountry.UseAccent = true;
            // 
            // pictureBox34
            // 
            this.pictureBox34.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox34.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox34.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox34.Location = new System.Drawing.Point(3, 435);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(24, 21);
            this.pictureBox34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox34.TabIndex = 102;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox4.Location = new System.Drawing.Point(3, 30);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 83;
            this.pictureBox4.TabStop = false;
            // 
            // labelAsManufact
            // 
            this.labelAsManufact.AutoSize = true;
            this.labelAsManufact.Depth = 0;
            this.labelAsManufact.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsManufact.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsManufact.Location = new System.Drawing.Point(33, 27);
            this.labelAsManufact.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsManufact.Name = "labelAsManufact";
            this.labelAsManufact.Size = new System.Drawing.Size(128, 24);
            this.labelAsManufact.TabIndex = 0;
            this.labelAsManufact.Text = "Manufacturer:";
            // 
            // labelAsCountry
            // 
            this.labelAsCountry.AutoSize = true;
            this.labelAsCountry.Depth = 0;
            this.labelAsCountry.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsCountry.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsCountry.Location = new System.Drawing.Point(33, 432);
            this.labelAsCountry.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsCountry.Name = "labelAsCountry";
            this.labelAsCountry.Size = new System.Drawing.Size(76, 24);
            this.labelAsCountry.TabIndex = 100;
            this.labelAsCountry.Text = "Country:";
            // 
            // labelAssetManufacturer
            // 
            this.labelAssetManufacturer.AutoSize = true;
            this.labelAssetManufacturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetManufacturer.Depth = 0;
            this.labelAssetManufacturer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetManufacturer.HighEmphasis = true;
            this.labelAssetManufacturer.Location = new System.Drawing.Point(187, 27);
            this.labelAssetManufacturer.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetManufacturer.Name = "labelAssetManufacturer";
            this.labelAssetManufacturer.Size = new System.Drawing.Size(19, 19);
            this.labelAssetManufacturer.TabIndex = 39;
            this.labelAssetManufacturer.Text = "33";
            this.labelAssetManufacturer.UseAccent = true;
            this.labelAssetManufacturer.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox15.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox15.Location = new System.Drawing.Point(3, 408);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(24, 21);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 94;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox20.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox20.Location = new System.Drawing.Point(3, 300);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(24, 21);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 99;
            this.pictureBox20.TabStop = false;
            // 
            // labelAssetClass
            // 
            this.labelAssetClass.AutoSize = true;
            this.labelAssetClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetClass.Depth = 0;
            this.labelAssetClass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetClass.HighEmphasis = true;
            this.labelAssetClass.Location = new System.Drawing.Point(187, 405);
            this.labelAssetClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetClass.Name = "labelAssetClass";
            this.labelAssetClass.Size = new System.Drawing.Size(19, 19);
            this.labelAssetClass.TabIndex = 75;
            this.labelAssetClass.Text = "33";
            this.labelAssetClass.UseAccent = true;
            this.labelAssetClass.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox14.Image = global::ServiceMonitorEVK.Properties.Resources.storage;
            this.pictureBox14.Location = new System.Drawing.Point(3, 381);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(24, 21);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 93;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox17.Image = global::ServiceMonitorEVK.Properties.Resources.web;
            this.pictureBox17.Location = new System.Drawing.Point(3, 327);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(24, 21);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 96;
            this.pictureBox17.TabStop = false;
            // 
            // labelAssetModel
            // 
            this.labelAssetModel.AutoSize = true;
            this.labelAssetModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetModel.Depth = 0;
            this.labelAssetModel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetModel.HighEmphasis = true;
            this.labelAssetModel.Location = new System.Drawing.Point(187, 54);
            this.labelAssetModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetModel.Name = "labelAssetModel";
            this.labelAssetModel.Size = new System.Drawing.Size(19, 19);
            this.labelAssetModel.TabIndex = 40;
            this.labelAssetModel.Text = "33";
            this.labelAssetModel.UseAccent = true;
            this.labelAssetModel.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelAsClass
            // 
            this.labelAsClass.AutoSize = true;
            this.labelAsClass.Depth = 0;
            this.labelAsClass.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsClass.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsClass.Location = new System.Drawing.Point(33, 405);
            this.labelAsClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsClass.Name = "labelAsClass";
            this.labelAsClass.Size = new System.Drawing.Size(55, 24);
            this.labelAsClass.TabIndex = 74;
            this.labelAsClass.Text = "Class:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox5.Location = new System.Drawing.Point(3, 57);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 21);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 84;
            this.pictureBox5.TabStop = false;
            // 
            // labelAssetPlace
            // 
            this.labelAssetPlace.AutoSize = true;
            this.labelAssetPlace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetPlace.Depth = 0;
            this.labelAssetPlace.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetPlace.HighEmphasis = true;
            this.labelAssetPlace.Location = new System.Drawing.Point(187, 378);
            this.labelAssetPlace.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetPlace.Name = "labelAssetPlace";
            this.labelAssetPlace.Size = new System.Drawing.Size(19, 19);
            this.labelAssetPlace.TabIndex = 73;
            this.labelAssetPlace.Text = "33";
            this.labelAssetPlace.UseAccent = true;
            this.labelAssetPlace.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox18.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox18.Location = new System.Drawing.Point(3, 246);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(24, 21);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 97;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox16.Image = global::ServiceMonitorEVK.Properties.Resources.web;
            this.pictureBox16.Location = new System.Drawing.Point(3, 273);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(24, 21);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 95;
            this.pictureBox16.TabStop = false;
            // 
            // labelAsModel
            // 
            this.labelAsModel.AutoSize = true;
            this.labelAsModel.Depth = 0;
            this.labelAsModel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsModel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsModel.Location = new System.Drawing.Point(33, 54);
            this.labelAsModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsModel.Name = "labelAsModel";
            this.labelAsModel.Size = new System.Drawing.Size(62, 24);
            this.labelAsModel.TabIndex = 1;
            this.labelAsModel.Text = "Model:";
            // 
            // labelAsPlace
            // 
            this.labelAsPlace.AutoSize = true;
            this.labelAsPlace.Depth = 0;
            this.labelAsPlace.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsPlace.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsPlace.Location = new System.Drawing.Point(33, 378);
            this.labelAsPlace.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsPlace.Name = "labelAsPlace";
            this.labelAsPlace.Size = new System.Drawing.Size(56, 24);
            this.labelAsPlace.TabIndex = 72;
            this.labelAsPlace.Text = "Place:";
            // 
            // labelAssetDateCleaning
            // 
            this.labelAssetDateCleaning.AutoSize = true;
            this.labelAssetDateCleaning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetDateCleaning.Depth = 0;
            this.labelAssetDateCleaning.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetDateCleaning.HighEmphasis = true;
            this.labelAssetDateCleaning.Location = new System.Drawing.Point(212, 297);
            this.labelAssetDateCleaning.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetDateCleaning.Name = "labelAssetDateCleaning";
            this.labelAssetDateCleaning.Size = new System.Drawing.Size(19, 19);
            this.labelAssetDateCleaning.TabIndex = 78;
            this.labelAssetDateCleaning.Text = "33";
            this.labelAssetDateCleaning.UseAccent = true;
            this.labelAssetDateCleaning.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelAssetIsPictured
            // 
            this.labelAssetIsPictured.AutoSize = true;
            this.labelAssetIsPictured.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetIsPictured.Depth = 0;
            this.labelAssetIsPictured.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetIsPictured.HighEmphasis = true;
            this.labelAssetIsPictured.Location = new System.Drawing.Point(187, 351);
            this.labelAssetIsPictured.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetIsPictured.Name = "labelAssetIsPictured";
            this.labelAssetIsPictured.Size = new System.Drawing.Size(19, 19);
            this.labelAssetIsPictured.TabIndex = 69;
            this.labelAssetIsPictured.Text = "33";
            this.labelAssetIsPictured.UseAccent = true;
            this.labelAssetIsPictured.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox6.Location = new System.Drawing.Point(3, 84);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 21);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 85;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox7.Location = new System.Drawing.Point(3, 111);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 21);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 86;
            this.pictureBox7.TabStop = false;
            // 
            // labelAsPicture
            // 
            this.labelAsPicture.AutoSize = true;
            this.labelAsPicture.Depth = 0;
            this.labelAsPicture.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsPicture.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsPicture.Location = new System.Drawing.Point(33, 351);
            this.labelAsPicture.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsPicture.Name = "labelAsPicture";
            this.labelAsPicture.Size = new System.Drawing.Size(91, 24);
            this.labelAsPicture.TabIndex = 68;
            this.labelAsPicture.Text = "Pictured?:";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox11.Location = new System.Drawing.Point(3, 219);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(24, 21);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 90;
            this.pictureBox11.TabStop = false;
            // 
            // labelAssetTester
            // 
            this.labelAssetTester.AutoSize = true;
            this.labelAssetTester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetTester.Depth = 0;
            this.labelAssetTester.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetTester.HighEmphasis = true;
            this.labelAssetTester.Location = new System.Drawing.Point(187, 324);
            this.labelAssetTester.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetTester.Name = "labelAssetTester";
            this.labelAssetTester.Size = new System.Drawing.Size(19, 19);
            this.labelAssetTester.TabIndex = 48;
            this.labelAssetTester.Text = "33";
            this.labelAssetTester.UseAccent = true;
            this.labelAssetTester.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox8.Location = new System.Drawing.Point(3, 138);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(24, 21);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 87;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox10.Location = new System.Drawing.Point(3, 192);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(24, 21);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 89;
            this.pictureBox10.TabStop = false;
            // 
            // labelAssetCleaner1
            // 
            this.labelAssetCleaner1.AutoSize = true;
            this.labelAssetCleaner1.Depth = 0;
            this.labelAssetCleaner1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetCleaner1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAssetCleaner1.Location = new System.Drawing.Point(33, 324);
            this.labelAssetCleaner1.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetCleaner1.Name = "labelAssetCleaner1";
            this.labelAssetCleaner1.Size = new System.Drawing.Size(75, 24);
            this.labelAssetCleaner1.TabIndex = 38;
            this.labelAssetCleaner1.Text = "Cleaner:";
            // 
            // labelAssetIsCleaned
            // 
            this.labelAssetIsCleaned.AutoSize = true;
            this.labelAssetIsCleaned.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetIsCleaned.Depth = 0;
            this.labelAssetIsCleaned.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetIsCleaned.HighEmphasis = true;
            this.labelAssetIsCleaned.Location = new System.Drawing.Point(187, 297);
            this.labelAssetIsCleaned.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetIsCleaned.Name = "labelAssetIsCleaned";
            this.labelAssetIsCleaned.Size = new System.Drawing.Size(19, 19);
            this.labelAssetIsCleaned.TabIndex = 71;
            this.labelAssetIsCleaned.Text = "33";
            this.labelAssetIsCleaned.UseAccent = true;
            this.labelAssetIsCleaned.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelAssetDateTesting
            // 
            this.labelAssetDateTesting.AutoSize = true;
            this.labelAssetDateTesting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetDateTesting.Depth = 0;
            this.labelAssetDateTesting.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetDateTesting.HighEmphasis = true;
            this.labelAssetDateTesting.Location = new System.Drawing.Point(212, 243);
            this.labelAssetDateTesting.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetDateTesting.Name = "labelAssetDateTesting";
            this.labelAssetDateTesting.Size = new System.Drawing.Size(19, 19);
            this.labelAssetDateTesting.TabIndex = 76;
            this.labelAssetDateTesting.Text = "33";
            this.labelAssetDateTesting.UseAccent = true;
            this.labelAssetDateTesting.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelAsType
            // 
            this.labelAsType.AutoSize = true;
            this.labelAsType.Depth = 0;
            this.labelAsType.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsType.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsType.Location = new System.Drawing.Point(33, 135);
            this.labelAsType.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsType.Name = "labelAsType";
            this.labelAsType.Size = new System.Drawing.Size(50, 24);
            this.labelAsType.TabIndex = 79;
            this.labelAsType.Text = "Type:";
            // 
            // labelAssetDiagonalDB
            // 
            this.labelAssetDiagonalDB.AutoSize = true;
            this.labelAssetDiagonalDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetDiagonalDB.Depth = 0;
            this.labelAssetDiagonalDB.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetDiagonalDB.HighEmphasis = true;
            this.labelAssetDiagonalDB.Location = new System.Drawing.Point(187, 162);
            this.labelAssetDiagonalDB.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetDiagonalDB.Name = "labelAssetDiagonalDB";
            this.labelAssetDiagonalDB.Size = new System.Drawing.Size(19, 19);
            this.labelAssetDiagonalDB.TabIndex = 82;
            this.labelAssetDiagonalDB.Text = "33";
            this.labelAssetDiagonalDB.UseAccent = true;
            // 
            // labelAsCleaned
            // 
            this.labelAsCleaned.AutoSize = true;
            this.labelAsCleaned.Depth = 0;
            this.labelAsCleaned.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsCleaned.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsCleaned.Location = new System.Drawing.Point(33, 297);
            this.labelAsCleaned.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsCleaned.Name = "labelAsCleaned";
            this.labelAsCleaned.Size = new System.Drawing.Size(89, 24);
            this.labelAsCleaned.TabIndex = 70;
            this.labelAsCleaned.Text = "Cleaned?:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox9.Location = new System.Drawing.Point(3, 165);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(24, 21);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 88;
            this.pictureBox9.TabStop = false;
            // 
            // labelAssetType
            // 
            this.labelAssetType.AutoSize = true;
            this.labelAssetType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetType.Depth = 0;
            this.labelAssetType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetType.HighEmphasis = true;
            this.labelAssetType.Location = new System.Drawing.Point(187, 135);
            this.labelAssetType.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetType.Name = "labelAssetType";
            this.labelAssetType.Size = new System.Drawing.Size(19, 19);
            this.labelAssetType.TabIndex = 80;
            this.labelAssetType.Text = "33";
            this.labelAssetType.UseAccent = true;
            // 
            // labelAsDiagonal
            // 
            this.labelAsDiagonal.AutoSize = true;
            this.labelAsDiagonal.Depth = 0;
            this.labelAsDiagonal.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsDiagonal.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsDiagonal.Location = new System.Drawing.Point(33, 162);
            this.labelAsDiagonal.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsDiagonal.Name = "labelAsDiagonal";
            this.labelAsDiagonal.Size = new System.Drawing.Size(84, 24);
            this.labelAsDiagonal.TabIndex = 81;
            this.labelAsDiagonal.Text = "Diagonal:";
            // 
            // labelAssetCleaner
            // 
            this.labelAssetCleaner.AutoSize = true;
            this.labelAssetCleaner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetCleaner.Depth = 0;
            this.labelAssetCleaner.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetCleaner.HighEmphasis = true;
            this.labelAssetCleaner.Location = new System.Drawing.Point(187, 270);
            this.labelAssetCleaner.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetCleaner.Name = "labelAssetCleaner";
            this.labelAssetCleaner.Size = new System.Drawing.Size(19, 19);
            this.labelAssetCleaner.TabIndex = 50;
            this.labelAssetCleaner.Text = "33";
            this.labelAssetCleaner.UseAccent = true;
            this.labelAssetCleaner.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelAsProductId
            // 
            this.labelAsProductId.AutoSize = true;
            this.labelAsProductId.Depth = 0;
            this.labelAsProductId.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsProductId.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsProductId.Location = new System.Drawing.Point(33, 189);
            this.labelAsProductId.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsProductId.Name = "labelAsProductId";
            this.labelAsProductId.Size = new System.Drawing.Size(148, 24);
            this.labelAsProductId.TabIndex = 4;
            this.labelAsProductId.Text = "Product code ID:";
            // 
            // labelAssetProductCode
            // 
            this.labelAssetProductCode.AutoSize = true;
            this.labelAssetProductCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetProductCode.Depth = 0;
            this.labelAssetProductCode.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetProductCode.HighEmphasis = true;
            this.labelAssetProductCode.Location = new System.Drawing.Point(187, 189);
            this.labelAssetProductCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetProductCode.Name = "labelAssetProductCode";
            this.labelAssetProductCode.Size = new System.Drawing.Size(19, 19);
            this.labelAssetProductCode.TabIndex = 43;
            this.labelAssetProductCode.Text = "33";
            this.labelAssetProductCode.UseAccent = true;
            this.labelAssetProductCode.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelAsDIagHW
            // 
            this.labelAsDIagHW.AutoSize = true;
            this.labelAsDIagHW.Depth = 0;
            this.labelAsDIagHW.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsDIagHW.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsDIagHW.Location = new System.Drawing.Point(33, 216);
            this.labelAsDIagHW.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsDIagHW.Name = "labelAsDIagHW";
            this.labelAsDIagHW.Size = new System.Drawing.Size(143, 24);
            this.labelAsDIagHW.TabIndex = 32;
            this.labelAsDIagHW.Text = "Diagonal (H\\W):";
            // 
            // labelAssetDiagonal
            // 
            this.labelAssetDiagonal.AutoSize = true;
            this.labelAssetDiagonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetDiagonal.Depth = 0;
            this.labelAssetDiagonal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetDiagonal.HighEmphasis = true;
            this.labelAssetDiagonal.Location = new System.Drawing.Point(187, 216);
            this.labelAssetDiagonal.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetDiagonal.Name = "labelAssetDiagonal";
            this.labelAssetDiagonal.Size = new System.Drawing.Size(19, 19);
            this.labelAssetDiagonal.TabIndex = 44;
            this.labelAssetDiagonal.Text = "33";
            this.labelAssetDiagonal.UseAccent = true;
            this.labelAssetDiagonal.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelAssetIsTested
            // 
            this.labelAssetIsTested.AutoSize = true;
            this.labelAssetIsTested.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetIsTested.Depth = 0;
            this.labelAssetIsTested.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetIsTested.HighEmphasis = true;
            this.labelAssetIsTested.Location = new System.Drawing.Point(187, 243);
            this.labelAssetIsTested.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetIsTested.Name = "labelAssetIsTested";
            this.labelAssetIsTested.Size = new System.Drawing.Size(19, 19);
            this.labelAssetIsTested.TabIndex = 67;
            this.labelAssetIsTested.Text = "33";
            this.labelAssetIsTested.UseAccent = true;
            this.labelAssetIsTested.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelAsTester
            // 
            this.labelAsTester.AutoSize = true;
            this.labelAsTester.Depth = 0;
            this.labelAsTester.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsTester.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsTester.Location = new System.Drawing.Point(33, 270);
            this.labelAsTester.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsTester.Name = "labelAsTester";
            this.labelAsTester.Size = new System.Drawing.Size(64, 24);
            this.labelAsTester.TabIndex = 36;
            this.labelAsTester.Text = "Tester:";
            // 
            // labelAsSerial
            // 
            this.labelAsSerial.AutoSize = true;
            this.labelAsSerial.Depth = 0;
            this.labelAsSerial.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsSerial.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsSerial.Location = new System.Drawing.Point(33, 81);
            this.labelAsSerial.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsSerial.Name = "labelAsSerial";
            this.labelAsSerial.Size = new System.Drawing.Size(93, 24);
            this.labelAsSerial.TabIndex = 34;
            this.labelAsSerial.Text = "Serial No.:";
            // 
            // labelAssetSerialNumber
            // 
            this.labelAssetSerialNumber.AutoSize = true;
            this.labelAssetSerialNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetSerialNumber.Depth = 0;
            this.labelAssetSerialNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetSerialNumber.HighEmphasis = true;
            this.labelAssetSerialNumber.Location = new System.Drawing.Point(187, 81);
            this.labelAssetSerialNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetSerialNumber.Name = "labelAssetSerialNumber";
            this.labelAssetSerialNumber.Size = new System.Drawing.Size(19, 19);
            this.labelAssetSerialNumber.TabIndex = 46;
            this.labelAssetSerialNumber.Text = "33";
            this.labelAssetSerialNumber.UseAccent = true;
            this.labelAssetSerialNumber.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelAsResolution
            // 
            this.labelAsResolution.AutoSize = true;
            this.labelAsResolution.Depth = 0;
            this.labelAsResolution.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsResolution.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsResolution.Location = new System.Drawing.Point(33, 108);
            this.labelAsResolution.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsResolution.Name = "labelAsResolution";
            this.labelAsResolution.Size = new System.Drawing.Size(100, 24);
            this.labelAsResolution.TabIndex = 37;
            this.labelAsResolution.Text = "Resolution:";
            // 
            // labelAsTested
            // 
            this.labelAsTested.AutoSize = true;
            this.labelAsTested.Depth = 0;
            this.labelAsTested.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsTested.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsTested.Location = new System.Drawing.Point(33, 243);
            this.labelAsTested.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsTested.Name = "labelAsTested";
            this.labelAsTested.Size = new System.Drawing.Size(78, 24);
            this.labelAsTested.TabIndex = 66;
            this.labelAsTested.Text = "Tested?:";
            // 
            // labelAssetResolution
            // 
            this.labelAssetResolution.AutoSize = true;
            this.labelAssetResolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetResolution.Depth = 0;
            this.labelAssetResolution.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetResolution.HighEmphasis = true;
            this.labelAssetResolution.Location = new System.Drawing.Point(187, 108);
            this.labelAssetResolution.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetResolution.Name = "labelAssetResolution";
            this.labelAssetResolution.Size = new System.Drawing.Size(19, 19);
            this.labelAssetResolution.TabIndex = 49;
            this.labelAssetResolution.Text = "33";
            this.labelAssetResolution.UseAccent = true;
            this.labelAssetResolution.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox19.Image = global::ServiceMonitorEVK.Properties.Resources.gallery;
            this.pictureBox19.Location = new System.Drawing.Point(3, 354);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(24, 21);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 98;
            this.pictureBox19.TabStop = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel11.HighEmphasis = true;
            this.materialLabel11.Location = new System.Drawing.Point(124, 10);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(62, 29);
            this.materialLabel11.TabIndex = 79;
            this.materialLabel11.Text = "Asset";
            this.materialLabel11.UseAccent = true;
            // 
            // materialCard2
            // 
            this.materialCard2.AutoSize = true;
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.flowLayoutPanel8);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(20, 58);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5);
            this.materialCard2.Size = new System.Drawing.Size(490, 626);
            this.materialCard2.TabIndex = 56;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(480, 616);
            this.flowLayoutPanel8.TabIndex = 80;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.textBoxSerial, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxCountry, 3, 11);
            this.tableLayoutPanel2.Controls.Add(this.materialCheckbox6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox21, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchAssetButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox29, 1, 12);
            this.tableLayoutPanel2.Controls.Add(this.textBoxIdEVK, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxCountry, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.materialCheckbox7, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox28, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelManufacturer, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox27, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelManufacturer, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelPPI, 3, 12);
            this.tableLayoutPanel2.Controls.Add(this.labelCountry, 2, 11);
            this.tableLayoutPanel2.Controls.Add(this.labelPPI, 2, 12);
            this.tableLayoutPanel2.Controls.Add(this.labelModel, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox26, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.materialCheckbox4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox31, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.materialCheckbox9, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox30, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox22, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelDiagonal2, 4, 9);
            this.tableLayoutPanel2.Controls.Add(this.materialCheckbox12, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelSizeMonitor, 3, 10);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelModel, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelSerial, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.materialCheckbox13, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox23, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox32, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelSize, 2, 10);
            this.tableLayoutPanel2.Controls.Add(this.materialCheckbox14, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox24, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelDiagonal1, 3, 9);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox33, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.materialCheckbox11, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox25, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.labelFrequency, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelProductCodeID, 3, 8);
            this.tableLayoutPanel2.Controls.Add(this.labelDiagonal, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.materialCheckbox10, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelFrequency, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelProductCode, 2, 8);
            this.tableLayoutPanel2.Controls.Add(this.ResolutionLabel, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.materialCheckbox5, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.labelMonth, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.materialCheckbox8, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelMonthOfProduction, 3, 7);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelResolution, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelYear, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelYearOfProduction, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.materialCheckbox3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel13, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel7, 0, 13);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 14;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(462, 600);
            this.tableLayoutPanel2.TabIndex = 80;
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.AnimateReadOnly = false;
            this.textBoxSerial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxSerial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSerial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSerial.Depth = 0;
            this.textBoxSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxSerial.HelperText = "Insert serial number from monitor";
            this.textBoxSerial.HideSelection = true;
            this.textBoxSerial.LeadingIcon = null;
            this.textBoxSerial.Location = new System.Drawing.Point(239, 131);
            this.textBoxSerial.MaxLength = 32767;
            this.textBoxSerial.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.PasswordChar = '\0';
            this.textBoxSerial.PrefixSuffixText = null;
            this.textBoxSerial.ReadOnly = false;
            this.textBoxSerial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSerial.SelectedText = "";
            this.textBoxSerial.SelectionLength = 0;
            this.textBoxSerial.SelectionStart = 0;
            this.textBoxSerial.ShortcutsEnabled = true;
            this.textBoxSerial.Size = new System.Drawing.Size(174, 48);
            this.textBoxSerial.TabIndex = 73;
            this.textBoxSerial.TabStop = false;
            this.textBoxSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxSerial.TrailingIcon = null;
            this.textBoxSerial.UseSystemPasswordChar = false;
            this.textBoxSerial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSerial_KeyDown);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.AutoResize = false;
            this.comboBoxCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxCountry.CausesValidation = false;
            this.comboBoxCountry.Depth = 0;
            this.comboBoxCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxCountry.DropDownHeight = 174;
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.DropDownWidth = 121;
            this.comboBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Hint = "Choose country";
            this.comboBoxCountry.IntegralHeight = false;
            this.comboBoxCountry.ItemHeight = 43;
            this.comboBoxCountry.Location = new System.Drawing.Point(239, 444);
            this.comboBoxCountry.MaxDropDownItems = 4;
            this.comboBoxCountry.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(166, 49);
            this.comboBoxCountry.StartIndex = 0;
            this.comboBoxCountry.TabIndex = 80;
            this.comboBoxCountry.TabStop = false;
            // 
            // materialCheckbox6
            // 
            this.materialCheckbox6.AutoSize = true;
            this.materialCheckbox6.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox6.Checked = true;
            this.materialCheckbox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox6.Depth = 0;
            this.materialCheckbox6.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox6.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox6.Name = "materialCheckbox6";
            this.materialCheckbox6.ReadOnly = false;
            this.materialCheckbox6.Ripple = true;
            this.materialCheckbox6.Size = new System.Drawing.Size(35, 37);
            this.materialCheckbox6.TabIndex = 57;
            this.materialCheckbox6.UseVisualStyleBackColor = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox21.Image = global::ServiceMonitorEVK.Properties.Resources.id;
            this.pictureBox21.Location = new System.Drawing.Point(38, 3);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(24, 21);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 100;
            this.pictureBox21.TabStop = false;
            // 
            // searchAssetButton
            // 
            this.searchAssetButton.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.searchAssetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchAssetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchAssetButton.Image = global::ServiceMonitorEVK.Properties.Resources.searchAsset;
            this.searchAssetButton.Location = new System.Drawing.Point(419, 3);
            this.searchAssetButton.Name = "searchAssetButton";
            this.searchAssetButton.Size = new System.Drawing.Size(36, 39);
            this.searchAssetButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchAssetButton.TabIndex = 59;
            this.searchAssetButton.TabStop = false;
            this.searchAssetButton.Click += new System.EventHandler(this.searchAssetButton_Click);
            // 
            // pictureBox29
            // 
            this.pictureBox29.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox29.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox29.Location = new System.Drawing.Point(38, 499);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(24, 21);
            this.pictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox29.TabIndex = 110;
            this.pictureBox29.TabStop = false;
            // 
            // textBoxIdEVK
            // 
            this.textBoxIdEVK.AnimateReadOnly = false;
            this.textBoxIdEVK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxIdEVK.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxIdEVK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxIdEVK.Depth = 0;
            this.textBoxIdEVK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxIdEVK.HelperText = "Insert ID EVK from monitor";
            this.textBoxIdEVK.HideSelection = true;
            this.textBoxIdEVK.Hint = "M*********";
            this.textBoxIdEVK.LeadingIcon = null;
            this.textBoxIdEVK.Location = new System.Drawing.Point(239, 3);
            this.textBoxIdEVK.MaxLength = 32767;
            this.textBoxIdEVK.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxIdEVK.Name = "textBoxIdEVK";
            this.textBoxIdEVK.PasswordChar = '\0';
            this.textBoxIdEVK.PrefixSuffixText = null;
            this.textBoxIdEVK.ReadOnly = false;
            this.textBoxIdEVK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxIdEVK.SelectedText = "";
            this.textBoxIdEVK.SelectionLength = 0;
            this.textBoxIdEVK.SelectionStart = 0;
            this.textBoxIdEVK.ShortcutsEnabled = true;
            this.textBoxIdEVK.Size = new System.Drawing.Size(174, 48);
            this.textBoxIdEVK.TabIndex = 30;
            this.textBoxIdEVK.TabStop = false;
            this.textBoxIdEVK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxIdEVK.TrailingIcon = null;
            this.textBoxIdEVK.UseSystemPasswordChar = false;
            this.textBoxIdEVK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIdEVK_KeyDown);
            this.textBoxIdEVK.TextChanged += new System.EventHandler(this.textBoxIdEVK_TextChanged);
            // 
            // checkBoxCountry
            // 
            this.checkBoxCountry.AutoSize = true;
            this.checkBoxCountry.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxCountry.Checked = true;
            this.checkBoxCountry.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCountry.Depth = 0;
            this.checkBoxCountry.Location = new System.Drawing.Point(0, 441);
            this.checkBoxCountry.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxCountry.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxCountry.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxCountry.Name = "checkBoxCountry";
            this.checkBoxCountry.ReadOnly = false;
            this.checkBoxCountry.Ripple = true;
            this.checkBoxCountry.Size = new System.Drawing.Size(35, 37);
            this.checkBoxCountry.TabIndex = 113;
            this.checkBoxCountry.UseVisualStyleBackColor = false;
            // 
            // materialCheckbox7
            // 
            this.materialCheckbox7.AutoSize = true;
            this.materialCheckbox7.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox7.Checked = true;
            this.materialCheckbox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox7.Depth = 0;
            this.materialCheckbox7.Location = new System.Drawing.Point(0, 496);
            this.materialCheckbox7.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox7.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox7.Name = "materialCheckbox7";
            this.materialCheckbox7.ReadOnly = false;
            this.materialCheckbox7.Ripple = true;
            this.materialCheckbox7.Size = new System.Drawing.Size(35, 37);
            this.materialCheckbox7.TabIndex = 58;
            this.materialCheckbox7.UseVisualStyleBackColor = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox28.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox28.Location = new System.Drawing.Point(38, 444);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(20, 21);
            this.pictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox28.TabIndex = 114;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ServiceMonitorEVK.Properties.Resources.searchAsset;
            this.pictureBox2.Location = new System.Drawing.Point(419, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Depth = 0;
            this.labelManufacturer.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelManufacturer.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelManufacturer.Location = new System.Drawing.Point(68, 54);
            this.labelManufacturer.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(123, 24);
            this.labelManufacturer.TabIndex = 0;
            this.labelManufacturer.Text = "Manufacturer";
            // 
            // pictureBox27
            // 
            this.pictureBox27.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox27.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox27.Location = new System.Drawing.Point(38, 57);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(24, 21);
            this.pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox27.TabIndex = 100;
            this.pictureBox27.TabStop = false;
            // 
            // materialLabelManufacturer
            // 
            this.materialLabelManufacturer.AutoSize = true;
            this.materialLabelManufacturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelManufacturer.Depth = 0;
            this.materialLabelManufacturer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelManufacturer.HighEmphasis = true;
            this.materialLabelManufacturer.Location = new System.Drawing.Point(239, 54);
            this.materialLabelManufacturer.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelManufacturer.Name = "materialLabelManufacturer";
            this.materialLabelManufacturer.Size = new System.Drawing.Size(19, 19);
            this.materialLabelManufacturer.TabIndex = 39;
            this.materialLabelManufacturer.Text = "44";
            this.materialLabelManufacturer.UseAccent = true;
            this.materialLabelManufacturer.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // materialLabelPPI
            // 
            this.materialLabelPPI.AutoSize = true;
            this.materialLabelPPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelPPI.Depth = 0;
            this.materialLabelPPI.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelPPI.Location = new System.Drawing.Point(239, 496);
            this.materialLabelPPI.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelPPI.Name = "materialLabelPPI";
            this.materialLabelPPI.Size = new System.Drawing.Size(19, 19);
            this.materialLabelPPI.TabIndex = 50;
            this.materialLabelPPI.Text = "44";
            this.materialLabelPPI.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Depth = 0;
            this.labelCountry.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelCountry.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelCountry.Location = new System.Drawing.Point(68, 441);
            this.labelCountry.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(71, 24);
            this.labelCountry.TabIndex = 111;
            this.labelCountry.Text = "Country";
            // 
            // labelPPI
            // 
            this.labelPPI.AutoSize = true;
            this.labelPPI.Depth = 0;
            this.labelPPI.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelPPI.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelPPI.Location = new System.Drawing.Point(68, 496);
            this.labelPPI.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPPI.Name = "labelPPI";
            this.labelPPI.Size = new System.Drawing.Size(33, 24);
            this.labelPPI.TabIndex = 38;
            this.labelPPI.Text = "PPI";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Depth = 0;
            this.labelModel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelModel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelModel.Location = new System.Drawing.Point(68, 91);
            this.labelModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(57, 24);
            this.labelModel.TabIndex = 1;
            this.labelModel.Text = "Model";
            // 
            // pictureBox26
            // 
            this.pictureBox26.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox26.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox26.Location = new System.Drawing.Point(38, 94);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(24, 21);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox26.TabIndex = 101;
            this.pictureBox26.TabStop = false;
            // 
            // materialCheckbox4
            // 
            this.materialCheckbox4.AutoSize = true;
            this.materialCheckbox4.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox4.Checked = true;
            this.materialCheckbox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox4.Depth = 0;
            this.materialCheckbox4.Location = new System.Drawing.Point(0, 91);
            this.materialCheckbox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox4.Name = "materialCheckbox4";
            this.materialCheckbox4.ReadOnly = false;
            this.materialCheckbox4.Ripple = true;
            this.materialCheckbox4.Size = new System.Drawing.Size(35, 37);
            this.materialCheckbox4.TabIndex = 55;
            this.materialCheckbox4.UseVisualStyleBackColor = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox31.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox31.Location = new System.Drawing.Point(38, 407);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(24, 21);
            this.pictureBox31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox31.TabIndex = 108;
            this.pictureBox31.TabStop = false;
            // 
            // materialCheckbox9
            // 
            this.materialCheckbox9.AutoSize = true;
            this.materialCheckbox9.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox9.Checked = true;
            this.materialCheckbox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox9.Depth = 0;
            this.materialCheckbox9.Location = new System.Drawing.Point(0, 404);
            this.materialCheckbox9.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox9.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox9.Name = "materialCheckbox9";
            this.materialCheckbox9.ReadOnly = false;
            this.materialCheckbox9.Ripple = true;
            this.materialCheckbox9.Size = new System.Drawing.Size(35, 37);
            this.materialCheckbox9.TabIndex = 60;
            this.materialCheckbox9.UseVisualStyleBackColor = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox30.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox30.Location = new System.Drawing.Point(38, 222);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(24, 21);
            this.pictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox30.TabIndex = 109;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox22.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox22.Location = new System.Drawing.Point(38, 370);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(24, 21);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox22.TabIndex = 105;
            this.pictureBox22.TabStop = false;
            // 
            // materialLabelDiagonal2
            // 
            this.materialLabelDiagonal2.AutoSize = true;
            this.materialLabelDiagonal2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelDiagonal2.Depth = 0;
            this.materialLabelDiagonal2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelDiagonal2.Location = new System.Drawing.Point(419, 367);
            this.materialLabelDiagonal2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDiagonal2.Name = "materialLabelDiagonal2";
            this.materialLabelDiagonal2.Size = new System.Drawing.Size(19, 19);
            this.materialLabelDiagonal2.TabIndex = 45;
            this.materialLabelDiagonal2.Text = "44";
            this.materialLabelDiagonal2.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // materialCheckbox12
            // 
            this.materialCheckbox12.AutoSize = true;
            this.materialCheckbox12.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox12.Checked = true;
            this.materialCheckbox12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox12.Depth = 0;
            this.materialCheckbox12.Location = new System.Drawing.Point(0, 367);
            this.materialCheckbox12.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox12.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox12.Name = "materialCheckbox12";
            this.materialCheckbox12.ReadOnly = false;
            this.materialCheckbox12.Ripple = true;
            this.materialCheckbox12.Size = new System.Drawing.Size(35, 37);
            this.materialCheckbox12.TabIndex = 63;
            this.materialCheckbox12.UseVisualStyleBackColor = false;
            // 
            // materialLabelSizeMonitor
            // 
            this.materialLabelSizeMonitor.AutoSize = true;
            this.materialLabelSizeMonitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelSizeMonitor.Depth = 0;
            this.materialLabelSizeMonitor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelSizeMonitor.Location = new System.Drawing.Point(239, 404);
            this.materialLabelSizeMonitor.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelSizeMonitor.Name = "materialLabelSizeMonitor";
            this.materialLabelSizeMonitor.Size = new System.Drawing.Size(19, 19);
            this.materialLabelSizeMonitor.TabIndex = 48;
            this.materialLabelSizeMonitor.Text = "44";
            this.materialLabelSizeMonitor.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // materialLabelModel
            // 
            this.materialLabelModel.AutoSize = true;
            this.materialLabelModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelModel.Depth = 0;
            this.materialLabelModel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelModel.Location = new System.Drawing.Point(239, 91);
            this.materialLabelModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelModel.Name = "materialLabelModel";
            this.materialLabelModel.Size = new System.Drawing.Size(19, 19);
            this.materialLabelModel.TabIndex = 40;
            this.materialLabelModel.Text = "44";
            this.materialLabelModel.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelSerial
            // 
            this.labelSerial.AutoSize = true;
            this.labelSerial.Depth = 0;
            this.labelSerial.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelSerial.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelSerial.Location = new System.Drawing.Point(68, 128);
            this.labelSerial.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSerial.Name = "labelSerial";
            this.labelSerial.Size = new System.Drawing.Size(88, 24);
            this.labelSerial.TabIndex = 34;
            this.labelSerial.Text = "Serial No.";
            // 
            // materialCheckbox13
            // 
            this.materialCheckbox13.AutoSize = true;
            this.materialCheckbox13.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox13.Checked = true;
            this.materialCheckbox13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox13.Depth = 0;
            this.materialCheckbox13.Location = new System.Drawing.Point(0, 330);
            this.materialCheckbox13.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox13.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox13.Name = "materialCheckbox13";
            this.materialCheckbox13.ReadOnly = false;
            this.materialCheckbox13.Ripple = true;
            this.materialCheckbox13.Size = new System.Drawing.Size(35, 37);
            this.materialCheckbox13.TabIndex = 64;
            this.materialCheckbox13.UseVisualStyleBackColor = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox23.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox23.Location = new System.Drawing.Point(38, 333);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(24, 21);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox23.TabIndex = 104;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox32.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox32.Location = new System.Drawing.Point(38, 185);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(24, 21);
            this.pictureBox32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox32.TabIndex = 107;
            this.pictureBox32.TabStop = false;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Depth = 0;
            this.labelSize.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelSize.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelSize.Location = new System.Drawing.Point(68, 404);
            this.labelSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(165, 24);
            this.labelSize.TabIndex = 36;
            this.labelSize.Text = "Size monitor (cm.)";
            // 
            // materialCheckbox14
            // 
            this.materialCheckbox14.AutoSize = true;
            this.materialCheckbox14.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox14.Checked = true;
            this.materialCheckbox14.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox14.Depth = 0;
            this.materialCheckbox14.Location = new System.Drawing.Point(0, 293);
            this.materialCheckbox14.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox14.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox14.Name = "materialCheckbox14";
            this.materialCheckbox14.ReadOnly = false;
            this.materialCheckbox14.Ripple = true;
            this.materialCheckbox14.Size = new System.Drawing.Size(35, 37);
            this.materialCheckbox14.TabIndex = 65;
            this.materialCheckbox14.UseVisualStyleBackColor = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox24.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox24.Location = new System.Drawing.Point(38, 296);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(24, 21);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox24.TabIndex = 103;
            this.pictureBox24.TabStop = false;
            // 
            // materialLabelDiagonal1
            // 
            this.materialLabelDiagonal1.AutoSize = true;
            this.materialLabelDiagonal1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelDiagonal1.Depth = 0;
            this.materialLabelDiagonal1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelDiagonal1.Location = new System.Drawing.Point(239, 367);
            this.materialLabelDiagonal1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDiagonal1.Name = "materialLabelDiagonal1";
            this.materialLabelDiagonal1.Size = new System.Drawing.Size(19, 19);
            this.materialLabelDiagonal1.TabIndex = 44;
            this.materialLabelDiagonal1.Text = "44";
            this.materialLabelDiagonal1.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // pictureBox33
            // 
            this.pictureBox33.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox33.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox33.Location = new System.Drawing.Point(38, 131);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(24, 21);
            this.pictureBox33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox33.TabIndex = 106;
            this.pictureBox33.TabStop = false;
            // 
            // materialCheckbox11
            // 
            this.materialCheckbox11.AutoSize = true;
            this.materialCheckbox11.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox11.Checked = true;
            this.materialCheckbox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox11.Depth = 0;
            this.materialCheckbox11.Location = new System.Drawing.Point(0, 128);
            this.materialCheckbox11.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox11.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox11.Name = "materialCheckbox11";
            this.materialCheckbox11.ReadOnly = false;
            this.materialCheckbox11.Ripple = true;
            this.materialCheckbox11.Size = new System.Drawing.Size(35, 37);
            this.materialCheckbox11.TabIndex = 62;
            this.materialCheckbox11.UseVisualStyleBackColor = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox25.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox25.Location = new System.Drawing.Point(38, 259);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(24, 21);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox25.TabIndex = 102;
            this.pictureBox25.TabStop = false;
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Depth = 0;
            this.labelFrequency.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelFrequency.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelFrequency.Location = new System.Drawing.Point(68, 182);
            this.labelFrequency.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(94, 24);
            this.labelFrequency.TabIndex = 35;
            this.labelFrequency.Text = "Frequency";
            // 
            // materialLabelProductCodeID
            // 
            this.materialLabelProductCodeID.AutoSize = true;
            this.materialLabelProductCodeID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelProductCodeID.Depth = 0;
            this.materialLabelProductCodeID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelProductCodeID.Location = new System.Drawing.Point(239, 330);
            this.materialLabelProductCodeID.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelProductCodeID.Name = "materialLabelProductCodeID";
            this.materialLabelProductCodeID.Size = new System.Drawing.Size(19, 19);
            this.materialLabelProductCodeID.TabIndex = 43;
            this.materialLabelProductCodeID.Text = "44";
            this.materialLabelProductCodeID.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelDiagonal
            // 
            this.labelDiagonal.AutoSize = true;
            this.labelDiagonal.Depth = 0;
            this.labelDiagonal.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelDiagonal.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelDiagonal.Location = new System.Drawing.Point(68, 367);
            this.labelDiagonal.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDiagonal.Name = "labelDiagonal";
            this.labelDiagonal.Size = new System.Drawing.Size(138, 24);
            this.labelDiagonal.TabIndex = 32;
            this.labelDiagonal.Text = "Diagonal (H\\W)";
            // 
            // materialCheckbox10
            // 
            this.materialCheckbox10.AutoSize = true;
            this.materialCheckbox10.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox10.Checked = true;
            this.materialCheckbox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox10.Depth = 0;
            this.materialCheckbox10.Location = new System.Drawing.Point(0, 182);
            this.materialCheckbox10.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox10.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox10.Name = "materialCheckbox10";
            this.materialCheckbox10.ReadOnly = false;
            this.materialCheckbox10.Ripple = true;
            this.materialCheckbox10.Size = new System.Drawing.Size(35, 37);
            this.materialCheckbox10.TabIndex = 61;
            this.materialCheckbox10.UseVisualStyleBackColor = false;
            // 
            // materialLabelFrequency
            // 
            this.materialLabelFrequency.AutoSize = true;
            this.materialLabelFrequency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelFrequency.Depth = 0;
            this.materialLabelFrequency.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelFrequency.Location = new System.Drawing.Point(239, 182);
            this.materialLabelFrequency.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelFrequency.Name = "materialLabelFrequency";
            this.materialLabelFrequency.Size = new System.Drawing.Size(19, 19);
            this.materialLabelFrequency.TabIndex = 47;
            this.materialLabelFrequency.Text = "44";
            this.materialLabelFrequency.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelProductCode
            // 
            this.labelProductCode.AutoSize = true;
            this.labelProductCode.Depth = 0;
            this.labelProductCode.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelProductCode.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelProductCode.Location = new System.Drawing.Point(68, 330);
            this.labelProductCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProductCode.Name = "labelProductCode";
            this.labelProductCode.Size = new System.Drawing.Size(143, 24);
            this.labelProductCode.TabIndex = 4;
            this.labelProductCode.Text = "Product code ID";
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Depth = 0;
            this.ResolutionLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ResolutionLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.ResolutionLabel.Location = new System.Drawing.Point(68, 219);
            this.ResolutionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(95, 24);
            this.ResolutionLabel.TabIndex = 37;
            this.ResolutionLabel.Text = "Resolution";
            // 
            // materialCheckbox5
            // 
            this.materialCheckbox5.AutoSize = true;
            this.materialCheckbox5.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox5.Checked = true;
            this.materialCheckbox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox5.Depth = 0;
            this.materialCheckbox5.Location = new System.Drawing.Point(0, 256);
            this.materialCheckbox5.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox5.Name = "materialCheckbox5";
            this.materialCheckbox5.ReadOnly = false;
            this.materialCheckbox5.Ripple = true;
            this.materialCheckbox5.Size = new System.Drawing.Size(35, 37);
            this.materialCheckbox5.TabIndex = 56;
            this.materialCheckbox5.UseVisualStyleBackColor = false;
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Depth = 0;
            this.labelMonth.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelMonth.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelMonth.Location = new System.Drawing.Point(68, 293);
            this.labelMonth.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(59, 24);
            this.labelMonth.TabIndex = 3;
            this.labelMonth.Text = "Month";
            // 
            // materialCheckbox8
            // 
            this.materialCheckbox8.AutoSize = true;
            this.materialCheckbox8.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox8.Checked = true;
            this.materialCheckbox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox8.Depth = 0;
            this.materialCheckbox8.Location = new System.Drawing.Point(0, 219);
            this.materialCheckbox8.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox8.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox8.Name = "materialCheckbox8";
            this.materialCheckbox8.ReadOnly = false;
            this.materialCheckbox8.Ripple = true;
            this.materialCheckbox8.Size = new System.Drawing.Size(35, 37);
            this.materialCheckbox8.TabIndex = 59;
            this.materialCheckbox8.UseVisualStyleBackColor = false;
            // 
            // materialLabelMonthOfProduction
            // 
            this.materialLabelMonthOfProduction.AutoSize = true;
            this.materialLabelMonthOfProduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelMonthOfProduction.Depth = 0;
            this.materialLabelMonthOfProduction.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelMonthOfProduction.Location = new System.Drawing.Point(239, 293);
            this.materialLabelMonthOfProduction.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelMonthOfProduction.Name = "materialLabelMonthOfProduction";
            this.materialLabelMonthOfProduction.Size = new System.Drawing.Size(19, 19);
            this.materialLabelMonthOfProduction.TabIndex = 42;
            this.materialLabelMonthOfProduction.Text = "44";
            this.materialLabelMonthOfProduction.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // materialLabelResolution
            // 
            this.materialLabelResolution.AutoSize = true;
            this.materialLabelResolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelResolution.Depth = 0;
            this.materialLabelResolution.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelResolution.Location = new System.Drawing.Point(239, 219);
            this.materialLabelResolution.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelResolution.Name = "materialLabelResolution";
            this.materialLabelResolution.Size = new System.Drawing.Size(19, 19);
            this.materialLabelResolution.TabIndex = 49;
            this.materialLabelResolution.Text = "44";
            this.materialLabelResolution.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Depth = 0;
            this.labelYear.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelYear.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelYear.Location = new System.Drawing.Point(68, 256);
            this.labelYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(47, 24);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "Year ";
            // 
            // materialLabelYearOfProduction
            // 
            this.materialLabelYearOfProduction.AutoSize = true;
            this.materialLabelYearOfProduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelYearOfProduction.Depth = 0;
            this.materialLabelYearOfProduction.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelYearOfProduction.Location = new System.Drawing.Point(239, 256);
            this.materialLabelYearOfProduction.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelYearOfProduction.Name = "materialLabelYearOfProduction";
            this.materialLabelYearOfProduction.Size = new System.Drawing.Size(19, 19);
            this.materialLabelYearOfProduction.TabIndex = 41;
            this.materialLabelYearOfProduction.Text = "44";
            this.materialLabelYearOfProduction.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // materialCheckbox3
            // 
            this.materialCheckbox3.AutoSize = true;
            this.materialCheckbox3.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox3.Checked = true;
            this.materialCheckbox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox3.Depth = 0;
            this.materialCheckbox3.Location = new System.Drawing.Point(0, 54);
            this.materialCheckbox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox3.Name = "materialCheckbox3";
            this.materialCheckbox3.ReadOnly = false;
            this.materialCheckbox3.Ripple = true;
            this.materialCheckbox3.Size = new System.Drawing.Size(35, 37);
            this.materialCheckbox3.TabIndex = 54;
            this.materialCheckbox3.UseVisualStyleBackColor = false;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel13.Location = new System.Drawing.Point(68, 0);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(62, 24);
            this.materialLabel13.TabIndex = 53;
            this.materialLabel13.Text = "ID EVK";
            // 
            // flowLayoutPanel7
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel7, 5);
            this.flowLayoutPanel7.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel7.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel7.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel7.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 536);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(456, 61);
            this.flowLayoutPanel7.TabIndex = 82;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.checkBoxHDMI);
            this.flowLayoutPanel3.Controls.Add(this.numericUpDownHdmi);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(82, 69);
            this.flowLayoutPanel3.TabIndex = 80;
            // 
            // checkBoxHDMI
            // 
            this.checkBoxHDMI.AutoSize = true;
            this.checkBoxHDMI.Depth = 0;
            this.checkBoxHDMI.Location = new System.Drawing.Point(0, 0);
            this.checkBoxHDMI.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxHDMI.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxHDMI.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxHDMI.Name = "checkBoxHDMI";
            this.checkBoxHDMI.ReadOnly = false;
            this.checkBoxHDMI.Ripple = true;
            this.checkBoxHDMI.Size = new System.Drawing.Size(75, 37);
            this.checkBoxHDMI.TabIndex = 0;
            this.checkBoxHDMI.Text = "HDMI";
            this.checkBoxHDMI.UseVisualStyleBackColor = true;
            this.checkBoxHDMI.CheckedChanged += new System.EventHandler(this.checkBoxHDMI_CheckedChanged);
            // 
            // numericUpDownHdmi
            // 
            this.numericUpDownHdmi.Enabled = false;
            this.numericUpDownHdmi.Location = new System.Drawing.Point(3, 40);
            this.numericUpDownHdmi.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownHdmi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHdmi.Name = "numericUpDownHdmi";
            this.numericUpDownHdmi.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownHdmi.TabIndex = 119;
            this.numericUpDownHdmi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.checkBoxVGA);
            this.flowLayoutPanel4.Controls.Add(this.numericUpDownVga);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(91, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(73, 67);
            this.flowLayoutPanel4.TabIndex = 81;
            // 
            // checkBoxVGA
            // 
            this.checkBoxVGA.AutoSize = true;
            this.checkBoxVGA.Depth = 0;
            this.checkBoxVGA.Location = new System.Drawing.Point(0, 0);
            this.checkBoxVGA.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxVGA.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxVGA.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxVGA.Name = "checkBoxVGA";
            this.checkBoxVGA.ReadOnly = false;
            this.checkBoxVGA.Ripple = true;
            this.checkBoxVGA.Size = new System.Drawing.Size(66, 37);
            this.checkBoxVGA.TabIndex = 1;
            this.checkBoxVGA.Text = "VGA";
            this.checkBoxVGA.UseVisualStyleBackColor = true;
            this.checkBoxVGA.CheckedChanged += new System.EventHandler(this.CheckboxVGA_CheckedChanged);
            // 
            // numericUpDownVga
            // 
            this.numericUpDownVga.Enabled = false;
            this.numericUpDownVga.Location = new System.Drawing.Point(3, 40);
            this.numericUpDownVga.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownVga.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownVga.Name = "numericUpDownVga";
            this.numericUpDownVga.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownVga.TabIndex = 121;
            this.numericUpDownVga.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.checkBoxDisplayPort);
            this.flowLayoutPanel6.Controls.Add(this.numericUpDownDisplayPort);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(170, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(124, 65);
            this.flowLayoutPanel6.TabIndex = 81;
            // 
            // checkBoxDisplayPort
            // 
            this.checkBoxDisplayPort.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxDisplayPort.AutoSize = true;
            this.checkBoxDisplayPort.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDisplayPort.Depth = 0;
            this.checkBoxDisplayPort.ImageIndex = 0;
            this.checkBoxDisplayPort.Location = new System.Drawing.Point(0, 0);
            this.checkBoxDisplayPort.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDisplayPort.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxDisplayPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxDisplayPort.Name = "checkBoxDisplayPort";
            this.checkBoxDisplayPort.ReadOnly = false;
            this.checkBoxDisplayPort.Ripple = true;
            this.checkBoxDisplayPort.Size = new System.Drawing.Size(117, 37);
            this.checkBoxDisplayPort.TabIndex = 3;
            this.checkBoxDisplayPort.Text = "DisplayPort";
            this.checkBoxDisplayPort.UseVisualStyleBackColor = false;
            this.checkBoxDisplayPort.CheckedChanged += new System.EventHandler(this.materialCheckbox17_CheckedChanged);
            // 
            // numericUpDownDisplayPort
            // 
            this.numericUpDownDisplayPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownDisplayPort.Enabled = false;
            this.numericUpDownDisplayPort.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownDisplayPort.ForeColor = System.Drawing.SystemColors.Desktop;
            this.numericUpDownDisplayPort.Location = new System.Drawing.Point(3, 40);
            this.numericUpDownDisplayPort.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownDisplayPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDisplayPort.Name = "numericUpDownDisplayPort";
            this.numericUpDownDisplayPort.Size = new System.Drawing.Size(38, 22);
            this.numericUpDownDisplayPort.TabIndex = 122;
            this.numericUpDownDisplayPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.checkBoxDVI);
            this.flowLayoutPanel5.Controls.Add(this.numericUpDownDvi);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(300, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(64, 67);
            this.flowLayoutPanel5.TabIndex = 81;
            // 
            // checkBoxDVI
            // 
            this.checkBoxDVI.AutoSize = true;
            this.checkBoxDVI.Depth = 0;
            this.checkBoxDVI.Location = new System.Drawing.Point(0, 0);
            this.checkBoxDVI.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDVI.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxDVI.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxDVI.Name = "checkBoxDVI";
            this.checkBoxDVI.ReadOnly = false;
            this.checkBoxDVI.Ripple = true;
            this.checkBoxDVI.Size = new System.Drawing.Size(60, 37);
            this.checkBoxDVI.TabIndex = 2;
            this.checkBoxDVI.Text = "DVI";
            this.checkBoxDVI.UseVisualStyleBackColor = true;
            this.checkBoxDVI.CheckedChanged += new System.EventHandler(this.CheckBoxDVI_CheckedChanged);
            // 
            // numericUpDownDvi
            // 
            this.numericUpDownDvi.Enabled = false;
            this.numericUpDownDvi.Location = new System.Drawing.Point(3, 40);
            this.numericUpDownDvi.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownDvi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDvi.Name = "numericUpDownDvi";
            this.numericUpDownDvi.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownDvi.TabIndex = 120;
            this.numericUpDownDvi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sendButton
            // 
            this.sendButton.AutoSize = false;
            this.sendButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.sendButton.Depth = 0;
            this.sendButton.HighEmphasis = true;
            this.sendButton.Icon = null;
            this.sendButton.Location = new System.Drawing.Point(249, 13);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sendButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendButton.Name = "sendButton";
            this.sendButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.sendButton.Size = new System.Drawing.Size(191, 19);
            this.sendButton.TabIndex = 54;
            this.sendButton.TabStop = false;
            this.sendButton.Text = "Send";
            this.sendButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.sendButton.UseAccentColor = false;
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // materialComboBoxMonitors
            // 
            this.materialComboBoxMonitors.AutoResize = false;
            this.materialComboBoxMonitors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxMonitors.CausesValidation = false;
            this.materialComboBoxMonitors.Depth = 0;
            this.materialComboBoxMonitors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxMonitors.DropDownHeight = 174;
            this.materialComboBoxMonitors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxMonitors.DropDownWidth = 121;
            this.materialComboBoxMonitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxMonitors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxMonitors.FormattingEnabled = true;
            this.materialComboBoxMonitors.Hint = "Choose monitor";
            this.materialComboBoxMonitors.IntegralHeight = false;
            this.materialComboBoxMonitors.ItemHeight = 43;
            this.materialComboBoxMonitors.Location = new System.Drawing.Point(20, 5);
            this.materialComboBoxMonitors.MaxDropDownItems = 4;
            this.materialComboBoxMonitors.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxMonitors.Name = "materialComboBoxMonitors";
            this.materialComboBoxMonitors.Size = new System.Drawing.Size(222, 49);
            this.materialComboBoxMonitors.StartIndex = 0;
            this.materialComboBoxMonitors.TabIndex = 31;
            this.materialComboBoxMonitors.TabStop = false;
            this.materialComboBoxMonitors.SelectedIndexChanged += new System.EventHandler(this.materialComboBoxMonitors_SelectedIndexChanged);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(249, 35);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(191, 19);
            this.materialButton1.TabIndex = 31;
            this.materialButton1.TabStop = false;
            this.materialButton1.Text = "Search info";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // searchInfoPage
            // 
            this.searchInfoPage.ImageKey = "search.png";
            this.searchInfoPage.Location = new System.Drawing.Point(4, 39);
            this.searchInfoPage.Name = "searchInfoPage";
            this.searchInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchInfoPage.Size = new System.Drawing.Size(1491, 887);
            this.searchInfoPage.TabIndex = 4;
            this.searchInfoPage.Text = "Search info";
            this.searchInfoPage.UseVisualStyleBackColor = true;
            this.searchInfoPage.Enter += new System.EventHandler(this.searchInfoPage_Enter);
            // 
            // testMonitorPage
            // 
            this.testMonitorPage.Controls.Add(this.flowLayoutPanel11);
            this.testMonitorPage.Controls.Add(this.flowLayoutPanel10);
            this.testMonitorPage.Controls.Add(this.buttonServiceFixPixel);
            this.testMonitorPage.Controls.Add(this.buttonTestingMonitor);
            this.testMonitorPage.ImageKey = "monitoring-test.png";
            this.testMonitorPage.Location = new System.Drawing.Point(4, 39);
            this.testMonitorPage.Name = "testMonitorPage";
            this.testMonitorPage.Padding = new System.Windows.Forms.Padding(3);
            this.testMonitorPage.Size = new System.Drawing.Size(1491, 887);
            this.testMonitorPage.TabIndex = 6;
            this.testMonitorPage.Text = "Service";
            this.testMonitorPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.Controls.Add(this.btnDisplaySettings);
            this.flowLayoutPanel11.Controls.Add(this.materialButton2);
            this.flowLayoutPanel11.Controls.Add(this.materialButton3);
            this.flowLayoutPanel11.Location = new System.Drawing.Point(389, 143);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(332, 151);
            this.flowLayoutPanel11.TabIndex = 64;
            // 
            // btnDisplaySettings
            // 
            this.btnDisplaySettings.AutoSize = false;
            this.btnDisplaySettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDisplaySettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDisplaySettings.Depth = 0;
            this.btnDisplaySettings.HighEmphasis = true;
            this.btnDisplaySettings.Icon = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.btnDisplaySettings.ImageKey = "monitoring-test.png";
            this.btnDisplaySettings.ImageList = this.imageList1;
            this.btnDisplaySettings.Location = new System.Drawing.Point(4, 6);
            this.btnDisplaySettings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDisplaySettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDisplaySettings.Name = "btnDisplaySettings";
            this.btnDisplaySettings.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDisplaySettings.Size = new System.Drawing.Size(321, 36);
            this.btnDisplaySettings.TabIndex = 63;
            this.btnDisplaySettings.Text = "Display settings";
            this.btnDisplaySettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDisplaySettings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDisplaySettings.UseAccentColor = false;
            this.btnDisplaySettings.UseVisualStyleBackColor = true;
            this.btnDisplaySettings.Click += new System.EventHandler(this.btnDisplaySettings_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search.png");
            this.imageList1.Images.SetKeyName(1, "fix (1).png");
            this.imageList1.Images.SetKeyName(2, "resolution.png");
            this.imageList1.Images.SetKeyName(3, "computer.png");
            this.imageList1.Images.SetKeyName(4, "info (2).png");
            this.imageList1.Images.SetKeyName(5, "monitoring-test.png");
            this.imageList1.Images.SetKeyName(6, "homepage.png");
            this.imageList1.Images.SetKeyName(7, "knowledge-base.png");
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.materialButton2.ImageKey = "monitoring-test.png";
            this.materialButton2.ImageList = this.imageList1;
            this.materialButton2.Location = new System.Drawing.Point(4, 54);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(321, 36);
            this.materialButton2.TabIndex = 64;
            this.materialButton2.Text = "System information";
            this.materialButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(this.btnExtend);
            this.flowLayoutPanel10.Controls.Add(this.btnDuplicate);
            this.flowLayoutPanel10.Controls.Add(this.btnOnlyPC);
            this.flowLayoutPanel10.Controls.Add(this.btnOnlySecond);
            this.flowLayoutPanel10.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel10.Location = new System.Drawing.Point(24, 143);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(209, 135);
            this.flowLayoutPanel10.TabIndex = 62;
            // 
            // btnExtend
            // 
            this.btnExtend.AutoSize = false;
            this.btnExtend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExtend.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnExtend.Depth = 0;
            this.btnExtend.HighEmphasis = true;
            this.btnExtend.Icon = global::ServiceMonitorEVK.Properties.Resources.extend;
            this.btnExtend.ImageKey = "monitoring-test.png";
            this.btnExtend.ImageList = this.imageList1;
            this.btnExtend.Location = new System.Drawing.Point(4, 6);
            this.btnExtend.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExtend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExtend.Size = new System.Drawing.Size(196, 21);
            this.btnExtend.TabIndex = 63;
            this.btnExtend.Text = "Extend";
            this.btnExtend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExtend.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExtend.UseAccentColor = false;
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.AutoSize = false;
            this.btnDuplicate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDuplicate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDuplicate.Depth = 0;
            this.btnDuplicate.HighEmphasis = true;
            this.btnDuplicate.Icon = global::ServiceMonitorEVK.Properties.Resources.duplicate;
            this.btnDuplicate.ImageKey = "monitoring-test.png";
            this.btnDuplicate.ImageList = this.imageList1;
            this.btnDuplicate.Location = new System.Drawing.Point(4, 39);
            this.btnDuplicate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDuplicate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDuplicate.Size = new System.Drawing.Size(196, 19);
            this.btnDuplicate.TabIndex = 64;
            this.btnDuplicate.Text = "Duplicate";
            this.btnDuplicate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDuplicate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDuplicate.UseAccentColor = false;
            this.btnDuplicate.UseVisualStyleBackColor = true;
            this.btnDuplicate.Click += new System.EventHandler(this.btnDuplicate_Click);
            // 
            // btnOnlyPC
            // 
            this.btnOnlyPC.AutoSize = false;
            this.btnOnlyPC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOnlyPC.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOnlyPC.Depth = 0;
            this.btnOnlyPC.HighEmphasis = true;
            this.btnOnlyPC.Icon = global::ServiceMonitorEVK.Properties.Resources.onlyPC;
            this.btnOnlyPC.ImageKey = "monitoring-test.png";
            this.btnOnlyPC.ImageList = this.imageList1;
            this.btnOnlyPC.Location = new System.Drawing.Point(4, 70);
            this.btnOnlyPC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOnlyPC.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOnlyPC.Name = "btnOnlyPC";
            this.btnOnlyPC.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOnlyPC.Size = new System.Drawing.Size(196, 20);
            this.btnOnlyPC.TabIndex = 65;
            this.btnOnlyPC.Text = "Only PC";
            this.btnOnlyPC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOnlyPC.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOnlyPC.UseAccentColor = false;
            this.btnOnlyPC.UseVisualStyleBackColor = true;
            this.btnOnlyPC.Click += new System.EventHandler(this.btnOnlyPC_Click);
            // 
            // btnOnlySecond
            // 
            this.btnOnlySecond.AutoSize = false;
            this.btnOnlySecond.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOnlySecond.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOnlySecond.Depth = 0;
            this.btnOnlySecond.HighEmphasis = true;
            this.btnOnlySecond.Icon = global::ServiceMonitorEVK.Properties.Resources.onlySecond;
            this.btnOnlySecond.ImageKey = "monitoring-test.png";
            this.btnOnlySecond.ImageList = this.imageList1;
            this.btnOnlySecond.Location = new System.Drawing.Point(4, 102);
            this.btnOnlySecond.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOnlySecond.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOnlySecond.Name = "btnOnlySecond";
            this.btnOnlySecond.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOnlySecond.Size = new System.Drawing.Size(196, 21);
            this.btnOnlySecond.TabIndex = 66;
            this.btnOnlySecond.Text = "Only Second";
            this.btnOnlySecond.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOnlySecond.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOnlySecond.UseAccentColor = false;
            this.btnOnlySecond.UseVisualStyleBackColor = true;
            this.btnOnlySecond.Click += new System.EventHandler(this.btnOnlySecond_Click);
            // 
            // buttonServiceFixPixel
            // 
            this.buttonServiceFixPixel.AutoSize = false;
            this.buttonServiceFixPixel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonServiceFixPixel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonServiceFixPixel.Depth = 0;
            this.buttonServiceFixPixel.HighEmphasis = true;
            this.buttonServiceFixPixel.Icon = global::ServiceMonitorEVK.Properties.Resources.fix__1_;
            this.buttonServiceFixPixel.Location = new System.Drawing.Point(367, 32);
            this.buttonServiceFixPixel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonServiceFixPixel.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonServiceFixPixel.Name = "buttonServiceFixPixel";
            this.buttonServiceFixPixel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonServiceFixPixel.Size = new System.Drawing.Size(417, 36);
            this.buttonServiceFixPixel.TabIndex = 56;
            this.buttonServiceFixPixel.Text = "Fixing bad pixels";
            this.buttonServiceFixPixel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonServiceFixPixel.UseAccentColor = false;
            this.buttonServiceFixPixel.UseVisualStyleBackColor = true;
            this.buttonServiceFixPixel.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // buttonTestingMonitor
            // 
            this.buttonTestingMonitor.AutoSize = false;
            this.buttonTestingMonitor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTestingMonitor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonTestingMonitor.Depth = 0;
            this.buttonTestingMonitor.HighEmphasis = true;
            this.buttonTestingMonitor.Icon = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.buttonTestingMonitor.ImageKey = "monitoring-test.png";
            this.buttonTestingMonitor.ImageList = this.imageList1;
            this.buttonTestingMonitor.Location = new System.Drawing.Point(24, 32);
            this.buttonTestingMonitor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonTestingMonitor.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonTestingMonitor.Name = "buttonTestingMonitor";
            this.buttonTestingMonitor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonTestingMonitor.Size = new System.Drawing.Size(321, 36);
            this.buttonTestingMonitor.TabIndex = 55;
            this.buttonTestingMonitor.Text = "Testing monitor";
            this.buttonTestingMonitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonTestingMonitor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonTestingMonitor.UseAccentColor = false;
            this.buttonTestingMonitor.UseVisualStyleBackColor = true;
            this.buttonTestingMonitor.Click += new System.EventHandler(this.buttonTestingMonitor_Click);
            // 
            // resolutionPage
            // 
            this.resolutionPage.BackColor = System.Drawing.Color.Transparent;
            this.resolutionPage.Controls.Add(this.MonitorComboBox);
            this.resolutionPage.Controls.Add(this.labelMonitor);
            this.resolutionPage.Controls.Add(this.ResolutionComboBox);
            this.resolutionPage.Controls.Add(this.lableChanRes);
            this.resolutionPage.Controls.Add(this.SetResolution);
            this.resolutionPage.Controls.Add(this.SetMaxResolution);
            this.resolutionPage.ImageKey = "resolution.png";
            this.resolutionPage.Location = new System.Drawing.Point(4, 39);
            this.resolutionPage.Name = "resolutionPage";
            this.resolutionPage.Padding = new System.Windows.Forms.Padding(3);
            this.resolutionPage.Size = new System.Drawing.Size(1491, 887);
            this.resolutionPage.TabIndex = 0;
            this.resolutionPage.Text = "Resolution";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.materialTabControl2);
            this.tabPage6.ImageIndex = 7;
            this.tabPage6.Location = new System.Drawing.Point(4, 39);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1491, 887);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Knowlenge base";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.testMonitorKnPage);
            this.materialTabControl2.Controls.Add(this.instructionKnPage);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.ImageList = this.imageList1;
            this.materialTabControl2.Location = new System.Drawing.Point(6, 6);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Multiline = true;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(1258, 636);
            this.materialTabControl2.TabIndex = 0;
            // 
            // testMonitorKnPage
            // 
            this.testMonitorKnPage.Controls.Add(this.materialMultiLineTextBox1);
            this.testMonitorKnPage.Location = new System.Drawing.Point(4, 39);
            this.testMonitorKnPage.Name = "testMonitorKnPage";
            this.testMonitorKnPage.Padding = new System.Windows.Forms.Padding(3);
            this.testMonitorKnPage.Size = new System.Drawing.Size(1250, 593);
            this.testMonitorKnPage.TabIndex = 0;
            this.testMonitorKnPage.Text = "How to test monitor";
            this.testMonitorKnPage.UseVisualStyleBackColor = true;
            // 
            // materialMultiLineTextBox1
            // 
            this.materialMultiLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox1.Depth = 0;
            this.materialMultiLineTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox1.Location = new System.Drawing.Point(6, 6);
            this.materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            this.materialMultiLineTextBox1.Size = new System.Drawing.Size(428, 598);
            this.materialMultiLineTextBox1.TabIndex = 0;
            this.materialMultiLineTextBox1.Text = "";
            // 
            // instructionKnPage
            // 
            this.instructionKnPage.Controls.Add(this.materialLabel6);
            this.instructionKnPage.Controls.Add(this.materialLabel2);
            this.instructionKnPage.Controls.Add(this.materialLabel1);
            this.instructionKnPage.Location = new System.Drawing.Point(4, 39);
            this.instructionKnPage.Name = "instructionKnPage";
            this.instructionKnPage.Padding = new System.Windows.Forms.Padding(3);
            this.instructionKnPage.Size = new System.Drawing.Size(1250, 593);
            this.instructionKnPage.TabIndex = 1;
            this.instructionKnPage.Text = "App instruction";
            this.instructionKnPage.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(18, 116);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(107, 19);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "materialLabel6";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(18, 67);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(107, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "materialLabel2";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(18, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.disabledItemToolStripMenuItem,
            this.item2ToolStripMenuItem,
            this.toolStripSeparator1,
            this.item3ToolStripMenuItem});
            this.materialContextMenuStrip1.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(166, 130);
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.AutoSize = false;
            this.item1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subItem1ToolStripMenuItem,
            this.subItem2ToolStripMenuItem});
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item1ToolStripMenuItem.Text = "Item 1";
            // 
            // subItem1ToolStripMenuItem
            // 
            this.subItem1ToolStripMenuItem.AutoSize = false;
            this.subItem1ToolStripMenuItem.Name = "subItem1ToolStripMenuItem";
            this.subItem1ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem1ToolStripMenuItem.Text = "SubItem 1";
            // 
            // subItem2ToolStripMenuItem
            // 
            this.subItem2ToolStripMenuItem.AutoSize = false;
            this.subItem2ToolStripMenuItem.Name = "subItem2ToolStripMenuItem";
            this.subItem2ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem2ToolStripMenuItem.Text = "SubItem 2";
            // 
            // disabledItemToolStripMenuItem
            // 
            this.disabledItemToolStripMenuItem.AutoSize = false;
            this.disabledItemToolStripMenuItem.Enabled = false;
            this.disabledItemToolStripMenuItem.Name = "disabledItemToolStripMenuItem";
            this.disabledItemToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.disabledItemToolStripMenuItem.Text = "Disabled item";
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.AutoSize = false;
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item2ToolStripMenuItem.Text = "Item 2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // item3ToolStripMenuItem
            // 
            this.item3ToolStripMenuItem.AutoSize = false;
            this.item3ToolStripMenuItem.Name = "item3ToolStripMenuItem";
            this.item3ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item3ToolStripMenuItem.Text = "Item 3";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::ServiceMonitorEVK.Properties.Resources.logo__1_;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(97, 31);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 41;
            this.pictureBoxLogo.TabStop = false;
            // 
            // mainLabelTester
            // 
            this.mainLabelTester.AutoSize = true;
            this.mainLabelTester.BackColor = System.Drawing.Color.Transparent;
            this.mainLabelTester.Depth = 0;
            this.mainLabelTester.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mainLabelTester.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.mainLabelTester.ForeColor = System.Drawing.Color.Transparent;
            this.mainLabelTester.Location = new System.Drawing.Point(1482, 0);
            this.mainLabelTester.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainLabelTester.Name = "mainLabelTester";
            this.mainLabelTester.Size = new System.Drawing.Size(30, 24);
            this.mainLabelTester.TabIndex = 42;
            this.mainLabelTester.Text = "fhg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1407, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tester:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.mainLabelTester);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 1009);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1515, 24);
            this.flowLayoutPanel1.TabIndex = 47;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.pictureBoxLogo);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(645, 27);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(96, 31);
            this.flowLayoutPanel2.TabIndex = 47;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.materialButton3.ImageKey = "monitoring-test.png";
            this.materialButton3.ImageList = this.imageList1;
            this.materialButton3.Location = new System.Drawing.Point(4, 102);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(321, 36);
            this.materialButton3.TabIndex = 65;
            this.materialButton3.Text = "Personalization Settings";
            this.materialButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click_1);
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.AutoSize = true;
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.ReadOnly = false;
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(454, 37);
            this.materialCheckbox2.TabIndex = 52;
            this.materialCheckbox2.Text = "When connecting a new monitor, change the display type to";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.AutoSize = true;
            this.flowLayoutPanel12.Controls.Add(this.materialCheckbox2);
            this.flowLayoutPanel12.Controls.Add(this.comboBoxTypeScreen);
            this.flowLayoutPanel12.Location = new System.Drawing.Point(14, 92);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(636, 42);
            this.flowLayoutPanel12.TabIndex = 53;
            // 
            // comboBoxTypeScreen
            // 
            this.comboBoxTypeScreen.AutoResize = false;
            this.comboBoxTypeScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxTypeScreen.Depth = 0;
            this.comboBoxTypeScreen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxTypeScreen.DropDownHeight = 118;
            this.comboBoxTypeScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeScreen.DropDownWidth = 121;
            this.comboBoxTypeScreen.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxTypeScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxTypeScreen.FormattingEnabled = true;
            this.comboBoxTypeScreen.IntegralHeight = false;
            this.comboBoxTypeScreen.ItemHeight = 29;
            this.comboBoxTypeScreen.Location = new System.Drawing.Point(457, 3);
            this.comboBoxTypeScreen.MaxDropDownItems = 4;
            this.comboBoxTypeScreen.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxTypeScreen.Name = "comboBoxTypeScreen";
            this.comboBoxTypeScreen.Size = new System.Drawing.Size(176, 35);
            this.comboBoxTypeScreen.StartIndex = 0;
            this.comboBoxTypeScreen.TabIndex = 53;
            this.comboBoxTypeScreen.UseTallSize = false;
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1521, 1036);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoShow = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerUseColors = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Monitor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedColorAutoShow)).EndInit();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rusLang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsEng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlLang)).EndInit();
            this.fullInfoPage.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.showInfoPage.ResumeLayout(false);
            this.showInfoPage.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchAssetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHdmi)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVga)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisplayPort)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDvi)).EndInit();
            this.testMonitorPage.ResumeLayout(false);
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel10.ResumeLayout(false);
            this.resolutionPage.ResumeLayout(false);
            this.resolutionPage.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.materialTabControl2.ResumeLayout(false);
            this.testMonitorKnPage.ResumeLayout(false);
            this.instructionKnPage.ResumeLayout(false);
            this.instructionKnPage.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MaterialSkin.Controls.MaterialLabel labelMonitor;
        private MaterialSkin.Controls.MaterialLabel lableChanRes;
        private MaterialSkin.Controls.MaterialComboBox MonitorComboBox;
        private MaterialSkin.Controls.MaterialComboBox ResolutionComboBox;
        private MaterialSkin.Controls.MaterialButton SetMaxResolution;
        private MaterialSkin.Controls.MaterialButton SetResolution;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage resolutionPage;
        private TabPage showInfoPage;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem2ToolStripMenuItem;
        private ToolStripMenuItem disabledItemToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item2ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item3ToolStripMenuItem;
        private TabPage fullInfoPage;
        private TabPage searchInfoPage;
        private TabPage tabPage6;
        private TabPage testMonitorPage;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox2;
        private MaterialSkin.Controls.MaterialLabel labelProductCode;
        private MaterialSkin.Controls.MaterialLabel labelMonth;
        private MaterialSkin.Controls.MaterialLabel labelYear;
        private MaterialSkin.Controls.MaterialLabel labelModel;
        private MaterialSkin.Controls.MaterialLabel labelManufacturer;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private TabPage tabPageMain;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxTester;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxAutoShow;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
       
        private MaterialSkin.Controls.MaterialLabel labelSize;
        private MaterialSkin.Controls.MaterialLabel labelFrequency;
        private MaterialSkin.Controls.MaterialLabel labelSerial;
        private MaterialSkin.Controls.MaterialLabel labelDiagonal;
        private MaterialSkin.Controls.MaterialLabel labelPPI;
        private MaterialSkin.Controls.MaterialLabel ResolutionLabel;
        public MaterialComboBox materialComboBoxMonitors;
        public MaterialLabel materialLabelPPI;
        public MaterialLabel materialLabelResolution;
        public MaterialLabel materialLabelSizeMonitor;
        public MaterialLabel materialLabelFrequency;
        public MaterialLabel materialLabelDiagonal2;
        public MaterialLabel materialLabelDiagonal1;
        public MaterialLabel materialLabelProductCodeID;
        public MaterialLabel materialLabelMonthOfProduction;
        public MaterialLabel materialLabelYearOfProduction;
        public MaterialLabel materialLabelModel;
        public MaterialLabel materialLabelManufacturer;
        private MaterialLabel materialLabel13;
        private MaterialTextBox2 textBoxIdEVK;
        private MaterialButton sendButton;
        public MaterialSwitch materialSwitch1;
        private MaterialSlider materialSliderOpasity;
        private MaterialButton buttonTestingMonitor;
        private MaterialButton buttonServiceFixPixel;
        private MaterialCard materialCard1;
        private MaterialCard materialCard2;
        private MaterialCheckbox materialCheckbox3;
        private MaterialCheckbox materialCheckbox9;
        private MaterialCheckbox materialCheckbox8;
        private MaterialCheckbox materialCheckbox7;
        private MaterialCheckbox materialCheckbox6;
        private MaterialCheckbox materialCheckbox5;
        private MaterialCheckbox materialCheckbox4;
        private MaterialCheckbox materialCheckbox14;
        private MaterialCheckbox materialCheckbox13;
        private MaterialCheckbox materialCheckbox12;
        private MaterialCheckbox materialCheckbox11;
        private MaterialCheckbox materialCheckbox10;
        private PictureBox searchAssetButton;
        private MaterialCard materialCard3;
        public MaterialLabel labelAssetIsCleaned;
        private MaterialLabel labelAsCleaned;
        public MaterialLabel labelAssetIsPictured;
        private MaterialLabel labelAsPicture;
        public MaterialLabel labelAssetIsTested;
        private MaterialLabel labelAsTested;
        private MaterialLabel labelAsModel;
        private MaterialLabel labelAsManufact;
        public MaterialLabel labelAssetManufacturer;
        public MaterialLabel labelAssetModel;
        public MaterialLabel labelAssetCleaner;
        private MaterialLabel labelAssetCleaner1;
        public MaterialLabel labelAssetResolution;
        private MaterialLabel labelAsProductId;
        public MaterialLabel labelAssetTester;
        private MaterialLabel labelAsResolution;
        private MaterialLabel labelAsTester;
        public MaterialLabel labelAssetSerialNumber;
        public MaterialLabel labelAssetProductCode;
        private MaterialLabel materialLabel46;
        public MaterialLabel labelAssetDiagonal;
        private MaterialLabel labelAsDIagHW;
        private MaterialLabel labelAsSerial;
        public MaterialLabel labelAssetClass;
        private MaterialLabel labelAsClass;
        public MaterialLabel labelAssetPlace;
        private MaterialLabel labelAsPlace;
        public MaterialLabel labelAssetDateCleaning;
        public MaterialLabel labelAssetDateTesting;
        private PictureBox pictureBox2;
        private MaterialLabel materialLabel11;
        private MaterialLabel labelAsType;
        public MaterialLabel labelAssetType;
        private MaterialLabel labelAsDiagonal;
        public MaterialLabel labelAssetDiagonalDB;
        private PictureBox pictureBox3;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox14;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox16;
        private PictureBox pictureBox15;
        private PictureBox pictureBox20;
        private PictureBox pictureBox19;
        private PictureBox pictureBox18;
        private PictureBox pictureBox17;
        private PictureBox pictureBox29;
        private PictureBox pictureBox30;
        private PictureBox pictureBox31;
        private PictureBox pictureBox32;
        private PictureBox pictureBox33;
        private PictureBox pictureBox22;
        private PictureBox pictureBox21;
        private PictureBox pictureBox23;
        private PictureBox pictureBox24;
        private PictureBox pictureBox25;
        private PictureBox pictureBox26;
        private PictureBox pictureBox27;
        public MaterialComboBox comboBoxCountry;
        private PictureBox pictureBox28;
        private MaterialCheckbox checkBoxCountry;
        private MaterialLabel labelCountry;
        private PictureBox pictureBox34;
        public MaterialLabel labelAssetCountry;
        private MaterialLabel labelAsCountry;
        private PictureBox pictureBox35;
        public MaterialLabel materialLabel17;
        private MaterialLabel labelAsCable;
        private NumericUpDown numericUpDownHdmi;
        private MaterialCheckbox checkBoxDVI;
        private NumericUpDown numericUpDownDisplayPort;
        private MaterialCheckbox checkBoxDisplayPort;
        private NumericUpDown numericUpDownVga;
        private MaterialCheckbox checkBoxHDMI;
        private NumericUpDown numericUpDownDvi;
        private MaterialCheckbox checkBoxVGA;
        private PictureBox PlLang;
        private PictureBox UsEng;
        private MaterialCard materialCard5;
        private PictureBox rusLang;
        private PictureBox pictureBox36;
        private MaterialLabel materialLabel4;
        private MaterialLabel materialLabel3;
        private MaterialLabel RusLabel;
        private MaterialLabel LabelUkr;
        private PictureBox pictureBox37;
        private MaterialLabel materialLabel25;
        private MaterialCheckbox checkBoxSaveLanguage;
        private MaterialTabControl materialTabControl2;
        private TabPage testMonitorKnPage;
        private TabPage instructionKnPage;
        private MaterialMultiLineTextBox materialMultiLineTextBox1;
        private MaterialLabel materialLabel6;
        private MaterialLabel materialLabel2;
        private MaterialLabel materialLabel1;
        public PictureBox pictureBoxLogo;
        private MaterialLabel mainLabelTester;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        public MaterialLabel labelAssetIdEvk;
        private FlowLayoutPanel flowLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel8;
        private MaterialCard materialCard4;
        private MaterialCheckbox checkBoxSearchSerial;
        private MaterialCheckbox checkBoxSearchEVK_ID;
        private MaterialTextBox2 textBoxSerial;
        private MaterialCheckbox checkBoxConnectMonitor;
        private FlowLayoutPanel flowLayoutPanel9;
        private PictureBox selectedColorAutoShow;
        private ColorDialog colorDialog1;
        private FlowLayoutPanel flowLayoutPanel10;
        private MaterialButton btnExtend;
        private MaterialButton btnDuplicate;
        private MaterialButton btnOnlyPC;
        private MaterialButton btnOnlySecond;
        private FlowLayoutPanel flowLayoutPanel11;
        private MaterialButton btnDisplaySettings;
        private MaterialButton materialButton2;
        private MaterialButton materialButton3;
        private MaterialCheckbox materialCheckbox2;
        private FlowLayoutPanel flowLayoutPanel12;
        private MaterialComboBox comboBoxTypeScreen;
    }
}

