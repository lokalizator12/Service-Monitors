using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;
using MaterialSkin.Controls;

namespace changeResolution1
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.MonitorComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.ResolutionComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SetMaxResolution = new MaterialSkin.Controls.MaterialButton();
            this.SetResolution = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialSliderOpasity = new MaterialSkin.Controls.MaterialSlider();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.textBoxTester = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.fullInfoPage = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialMultiLineTextBox6 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialMultiLineTextBox2 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.showInfoPage = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.searchAssetButton = new System.Windows.Forms.PictureBox();
            this.materialCheckbox14 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox13 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox12 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox11 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox10 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox9 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox8 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox7 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox6 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox5 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelManufacturer = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelModel = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxIdEVK = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelPPI = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelResolution = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelSizeMonitor = new MaterialSkin.Controls.MaterialLabel();
            this.ResolutionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelYearOfProduction = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelFrequency = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelMonthOfProduction = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelSerialNo = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelProductCodeID = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelDiagonal2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelDiagonal1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.sendButton = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBoxMonitors = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.searchInfoPage = new System.Windows.Forms.TabPage();
            this.testMonitorPage = new System.Windows.Forms.TabPage();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.buttonTestingMonitor = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.resolutionPage = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.item1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.disabledItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.item3ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.labelAssetIsCleaned = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetIsPictured = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetIsTested = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel27 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel28 = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetManufacturer = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetModel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel32 = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetCleaner = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel34 = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetCleaner1 = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetResolution = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel37 = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetTester = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel39 = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetYearProfuction = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetIdEvk = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetMonthOfProduction = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel43 = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetSerialNumber = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetProductCode = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel46 = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetDiagonal = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel48 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel49 = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetPlace = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetClass = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetDateTesting = new MaterialSkin.Controls.MaterialLabel();
            this.labelAssetDateCleaning = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.fullInfoPage.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.showInfoPage.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchAssetButton)).BeginInit();
            this.testMonitorPage.SuspendLayout();
            this.resolutionPage.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(81, 47);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 24;
            this.materialLabel1.Text = "Display";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(50, 124);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(129, 19);
            this.materialLabel2.TabIndex = 25;
            this.materialLabel2.Text = "Change resolution";
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
            this.ResolutionComboBox.SelectedIndexChanged += new System.EventHandler(this.ResolutionComboBox_SelectedIndexChanged);
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
            this.materialTabControl1.Controls.Add(this.tabPage1);
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
            this.materialTabControl1.Size = new System.Drawing.Size(971, 534);
            this.materialTabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialSliderOpasity);
            this.tabPage1.Controls.Add(this.materialCheckbox2);
            this.tabPage1.Controls.Add(this.materialCheckbox1);
            this.tabPage1.Controls.Add(this.textBoxTester);
            this.tabPage1.Controls.Add(this.materialSwitch1);
            this.tabPage1.ImageKey = "homepage.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(963, 491);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialSliderOpasity
            // 
            this.materialSliderOpasity.Depth = 0;
            this.materialSliderOpasity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSliderOpasity.Location = new System.Drawing.Point(166, 296);
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
            // materialCheckbox2
            // 
            this.materialCheckbox2.AutoSize = true;
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(81, 202);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.ReadOnly = false;
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(503, 37);
            this.materialCheckbox2.TabIndex = 40;
            this.materialCheckbox2.Text = "Automatically show info from serial number (only for one monitor)";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(81, 121);
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
            this.textBoxTester.Location = new System.Drawing.Point(81, 26);
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
            this.textBoxTester.Size = new System.Drawing.Size(250, 48);
            this.textBoxTester.TabIndex = 0;
            this.textBoxTester.TabStop = false;
            this.textBoxTester.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxTester.TrailingIcon = null;
            this.textBoxTester.UseSystemPasswordChar = false;
            this.textBoxTester.TextChanged += new System.EventHandler(this.textBoxTester_TextChanged);
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.BackColor = System.Drawing.Color.RosyBrown;
            this.materialSwitch1.Checked = true;
            this.materialSwitch1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(3, 296);
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
            // fullInfoPage
            // 
            this.fullInfoPage.BackColor = System.Drawing.Color.Transparent;
            this.fullInfoPage.Controls.Add(this.materialCard1);
            this.fullInfoPage.ImageKey = "info (2).png";
            this.fullInfoPage.Location = new System.Drawing.Point(4, 39);
            this.fullInfoPage.Name = "fullInfoPage";
            this.fullInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.fullInfoPage.Size = new System.Drawing.Size(947, 452);
            this.fullInfoPage.TabIndex = 3;
            this.fullInfoPage.Text = "Show full info";
            this.fullInfoPage.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialMultiLineTextBox6);
            this.materialCard1.Controls.Add(this.materialMultiLineTextBox2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(913, 343);
            this.materialCard1.TabIndex = 35;
            // 
            // materialMultiLineTextBox6
            // 
            this.materialMultiLineTextBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox6.Depth = 0;
            this.materialMultiLineTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox6.Location = new System.Drawing.Point(1165, 46);
            this.materialMultiLineTextBox6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox6.Name = "materialMultiLineTextBox6";
            this.materialMultiLineTextBox6.ReadOnly = true;
            this.materialMultiLineTextBox6.Size = new System.Drawing.Size(247, 523);
            this.materialMultiLineTextBox6.TabIndex = 34;
            this.materialMultiLineTextBox6.Text = "";
            // 
            // materialMultiLineTextBox2
            // 
            this.materialMultiLineTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox2.Depth = 0;
            this.materialMultiLineTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox2.Location = new System.Drawing.Point(17, 17);
            this.materialMultiLineTextBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox2.Name = "materialMultiLineTextBox2";
            this.materialMultiLineTextBox2.ReadOnly = true;
            this.materialMultiLineTextBox2.Size = new System.Drawing.Size(879, 314);
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
            this.showInfoPage.Size = new System.Drawing.Size(963, 491);
            this.showInfoPage.TabIndex = 1;
            this.showInfoPage.Text = "Show info";
            this.showInfoPage.Enter += new System.EventHandler(this.showInfoPage_Enter);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.searchAssetButton);
            this.materialCard2.Controls.Add(this.materialCheckbox14);
            this.materialCard2.Controls.Add(this.materialCheckbox13);
            this.materialCard2.Controls.Add(this.materialCheckbox12);
            this.materialCard2.Controls.Add(this.materialCheckbox11);
            this.materialCard2.Controls.Add(this.materialCheckbox10);
            this.materialCard2.Controls.Add(this.materialLabelDiagonal2);
            this.materialCard2.Controls.Add(this.materialCheckbox9);
            this.materialCard2.Controls.Add(this.materialCheckbox8);
            this.materialCard2.Controls.Add(this.materialCheckbox7);
            this.materialCard2.Controls.Add(this.materialCheckbox6);
            this.materialCard2.Controls.Add(this.materialCheckbox5);
            this.materialCard2.Controls.Add(this.materialCheckbox4);
            this.materialCard2.Controls.Add(this.materialCheckbox3);
            this.materialCard2.Controls.Add(this.materialLabel4);
            this.materialCard2.Controls.Add(this.materialLabel3);
            this.materialCard2.Controls.Add(this.materialLabelManufacturer);
            this.materialCard2.Controls.Add(this.materialLabel13);
            this.materialCard2.Controls.Add(this.materialLabelModel);
            this.materialCard2.Controls.Add(this.textBoxIdEVK);
            this.materialCard2.Controls.Add(this.materialLabel6);
            this.materialCard2.Controls.Add(this.materialLabelPPI);
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Controls.Add(this.materialLabel14);
            this.materialCard2.Controls.Add(this.materialLabelResolution);
            this.materialCard2.Controls.Add(this.materialLabel7);
            this.materialCard2.Controls.Add(this.materialLabelSizeMonitor);
            this.materialCard2.Controls.Add(this.ResolutionLabel);
            this.materialCard2.Controls.Add(this.materialLabelYearOfProduction);
            this.materialCard2.Controls.Add(this.materialLabelFrequency);
            this.materialCard2.Controls.Add(this.materialLabelMonthOfProduction);
            this.materialCard2.Controls.Add(this.materialLabel8);
            this.materialCard2.Controls.Add(this.materialLabelSerialNo);
            this.materialCard2.Controls.Add(this.materialLabelProductCodeID);
            this.materialCard2.Controls.Add(this.materialLabel9);
            this.materialCard2.Controls.Add(this.materialLabelDiagonal1);
            this.materialCard2.Controls.Add(this.materialLabel12);
            this.materialCard2.Controls.Add(this.materialLabel10);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 67);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(407, 407);
            this.materialCard2.TabIndex = 56;
            // 
            // searchAssetButton
            // 
            this.searchAssetButton.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.monitoring_test;
            this.searchAssetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchAssetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchAssetButton.Image = global::ServiceMonitorEVK.Properties.Resources.searchAsset;
            this.searchAssetButton.Location = new System.Drawing.Point(354, 351);
            this.searchAssetButton.Name = "searchAssetButton";
            this.searchAssetButton.Size = new System.Drawing.Size(40, 41);
            this.searchAssetButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchAssetButton.TabIndex = 59;
            this.searchAssetButton.TabStop = false;
            this.searchAssetButton.Click += new System.EventHandler(this.searchAssetButton_Click);
            // 
            // materialCheckbox14
            // 
            this.materialCheckbox14.AutoSize = true;
            this.materialCheckbox14.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox14.Checked = true;
            this.materialCheckbox14.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox14.Depth = 0;
            this.materialCheckbox14.Location = new System.Drawing.Point(13, 93);
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
            // materialCheckbox13
            // 
            this.materialCheckbox13.AutoSize = true;
            this.materialCheckbox13.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox13.Checked = true;
            this.materialCheckbox13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox13.Depth = 0;
            this.materialCheckbox13.Location = new System.Drawing.Point(14, 123);
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
            // materialCheckbox12
            // 
            this.materialCheckbox12.AutoSize = true;
            this.materialCheckbox12.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox12.Checked = true;
            this.materialCheckbox12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox12.Depth = 0;
            this.materialCheckbox12.Location = new System.Drawing.Point(13, 152);
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
            // materialCheckbox11
            // 
            this.materialCheckbox11.AutoSize = true;
            this.materialCheckbox11.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox11.Checked = true;
            this.materialCheckbox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox11.Depth = 0;
            this.materialCheckbox11.Location = new System.Drawing.Point(13, 182);
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
            // materialCheckbox10
            // 
            this.materialCheckbox10.AutoSize = true;
            this.materialCheckbox10.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox10.Checked = true;
            this.materialCheckbox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox10.Depth = 0;
            this.materialCheckbox10.Location = new System.Drawing.Point(13, 218);
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
            // materialCheckbox9
            // 
            this.materialCheckbox9.AutoSize = true;
            this.materialCheckbox9.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox9.Checked = true;
            this.materialCheckbox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox9.Depth = 0;
            this.materialCheckbox9.Location = new System.Drawing.Point(12, 247);
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
            // materialCheckbox8
            // 
            this.materialCheckbox8.AutoSize = true;
            this.materialCheckbox8.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox8.Checked = true;
            this.materialCheckbox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox8.Depth = 0;
            this.materialCheckbox8.Location = new System.Drawing.Point(12, 276);
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
            // materialCheckbox7
            // 
            this.materialCheckbox7.AutoSize = true;
            this.materialCheckbox7.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox7.Checked = true;
            this.materialCheckbox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox7.Depth = 0;
            this.materialCheckbox7.Location = new System.Drawing.Point(12, 309);
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
            // materialCheckbox6
            // 
            this.materialCheckbox6.AutoSize = true;
            this.materialCheckbox6.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox6.Checked = true;
            this.materialCheckbox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox6.Depth = 0;
            this.materialCheckbox6.Location = new System.Drawing.Point(18, 362);
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
            // materialCheckbox5
            // 
            this.materialCheckbox5.AutoSize = true;
            this.materialCheckbox5.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox5.Checked = true;
            this.materialCheckbox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox5.Depth = 0;
            this.materialCheckbox5.Location = new System.Drawing.Point(12, 60);
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
            // materialCheckbox4
            // 
            this.materialCheckbox4.AutoSize = true;
            this.materialCheckbox4.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox4.Checked = true;
            this.materialCheckbox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox4.Depth = 0;
            this.materialCheckbox4.Location = new System.Drawing.Point(13, 29);
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
            // materialCheckbox3
            // 
            this.materialCheckbox3.AutoSize = true;
            this.materialCheckbox3.BackColor = System.Drawing.Color.Transparent;
            this.materialCheckbox3.Checked = true;
            this.materialCheckbox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox3.Depth = 0;
            this.materialCheckbox3.Location = new System.Drawing.Point(13, 1);
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
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(59, 33);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(57, 24);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Model";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(59, 9);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(123, 24);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Manufacturer";
            // 
            // materialLabelManufacturer
            // 
            this.materialLabelManufacturer.AutoSize = true;
            this.materialLabelManufacturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelManufacturer.Depth = 0;
            this.materialLabelManufacturer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelManufacturer.HighEmphasis = true;
            this.materialLabelManufacturer.Location = new System.Drawing.Point(244, 10);
            this.materialLabelManufacturer.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelManufacturer.Name = "materialLabelManufacturer";
            this.materialLabelManufacturer.Size = new System.Drawing.Size(11, 19);
            this.materialLabelManufacturer.TabIndex = 39;
            this.materialLabelManufacturer.Text = ":)";
            this.materialLabelManufacturer.UseAccent = true;
            this.materialLabelManufacturer.Click += new System.EventHandler(this.materialLabelManufacturer_Click);
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel13.Location = new System.Drawing.Point(56, 365);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(60, 24);
            this.materialLabel13.TabIndex = 53;
            this.materialLabel13.Text = "Id EVK";
            // 
            // materialLabelModel
            // 
            this.materialLabelModel.AutoSize = true;
            this.materialLabelModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelModel.Depth = 0;
            this.materialLabelModel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelModel.Location = new System.Drawing.Point(244, 30);
            this.materialLabelModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelModel.Name = "materialLabelModel";
            this.materialLabelModel.Size = new System.Drawing.Size(11, 19);
            this.materialLabelModel.TabIndex = 40;
            this.materialLabelModel.Text = ":)";
            this.materialLabelModel.Click += new System.EventHandler(this.materialLabelModel_Click);
            // 
            // textBoxIdEVK
            // 
            this.textBoxIdEVK.AnimateReadOnly = false;
            this.textBoxIdEVK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxIdEVK.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxIdEVK.Depth = 0;
            this.textBoxIdEVK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxIdEVK.HelperText = "Insert ID EVK from monitor";
            this.textBoxIdEVK.HideSelection = true;
            this.textBoxIdEVK.Hint = "M*********";
            this.textBoxIdEVK.LeadingIcon = null;
            this.textBoxIdEVK.Location = new System.Drawing.Point(174, 344);
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
            this.textBoxIdEVK.TabIndex = 52;
            this.textBoxIdEVK.TabStop = false;
            this.textBoxIdEVK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxIdEVK.TrailingIcon = null;
            this.textBoxIdEVK.UseSystemPasswordChar = false;
            this.textBoxIdEVK.TextChanged += new System.EventHandler(this.textBoxIdEVK_TextChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(59, 96);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(182, 24);
            this.materialLabel6.TabIndex = 3;
            this.materialLabel6.Text = "Month of production";
            // 
            // materialLabelPPI
            // 
            this.materialLabelPPI.AutoSize = true;
            this.materialLabelPPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelPPI.Depth = 0;
            this.materialLabelPPI.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelPPI.Location = new System.Drawing.Point(245, 318);
            this.materialLabelPPI.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelPPI.Name = "materialLabelPPI";
            this.materialLabelPPI.Size = new System.Drawing.Size(11, 19);
            this.materialLabelPPI.TabIndex = 50;
            this.materialLabelPPI.Text = ":)";
            this.materialLabelPPI.Click += new System.EventHandler(this.materialLabelPPI_Click_1);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(60, 63);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(165, 24);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Year of production";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel14.Location = new System.Drawing.Point(59, 313);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(33, 24);
            this.materialLabel14.TabIndex = 38;
            this.materialLabel14.Text = "PPI";
            // 
            // materialLabelResolution
            // 
            this.materialLabelResolution.AutoSize = true;
            this.materialLabelResolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelResolution.Depth = 0;
            this.materialLabelResolution.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelResolution.Location = new System.Drawing.Point(244, 285);
            this.materialLabelResolution.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelResolution.Name = "materialLabelResolution";
            this.materialLabelResolution.Size = new System.Drawing.Size(11, 19);
            this.materialLabelResolution.TabIndex = 49;
            this.materialLabelResolution.Text = ":)";
            this.materialLabelResolution.Click += new System.EventHandler(this.materialLabelResolution_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(59, 127);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(143, 24);
            this.materialLabel7.TabIndex = 4;
            this.materialLabel7.Text = "Product code ID";
            // 
            // materialLabelSizeMonitor
            // 
            this.materialLabelSizeMonitor.AutoSize = true;
            this.materialLabelSizeMonitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelSizeMonitor.Depth = 0;
            this.materialLabelSizeMonitor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelSizeMonitor.Location = new System.Drawing.Point(244, 253);
            this.materialLabelSizeMonitor.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelSizeMonitor.Name = "materialLabelSizeMonitor";
            this.materialLabelSizeMonitor.Size = new System.Drawing.Size(11, 19);
            this.materialLabelSizeMonitor.TabIndex = 48;
            this.materialLabelSizeMonitor.Text = ":)";
            this.materialLabelSizeMonitor.Click += new System.EventHandler(this.materialLabelSizeMonitor_Click);
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Depth = 0;
            this.ResolutionLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ResolutionLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.ResolutionLabel.Location = new System.Drawing.Point(59, 279);
            this.ResolutionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(95, 24);
            this.ResolutionLabel.TabIndex = 37;
            this.ResolutionLabel.Text = "Resolution";
            // 
            // materialLabelYearOfProduction
            // 
            this.materialLabelYearOfProduction.AutoSize = true;
            this.materialLabelYearOfProduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelYearOfProduction.Depth = 0;
            this.materialLabelYearOfProduction.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelYearOfProduction.Location = new System.Drawing.Point(245, 63);
            this.materialLabelYearOfProduction.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelYearOfProduction.Name = "materialLabelYearOfProduction";
            this.materialLabelYearOfProduction.Size = new System.Drawing.Size(11, 19);
            this.materialLabelYearOfProduction.TabIndex = 41;
            this.materialLabelYearOfProduction.Text = ":)";
            this.materialLabelYearOfProduction.Click += new System.EventHandler(this.materialLabelYearOfProduction_Click);
            // 
            // materialLabelFrequency
            // 
            this.materialLabelFrequency.AutoSize = true;
            this.materialLabelFrequency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelFrequency.Depth = 0;
            this.materialLabelFrequency.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelFrequency.Location = new System.Drawing.Point(245, 221);
            this.materialLabelFrequency.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelFrequency.Name = "materialLabelFrequency";
            this.materialLabelFrequency.Size = new System.Drawing.Size(11, 19);
            this.materialLabelFrequency.TabIndex = 47;
            this.materialLabelFrequency.Text = ":)";
            this.materialLabelFrequency.Click += new System.EventHandler(this.materialLabelFrequency_Click);
            // 
            // materialLabelMonthOfProduction
            // 
            this.materialLabelMonthOfProduction.AutoSize = true;
            this.materialLabelMonthOfProduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelMonthOfProduction.Depth = 0;
            this.materialLabelMonthOfProduction.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelMonthOfProduction.Location = new System.Drawing.Point(244, 96);
            this.materialLabelMonthOfProduction.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelMonthOfProduction.Name = "materialLabelMonthOfProduction";
            this.materialLabelMonthOfProduction.Size = new System.Drawing.Size(11, 19);
            this.materialLabelMonthOfProduction.TabIndex = 42;
            this.materialLabelMonthOfProduction.Text = ":)";
            this.materialLabelMonthOfProduction.Click += new System.EventHandler(this.materialLabelMonthOfProduction_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(59, 250);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(165, 24);
            this.materialLabel8.TabIndex = 36;
            this.materialLabel8.Text = "Size monitor (cm.)";
            // 
            // materialLabelSerialNo
            // 
            this.materialLabelSerialNo.AutoSize = true;
            this.materialLabelSerialNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelSerialNo.Depth = 0;
            this.materialLabelSerialNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelSerialNo.Location = new System.Drawing.Point(245, 190);
            this.materialLabelSerialNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelSerialNo.Name = "materialLabelSerialNo";
            this.materialLabelSerialNo.Size = new System.Drawing.Size(11, 19);
            this.materialLabelSerialNo.TabIndex = 46;
            this.materialLabelSerialNo.Text = ":)";
            this.materialLabelSerialNo.Click += new System.EventHandler(this.materialLabelSerialNo_Click);
            // 
            // materialLabelProductCodeID
            // 
            this.materialLabelProductCodeID.AutoSize = true;
            this.materialLabelProductCodeID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelProductCodeID.Depth = 0;
            this.materialLabelProductCodeID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelProductCodeID.Location = new System.Drawing.Point(244, 132);
            this.materialLabelProductCodeID.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelProductCodeID.Name = "materialLabelProductCodeID";
            this.materialLabelProductCodeID.Size = new System.Drawing.Size(11, 19);
            this.materialLabelProductCodeID.TabIndex = 43;
            this.materialLabelProductCodeID.Text = ":)";
            this.materialLabelProductCodeID.Click += new System.EventHandler(this.materialLabelProductCodeID_Click);
            // 
            // materialLabelDiagonal2
            // 
            this.materialLabelDiagonal2.AutoSize = true;
            this.materialLabelDiagonal2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelDiagonal2.Depth = 0;
            this.materialLabelDiagonal2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelDiagonal2.Location = new System.Drawing.Point(351, 162);
            this.materialLabelDiagonal2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDiagonal2.Name = "materialLabelDiagonal2";
            this.materialLabelDiagonal2.Size = new System.Drawing.Size(11, 19);
            this.materialLabelDiagonal2.TabIndex = 45;
            this.materialLabelDiagonal2.Text = ":)";
            this.materialLabelDiagonal2.Click += new System.EventHandler(this.materialLabelDiagonal2_Click);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel9.Location = new System.Drawing.Point(60, 221);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(94, 24);
            this.materialLabel9.TabIndex = 35;
            this.materialLabel9.Text = "Frequency";
            // 
            // materialLabelDiagonal1
            // 
            this.materialLabelDiagonal1.AutoSize = true;
            this.materialLabelDiagonal1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelDiagonal1.Depth = 0;
            this.materialLabelDiagonal1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelDiagonal1.Location = new System.Drawing.Point(244, 161);
            this.materialLabelDiagonal1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDiagonal1.Name = "materialLabelDiagonal1";
            this.materialLabelDiagonal1.Size = new System.Drawing.Size(11, 19);
            this.materialLabelDiagonal1.TabIndex = 44;
            this.materialLabelDiagonal1.Text = ":)";
            this.materialLabelDiagonal1.Click += new System.EventHandler(this.materialLabelDiagonal1_Click);
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel12.Location = new System.Drawing.Point(60, 156);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(138, 24);
            this.materialLabel12.TabIndex = 32;
            this.materialLabel12.Text = "Diagonal (H\\W)";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel10.Location = new System.Drawing.Point(59, 185);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(88, 24);
            this.materialLabel10.TabIndex = 34;
            this.materialLabel10.Text = "Serial No.";
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
            this.sendButton.Location = new System.Drawing.Point(246, 38);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sendButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendButton.Name = "sendButton";
            this.sendButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.sendButton.Size = new System.Drawing.Size(175, 22);
            this.sendButton.TabIndex = 54;
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
            this.materialComboBoxMonitors.Location = new System.Drawing.Point(17, 16);
            this.materialComboBoxMonitors.MaxDropDownItems = 4;
            this.materialComboBoxMonitors.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxMonitors.Name = "materialComboBoxMonitors";
            this.materialComboBoxMonitors.Size = new System.Drawing.Size(222, 49);
            this.materialComboBoxMonitors.Sorted = true;
            this.materialComboBoxMonitors.StartIndex = 0;
            this.materialComboBoxMonitors.TabIndex = 31;
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
            this.materialButton1.Location = new System.Drawing.Point(246, 9);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(175, 23);
            this.materialButton1.TabIndex = 30;
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
            this.searchInfoPage.Size = new System.Drawing.Size(963, 491);
            this.searchInfoPage.TabIndex = 4;
            this.searchInfoPage.Text = "Search info";
            this.searchInfoPage.UseVisualStyleBackColor = true;
            this.searchInfoPage.Enter += new System.EventHandler(this.searchInfoPage_Enter);
            // 
            // testMonitorPage
            // 
            this.testMonitorPage.Controls.Add(this.materialButton3);
            this.testMonitorPage.Controls.Add(this.buttonTestingMonitor);
            this.testMonitorPage.ImageKey = "monitoring-test.png";
            this.testMonitorPage.Location = new System.Drawing.Point(4, 39);
            this.testMonitorPage.Name = "testMonitorPage";
            this.testMonitorPage.Padding = new System.Windows.Forms.Padding(3);
            this.testMonitorPage.Size = new System.Drawing.Size(963, 491);
            this.testMonitorPage.TabIndex = 6;
            this.testMonitorPage.Text = "Service";
            this.testMonitorPage.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = global::ServiceMonitorEVK.Properties.Resources.fix__1_;
            this.materialButton3.Location = new System.Drawing.Point(367, 32);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(417, 36);
            this.materialButton3.TabIndex = 56;
            this.materialButton3.Text = "Fixing bad pixels";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
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
            // 
            // resolutionPage
            // 
            this.resolutionPage.BackColor = System.Drawing.Color.Transparent;
            this.resolutionPage.Controls.Add(this.MonitorComboBox);
            this.resolutionPage.Controls.Add(this.materialLabel1);
            this.resolutionPage.Controls.Add(this.ResolutionComboBox);
            this.resolutionPage.Controls.Add(this.materialLabel2);
            this.resolutionPage.Controls.Add(this.SetResolution);
            this.resolutionPage.Controls.Add(this.SetMaxResolution);
            this.resolutionPage.ImageKey = "resolution.png";
            this.resolutionPage.Location = new System.Drawing.Point(4, 39);
            this.resolutionPage.Name = "resolutionPage";
            this.resolutionPage.Padding = new System.Windows.Forms.Padding(3);
            this.resolutionPage.Size = new System.Drawing.Size(947, 452);
            this.resolutionPage.TabIndex = 0;
            this.resolutionPage.Text = "Resolution";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button7);
            this.tabPage6.Controls.Add(this.button5);
            this.tabPage6.Controls.Add(this.button4);
            this.tabPage6.Controls.Add(this.button3);
            this.tabPage6.Controls.Add(this.button2);
            this.tabPage6.Controls.Add(this.pictureBox1);
            this.tabPage6.Location = new System.Drawing.Point(4, 39);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(947, 452);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "test";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(245, 261);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 27;
            this.button7.Text = "search info";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(447, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 23);
            this.button5.TabIndex = 26;
            this.button5.Text = "secondary only";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(326, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "primary only";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(445, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "extend";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "duplicate";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ServiceMonitorEVK.Properties.Resources.DA;
            this.pictureBox1.Location = new System.Drawing.Point(225, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
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
            this.pictureBoxLogo.Location = new System.Drawing.Point(827, 28);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(97, 33);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 41;
            this.pictureBoxLogo.TabStop = false;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.pictureBox2);
            this.materialCard3.Controls.Add(this.labelAssetDateCleaning);
            this.materialCard3.Controls.Add(this.labelAssetDateTesting);
            this.materialCard3.Controls.Add(this.labelAssetClass);
            this.materialCard3.Controls.Add(this.materialLabel18);
            this.materialCard3.Controls.Add(this.labelAssetPlace);
            this.materialCard3.Controls.Add(this.materialLabel16);
            this.materialCard3.Controls.Add(this.labelAssetIsCleaned);
            this.materialCard3.Controls.Add(this.materialLabel22);
            this.materialCard3.Controls.Add(this.labelAssetIsPictured);
            this.materialCard3.Controls.Add(this.materialLabel24);
            this.materialCard3.Controls.Add(this.labelAssetIsTested);
            this.materialCard3.Controls.Add(this.materialLabel26);
            this.materialCard3.Controls.Add(this.materialLabel27);
            this.materialCard3.Controls.Add(this.materialLabel28);
            this.materialCard3.Controls.Add(this.labelAssetManufacturer);
            this.materialCard3.Controls.Add(this.labelAssetModel);
            this.materialCard3.Controls.Add(this.materialLabel32);
            this.materialCard3.Controls.Add(this.labelAssetCleaner);
            this.materialCard3.Controls.Add(this.materialLabel34);
            this.materialCard3.Controls.Add(this.labelAssetCleaner1);
            this.materialCard3.Controls.Add(this.labelAssetResolution);
            this.materialCard3.Controls.Add(this.materialLabel37);
            this.materialCard3.Controls.Add(this.labelAssetTester);
            this.materialCard3.Controls.Add(this.materialLabel39);
            this.materialCard3.Controls.Add(this.labelAssetYearProfuction);
            this.materialCard3.Controls.Add(this.labelAssetIdEvk);
            this.materialCard3.Controls.Add(this.labelAssetMonthOfProduction);
            this.materialCard3.Controls.Add(this.materialLabel43);
            this.materialCard3.Controls.Add(this.labelAssetSerialNumber);
            this.materialCard3.Controls.Add(this.labelAssetProductCode);
            this.materialCard3.Controls.Add(this.materialLabel46);
            this.materialCard3.Controls.Add(this.labelAssetDiagonal);
            this.materialCard3.Controls.Add(this.materialLabel48);
            this.materialCard3.Controls.Add(this.materialLabel49);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(464, 9);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(482, 473);
            this.materialCard3.TabIndex = 72;
            // 
            // labelAssetIsCleaned
            // 
            this.labelAssetIsCleaned.AutoSize = true;
            this.labelAssetIsCleaned.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetIsCleaned.Depth = 0;
            this.labelAssetIsCleaned.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetIsCleaned.Location = new System.Drawing.Point(204, 398);
            this.labelAssetIsCleaned.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetIsCleaned.Name = "labelAssetIsCleaned";
            this.labelAssetIsCleaned.Size = new System.Drawing.Size(11, 19);
            this.labelAssetIsCleaned.TabIndex = 71;
            this.labelAssetIsCleaned.Text = ":)";
            // 
            // materialLabel22
            // 
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel22.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel22.Location = new System.Drawing.Point(18, 393);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(84, 24);
            this.materialLabel22.TabIndex = 70;
            this.materialLabel22.Text = "Cleaned?";
            // 
            // labelAssetIsPictured
            // 
            this.labelAssetIsPictured.AutoSize = true;
            this.labelAssetIsPictured.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetIsPictured.Depth = 0;
            this.labelAssetIsPictured.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetIsPictured.Location = new System.Drawing.Point(204, 370);
            this.labelAssetIsPictured.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetIsPictured.Name = "labelAssetIsPictured";
            this.labelAssetIsPictured.Size = new System.Drawing.Size(11, 19);
            this.labelAssetIsPictured.TabIndex = 69;
            this.labelAssetIsPictured.Text = ":)";
            // 
            // materialLabel24
            // 
            this.materialLabel24.AutoSize = true;
            this.materialLabel24.Depth = 0;
            this.materialLabel24.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel24.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel24.Location = new System.Drawing.Point(18, 365);
            this.materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel24.Name = "materialLabel24";
            this.materialLabel24.Size = new System.Drawing.Size(86, 24);
            this.materialLabel24.TabIndex = 68;
            this.materialLabel24.Text = "Pictured?";
            // 
            // labelAssetIsTested
            // 
            this.labelAssetIsTested.AutoSize = true;
            this.labelAssetIsTested.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetIsTested.Depth = 0;
            this.labelAssetIsTested.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetIsTested.Location = new System.Drawing.Point(203, 346);
            this.labelAssetIsTested.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetIsTested.Name = "labelAssetIsTested";
            this.labelAssetIsTested.Size = new System.Drawing.Size(11, 19);
            this.labelAssetIsTested.TabIndex = 67;
            this.labelAssetIsTested.Text = ":)";
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel26.Location = new System.Drawing.Point(17, 341);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(73, 24);
            this.materialLabel26.TabIndex = 66;
            this.materialLabel26.Text = "Tested?";
            // 
            // materialLabel27
            // 
            this.materialLabel27.AutoSize = true;
            this.materialLabel27.Depth = 0;
            this.materialLabel27.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel27.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel27.Location = new System.Drawing.Point(16, 71);
            this.materialLabel27.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel27.Name = "materialLabel27";
            this.materialLabel27.Size = new System.Drawing.Size(57, 24);
            this.materialLabel27.TabIndex = 1;
            this.materialLabel27.Text = "Model";
            // 
            // materialLabel28
            // 
            this.materialLabel28.AutoSize = true;
            this.materialLabel28.Depth = 0;
            this.materialLabel28.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel28.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel28.Location = new System.Drawing.Point(16, 47);
            this.materialLabel28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel28.Name = "materialLabel28";
            this.materialLabel28.Size = new System.Drawing.Size(123, 24);
            this.materialLabel28.TabIndex = 0;
            this.materialLabel28.Text = "Manufacturer";
            // 
            // labelAssetManufacturer
            // 
            this.labelAssetManufacturer.AutoSize = true;
            this.labelAssetManufacturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetManufacturer.Depth = 0;
            this.labelAssetManufacturer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetManufacturer.HighEmphasis = true;
            this.labelAssetManufacturer.Location = new System.Drawing.Point(201, 48);
            this.labelAssetManufacturer.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetManufacturer.Name = "labelAssetManufacturer";
            this.labelAssetManufacturer.Size = new System.Drawing.Size(11, 19);
            this.labelAssetManufacturer.TabIndex = 39;
            this.labelAssetManufacturer.Text = ":)";
            this.labelAssetManufacturer.UseAccent = true;
            // 
            // labelAssetModel
            // 
            this.labelAssetModel.AutoSize = true;
            this.labelAssetModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetModel.Depth = 0;
            this.labelAssetModel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetModel.Location = new System.Drawing.Point(201, 68);
            this.labelAssetModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetModel.Name = "labelAssetModel";
            this.labelAssetModel.Size = new System.Drawing.Size(11, 19);
            this.labelAssetModel.TabIndex = 40;
            this.labelAssetModel.Text = ":)";
            // 
            // materialLabel32
            // 
            this.materialLabel32.AutoSize = true;
            this.materialLabel32.Depth = 0;
            this.materialLabel32.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel32.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel32.Location = new System.Drawing.Point(16, 134);
            this.materialLabel32.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel32.Name = "materialLabel32";
            this.materialLabel32.Size = new System.Drawing.Size(182, 24);
            this.materialLabel32.TabIndex = 3;
            this.materialLabel32.Text = "Month of production";
            // 
            // labelAssetCleaner
            // 
            this.labelAssetCleaner.AutoSize = true;
            this.labelAssetCleaner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetCleaner.Depth = 0;
            this.labelAssetCleaner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetCleaner.Location = new System.Drawing.Point(203, 318);
            this.labelAssetCleaner.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetCleaner.Name = "labelAssetCleaner";
            this.labelAssetCleaner.Size = new System.Drawing.Size(11, 19);
            this.labelAssetCleaner.TabIndex = 50;
            this.labelAssetCleaner.Text = ":)";
            // 
            // materialLabel34
            // 
            this.materialLabel34.AutoSize = true;
            this.materialLabel34.Depth = 0;
            this.materialLabel34.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel34.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel34.Location = new System.Drawing.Point(16, 94);
            this.materialLabel34.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel34.Name = "materialLabel34";
            this.materialLabel34.Size = new System.Drawing.Size(165, 24);
            this.materialLabel34.TabIndex = 2;
            this.materialLabel34.Text = "Year of production";
            // 
            // labelAssetCleaner1
            // 
            this.labelAssetCleaner1.AutoSize = true;
            this.labelAssetCleaner1.Depth = 0;
            this.labelAssetCleaner1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetCleaner1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAssetCleaner1.Location = new System.Drawing.Point(17, 313);
            this.labelAssetCleaner1.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetCleaner1.Name = "labelAssetCleaner1";
            this.labelAssetCleaner1.Size = new System.Drawing.Size(70, 24);
            this.labelAssetCleaner1.TabIndex = 38;
            this.labelAssetCleaner1.Text = "Cleaner";
            // 
            // labelAssetResolution
            // 
            this.labelAssetResolution.AutoSize = true;
            this.labelAssetResolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetResolution.Depth = 0;
            this.labelAssetResolution.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetResolution.Location = new System.Drawing.Point(203, 257);
            this.labelAssetResolution.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetResolution.Name = "labelAssetResolution";
            this.labelAssetResolution.Size = new System.Drawing.Size(11, 19);
            this.labelAssetResolution.TabIndex = 49;
            this.labelAssetResolution.Text = ":)";
            // 
            // materialLabel37
            // 
            this.materialLabel37.AutoSize = true;
            this.materialLabel37.Depth = 0;
            this.materialLabel37.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel37.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel37.Location = new System.Drawing.Point(16, 165);
            this.materialLabel37.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel37.Name = "materialLabel37";
            this.materialLabel37.Size = new System.Drawing.Size(143, 24);
            this.materialLabel37.TabIndex = 4;
            this.materialLabel37.Text = "Product code ID";
            // 
            // labelAssetTester
            // 
            this.labelAssetTester.AutoSize = true;
            this.labelAssetTester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetTester.Depth = 0;
            this.labelAssetTester.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetTester.Location = new System.Drawing.Point(203, 282);
            this.labelAssetTester.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetTester.Name = "labelAssetTester";
            this.labelAssetTester.Size = new System.Drawing.Size(11, 19);
            this.labelAssetTester.TabIndex = 48;
            this.labelAssetTester.Text = ":)";
            // 
            // materialLabel39
            // 
            this.materialLabel39.AutoSize = true;
            this.materialLabel39.Depth = 0;
            this.materialLabel39.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel39.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel39.Location = new System.Drawing.Point(18, 251);
            this.materialLabel39.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel39.Name = "materialLabel39";
            this.materialLabel39.Size = new System.Drawing.Size(95, 24);
            this.materialLabel39.TabIndex = 37;
            this.materialLabel39.Text = "Resolution";
            // 
            // labelAssetYearProfuction
            // 
            this.labelAssetYearProfuction.AutoSize = true;
            this.labelAssetYearProfuction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetYearProfuction.Depth = 0;
            this.labelAssetYearProfuction.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetYearProfuction.Location = new System.Drawing.Point(202, 101);
            this.labelAssetYearProfuction.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetYearProfuction.Name = "labelAssetYearProfuction";
            this.labelAssetYearProfuction.Size = new System.Drawing.Size(11, 19);
            this.labelAssetYearProfuction.TabIndex = 41;
            this.labelAssetYearProfuction.Text = ":)";
            // 
            // labelAssetIdEvk
            // 
            this.labelAssetIdEvk.AutoSize = true;
            this.labelAssetIdEvk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetIdEvk.Depth = 0;
            this.labelAssetIdEvk.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetIdEvk.Location = new System.Drawing.Point(203, 7);
            this.labelAssetIdEvk.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetIdEvk.Name = "labelAssetIdEvk";
            this.labelAssetIdEvk.Size = new System.Drawing.Size(11, 19);
            this.labelAssetIdEvk.TabIndex = 47;
            this.labelAssetIdEvk.Text = ":)";
            // 
            // labelAssetMonthOfProduction
            // 
            this.labelAssetMonthOfProduction.AutoSize = true;
            this.labelAssetMonthOfProduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetMonthOfProduction.Depth = 0;
            this.labelAssetMonthOfProduction.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetMonthOfProduction.Location = new System.Drawing.Point(201, 134);
            this.labelAssetMonthOfProduction.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetMonthOfProduction.Name = "labelAssetMonthOfProduction";
            this.labelAssetMonthOfProduction.Size = new System.Drawing.Size(11, 19);
            this.labelAssetMonthOfProduction.TabIndex = 42;
            this.labelAssetMonthOfProduction.Text = ":)";
            // 
            // materialLabel43
            // 
            this.materialLabel43.AutoSize = true;
            this.materialLabel43.Depth = 0;
            this.materialLabel43.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel43.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel43.Location = new System.Drawing.Point(18, 279);
            this.materialLabel43.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel43.Name = "materialLabel43";
            this.materialLabel43.Size = new System.Drawing.Size(59, 24);
            this.materialLabel43.TabIndex = 36;
            this.materialLabel43.Text = "Tester";
            // 
            // labelAssetSerialNumber
            // 
            this.labelAssetSerialNumber.AutoSize = true;
            this.labelAssetSerialNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetSerialNumber.Depth = 0;
            this.labelAssetSerialNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetSerialNumber.Location = new System.Drawing.Point(202, 228);
            this.labelAssetSerialNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetSerialNumber.Name = "labelAssetSerialNumber";
            this.labelAssetSerialNumber.Size = new System.Drawing.Size(11, 19);
            this.labelAssetSerialNumber.TabIndex = 46;
            this.labelAssetSerialNumber.Text = ":)";
            // 
            // labelAssetProductCode
            // 
            this.labelAssetProductCode.AutoSize = true;
            this.labelAssetProductCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetProductCode.Depth = 0;
            this.labelAssetProductCode.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetProductCode.Location = new System.Drawing.Point(201, 170);
            this.labelAssetProductCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetProductCode.Name = "labelAssetProductCode";
            this.labelAssetProductCode.Size = new System.Drawing.Size(11, 19);
            this.labelAssetProductCode.TabIndex = 43;
            this.labelAssetProductCode.Text = ":)";
            // 
            // materialLabel46
            // 
            this.materialLabel46.AutoSize = true;
            this.materialLabel46.Depth = 0;
            this.materialLabel46.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel46.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel46.Location = new System.Drawing.Point(18, 7);
            this.materialLabel46.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel46.Name = "materialLabel46";
            this.materialLabel46.Size = new System.Drawing.Size(62, 24);
            this.materialLabel46.TabIndex = 35;
            this.materialLabel46.Text = "ID EVK";
            // 
            // labelAssetDiagonal
            // 
            this.labelAssetDiagonal.AutoSize = true;
            this.labelAssetDiagonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetDiagonal.Depth = 0;
            this.labelAssetDiagonal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetDiagonal.Location = new System.Drawing.Point(201, 199);
            this.labelAssetDiagonal.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetDiagonal.Name = "labelAssetDiagonal";
            this.labelAssetDiagonal.Size = new System.Drawing.Size(11, 19);
            this.labelAssetDiagonal.TabIndex = 44;
            this.labelAssetDiagonal.Text = ":)";
            // 
            // materialLabel48
            // 
            this.materialLabel48.AutoSize = true;
            this.materialLabel48.Depth = 0;
            this.materialLabel48.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel48.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel48.Location = new System.Drawing.Point(17, 194);
            this.materialLabel48.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel48.Name = "materialLabel48";
            this.materialLabel48.Size = new System.Drawing.Size(138, 24);
            this.materialLabel48.TabIndex = 32;
            this.materialLabel48.Text = "Diagonal (H\\W)";
            // 
            // materialLabel49
            // 
            this.materialLabel49.AutoSize = true;
            this.materialLabel49.Depth = 0;
            this.materialLabel49.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel49.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel49.Location = new System.Drawing.Point(16, 223);
            this.materialLabel49.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel49.Name = "materialLabel49";
            this.materialLabel49.Size = new System.Drawing.Size(88, 24);
            this.materialLabel49.TabIndex = 34;
            this.materialLabel49.Text = "Serial No.";
            // 
            // labelAssetPlace
            // 
            this.labelAssetPlace.AutoSize = true;
            this.labelAssetPlace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetPlace.Depth = 0;
            this.labelAssetPlace.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetPlace.Location = new System.Drawing.Point(204, 422);
            this.labelAssetPlace.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetPlace.Name = "labelAssetPlace";
            this.labelAssetPlace.Size = new System.Drawing.Size(11, 19);
            this.labelAssetPlace.TabIndex = 73;
            this.labelAssetPlace.Text = ":)";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel16.Location = new System.Drawing.Point(18, 417);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(51, 24);
            this.materialLabel16.TabIndex = 72;
            this.materialLabel16.Text = "Place";
            // 
            // labelAssetClass
            // 
            this.labelAssetClass.AutoSize = true;
            this.labelAssetClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetClass.Depth = 0;
            this.labelAssetClass.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetClass.Location = new System.Drawing.Point(204, 446);
            this.labelAssetClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetClass.Name = "labelAssetClass";
            this.labelAssetClass.Size = new System.Drawing.Size(11, 19);
            this.labelAssetClass.TabIndex = 75;
            this.labelAssetClass.Text = ":)";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel18.Location = new System.Drawing.Point(18, 441);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(50, 24);
            this.materialLabel18.TabIndex = 74;
            this.materialLabel18.Text = "Class";
            // 
            // labelAssetDateTesting
            // 
            this.labelAssetDateTesting.AutoSize = true;
            this.labelAssetDateTesting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetDateTesting.Depth = 0;
            this.labelAssetDateTesting.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetDateTesting.Location = new System.Drawing.Point(293, 346);
            this.labelAssetDateTesting.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetDateTesting.Name = "labelAssetDateTesting";
            this.labelAssetDateTesting.Size = new System.Drawing.Size(11, 19);
            this.labelAssetDateTesting.TabIndex = 76;
            this.labelAssetDateTesting.Text = ":)";
            // 
            // labelAssetDateCleaning
            // 
            this.labelAssetDateCleaning.AutoSize = true;
            this.labelAssetDateCleaning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAssetDateCleaning.Depth = 0;
            this.labelAssetDateCleaning.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAssetDateCleaning.Location = new System.Drawing.Point(293, 393);
            this.labelAssetDateCleaning.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAssetDateCleaning.Name = "labelAssetDateCleaning";
            this.labelAssetDateCleaning.Size = new System.Drawing.Size(11, 19);
            this.labelAssetDateCleaning.TabIndex = 78;
            this.labelAssetDateCleaning.Text = ":)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(328, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 100);
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(977, 601);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoShow = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerUseColors = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Monitor";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.fullInfoPage.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.showInfoPage.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchAssetButton)).EndInit();
            this.testMonitorPage.ResumeLayout(false);
            this.resolutionPage.ResumeLayout(false);
            this.resolutionPage.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
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
        private Button button7;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxTester;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
       
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel ResolutionLabel;
        public MaterialComboBox materialComboBoxMonitors;
        public MaterialLabel materialLabelPPI;
        public MaterialLabel materialLabelResolution;
        public MaterialLabel materialLabelSizeMonitor;
        public MaterialLabel materialLabelFrequency;
        public MaterialLabel materialLabelSerialNo;
        public MaterialLabel materialLabelDiagonal2;
        public MaterialLabel materialLabelDiagonal1;
        public MaterialLabel materialLabelProductCodeID;
        public MaterialLabel materialLabelMonthOfProduction;
        public MaterialLabel materialLabelYearOfProduction;
        public MaterialLabel materialLabelModel;
        public MaterialLabel materialLabelManufacturer;
        private PictureBox pictureBoxLogo;
        private MaterialLabel materialLabel13;
        private MaterialTextBox2 textBoxIdEVK;
        private MaterialButton sendButton;
        public MaterialSwitch materialSwitch1;
        private MaterialSlider materialSliderOpasity;
        private MaterialButton buttonTestingMonitor;
        private MaterialButton materialButton3;
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
        private MaterialLabel materialLabel22;
        public MaterialLabel labelAssetIsPictured;
        private MaterialLabel materialLabel24;
        public MaterialLabel labelAssetIsTested;
        private MaterialLabel materialLabel26;
        private MaterialLabel materialLabel27;
        private MaterialLabel materialLabel28;
        public MaterialLabel labelAssetManufacturer;
        public MaterialLabel labelAssetModel;
        private MaterialLabel materialLabel32;
        public MaterialLabel labelAssetCleaner;
        private MaterialLabel materialLabel34;
        private MaterialLabel labelAssetCleaner1;
        public MaterialLabel labelAssetResolution;
        private MaterialLabel materialLabel37;
        public MaterialLabel labelAssetTester;
        private MaterialLabel materialLabel39;
        public MaterialLabel labelAssetYearProfuction;
        public MaterialLabel labelAssetIdEvk;
        public MaterialLabel labelAssetMonthOfProduction;
        private MaterialLabel materialLabel43;
        public MaterialLabel labelAssetSerialNumber;
        public MaterialLabel labelAssetProductCode;
        private MaterialLabel materialLabel46;
        public MaterialLabel labelAssetDiagonal;
        private MaterialLabel materialLabel48;
        private MaterialLabel materialLabel49;
        public MaterialLabel labelAssetClass;
        private MaterialLabel materialLabel18;
        public MaterialLabel labelAssetPlace;
        private MaterialLabel materialLabel16;
        public MaterialLabel labelAssetDateCleaning;
        public MaterialLabel labelAssetDateTesting;
        private PictureBox pictureBox2;
    }
}

