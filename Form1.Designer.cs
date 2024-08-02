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
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.textBoxTester = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.fullInfoPage = new System.Windows.Forms.TabPage();
            this.materialMultiLineTextBox6 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialMultiLineTextBox5 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialMultiLineTextBox4 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialMultiLineTextBox3 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialMultiLineTextBox2 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.showInfoPage = new System.Windows.Forms.TabPage();
            this.materialLabelPPI = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelResolution = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelSizeMonitor = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelFrequency = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelSerialNo = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelDiagonal2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelDiagonal1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelProductCodeID = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelMonthOfProduction = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelYearOfProduction = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelModel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelManufacturer = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.ResolutionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBoxMonitors = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.searchInfoPage = new System.Windows.Forms.TabPage();
            this.testMonitorPage = new System.Windows.Forms.TabPage();
            this.resolutionPage = new System.Windows.Forms.TabPage();
            this.fixPixelPage = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.item1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.disabledItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.item3ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.textBoxIdEVK = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.sendButton = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.fullInfoPage.SuspendLayout();
            this.showInfoPage.SuspendLayout();
            this.resolutionPage.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
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
            this.materialTabControl1.Controls.Add(this.fixPixelPage);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1544, 674);
            this.materialTabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialCheckbox2);
            this.tabPage1.Controls.Add(this.materialCheckbox1);
            this.tabPage1.Controls.Add(this.textBoxTester);
            this.tabPage1.Controls.Add(this.materialSwitch1);
            this.tabPage1.ImageKey = "homepage.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1536, 631);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.materialSwitch1.Location = new System.Drawing.Point(3, 591);
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
            this.fullInfoPage.Controls.Add(this.materialMultiLineTextBox6);
            this.fullInfoPage.Controls.Add(this.materialMultiLineTextBox5);
            this.fullInfoPage.Controls.Add(this.materialMultiLineTextBox4);
            this.fullInfoPage.Controls.Add(this.materialMultiLineTextBox3);
            this.fullInfoPage.Controls.Add(this.materialMultiLineTextBox2);
            this.fullInfoPage.Controls.Add(this.materialMultiLineTextBox1);
            this.fullInfoPage.ImageKey = "info (2).png";
            this.fullInfoPage.Location = new System.Drawing.Point(4, 39);
            this.fullInfoPage.Name = "fullInfoPage";
            this.fullInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.fullInfoPage.Size = new System.Drawing.Size(1536, 631);
            this.fullInfoPage.TabIndex = 3;
            this.fullInfoPage.Text = "Show full info";
            this.fullInfoPage.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // materialMultiLineTextBox6
            // 
            this.materialMultiLineTextBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox6.Depth = 0;
            this.materialMultiLineTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox6.Location = new System.Drawing.Point(1286, 5);
            this.materialMultiLineTextBox6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox6.Name = "materialMultiLineTextBox6";
            this.materialMultiLineTextBox6.ReadOnly = true;
            this.materialMultiLineTextBox6.Size = new System.Drawing.Size(247, 619);
            this.materialMultiLineTextBox6.TabIndex = 34;
            this.materialMultiLineTextBox6.Text = "";
            // 
            // materialMultiLineTextBox5
            // 
            this.materialMultiLineTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox5.Depth = 0;
            this.materialMultiLineTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox5.Location = new System.Drawing.Point(1032, 6);
            this.materialMultiLineTextBox5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox5.Name = "materialMultiLineTextBox5";
            this.materialMultiLineTextBox5.ReadOnly = true;
            this.materialMultiLineTextBox5.Size = new System.Drawing.Size(248, 619);
            this.materialMultiLineTextBox5.TabIndex = 33;
            this.materialMultiLineTextBox5.Text = "";
            // 
            // materialMultiLineTextBox4
            // 
            this.materialMultiLineTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox4.Depth = 0;
            this.materialMultiLineTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox4.Location = new System.Drawing.Point(524, 6);
            this.materialMultiLineTextBox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox4.Name = "materialMultiLineTextBox4";
            this.materialMultiLineTextBox4.ReadOnly = true;
            this.materialMultiLineTextBox4.Size = new System.Drawing.Size(250, 619);
            this.materialMultiLineTextBox4.TabIndex = 32;
            this.materialMultiLineTextBox4.Text = "";
            // 
            // materialMultiLineTextBox3
            // 
            this.materialMultiLineTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox3.Depth = 0;
            this.materialMultiLineTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox3.Location = new System.Drawing.Point(267, 6);
            this.materialMultiLineTextBox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox3.Name = "materialMultiLineTextBox3";
            this.materialMultiLineTextBox3.ReadOnly = true;
            this.materialMultiLineTextBox3.Size = new System.Drawing.Size(251, 619);
            this.materialMultiLineTextBox3.TabIndex = 31;
            this.materialMultiLineTextBox3.Text = "";
            // 
            // materialMultiLineTextBox2
            // 
            this.materialMultiLineTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox2.Depth = 0;
            this.materialMultiLineTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox2.Location = new System.Drawing.Point(10, 6);
            this.materialMultiLineTextBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox2.Name = "materialMultiLineTextBox2";
            this.materialMultiLineTextBox2.ReadOnly = true;
            this.materialMultiLineTextBox2.Size = new System.Drawing.Size(251, 619);
            this.materialMultiLineTextBox2.TabIndex = 30;
            this.materialMultiLineTextBox2.Text = "";
            // 
            // materialMultiLineTextBox1
            // 
            this.materialMultiLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox1.Depth = 0;
            this.materialMultiLineTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox1.Location = new System.Drawing.Point(780, 6);
            this.materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            this.materialMultiLineTextBox1.ReadOnly = true;
            this.materialMultiLineTextBox1.Size = new System.Drawing.Size(246, 619);
            this.materialMultiLineTextBox1.TabIndex = 29;
            this.materialMultiLineTextBox1.Text = "";
            // 
            // showInfoPage
            // 
            this.showInfoPage.BackColor = System.Drawing.Color.White;
            this.showInfoPage.Controls.Add(this.sendButton);
            this.showInfoPage.Controls.Add(this.materialLabel13);
            this.showInfoPage.Controls.Add(this.textBoxIdEVK);
            this.showInfoPage.Controls.Add(this.materialLabelPPI);
            this.showInfoPage.Controls.Add(this.materialLabelResolution);
            this.showInfoPage.Controls.Add(this.materialLabelSizeMonitor);
            this.showInfoPage.Controls.Add(this.materialLabelFrequency);
            this.showInfoPage.Controls.Add(this.materialLabelSerialNo);
            this.showInfoPage.Controls.Add(this.materialLabelDiagonal2);
            this.showInfoPage.Controls.Add(this.materialLabelDiagonal1);
            this.showInfoPage.Controls.Add(this.materialLabelProductCodeID);
            this.showInfoPage.Controls.Add(this.materialLabelMonthOfProduction);
            this.showInfoPage.Controls.Add(this.materialLabelYearOfProduction);
            this.showInfoPage.Controls.Add(this.materialLabelModel);
            this.showInfoPage.Controls.Add(this.materialLabelManufacturer);
            this.showInfoPage.Controls.Add(this.materialLabel14);
            this.showInfoPage.Controls.Add(this.ResolutionLabel);
            this.showInfoPage.Controls.Add(this.materialLabel8);
            this.showInfoPage.Controls.Add(this.materialLabel9);
            this.showInfoPage.Controls.Add(this.materialLabel10);
            this.showInfoPage.Controls.Add(this.materialLabel11);
            this.showInfoPage.Controls.Add(this.materialLabel12);
            this.showInfoPage.Controls.Add(this.materialComboBoxMonitors);
            this.showInfoPage.Controls.Add(this.materialButton1);
            this.showInfoPage.Controls.Add(this.materialLabel7);
            this.showInfoPage.Controls.Add(this.materialLabel6);
            this.showInfoPage.Controls.Add(this.materialLabel5);
            this.showInfoPage.Controls.Add(this.materialLabel4);
            this.showInfoPage.Controls.Add(this.materialLabel3);
            this.showInfoPage.ImageKey = "computer.png";
            this.showInfoPage.Location = new System.Drawing.Point(4, 39);
            this.showInfoPage.Name = "showInfoPage";
            this.showInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.showInfoPage.Size = new System.Drawing.Size(1536, 631);
            this.showInfoPage.TabIndex = 1;
            this.showInfoPage.Text = "Show info";
            this.showInfoPage.Enter += new System.EventHandler(this.showInfoPage_Enter);
            // 
            // materialLabelPPI
            // 
            this.materialLabelPPI.AutoSize = true;
            this.materialLabelPPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelPPI.Depth = 0;
            this.materialLabelPPI.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelPPI.Location = new System.Drawing.Point(619, 467);
            this.materialLabelPPI.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelPPI.Name = "materialLabelPPI";
            this.materialLabelPPI.Size = new System.Drawing.Size(11, 19);
            this.materialLabelPPI.TabIndex = 50;
            this.materialLabelPPI.Text = ":)";
            this.materialLabelPPI.Click += new System.EventHandler(this.materialLabelPPI_Click_1);
            // 
            // materialLabelResolution
            // 
            this.materialLabelResolution.AutoSize = true;
            this.materialLabelResolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelResolution.Depth = 0;
            this.materialLabelResolution.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelResolution.Location = new System.Drawing.Point(619, 429);
            this.materialLabelResolution.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelResolution.Name = "materialLabelResolution";
            this.materialLabelResolution.Size = new System.Drawing.Size(11, 19);
            this.materialLabelResolution.TabIndex = 49;
            this.materialLabelResolution.Text = ":)";
            this.materialLabelResolution.Click += new System.EventHandler(this.materialLabelResolution_Click);
            // 
            // materialLabelSizeMonitor
            // 
            this.materialLabelSizeMonitor.AutoSize = true;
            this.materialLabelSizeMonitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelSizeMonitor.Depth = 0;
            this.materialLabelSizeMonitor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelSizeMonitor.Location = new System.Drawing.Point(619, 391);
            this.materialLabelSizeMonitor.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelSizeMonitor.Name = "materialLabelSizeMonitor";
            this.materialLabelSizeMonitor.Size = new System.Drawing.Size(11, 19);
            this.materialLabelSizeMonitor.TabIndex = 48;
            this.materialLabelSizeMonitor.Text = ":)";
            this.materialLabelSizeMonitor.Click += new System.EventHandler(this.materialLabelSizeMonitor_Click);
            // 
            // materialLabelFrequency
            // 
            this.materialLabelFrequency.AutoSize = true;
            this.materialLabelFrequency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelFrequency.Depth = 0;
            this.materialLabelFrequency.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelFrequency.Location = new System.Drawing.Point(619, 352);
            this.materialLabelFrequency.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelFrequency.Name = "materialLabelFrequency";
            this.materialLabelFrequency.Size = new System.Drawing.Size(11, 19);
            this.materialLabelFrequency.TabIndex = 47;
            this.materialLabelFrequency.Text = ":)";
            this.materialLabelFrequency.Click += new System.EventHandler(this.materialLabelFrequency_Click);
            // 
            // materialLabelSerialNo
            // 
            this.materialLabelSerialNo.AutoSize = true;
            this.materialLabelSerialNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelSerialNo.Depth = 0;
            this.materialLabelSerialNo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelSerialNo.Location = new System.Drawing.Point(619, 310);
            this.materialLabelSerialNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelSerialNo.Name = "materialLabelSerialNo";
            this.materialLabelSerialNo.Size = new System.Drawing.Size(11, 19);
            this.materialLabelSerialNo.TabIndex = 46;
            this.materialLabelSerialNo.Text = ":)";
            this.materialLabelSerialNo.Click += new System.EventHandler(this.materialLabelSerialNo_Click);
            // 
            // materialLabelDiagonal2
            // 
            this.materialLabelDiagonal2.AutoSize = true;
            this.materialLabelDiagonal2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelDiagonal2.Depth = 0;
            this.materialLabelDiagonal2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelDiagonal2.Location = new System.Drawing.Point(619, 268);
            this.materialLabelDiagonal2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDiagonal2.Name = "materialLabelDiagonal2";
            this.materialLabelDiagonal2.Size = new System.Drawing.Size(11, 19);
            this.materialLabelDiagonal2.TabIndex = 45;
            this.materialLabelDiagonal2.Text = ":)";
            this.materialLabelDiagonal2.Click += new System.EventHandler(this.materialLabelDiagonal2_Click);
            // 
            // materialLabelDiagonal1
            // 
            this.materialLabelDiagonal1.AutoSize = true;
            this.materialLabelDiagonal1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelDiagonal1.Depth = 0;
            this.materialLabelDiagonal1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelDiagonal1.Location = new System.Drawing.Point(619, 226);
            this.materialLabelDiagonal1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDiagonal1.Name = "materialLabelDiagonal1";
            this.materialLabelDiagonal1.Size = new System.Drawing.Size(11, 19);
            this.materialLabelDiagonal1.TabIndex = 44;
            this.materialLabelDiagonal1.Text = ":)";
            this.materialLabelDiagonal1.Click += new System.EventHandler(this.materialLabelDiagonal1_Click);
            // 
            // materialLabelProductCodeID
            // 
            this.materialLabelProductCodeID.AutoSize = true;
            this.materialLabelProductCodeID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelProductCodeID.Depth = 0;
            this.materialLabelProductCodeID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelProductCodeID.Location = new System.Drawing.Point(619, 189);
            this.materialLabelProductCodeID.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelProductCodeID.Name = "materialLabelProductCodeID";
            this.materialLabelProductCodeID.Size = new System.Drawing.Size(11, 19);
            this.materialLabelProductCodeID.TabIndex = 43;
            this.materialLabelProductCodeID.Text = ":)";
            this.materialLabelProductCodeID.Click += new System.EventHandler(this.materialLabelProductCodeID_Click);
            // 
            // materialLabelMonthOfProduction
            // 
            this.materialLabelMonthOfProduction.AutoSize = true;
            this.materialLabelMonthOfProduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelMonthOfProduction.Depth = 0;
            this.materialLabelMonthOfProduction.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelMonthOfProduction.Location = new System.Drawing.Point(619, 150);
            this.materialLabelMonthOfProduction.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelMonthOfProduction.Name = "materialLabelMonthOfProduction";
            this.materialLabelMonthOfProduction.Size = new System.Drawing.Size(11, 19);
            this.materialLabelMonthOfProduction.TabIndex = 42;
            this.materialLabelMonthOfProduction.Text = ":)";
            this.materialLabelMonthOfProduction.Click += new System.EventHandler(this.materialLabelMonthOfProduction_Click);
            // 
            // materialLabelYearOfProduction
            // 
            this.materialLabelYearOfProduction.AutoSize = true;
            this.materialLabelYearOfProduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelYearOfProduction.Depth = 0;
            this.materialLabelYearOfProduction.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelYearOfProduction.Location = new System.Drawing.Point(619, 108);
            this.materialLabelYearOfProduction.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelYearOfProduction.Name = "materialLabelYearOfProduction";
            this.materialLabelYearOfProduction.Size = new System.Drawing.Size(11, 19);
            this.materialLabelYearOfProduction.TabIndex = 41;
            this.materialLabelYearOfProduction.Text = ":)";
            this.materialLabelYearOfProduction.Click += new System.EventHandler(this.materialLabelYearOfProduction_Click);
            // 
            // materialLabelModel
            // 
            this.materialLabelModel.AutoSize = true;
            this.materialLabelModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelModel.Depth = 0;
            this.materialLabelModel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelModel.Location = new System.Drawing.Point(619, 66);
            this.materialLabelModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelModel.Name = "materialLabelModel";
            this.materialLabelModel.Size = new System.Drawing.Size(11, 19);
            this.materialLabelModel.TabIndex = 40;
            this.materialLabelModel.Text = ":)";
            this.materialLabelModel.Click += new System.EventHandler(this.materialLabelModel_Click);
            // 
            // materialLabelManufacturer
            // 
            this.materialLabelManufacturer.AutoSize = true;
            this.materialLabelManufacturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabelManufacturer.Depth = 0;
            this.materialLabelManufacturer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelManufacturer.Location = new System.Drawing.Point(619, 24);
            this.materialLabelManufacturer.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelManufacturer.Name = "materialLabelManufacturer";
            this.materialLabelManufacturer.Size = new System.Drawing.Size(11, 19);
            this.materialLabelManufacturer.TabIndex = 39;
            this.materialLabelManufacturer.Text = ":)";
            this.materialLabelManufacturer.Click += new System.EventHandler(this.materialLabelManufacturer_Click);
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(332, 467);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(25, 19);
            this.materialLabel14.TabIndex = 38;
            this.materialLabel14.Text = "PPI";
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Depth = 0;
            this.ResolutionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ResolutionLabel.Location = new System.Drawing.Point(332, 429);
            this.ResolutionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(76, 19);
            this.ResolutionLabel.TabIndex = 37;
            this.ResolutionLabel.Text = "Resolution";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(332, 391);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(131, 19);
            this.materialLabel8.TabIndex = 36;
            this.materialLabel8.Text = "Size monitor (cm.)";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(332, 352);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(74, 19);
            this.materialLabel9.TabIndex = 35;
            this.materialLabel9.Text = "Frequency";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(332, 310);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(69, 19);
            this.materialLabel10.TabIndex = 34;
            this.materialLabel10.Text = "Serial No.";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(332, 268);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(105, 19);
            this.materialLabel11.TabIndex = 33;
            this.materialLabel11.Text = "Diagonal (res.)";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(332, 226);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(112, 19);
            this.materialLabel12.TabIndex = 32;
            this.materialLabel12.Text = "Diagonal (H\\W)";
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
            this.materialComboBoxMonitors.Location = new System.Drawing.Point(21, 40);
            this.materialComboBoxMonitors.MaxDropDownItems = 4;
            this.materialComboBoxMonitors.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxMonitors.Name = "materialComboBoxMonitors";
            this.materialComboBoxMonitors.Size = new System.Drawing.Size(251, 49);
            this.materialComboBoxMonitors.Sorted = true;
            this.materialComboBoxMonitors.StartIndex = 0;
            this.materialComboBoxMonitors.TabIndex = 31;
            this.materialComboBoxMonitors.SelectedIndexChanged += new System.EventHandler(this.materialComboBoxMonitors_SelectedIndexChanged);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(21, 573);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(134, 36);
            this.materialButton1.TabIndex = 30;
            this.materialButton1.Text = "show form";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(332, 189);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(113, 19);
            this.materialLabel7.TabIndex = 4;
            this.materialLabel7.Text = "Product code ID";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(332, 150);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(146, 19);
            this.materialLabel6.TabIndex = 3;
            this.materialLabel6.Text = "Month of production";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(332, 108);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(132, 19);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Year of production";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(332, 66);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(45, 19);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Model";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(332, 24);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(97, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Manufacturer";
            // 
            // searchInfoPage
            // 
            this.searchInfoPage.ImageKey = "search.png";
            this.searchInfoPage.Location = new System.Drawing.Point(4, 39);
            this.searchInfoPage.Name = "searchInfoPage";
            this.searchInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchInfoPage.Size = new System.Drawing.Size(1536, 631);
            this.searchInfoPage.TabIndex = 4;
            this.searchInfoPage.Text = "Search info";
            this.searchInfoPage.UseVisualStyleBackColor = true;
            this.searchInfoPage.Enter += new System.EventHandler(this.searchInfoPage_Enter);
            // 
            // testMonitorPage
            // 
            this.testMonitorPage.ImageKey = "monitoring-test.png";
            this.testMonitorPage.Location = new System.Drawing.Point(4, 39);
            this.testMonitorPage.Name = "testMonitorPage";
            this.testMonitorPage.Padding = new System.Windows.Forms.Padding(3);
            this.testMonitorPage.Size = new System.Drawing.Size(1536, 631);
            this.testMonitorPage.TabIndex = 6;
            this.testMonitorPage.Text = "Test monitor";
            this.testMonitorPage.UseVisualStyleBackColor = true;
            this.testMonitorPage.Enter += new System.EventHandler(this.tabPage7_Enter);
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
            this.resolutionPage.Size = new System.Drawing.Size(1536, 631);
            this.resolutionPage.TabIndex = 0;
            this.resolutionPage.Text = "Resolution";
            // 
            // fixPixelPage
            // 
            this.fixPixelPage.ImageKey = "fix (1).png";
            this.fixPixelPage.Location = new System.Drawing.Point(4, 39);
            this.fixPixelPage.Name = "fixPixelPage";
            this.fixPixelPage.Size = new System.Drawing.Size(1536, 631);
            this.fixPixelPage.TabIndex = 2;
            this.fixPixelPage.Text = "Fix pixel";
            this.fixPixelPage.UseVisualStyleBackColor = true;
            this.fixPixelPage.Enter += new System.EventHandler(this.fixPixelPage_Enter);
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
            this.tabPage6.Size = new System.Drawing.Size(1536, 631);
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
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::ServiceMonitorEVK.Properties.Resources.logo__1_;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1446, 28);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(97, 33);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 41;
            this.pictureBoxLogo.TabStop = false;
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
            this.textBoxIdEVK.Location = new System.Drawing.Point(622, 497);
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
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(332, 509);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(47, 19);
            this.materialLabel13.TabIndex = 53;
            this.materialLabel13.Text = "Id EVK";
            // 
            // sendButton
            // 
            this.sendButton.AutoSize = false;
            this.sendButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.sendButton.Depth = 0;
            this.sendButton.HighEmphasis = true;
            this.sendButton.Icon = null;
            this.sendButton.Location = new System.Drawing.Point(21, 499);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sendButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendButton.Name = "sendButton";
            this.sendButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.sendButton.Size = new System.Drawing.Size(134, 36);
            this.sendButton.TabIndex = 54;
            this.sendButton.Text = "Sent";
            this.sendButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.sendButton.UseAccentColor = false;
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1550, 741);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoShow = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerUseColors = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Monitor";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.fullInfoPage.ResumeLayout(false);
            this.showInfoPage.ResumeLayout(false);
            this.showInfoPage.PerformLayout();
            this.resolutionPage.ResumeLayout(false);
            this.resolutionPage.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.materialContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
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
        private TabPage fixPixelPage;
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
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private TabPage tabPage6;
        private TabPage testMonitorPage;
        private Button button7;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox5;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox4;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox3;
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
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
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
    }
}

