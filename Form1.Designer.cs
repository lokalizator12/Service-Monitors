using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;

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
            this.fullInfoPage = new System.Windows.Forms.TabPage();
            this.materialMultiLineTextBox6 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialMultiLineTextBox5 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialMultiLineTextBox4 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialMultiLineTextBox3 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialMultiLineTextBox2 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.showInfoPage = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialListView2 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.item1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.disabledItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.item3ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialTabControl1.SuspendLayout();
            this.fullInfoPage.SuspendLayout();
            this.showInfoPage.SuspendLayout();
            this.resolutionPage.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialContextMenuStrip1.SuspendLayout();
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
            this.materialMultiLineTextBox6.Size = new System.Drawing.Size(231, 619);
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
            this.materialMultiLineTextBox5.Size = new System.Drawing.Size(231, 619);
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
            this.materialMultiLineTextBox4.Size = new System.Drawing.Size(231, 619);
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
            this.materialMultiLineTextBox3.Size = new System.Drawing.Size(231, 619);
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
            this.materialMultiLineTextBox2.Size = new System.Drawing.Size(231, 619);
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
            this.materialMultiLineTextBox1.Size = new System.Drawing.Size(231, 619);
            this.materialMultiLineTextBox1.TabIndex = 29;
            this.materialMultiLineTextBox1.Text = "";
            // 
            // showInfoPage
            // 
            this.showInfoPage.BackColor = System.Drawing.Color.White;
            this.showInfoPage.Controls.Add(this.materialButton1);
            this.showInfoPage.Controls.Add(this.materialListView2);
            this.showInfoPage.Controls.Add(this.materialListView1);
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
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(22, 244);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(134, 36);
            this.materialButton1.TabIndex = 30;
            this.materialButton1.Text = "aaa";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialListView2
            // 
            this.materialListView2.AllowColumnReorder = true;
            this.materialListView2.AutoSizeTable = true;
            this.materialListView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.materialListView2.Depth = 0;
            this.materialListView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialListView2.FullRowSelect = true;
            this.materialListView2.HideSelection = false;
            this.materialListView2.Location = new System.Drawing.Point(368, 120);
            this.materialListView2.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView2.Name = "materialListView2";
            this.materialListView2.OwnerDraw = true;
            this.materialListView2.Scrollable = false;
            this.materialListView2.Size = new System.Drawing.Size(564, 100);
            this.materialListView2.TabIndex = 6;
            this.materialListView2.UseCompatibleStateImageBehavior = false;
            this.materialListView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dessert (100g serving)";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Calories";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fat (g)";
            this.columnHeader3.Width = 111;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Protein (g)";
            this.columnHeader4.Width = 154;
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(379, 66);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(443, 234);
            this.materialListView1.TabIndex = 5;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(35, 201);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(107, 19);
            this.materialLabel7.TabIndex = 4;
            this.materialLabel7.Text = "materialLabel7";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(35, 162);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(107, 19);
            this.materialLabel6.TabIndex = 3;
            this.materialLabel6.Text = "materialLabel6";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(35, 120);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(107, 19);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "materialLabel5";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(35, 78);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(107, 19);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "materialLabel4";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(35, 36);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(107, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "materialLabel3";
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
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.BackColor = System.Drawing.Color.RosyBrown;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(1235, 24);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(58, 37);
            this.materialSwitch1.TabIndex = 38;
            this.materialSwitch1.UseVisualStyleBackColor = false;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1550, 741);
            this.Controls.Add(this.materialSwitch1);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerUseColors = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Monitor";
            this.materialTabControl1.ResumeLayout(false);
            this.fullInfoPage.ResumeLayout(false);
            this.showInfoPage.ResumeLayout(false);
            this.showInfoPage.PerformLayout();
            this.resolutionPage.ResumeLayout(false);
            this.resolutionPage.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialListView materialListView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}

