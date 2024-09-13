using System.Windows.Forms;
using MaterialSkin.Controls;

namespace ServiceMonitorEVK.Source.Main
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
            this.labelAppCloseIn = new MaterialSkin.Controls.MaterialLabel();
            this.labelStrAppCloseIn = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxAutoChangeMode = new MaterialSkin.Controls.MaterialCheckbox();
            this.comboBoxTypeScreen = new MaterialSkin.Controls.MaterialComboBox();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxConnectMonitor = new MaterialSkin.Controls.MaterialCheckbox();
            this.selectedColorAutoShow = new System.Windows.Forms.PictureBox();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
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
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.textBoxTester = new MaterialSkin.Controls.MaterialTextBox2();
            this.checkBoxAutoShow = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkBoxSaveLanguage = new MaterialSkin.Controls.MaterialCheckbox();
            this.fullInfoPage = new System.Windows.Forms.TabPage();
            this.materialMultiLineTextBox2 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.showInfoPage = new System.Windows.Forms.TabPage();
            this.buttonChangeMonitor = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabelBrightness = new MaterialSkin.Controls.MaterialLabel();
            this.labelEvkModel = new MaterialSkin.Controls.MaterialLabel();
            this.labelAsResolutionPr = new MaterialSkin.Controls.MaterialLabel();
            this.labelBrightnessPr = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.materialLabelViewingAngles = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelWeight = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.materialLabelResponseTime = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxSerial = new MaterialSkin.Controls.MaterialTextBox2();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.comboBoxCountry = new MaterialSkin.Controls.MaterialComboBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.searchAssetButton = new System.Windows.Forms.PictureBox();
            this.textBoxIdEVK = new MaterialSkin.Controls.MaterialTextBox2();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.materialLabelManufacturer = new MaterialSkin.Controls.MaterialLabel();
            this.labelCountryPr = new MaterialSkin.Controls.MaterialLabel();
            this.labelSystemModelPr = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.labelAsBiewAngles = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelSizeMonitor = new MaterialSkin.Controls.MaterialLabel();
            this.systemModelLabel = new MaterialSkin.Controls.MaterialLabel();
            this.labelFrequencyPr = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelFrequency = new MaterialSkin.Controls.MaterialLabel();
            this.labelSerialPr = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.labelAsResponseTimePr = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelYearOfProduction = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelMonthOfProduction = new MaterialSkin.Controls.MaterialLabel();
            this.labelDatePr = new MaterialSkin.Controls.MaterialLabel();
            this.labelAsWeightPr = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelDiagonal = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.materialLabelProductCodeID = new MaterialSkin.Controls.MaterialLabel();
            this.labelDiagonalPr = new MaterialSkin.Controls.MaterialLabel();
            this.labelAsScreenFormatPr = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxHDMI = new MaterialSkin.Controls.MaterialCheckbox();
            this.numericUpDownHdmi = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxVGA = new MaterialSkin.Controls.MaterialCheckbox();
            this.numericUpDownVga = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxDVI = new MaterialSkin.Controls.MaterialCheckbox();
            this.numericUpDownDvi = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel13 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxDisplayPort = new MaterialSkin.Controls.MaterialCheckbox();
            this.numericUpDownDisplayPort = new System.Windows.Forms.NumericUpDown();
            this.labelAsTypePr = new MaterialSkin.Controls.MaterialLabel();
            this.labelEvkModelPr = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelManufacturerPr = new MaterialSkin.Controls.MaterialLabel();
            this.labelProductCodePr = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelTypeMatrix = new MaterialSkin.Controls.MaterialLabel();
            this.labelSizePr = new MaterialSkin.Controls.MaterialLabel();
            this.labelScreenFormat = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.materialLabelResolution = new MaterialSkin.Controls.MaterialLabel();
            this.sendButton = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBoxMonitors = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.searchInfoPage = new System.Windows.Forms.TabPage();
            this.aiButton = new MaterialSkin.Controls.MaterialButton();
            this.testMonitorPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDisplaySettings = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
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
            this.materialTabControl1.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedColorAutoShow)).BeginInit();
            this.materialCard5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rusLang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsEng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlLang)).BeginInit();
            this.fullInfoPage.SuspendLayout();
            this.showInfoPage.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchAssetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHdmi)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVga)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDvi)).BeginInit();
            this.flowLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisplayPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            this.searchInfoPage.SuspendLayout();
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
            this.materialTabControl1.Size = new System.Drawing.Size(1564, 1317);
            this.materialTabControl1.TabIndex = 35;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.materialCard4);
            this.tabPageMain.ImageKey = "homepage.png";
            this.tabPageMain.Location = new System.Drawing.Point(4, 39);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(1556, 1274);
            this.tabPageMain.TabIndex = 7;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // materialCard4
            // 
            this.materialCard4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.labelAppCloseIn);
            this.materialCard4.Controls.Add(this.labelStrAppCloseIn);
            this.materialCard4.Controls.Add(this.flowLayoutPanel12);
            this.materialCard4.Controls.Add(this.flowLayoutPanel9);
            this.materialCard4.Controls.Add(this.materialCheckbox1);
            this.materialCard4.Controls.Add(this.checkBoxSearchSerial);
            this.materialCard4.Controls.Add(this.checkBoxSearchEVK_ID);
            this.materialCard4.Controls.Add(this.materialCard5);
            this.materialCard4.Controls.Add(this.materialSliderOpasity);
            this.materialCard4.Controls.Add(this.materialSwitch1);
            this.materialCard4.Controls.Add(this.textBoxTester);
            this.materialCard4.Controls.Add(this.checkBoxAutoShow);
            this.materialCard4.Controls.Add(this.checkBoxSaveLanguage);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(291, 404);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(698, 438);
            this.materialCard4.TabIndex = 47;
            // 
            // labelAppCloseIn
            // 
            this.labelAppCloseIn.AutoSize = true;
            this.labelAppCloseIn.Depth = 0;
            this.labelAppCloseIn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAppCloseIn.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.labelAppCloseIn.Location = new System.Drawing.Point(95, 410);
            this.labelAppCloseIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAppCloseIn.Name = "labelAppCloseIn";
            this.labelAppCloseIn.Size = new System.Drawing.Size(4, 14);
            this.labelAppCloseIn.TabIndex = 55;
            this.labelAppCloseIn.Text = "-";
            // 
            // labelStrAppCloseIn
            // 
            this.labelStrAppCloseIn.AutoSize = true;
            this.labelStrAppCloseIn.Depth = 0;
            this.labelStrAppCloseIn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.labelStrAppCloseIn.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.labelStrAppCloseIn.Location = new System.Drawing.Point(11, 410);
            this.labelStrAppCloseIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelStrAppCloseIn.Name = "labelStrAppCloseIn";
            this.labelStrAppCloseIn.Size = new System.Drawing.Size(77, 14);
            this.labelStrAppCloseIn.TabIndex = 54;
            this.labelStrAppCloseIn.Text = "App closed in:";
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.AutoSize = true;
            this.flowLayoutPanel12.Controls.Add(this.checkBoxAutoChangeMode);
            this.flowLayoutPanel12.Controls.Add(this.comboBoxTypeScreen);
            this.flowLayoutPanel12.Location = new System.Drawing.Point(14, 92);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(636, 42);
            this.flowLayoutPanel12.TabIndex = 53;
            // 
            // checkBoxAutoChangeMode
            // 
            this.checkBoxAutoChangeMode.AutoSize = true;
            this.checkBoxAutoChangeMode.Depth = 0;
            this.checkBoxAutoChangeMode.Location = new System.Drawing.Point(0, 0);
            this.checkBoxAutoChangeMode.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxAutoChangeMode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxAutoChangeMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxAutoChangeMode.Name = "checkBoxAutoChangeMode";
            this.checkBoxAutoChangeMode.ReadOnly = false;
            this.checkBoxAutoChangeMode.Ripple = true;
            this.checkBoxAutoChangeMode.Size = new System.Drawing.Size(454, 37);
            this.checkBoxAutoChangeMode.TabIndex = 52;
            this.checkBoxAutoChangeMode.Text = "When connecting a new monitor, change the display type to";
            this.checkBoxAutoChangeMode.UseVisualStyleBackColor = true;
            this.checkBoxAutoChangeMode.CheckedChanged += new System.EventHandler(this.checkBoxAutoChangeMode_CheckedChanged);
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
            this.comboBoxTypeScreen.Enabled = false;
            this.comboBoxTypeScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxTypeScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxTypeScreen.FormattingEnabled = true;
            this.comboBoxTypeScreen.IntegralHeight = false;
            this.comboBoxTypeScreen.ItemHeight = 29;
            this.comboBoxTypeScreen.Items.AddRange(new object[] {
            "PC_SCREEN_ONLY",
            "DUPLICATE",
            "EXTEND",
            "SECOND_SCREEN_ONLY"});
            this.comboBoxTypeScreen.Location = new System.Drawing.Point(457, 3);
            this.comboBoxTypeScreen.MaxDropDownItems = 4;
            this.comboBoxTypeScreen.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxTypeScreen.Name = "comboBoxTypeScreen";
            this.comboBoxTypeScreen.Size = new System.Drawing.Size(176, 35);
            this.comboBoxTypeScreen.StartIndex = 2;
            this.comboBoxTypeScreen.TabIndex = 53;
            this.comboBoxTypeScreen.UseTallSize = false;
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
            this.materialCard5.Location = new System.Drawing.Point(25, 335);
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
            this.materialSliderOpasity.Location = new System.Drawing.Point(375, 392);
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
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.BackColor = System.Drawing.Color.RosyBrown;
            this.materialSwitch1.Checked = true;
            this.materialSwitch1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(220, 395);
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
            this.checkBoxSaveLanguage.Location = new System.Drawing.Point(322, 342);
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
            this.fullInfoPage.Controls.Add(this.materialMultiLineTextBox2);
            this.fullInfoPage.ImageKey = "info (2).png";
            this.fullInfoPage.Location = new System.Drawing.Point(4, 39);
            this.fullInfoPage.Name = "fullInfoPage";
            this.fullInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.fullInfoPage.Size = new System.Drawing.Size(1556, 1274);
            this.fullInfoPage.TabIndex = 3;
            this.fullInfoPage.Text = "Show full info";
            this.fullInfoPage.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // materialMultiLineTextBox2
            // 
            this.materialMultiLineTextBox2.AcceptsTab = true;
            this.materialMultiLineTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox2.Depth = 0;
            this.materialMultiLineTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialMultiLineTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox2.Location = new System.Drawing.Point(3, 3);
            this.materialMultiLineTextBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox2.Name = "materialMultiLineTextBox2";
            this.materialMultiLineTextBox2.ReadOnly = true;
            this.materialMultiLineTextBox2.Size = new System.Drawing.Size(1550, 1268);
            this.materialMultiLineTextBox2.TabIndex = 30;
            this.materialMultiLineTextBox2.Text = "";
            // 
            // showInfoPage
            // 
            this.showInfoPage.BackColor = System.Drawing.Color.White;
            this.showInfoPage.Controls.Add(this.buttonChangeMonitor);
            this.showInfoPage.Controls.Add(this.materialCard2);
            this.showInfoPage.Controls.Add(this.sendButton);
            this.showInfoPage.Controls.Add(this.materialComboBoxMonitors);
            this.showInfoPage.Controls.Add(this.materialButton1);
            this.showInfoPage.ImageKey = "computer.png";
            this.showInfoPage.Location = new System.Drawing.Point(4, 39);
            this.showInfoPage.Name = "showInfoPage";
            this.showInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.showInfoPage.Size = new System.Drawing.Size(1556, 1274);
            this.showInfoPage.TabIndex = 1;
            this.showInfoPage.Text = "Show info";
            this.showInfoPage.Enter += new System.EventHandler(this.showInfoPage_Enter);
            this.showInfoPage.Leave += new System.EventHandler(this.showInfoPage_Leave);
            // 
            // buttonChangeMonitor
            // 
            this.buttonChangeMonitor.AutoSize = false;
            this.buttonChangeMonitor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonChangeMonitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeMonitor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonChangeMonitor.Depth = 0;
            this.buttonChangeMonitor.HighEmphasis = true;
            this.buttonChangeMonitor.Icon = null;
            this.buttonChangeMonitor.Location = new System.Drawing.Point(617, 124);
            this.buttonChangeMonitor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonChangeMonitor.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonChangeMonitor.Name = "buttonChangeMonitor";
            this.buttonChangeMonitor.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonChangeMonitor.Size = new System.Drawing.Size(330, 90);
            this.buttonChangeMonitor.TabIndex = 57;
            this.buttonChangeMonitor.TabStop = false;
            this.buttonChangeMonitor.Text = "Change monitor info";
            this.buttonChangeMonitor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonChangeMonitor.UseAccentColor = false;
            this.buttonChangeMonitor.UseVisualStyleBackColor = true;
            this.buttonChangeMonitor.Click += new System.EventHandler(this.buttonChangeMonitor_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.AutoSize = true;
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.tableLayoutPanel2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(20, 58);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5);
            this.materialCard2.Size = new System.Drawing.Size(548, 690);
            this.materialCard2.TabIndex = 56;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.materialLabelBrightness, 2, 19);
            this.tableLayoutPanel2.Controls.Add(this.labelEvkModel, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelAsResolutionPr, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.labelBrightnessPr, 1, 19);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox15, 0, 19);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelViewingAngles, 2, 18);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelWeight, 2, 14);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox4, 0, 15);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelResponseTime, 2, 15);
            this.tableLayoutPanel2.Controls.Add(this.textBoxSerial, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox35, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxCountry, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox21, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchAssetButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxIdEVK, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox7, 0, 16);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox28, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox8, 0, 17);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox27, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox9, 0, 18);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelManufacturer, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelCountryPr, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.labelSystemModelPr, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox26, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox22, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox10, 0, 14);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox11, 0, 13);
            this.tableLayoutPanel2.Controls.Add(this.labelAsBiewAngles, 1, 18);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelSizeMonitor, 2, 12);
            this.tableLayoutPanel2.Controls.Add(this.systemModelLabel, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelFrequencyPr, 1, 17);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelFrequency, 2, 17);
            this.tableLayoutPanel2.Controls.Add(this.labelSerialPr, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox23, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox32, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelAsResponseTimePr, 1, 15);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelYearOfProduction, 2, 16);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelMonthOfProduction, 3, 16);
            this.tableLayoutPanel2.Controls.Add(this.labelDatePr, 1, 16);
            this.tableLayoutPanel2.Controls.Add(this.labelAsWeightPr, 1, 14);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelDiagonal, 2, 8);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox33, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelProductCodeID, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.labelDiagonalPr, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.labelAsScreenFormatPr, 1, 13);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel13, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel7, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.labelAsTypePr, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelEvkModelPr, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelManufacturerPr, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelProductCodePr, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelTypeMatrix, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelSizePr, 1, 12);
            this.tableLayoutPanel2.Controls.Add(this.labelScreenFormat, 2, 13);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox30, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.materialLabelResolution, 2, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(24, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 20;
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(506, 640);
            this.tableLayoutPanel2.TabIndex = 80;
            // 
            // materialLabelBrightness
            // 
            this.materialLabelBrightness.AutoSize = true;
            this.materialLabelBrightness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelBrightness.Depth = 0;
            this.materialLabelBrightness.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelBrightness.Location = new System.Drawing.Point(204, 607);
            this.materialLabelBrightness.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelBrightness.Name = "materialLabelBrightness";
            this.materialLabelBrightness.Size = new System.Drawing.Size(37, 19);
            this.materialLabelBrightness.TabIndex = 83;
            this.materialLabelBrightness.Text = "         ";
            // 
            // labelEvkModel
            // 
            this.labelEvkModel.AutoSize = true;
            this.labelEvkModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEvkModel.Depth = 0;
            this.labelEvkModel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelEvkModel.Location = new System.Drawing.Point(204, 81);
            this.labelEvkModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEvkModel.Name = "labelEvkModel";
            this.labelEvkModel.Size = new System.Drawing.Size(37, 19);
            this.labelEvkModel.TabIndex = 120;
            this.labelEvkModel.Text = "         ";
            // 
            // labelAsResolutionPr
            // 
            this.labelAsResolutionPr.AutoSize = true;
            this.labelAsResolutionPr.Depth = 0;
            this.labelAsResolutionPr.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsResolutionPr.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsResolutionPr.Location = new System.Drawing.Point(33, 216);
            this.labelAsResolutionPr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsResolutionPr.Name = "labelAsResolutionPr";
            this.labelAsResolutionPr.Size = new System.Drawing.Size(100, 24);
            this.labelAsResolutionPr.TabIndex = 37;
            this.labelAsResolutionPr.Text = "Resolution:";
            // 
            // labelBrightnessPr
            // 
            this.labelBrightnessPr.AutoSize = true;
            this.labelBrightnessPr.Depth = 0;
            this.labelBrightnessPr.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelBrightnessPr.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelBrightnessPr.Location = new System.Drawing.Point(33, 607);
            this.labelBrightnessPr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBrightnessPr.Name = "labelBrightnessPr";
            this.labelBrightnessPr.Size = new System.Drawing.Size(97, 24);
            this.labelBrightnessPr.TabIndex = 101;
            this.labelBrightnessPr.Text = "Brightness";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox15.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox15.Location = new System.Drawing.Point(3, 610);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(24, 21);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 94;
            this.pictureBox15.TabStop = false;
            // 
            // materialLabelViewingAngles
            // 
            this.materialLabelViewingAngles.AutoSize = true;
            this.materialLabelViewingAngles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelViewingAngles.Depth = 0;
            this.materialLabelViewingAngles.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelViewingAngles.Location = new System.Drawing.Point(204, 582);
            this.materialLabelViewingAngles.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelViewingAngles.Name = "materialLabelViewingAngles";
            this.materialLabelViewingAngles.Size = new System.Drawing.Size(37, 19);
            this.materialLabelViewingAngles.TabIndex = 81;
            this.materialLabelViewingAngles.Text = "         ";
            // 
            // materialLabelWeight
            // 
            this.materialLabelWeight.AutoSize = true;
            this.materialLabelWeight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelWeight.Depth = 0;
            this.materialLabelWeight.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelWeight.Location = new System.Drawing.Point(204, 482);
            this.materialLabelWeight.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelWeight.Name = "materialLabelWeight";
            this.materialLabelWeight.Size = new System.Drawing.Size(37, 19);
            this.materialLabelWeight.TabIndex = 82;
            this.materialLabelWeight.Text = "         ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox4.Location = new System.Drawing.Point(3, 510);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 83;
            this.pictureBox4.TabStop = false;
            // 
            // materialLabelResponseTime
            // 
            this.materialLabelResponseTime.AutoSize = true;
            this.materialLabelResponseTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelResponseTime.Depth = 0;
            this.materialLabelResponseTime.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelResponseTime.Location = new System.Drawing.Point(204, 507);
            this.materialLabelResponseTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelResponseTime.Name = "materialLabelResponseTime";
            this.materialLabelResponseTime.Size = new System.Drawing.Size(37, 19);
            this.materialLabelResponseTime.TabIndex = 106;
            this.materialLabelResponseTime.Text = "         ";
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
            this.textBoxSerial.Location = new System.Drawing.Point(204, 138);
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
            // pictureBox35
            // 
            this.pictureBox35.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox35.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox35.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox35.Location = new System.Drawing.Point(3, 435);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(24, 19);
            this.pictureBox35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox35.TabIndex = 105;
            this.pictureBox35.TabStop = false;
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
            this.comboBoxCountry.Location = new System.Drawing.Point(204, 300);
            this.comboBoxCountry.MaxDropDownItems = 4;
            this.comboBoxCountry.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(166, 49);
            this.comboBoxCountry.StartIndex = 0;
            this.comboBoxCountry.TabIndex = 80;
            this.comboBoxCountry.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox21.Image = global::ServiceMonitorEVK.Properties.Resources.id;
            this.pictureBox21.Location = new System.Drawing.Point(3, 3);
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
            this.searchAssetButton.Location = new System.Drawing.Point(384, 3);
            this.searchAssetButton.Name = "searchAssetButton";
            this.searchAssetButton.Size = new System.Drawing.Size(36, 39);
            this.searchAssetButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchAssetButton.TabIndex = 59;
            this.searchAssetButton.TabStop = false;
            this.searchAssetButton.Click += new System.EventHandler(this.searchAssetButton_Click);
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
            this.textBoxIdEVK.Location = new System.Drawing.Point(204, 3);
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
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox7.Location = new System.Drawing.Point(3, 535);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 19);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 86;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox28.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox28.Location = new System.Drawing.Point(3, 300);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(20, 21);
            this.pictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox28.TabIndex = 114;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox8.Location = new System.Drawing.Point(3, 560);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(24, 19);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 87;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ServiceMonitorEVK.Properties.Resources.searchAsset;
            this.pictureBox2.Location = new System.Drawing.Point(384, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox27
            // 
            this.pictureBox27.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox27.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox27.Location = new System.Drawing.Point(3, 57);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(24, 21);
            this.pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox27.TabIndex = 100;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox9.Location = new System.Drawing.Point(3, 585);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(24, 19);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 88;
            this.pictureBox9.TabStop = false;
            // 
            // materialLabelManufacturer
            // 
            this.materialLabelManufacturer.AutoSize = true;
            this.materialLabelManufacturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelManufacturer.Depth = 0;
            this.materialLabelManufacturer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelManufacturer.Location = new System.Drawing.Point(204, 54);
            this.materialLabelManufacturer.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelManufacturer.Name = "materialLabelManufacturer";
            this.materialLabelManufacturer.Size = new System.Drawing.Size(37, 19);
            this.materialLabelManufacturer.TabIndex = 39;
            this.materialLabelManufacturer.Text = "         ";
            this.materialLabelManufacturer.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelCountryPr
            // 
            this.labelCountryPr.AutoSize = true;
            this.labelCountryPr.Depth = 0;
            this.labelCountryPr.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelCountryPr.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelCountryPr.Location = new System.Drawing.Point(33, 297);
            this.labelCountryPr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCountryPr.Name = "labelCountryPr";
            this.labelCountryPr.Size = new System.Drawing.Size(71, 24);
            this.labelCountryPr.TabIndex = 111;
            this.labelCountryPr.Text = "Country";
            // 
            // labelSystemModelPr
            // 
            this.labelSystemModelPr.AutoSize = true;
            this.labelSystemModelPr.Depth = 0;
            this.labelSystemModelPr.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelSystemModelPr.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelSystemModelPr.Location = new System.Drawing.Point(33, 108);
            this.labelSystemModelPr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSystemModelPr.Name = "labelSystemModelPr";
            this.labelSystemModelPr.Size = new System.Drawing.Size(128, 24);
            this.labelSystemModelPr.TabIndex = 1;
            this.labelSystemModelPr.Text = "System model";
            // 
            // pictureBox26
            // 
            this.pictureBox26.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox26.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox26.Location = new System.Drawing.Point(3, 111);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(24, 21);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox26.TabIndex = 101;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox22.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox22.Location = new System.Drawing.Point(3, 273);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(24, 21);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox22.TabIndex = 105;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox10.Location = new System.Drawing.Point(3, 485);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(24, 19);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 89;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox11.Location = new System.Drawing.Point(3, 460);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(24, 19);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 90;
            this.pictureBox11.TabStop = false;
            // 
            // labelAsBiewAngles
            // 
            this.labelAsBiewAngles.AutoSize = true;
            this.labelAsBiewAngles.Depth = 0;
            this.labelAsBiewAngles.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsBiewAngles.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsBiewAngles.Location = new System.Drawing.Point(33, 582);
            this.labelAsBiewAngles.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsBiewAngles.Name = "labelAsBiewAngles";
            this.labelAsBiewAngles.Size = new System.Drawing.Size(109, 24);
            this.labelAsBiewAngles.TabIndex = 81;
            this.labelAsBiewAngles.Text = "View angles";
            // 
            // materialLabelSizeMonitor
            // 
            this.materialLabelSizeMonitor.AutoSize = true;
            this.materialLabelSizeMonitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelSizeMonitor.Depth = 0;
            this.materialLabelSizeMonitor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelSizeMonitor.Location = new System.Drawing.Point(204, 432);
            this.materialLabelSizeMonitor.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelSizeMonitor.Name = "materialLabelSizeMonitor";
            this.materialLabelSizeMonitor.Size = new System.Drawing.Size(37, 19);
            this.materialLabelSizeMonitor.TabIndex = 48;
            this.materialLabelSizeMonitor.Text = "         ";
            this.materialLabelSizeMonitor.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // systemModelLabel
            // 
            this.systemModelLabel.AutoSize = true;
            this.systemModelLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.systemModelLabel.Depth = 0;
            this.systemModelLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.systemModelLabel.Location = new System.Drawing.Point(204, 108);
            this.systemModelLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.systemModelLabel.Name = "systemModelLabel";
            this.systemModelLabel.Size = new System.Drawing.Size(37, 19);
            this.systemModelLabel.TabIndex = 40;
            this.systemModelLabel.Text = "         ";
            this.systemModelLabel.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelFrequencyPr
            // 
            this.labelFrequencyPr.AutoSize = true;
            this.labelFrequencyPr.Depth = 0;
            this.labelFrequencyPr.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelFrequencyPr.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelFrequencyPr.Location = new System.Drawing.Point(33, 557);
            this.labelFrequencyPr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFrequencyPr.Name = "labelFrequencyPr";
            this.labelFrequencyPr.Size = new System.Drawing.Size(94, 24);
            this.labelFrequencyPr.TabIndex = 35;
            this.labelFrequencyPr.Text = "Frequency";
            // 
            // materialLabelFrequency
            // 
            this.materialLabelFrequency.AutoSize = true;
            this.materialLabelFrequency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelFrequency.Depth = 0;
            this.materialLabelFrequency.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelFrequency.Location = new System.Drawing.Point(204, 557);
            this.materialLabelFrequency.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelFrequency.Name = "materialLabelFrequency";
            this.materialLabelFrequency.Size = new System.Drawing.Size(37, 19);
            this.materialLabelFrequency.TabIndex = 47;
            this.materialLabelFrequency.Text = "         ";
            this.materialLabelFrequency.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelSerialPr
            // 
            this.labelSerialPr.AutoSize = true;
            this.labelSerialPr.Depth = 0;
            this.labelSerialPr.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelSerialPr.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelSerialPr.Location = new System.Drawing.Point(33, 135);
            this.labelSerialPr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSerialPr.Name = "labelSerialPr";
            this.labelSerialPr.Size = new System.Drawing.Size(88, 24);
            this.labelSerialPr.TabIndex = 34;
            this.labelSerialPr.Text = "Serial No.";
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox23.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox23.Location = new System.Drawing.Point(3, 246);
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
            this.pictureBox32.Location = new System.Drawing.Point(3, 192);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(24, 21);
            this.pictureBox32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox32.TabIndex = 107;
            this.pictureBox32.TabStop = false;
            // 
            // labelAsResponseTimePr
            // 
            this.labelAsResponseTimePr.AutoSize = true;
            this.labelAsResponseTimePr.Depth = 0;
            this.labelAsResponseTimePr.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsResponseTimePr.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsResponseTimePr.Location = new System.Drawing.Point(33, 507);
            this.labelAsResponseTimePr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsResponseTimePr.Name = "labelAsResponseTimePr";
            this.labelAsResponseTimePr.Size = new System.Drawing.Size(133, 24);
            this.labelAsResponseTimePr.TabIndex = 34;
            this.labelAsResponseTimePr.Text = "Response time";
            // 
            // materialLabelYearOfProduction
            // 
            this.materialLabelYearOfProduction.AutoSize = true;
            this.materialLabelYearOfProduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelYearOfProduction.Depth = 0;
            this.materialLabelYearOfProduction.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelYearOfProduction.Location = new System.Drawing.Point(204, 532);
            this.materialLabelYearOfProduction.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelYearOfProduction.Name = "materialLabelYearOfProduction";
            this.materialLabelYearOfProduction.Size = new System.Drawing.Size(37, 19);
            this.materialLabelYearOfProduction.TabIndex = 41;
            this.materialLabelYearOfProduction.Text = "         ";
            this.materialLabelYearOfProduction.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // materialLabelMonthOfProduction
            // 
            this.materialLabelMonthOfProduction.AutoSize = true;
            this.materialLabelMonthOfProduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelMonthOfProduction.Depth = 0;
            this.materialLabelMonthOfProduction.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelMonthOfProduction.Location = new System.Drawing.Point(384, 532);
            this.materialLabelMonthOfProduction.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelMonthOfProduction.Name = "materialLabelMonthOfProduction";
            this.materialLabelMonthOfProduction.Size = new System.Drawing.Size(37, 19);
            this.materialLabelMonthOfProduction.TabIndex = 42;
            this.materialLabelMonthOfProduction.Text = "         ";
            this.materialLabelMonthOfProduction.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelDatePr
            // 
            this.labelDatePr.AutoSize = true;
            this.labelDatePr.Depth = 0;
            this.labelDatePr.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelDatePr.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelDatePr.Location = new System.Drawing.Point(33, 532);
            this.labelDatePr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDatePr.Name = "labelDatePr";
            this.labelDatePr.Size = new System.Drawing.Size(43, 24);
            this.labelDatePr.TabIndex = 2;
            this.labelDatePr.Text = "Date";
            // 
            // labelAsWeightPr
            // 
            this.labelAsWeightPr.AutoSize = true;
            this.labelAsWeightPr.Depth = 0;
            this.labelAsWeightPr.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsWeightPr.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsWeightPr.Location = new System.Drawing.Point(33, 482);
            this.labelAsWeightPr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsWeightPr.Name = "labelAsWeightPr";
            this.labelAsWeightPr.Size = new System.Drawing.Size(64, 24);
            this.labelAsWeightPr.TabIndex = 4;
            this.labelAsWeightPr.Text = "Weight";
            // 
            // materialLabelDiagonal
            // 
            this.materialLabelDiagonal.AutoSize = true;
            this.materialLabelDiagonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelDiagonal.Depth = 0;
            this.materialLabelDiagonal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelDiagonal.Location = new System.Drawing.Point(204, 270);
            this.materialLabelDiagonal.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDiagonal.Name = "materialLabelDiagonal";
            this.materialLabelDiagonal.Size = new System.Drawing.Size(37, 19);
            this.materialLabelDiagonal.TabIndex = 44;
            this.materialLabelDiagonal.Text = "         ";
            this.materialLabelDiagonal.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // pictureBox33
            // 
            this.pictureBox33.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox33.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox33.Location = new System.Drawing.Point(3, 138);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(24, 21);
            this.pictureBox33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox33.TabIndex = 106;
            this.pictureBox33.TabStop = false;
            // 
            // materialLabelProductCodeID
            // 
            this.materialLabelProductCodeID.AutoSize = true;
            this.materialLabelProductCodeID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelProductCodeID.Depth = 0;
            this.materialLabelProductCodeID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelProductCodeID.Location = new System.Drawing.Point(204, 243);
            this.materialLabelProductCodeID.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelProductCodeID.Name = "materialLabelProductCodeID";
            this.materialLabelProductCodeID.Size = new System.Drawing.Size(37, 19);
            this.materialLabelProductCodeID.TabIndex = 43;
            this.materialLabelProductCodeID.Text = "         ";
            this.materialLabelProductCodeID.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // labelDiagonalPr
            // 
            this.labelDiagonalPr.AutoSize = true;
            this.labelDiagonalPr.Depth = 0;
            this.labelDiagonalPr.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelDiagonalPr.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelDiagonalPr.Location = new System.Drawing.Point(33, 270);
            this.labelDiagonalPr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDiagonalPr.Name = "labelDiagonalPr";
            this.labelDiagonalPr.Size = new System.Drawing.Size(79, 24);
            this.labelDiagonalPr.TabIndex = 32;
            this.labelDiagonalPr.Text = "Diagonal";
            // 
            // labelAsScreenFormatPr
            // 
            this.labelAsScreenFormatPr.AutoSize = true;
            this.labelAsScreenFormatPr.Depth = 0;
            this.labelAsScreenFormatPr.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsScreenFormatPr.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsScreenFormatPr.Location = new System.Drawing.Point(33, 457);
            this.labelAsScreenFormatPr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsScreenFormatPr.Name = "labelAsScreenFormatPr";
            this.labelAsScreenFormatPr.Size = new System.Drawing.Size(128, 24);
            this.labelAsScreenFormatPr.TabIndex = 32;
            this.labelAsScreenFormatPr.Text = "Screen format";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel13.Location = new System.Drawing.Point(33, 0);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(62, 24);
            this.materialLabel13.TabIndex = 53;
            this.materialLabel13.Text = "ID EVK";
            // 
            // flowLayoutPanel7
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel7, 3);
            this.flowLayoutPanel7.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel7.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel7.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel7.Controls.Add(this.flowLayoutPanel13);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 355);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(375, 74);
            this.flowLayoutPanel7.TabIndex = 82;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.checkBoxHDMI);
            this.flowLayoutPanel3.Controls.Add(this.numericUpDownHdmi);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(82, 74);
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
            this.checkBoxHDMI.ReadOnly = true;
            this.checkBoxHDMI.Ripple = true;
            this.checkBoxHDMI.Size = new System.Drawing.Size(75, 37);
            this.checkBoxHDMI.TabIndex = 0;
            this.checkBoxHDMI.Text = "HDMI";
            this.checkBoxHDMI.UseVisualStyleBackColor = true;
            // 
            // numericUpDownHdmi
            // 
            this.numericUpDownHdmi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownHdmi.Enabled = false;
            this.numericUpDownHdmi.Location = new System.Drawing.Point(18, 40);
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
            this.numericUpDownHdmi.ReadOnly = true;
            this.numericUpDownHdmi.Size = new System.Drawing.Size(38, 22);
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
            this.flowLayoutPanel4.Size = new System.Drawing.Size(76, 71);
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
            this.checkBoxVGA.ReadOnly = true;
            this.checkBoxVGA.Ripple = true;
            this.checkBoxVGA.Size = new System.Drawing.Size(66, 37);
            this.checkBoxVGA.TabIndex = 1;
            this.checkBoxVGA.Text = "VGA";
            this.checkBoxVGA.UseVisualStyleBackColor = true;
            // 
            // numericUpDownVga
            // 
            this.numericUpDownVga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownVga.Enabled = false;
            this.numericUpDownVga.Location = new System.Drawing.Point(14, 40);
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
            this.numericUpDownVga.ReadOnly = true;
            this.numericUpDownVga.Size = new System.Drawing.Size(38, 22);
            this.numericUpDownVga.TabIndex = 121;
            this.numericUpDownVga.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.checkBoxDVI);
            this.flowLayoutPanel6.Controls.Add(this.numericUpDownDvi);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(173, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(66, 74);
            this.flowLayoutPanel6.TabIndex = 81;
            // 
            // checkBoxDVI
            // 
            this.checkBoxDVI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDVI.AutoSize = true;
            this.checkBoxDVI.Depth = 0;
            this.checkBoxDVI.Location = new System.Drawing.Point(0, 0);
            this.checkBoxDVI.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDVI.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxDVI.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxDVI.Name = "checkBoxDVI";
            this.checkBoxDVI.ReadOnly = true;
            this.checkBoxDVI.Ripple = true;
            this.checkBoxDVI.Size = new System.Drawing.Size(60, 37);
            this.checkBoxDVI.TabIndex = 2;
            this.checkBoxDVI.Text = "DVI";
            this.checkBoxDVI.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDvi
            // 
            this.numericUpDownDvi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownDvi.Enabled = false;
            this.numericUpDownDvi.Location = new System.Drawing.Point(11, 40);
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
            this.numericUpDownDvi.ReadOnly = true;
            this.numericUpDownDvi.Size = new System.Drawing.Size(38, 22);
            this.numericUpDownDvi.TabIndex = 120;
            this.numericUpDownDvi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flowLayoutPanel13
            // 
            this.flowLayoutPanel13.Controls.Add(this.checkBoxDisplayPort);
            this.flowLayoutPanel13.Controls.Add(this.numericUpDownDisplayPort);
            this.flowLayoutPanel13.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel13.Location = new System.Drawing.Point(245, 3);
            this.flowLayoutPanel13.Name = "flowLayoutPanel13";
            this.flowLayoutPanel13.Size = new System.Drawing.Size(122, 71);
            this.flowLayoutPanel13.TabIndex = 82;
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
            this.checkBoxDisplayPort.ReadOnly = true;
            this.checkBoxDisplayPort.Ripple = true;
            this.checkBoxDisplayPort.Size = new System.Drawing.Size(117, 37);
            this.checkBoxDisplayPort.TabIndex = 3;
            this.checkBoxDisplayPort.Text = "DisplayPort";
            this.checkBoxDisplayPort.UseVisualStyleBackColor = false;
            // 
            // numericUpDownDisplayPort
            // 
            this.numericUpDownDisplayPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownDisplayPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownDisplayPort.Enabled = false;
            this.numericUpDownDisplayPort.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownDisplayPort.ForeColor = System.Drawing.SystemColors.Desktop;
            this.numericUpDownDisplayPort.Location = new System.Drawing.Point(39, 40);
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
            this.numericUpDownDisplayPort.ReadOnly = true;
            this.numericUpDownDisplayPort.Size = new System.Drawing.Size(38, 26);
            this.numericUpDownDisplayPort.TabIndex = 122;
            this.numericUpDownDisplayPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelAsTypePr
            // 
            this.labelAsTypePr.AutoSize = true;
            this.labelAsTypePr.Depth = 0;
            this.labelAsTypePr.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsTypePr.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsTypePr.Location = new System.Drawing.Point(33, 189);
            this.labelAsTypePr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsTypePr.Name = "labelAsTypePr";
            this.labelAsTypePr.Size = new System.Drawing.Size(50, 24);
            this.labelAsTypePr.TabIndex = 79;
            this.labelAsTypePr.Text = "Type:";
            // 
            // labelEvkModelPr
            // 
            this.labelEvkModelPr.AutoSize = true;
            this.labelEvkModelPr.Depth = 0;
            this.labelEvkModelPr.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelEvkModelPr.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelEvkModelPr.Location = new System.Drawing.Point(33, 81);
            this.labelEvkModelPr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEvkModelPr.Name = "labelEvkModelPr";
            this.labelEvkModelPr.Size = new System.Drawing.Size(92, 24);
            this.labelEvkModelPr.TabIndex = 118;
            this.labelEvkModelPr.Text = "Evk model";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox1.Location = new System.Drawing.Point(3, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            // 
            // labelManufacturerPr
            // 
            this.labelManufacturerPr.AutoSize = true;
            this.labelManufacturerPr.Depth = 0;
            this.labelManufacturerPr.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelManufacturerPr.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelManufacturerPr.Location = new System.Drawing.Point(33, 54);
            this.labelManufacturerPr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelManufacturerPr.Name = "labelManufacturerPr";
            this.labelManufacturerPr.Size = new System.Drawing.Size(123, 24);
            this.labelManufacturerPr.TabIndex = 0;
            this.labelManufacturerPr.Text = "Manufacturer";
            // 
            // labelProductCodePr
            // 
            this.labelProductCodePr.AutoSize = true;
            this.labelProductCodePr.Depth = 0;
            this.labelProductCodePr.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelProductCodePr.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelProductCodePr.Location = new System.Drawing.Point(33, 243);
            this.labelProductCodePr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelProductCodePr.Name = "labelProductCodePr";
            this.labelProductCodePr.Size = new System.Drawing.Size(143, 24);
            this.labelProductCodePr.TabIndex = 4;
            this.labelProductCodePr.Text = "Product code ID";
            // 
            // materialLabelTypeMatrix
            // 
            this.materialLabelTypeMatrix.AutoSize = true;
            this.materialLabelTypeMatrix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelTypeMatrix.Depth = 0;
            this.materialLabelTypeMatrix.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelTypeMatrix.Location = new System.Drawing.Point(204, 189);
            this.materialLabelTypeMatrix.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelTypeMatrix.Name = "materialLabelTypeMatrix";
            this.materialLabelTypeMatrix.Size = new System.Drawing.Size(37, 19);
            this.materialLabelTypeMatrix.TabIndex = 81;
            this.materialLabelTypeMatrix.Text = "         ";
            // 
            // labelSizePr
            // 
            this.labelSizePr.AutoSize = true;
            this.labelSizePr.Depth = 0;
            this.labelSizePr.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelSizePr.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelSizePr.Location = new System.Drawing.Point(33, 432);
            this.labelSizePr.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSizePr.Name = "labelSizePr";
            this.labelSizePr.Size = new System.Drawing.Size(165, 24);
            this.labelSizePr.TabIndex = 36;
            this.labelSizePr.Text = "Size monitor (cm.)";
            // 
            // labelScreenFormat
            // 
            this.labelScreenFormat.AutoSize = true;
            this.labelScreenFormat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelScreenFormat.Depth = 0;
            this.labelScreenFormat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelScreenFormat.Location = new System.Drawing.Point(204, 457);
            this.labelScreenFormat.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelScreenFormat.Name = "labelScreenFormat";
            this.labelScreenFormat.Size = new System.Drawing.Size(37, 19);
            this.labelScreenFormat.TabIndex = 44;
            this.labelScreenFormat.Text = "         ";
            this.labelScreenFormat.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.pictureBox30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox30.Image = global::ServiceMonitorEVK.Properties.Resources.monitor;
            this.pictureBox30.Location = new System.Drawing.Point(3, 219);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(24, 21);
            this.pictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox30.TabIndex = 109;
            this.pictureBox30.TabStop = false;
            // 
            // materialLabelResolution
            // 
            this.materialLabelResolution.AutoSize = true;
            this.materialLabelResolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelResolution.Depth = 0;
            this.materialLabelResolution.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelResolution.Location = new System.Drawing.Point(204, 216);
            this.materialLabelResolution.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelResolution.Name = "materialLabelResolution";
            this.materialLabelResolution.Size = new System.Drawing.Size(37, 19);
            this.materialLabelResolution.TabIndex = 49;
            this.materialLabelResolution.Text = "         ";
            this.materialLabelResolution.Click += new System.EventHandler(this.labelAssetClass_Click);
            // 
            // sendButton
            // 
            this.sendButton.AutoSize = false;
            this.sendButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.sendButton.Depth = 0;
            this.sendButton.Enabled = false;
            this.sendButton.HighEmphasis = true;
            this.sendButton.Icon = null;
            this.sendButton.Location = new System.Drawing.Point(638, 288);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sendButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendButton.Name = "sendButton";
            this.sendButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.sendButton.Size = new System.Drawing.Size(306, 221);
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
            this.materialComboBoxMonitors.Location = new System.Drawing.Point(617, 38);
            this.materialComboBoxMonitors.MaxDropDownItems = 4;
            this.materialComboBoxMonitors.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxMonitors.Name = "materialComboBoxMonitors";
            this.materialComboBoxMonitors.Size = new System.Drawing.Size(330, 49);
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
            this.materialButton1.Location = new System.Drawing.Point(737, 245);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(120, 21);
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
            this.searchInfoPage.Controls.Add(this.aiButton);
            this.searchInfoPage.ImageKey = "search.png";
            this.searchInfoPage.Location = new System.Drawing.Point(4, 39);
            this.searchInfoPage.Name = "searchInfoPage";
            this.searchInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchInfoPage.Size = new System.Drawing.Size(1556, 1274);
            this.searchInfoPage.TabIndex = 4;
            this.searchInfoPage.Text = "Search info";
            this.searchInfoPage.UseVisualStyleBackColor = true;
            this.searchInfoPage.Enter += new System.EventHandler(this.searchInfoPage_Enter);
            // 
            // aiButton
            // 
            this.aiButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aiButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.aiButton.Depth = 0;
            this.aiButton.HighEmphasis = true;
            this.aiButton.Icon = null;
            this.aiButton.Location = new System.Drawing.Point(446, 98);
            this.aiButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aiButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.aiButton.Name = "aiButton";
            this.aiButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.aiButton.Size = new System.Drawing.Size(64, 36);
            this.aiButton.TabIndex = 0;
            this.aiButton.Text = "ai";
            this.aiButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.aiButton.UseAccentColor = false;
            this.aiButton.UseVisualStyleBackColor = true;
            this.aiButton.Click += new System.EventHandler(this.aiButton_Click);
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
            this.testMonitorPage.Size = new System.Drawing.Size(1556, 1274);
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
            this.resolutionPage.Size = new System.Drawing.Size(1556, 1274);
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
            this.tabPage6.Size = new System.Drawing.Size(1556, 1274);
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
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(194, 130);
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
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
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
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.mainLabelTester.Location = new System.Drawing.Point(98, 0);
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
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tester:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.mainLabelTester);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 1331);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1564, 50);
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
            // Form1
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1570, 1384);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
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
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel12.PerformLayout();
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
            this.showInfoPage.ResumeLayout(false);
            this.showInfoPage.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchAssetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHdmi)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVga)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDvi)).EndInit();
            this.flowLayoutPanel13.ResumeLayout(false);
            this.flowLayoutPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisplayPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            this.searchInfoPage.ResumeLayout(false);
            this.searchInfoPage.PerformLayout();
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
            this.ResumeLayout(false);

        }

        private MaterialSkin.Controls.MaterialLabel labelMonitor;
        private MaterialSkin.Controls.MaterialLabel lableChanRes;
        private MaterialSkin.Controls.MaterialComboBox MonitorComboBox;
        private MaterialSkin.Controls.MaterialComboBox ResolutionComboBox;
        private MaterialSkin.Controls.MaterialButton SetMaxResolution;
        private MaterialSkin.Controls.MaterialButton SetResolution;
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
        private MaterialSkin.Controls.MaterialLabel labelProductCodePr;
        private MaterialSkin.Controls.MaterialLabel labelDatePr;
        private MaterialSkin.Controls.MaterialLabel labelSystemModelPr;
        private MaterialSkin.Controls.MaterialLabel labelManufacturerPr;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxTester;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxAutoShow;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
       
        private MaterialSkin.Controls.MaterialLabel labelSizePr;
        private MaterialSkin.Controls.MaterialLabel labelFrequencyPr;
        private MaterialSkin.Controls.MaterialLabel labelSerialPr;
        private MaterialSkin.Controls.MaterialLabel labelDiagonalPr;
        public MaterialComboBox materialComboBoxMonitors;
        public MaterialLabel materialLabelResolution;
        public MaterialLabel materialLabelSizeMonitor;
        public MaterialLabel materialLabelFrequency;
        public MaterialLabel materialLabelDiagonal;
        public MaterialLabel materialLabelProductCodeID;
        public MaterialLabel materialLabelMonthOfProduction;
        public MaterialLabel materialLabelYearOfProduction;
        public MaterialLabel systemModelLabel;
        public MaterialLabel materialLabelManufacturer;
        private MaterialLabel materialLabel13;
        private MaterialTextBox2 textBoxIdEVK;
        private MaterialButton sendButton;
        public MaterialSwitch materialSwitch1;
        private MaterialSlider materialSliderOpasity;
        private MaterialButton buttonTestingMonitor;
        private MaterialButton buttonServiceFixPixel;
        private MaterialCard materialCard2;
        private PictureBox searchAssetButton;
        private MaterialLabel labelAsWeightPr;
        private MaterialLabel labelAsResolutionPr;
        public MaterialLabel labelScreenFormat;
        private MaterialLabel labelAsScreenFormatPr;
        private MaterialLabel labelAsResponseTimePr;
        private PictureBox pictureBox2;
        private MaterialLabel labelAsTypePr;
        private MaterialLabel labelAsBiewAngles;
        private PictureBox pictureBox7;
        private PictureBox pictureBox4;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox15;
        private PictureBox pictureBox30;
        private PictureBox pictureBox32;
        private PictureBox pictureBox33;
        private PictureBox pictureBox22;
        private PictureBox pictureBox21;
        private PictureBox pictureBox23;
        private PictureBox pictureBox26;
        private PictureBox pictureBox27;
        public MaterialComboBox comboBoxCountry;
        private PictureBox pictureBox28;
        private MaterialLabel labelCountryPr;
        private PictureBox pictureBox35;
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
        private TableLayoutPanel tableLayoutPanel2;
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
        private MaterialCheckbox checkBoxAutoChangeMode;
        private FlowLayoutPanel flowLayoutPanel12;
        private MaterialComboBox comboBoxTypeScreen;
        private MaterialLabel labelStrAppCloseIn;
        internal MaterialLabel labelAppCloseIn;
        private MaterialButton aiButton;
        private FlowLayoutPanel flowLayoutPanel7;
        private FlowLayoutPanel flowLayoutPanel3;
        private MaterialCheckbox checkBoxHDMI;
        private NumericUpDown numericUpDownHdmi;
        private FlowLayoutPanel flowLayoutPanel4;
        private MaterialCheckbox checkBoxVGA;
        private NumericUpDown numericUpDownVga;
        private FlowLayoutPanel flowLayoutPanel6;
        private MaterialCheckbox checkBoxDVI;
        private NumericUpDown numericUpDownDvi;
        private FlowLayoutPanel flowLayoutPanel13;
        private MaterialCheckbox checkBoxDisplayPort;
        private NumericUpDown numericUpDownDisplayPort;
        public MaterialLabel materialLabelWeight;
        public MaterialLabel materialLabelViewingAngles;
        public MaterialLabel materialLabelResponseTime;
        public MaterialLabel materialLabelTypeMatrix;
        private MaterialLabel labelBrightnessPr;
        public MaterialLabel materialLabelBrightness;
        private MaterialLabel labelEvkModelPr;
        private PictureBox pictureBox1;
        public MaterialLabel labelEvkModel;
        internal MaterialTabControl materialTabControl1;
        internal TabPage tabPageMain;
        private MaterialButton buttonChangeMonitor;
    }
}

