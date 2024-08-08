using System.Drawing;

namespace changeResolution1
{
    partial class MonitorTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorChangeTimer = new System.Windows.Forms.Timer(this.components);
            this.colorPanel = new System.Windows.Forms.Panel();
            this.monitorComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.testModeComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.testPatternComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialSliderOpasity = new MaterialSkin.Controls.MaterialSlider();
            this.selectColorButton = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxChoose = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlack = new System.Windows.Forms.PictureBox();
            this.pictureBoxWhite = new System.Windows.Forms.PictureBox();
            this.pictureBoxSilver = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
            this.pictureBoxMagneta = new System.Windows.Forms.PictureBox();
            this.pictureBoxAqua = new System.Windows.Forms.PictureBox();
            this.pictureBoxYellow = new System.Windows.Forms.PictureBox();
            this.pictureBoxLime = new System.Windows.Forms.PictureBox();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.colorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectColorButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSilver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagneta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            this.SuspendLayout();
            // 
            // colorDialog2
            // 
            this.colorDialog2.ShowHelp = true;
            // 
            // colorChangeTimer
            // 
            this.colorChangeTimer.Tick += new System.EventHandler(this.colorChangeTimer_Tick);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Gray;
            this.colorPanel.Controls.Add(this.pictureBox10);
            this.colorPanel.Controls.Add(this.pictureBox9);
            this.colorPanel.Controls.Add(this.pictureBox8);
            this.colorPanel.Controls.Add(this.pictureBox7);
            this.colorPanel.Controls.Add(this.pictureBox6);
            this.colorPanel.Controls.Add(this.pictureBox5);
            this.colorPanel.Controls.Add(this.pictureBox4);
            this.colorPanel.Controls.Add(this.pictureBox3);
            this.colorPanel.Controls.Add(this.pictureBox2);
            this.colorPanel.Controls.Add(this.pictureBox1);
            this.colorPanel.Controls.Add(this.pictureBoxChoose);
            this.colorPanel.Controls.Add(this.pictureBoxBlack);
            this.colorPanel.Controls.Add(this.pictureBoxWhite);
            this.colorPanel.Controls.Add(this.pictureBoxSilver);
            this.colorPanel.Controls.Add(this.pictureBoxBlue);
            this.colorPanel.Controls.Add(this.pictureBoxMagneta);
            this.colorPanel.Controls.Add(this.pictureBoxAqua);
            this.colorPanel.Controls.Add(this.pictureBoxYellow);
            this.colorPanel.Controls.Add(this.pictureBoxLime);
            this.colorPanel.Controls.Add(this.pictureBoxRed);
            this.colorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.colorPanel.Location = new System.Drawing.Point(3, 81);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(843, 38);
            this.colorPanel.TabIndex = 6;
            // 
            // monitorComboBox1
            // 
            this.monitorComboBox1.AutoResize = false;
            this.monitorComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monitorComboBox1.Depth = 0;
            this.monitorComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.monitorComboBox1.DropDownHeight = 174;
            this.monitorComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monitorComboBox1.DropDownWidth = 121;
            this.monitorComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.monitorComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.monitorComboBox1.FormattingEnabled = true;
            this.monitorComboBox1.Hint = "Monitor";
            this.monitorComboBox1.IntegralHeight = false;
            this.monitorComboBox1.ItemHeight = 43;
            this.monitorComboBox1.Location = new System.Drawing.Point(6, 27);
            this.monitorComboBox1.MaxDropDownItems = 4;
            this.monitorComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.monitorComboBox1.Name = "monitorComboBox1";
            this.monitorComboBox1.Size = new System.Drawing.Size(201, 49);
            this.monitorComboBox1.StartIndex = 0;
            this.monitorComboBox1.TabIndex = 34;
            // 
            // testModeComboBox1
            // 
            this.testModeComboBox1.AutoResize = false;
            this.testModeComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.testModeComboBox1.Depth = 0;
            this.testModeComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.testModeComboBox1.DropDownHeight = 174;
            this.testModeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testModeComboBox1.DropDownWidth = 121;
            this.testModeComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.testModeComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.testModeComboBox1.FormattingEnabled = true;
            this.testModeComboBox1.Hint = "Test mode";
            this.testModeComboBox1.IntegralHeight = false;
            this.testModeComboBox1.ItemHeight = 43;
            this.testModeComboBox1.Items.AddRange(new object[] {
            "Custom Pattern",
            "Color Spectrum",
            "Grayscale Gradient",
            "Color Lines",
            "Checkerboard",
            "Circular Gradient"});
            this.testModeComboBox1.Location = new System.Drawing.Point(214, 27);
            this.testModeComboBox1.MaxDropDownItems = 4;
            this.testModeComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.testModeComboBox1.Name = "testModeComboBox1";
            this.testModeComboBox1.Size = new System.Drawing.Size(150, 49);
            this.testModeComboBox1.StartIndex = 0;
            this.testModeComboBox1.TabIndex = 35;
            this.testModeComboBox1.SelectedIndexChanged += new System.EventHandler(this.testModeComboBox1_SelectedIndexChanged);
            this.testModeComboBox1.SelectionChangeCommitted += new System.EventHandler(this.testModeComboBox_SelectedIndexChanged);
            // 
            // testPatternComboBox1
            // 
            this.testPatternComboBox1.AutoResize = false;
            this.testPatternComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.testPatternComboBox1.Depth = 0;
            this.testPatternComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.testPatternComboBox1.DropDownHeight = 174;
            this.testPatternComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testPatternComboBox1.DropDownWidth = 121;
            this.testPatternComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.testPatternComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.testPatternComboBox1.FormattingEnabled = true;
            this.testPatternComboBox1.Hint = "Test pattern";
            this.testPatternComboBox1.IntegralHeight = false;
            this.testPatternComboBox1.ItemHeight = 43;
            this.testPatternComboBox1.Items.AddRange(new object[] {
            "Chessboard",
            "Circles",
            "Lines"});
            this.testPatternComboBox1.Location = new System.Drawing.Point(370, 27);
            this.testPatternComboBox1.MaxDropDownItems = 4;
            this.testPatternComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.testPatternComboBox1.Name = "testPatternComboBox1";
            this.testPatternComboBox1.Size = new System.Drawing.Size(150, 49);
            this.testPatternComboBox1.StartIndex = 0;
            this.testPatternComboBox1.TabIndex = 36;
            this.testPatternComboBox1.SelectedIndexChanged += new System.EventHandler(this.testPatternComboBox1_SelectedIndexChanged);
            // 
            // materialSliderOpasity
            // 
            this.materialSliderOpasity.Depth = 0;
            this.materialSliderOpasity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSliderOpasity.Location = new System.Drawing.Point(609, 36);
            this.materialSliderOpasity.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSliderOpasity.Name = "materialSliderOpasity";
            this.materialSliderOpasity.ShowText = false;
            this.materialSliderOpasity.ShowValue = false;
            this.materialSliderOpasity.Size = new System.Drawing.Size(231, 40);
            this.materialSliderOpasity.TabIndex = 37;
            this.materialSliderOpasity.Text = "";
            this.materialSliderOpasity.Value = 90;
            this.materialSliderOpasity.ValueMax = 100;
            this.materialSliderOpasity.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.materialSliderOpasity_onValueChanged);
            // 
            // selectColorButton
            // 
            this.selectColorButton.BackColor = System.Drawing.Color.Transparent;
            this.selectColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectColorButton.Image = global::ServiceMonitorEVK.Properties.Resources.color_wheel1;
            this.selectColorButton.Location = new System.Drawing.Point(526, 27);
            this.selectColorButton.Name = "selectColorButton";
            this.selectColorButton.Size = new System.Drawing.Size(68, 49);
            this.selectColorButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectColorButton.TabIndex = 32;
            this.selectColorButton.TabStop = false;
            this.selectColorButton.Click += new System.EventHandler(this.selectColorButton_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Red;
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Location = new System.Drawing.Point(759, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(36, 30);
            this.pictureBox10.TabIndex = 19;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Red;
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Location = new System.Drawing.Point(717, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(36, 30);
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Red;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Location = new System.Drawing.Point(675, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(36, 30);
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Red;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Location = new System.Drawing.Point(633, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 30);
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Red;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(591, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 30);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Red;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(549, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 30);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Red;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(507, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 30);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Red;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(465, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 30);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(423, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 30);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(801, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxChoose
            // 
            this.pictureBoxChoose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChoose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxChoose.Image = global::ServiceMonitorEVK.Properties.Resources.color_wheel;
            this.pictureBoxChoose.InitialImage = global::ServiceMonitorEVK.Properties.Resources.color_wheel;
            this.pictureBoxChoose.Location = new System.Drawing.Point(381, 3);
            this.pictureBoxChoose.Name = "pictureBoxChoose";
            this.pictureBoxChoose.Size = new System.Drawing.Size(36, 30);
            this.pictureBoxChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxChoose.TabIndex = 9;
            this.pictureBoxChoose.TabStop = false;
            this.pictureBoxChoose.Click += new System.EventHandler(this.pictureBoxChoose_Click);
            // 
            // pictureBoxBlack
            // 
            this.pictureBoxBlack.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBlack.Image = global::ServiceMonitorEVK.Properties.Resources.black;
            this.pictureBoxBlack.Location = new System.Drawing.Point(339, 3);
            this.pictureBoxBlack.Name = "pictureBoxBlack";
            this.pictureBoxBlack.Size = new System.Drawing.Size(36, 30);
            this.pictureBoxBlack.TabIndex = 8;
            this.pictureBoxBlack.TabStop = false;
            this.pictureBoxBlack.Click += new System.EventHandler(this.pictureBoxBlack_Click);
            // 
            // pictureBoxWhite
            // 
            this.pictureBoxWhite.BackColor = System.Drawing.Color.White;
            this.pictureBoxWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxWhite.Image = global::ServiceMonitorEVK.Properties.Resources.white;
            this.pictureBoxWhite.Location = new System.Drawing.Point(297, 3);
            this.pictureBoxWhite.Name = "pictureBoxWhite";
            this.pictureBoxWhite.Size = new System.Drawing.Size(36, 30);
            this.pictureBoxWhite.TabIndex = 7;
            this.pictureBoxWhite.TabStop = false;
            this.pictureBoxWhite.Click += new System.EventHandler(this.pictureBoxWhite_Click);
            // 
            // pictureBoxSilver
            // 
            this.pictureBoxSilver.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxSilver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSilver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSilver.Image = global::ServiceMonitorEVK.Properties.Resources.silver;
            this.pictureBoxSilver.Location = new System.Drawing.Point(255, 3);
            this.pictureBoxSilver.Name = "pictureBoxSilver";
            this.pictureBoxSilver.Size = new System.Drawing.Size(36, 30);
            this.pictureBoxSilver.TabIndex = 6;
            this.pictureBoxSilver.TabStop = false;
            this.pictureBoxSilver.Click += new System.EventHandler(this.pictureBoxSilver_Click);
            // 
            // pictureBoxBlue
            // 
            this.pictureBoxBlue.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBlue.Image = global::ServiceMonitorEVK.Properties.Resources.blue;
            this.pictureBoxBlue.Location = new System.Drawing.Point(213, 3);
            this.pictureBoxBlue.Name = "pictureBoxBlue";
            this.pictureBoxBlue.Size = new System.Drawing.Size(36, 30);
            this.pictureBoxBlue.TabIndex = 5;
            this.pictureBoxBlue.TabStop = false;
            this.pictureBoxBlue.Click += new System.EventHandler(this.pictureBoxBlue_Click);
            // 
            // pictureBoxMagneta
            // 
            this.pictureBoxMagneta.BackColor = System.Drawing.Color.Magenta;
            this.pictureBoxMagneta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMagneta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMagneta.Image = global::ServiceMonitorEVK.Properties.Resources.magenta;
            this.pictureBoxMagneta.Location = new System.Drawing.Point(171, 3);
            this.pictureBoxMagneta.Name = "pictureBoxMagneta";
            this.pictureBoxMagneta.Size = new System.Drawing.Size(36, 30);
            this.pictureBoxMagneta.TabIndex = 4;
            this.pictureBoxMagneta.TabStop = false;
            this.pictureBoxMagneta.Click += new System.EventHandler(this.pictureBoxMagneta_Click);
            // 
            // pictureBoxAqua
            // 
            this.pictureBoxAqua.BackColor = System.Drawing.Color.Aqua;
            this.pictureBoxAqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAqua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAqua.Image = global::ServiceMonitorEVK.Properties.Resources.aqua;
            this.pictureBoxAqua.Location = new System.Drawing.Point(129, 3);
            this.pictureBoxAqua.Name = "pictureBoxAqua";
            this.pictureBoxAqua.Size = new System.Drawing.Size(36, 30);
            this.pictureBoxAqua.TabIndex = 3;
            this.pictureBoxAqua.TabStop = false;
            this.pictureBoxAqua.Click += new System.EventHandler(this.pictureBoxAqua_Click);
            // 
            // pictureBoxYellow
            // 
            this.pictureBoxYellow.BackColor = System.Drawing.Color.Yellow;
            this.pictureBoxYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxYellow.Image = global::ServiceMonitorEVK.Properties.Resources.yellow;
            this.pictureBoxYellow.Location = new System.Drawing.Point(87, 3);
            this.pictureBoxYellow.Name = "pictureBoxYellow";
            this.pictureBoxYellow.Size = new System.Drawing.Size(36, 30);
            this.pictureBoxYellow.TabIndex = 2;
            this.pictureBoxYellow.TabStop = false;
            this.pictureBoxYellow.Click += new System.EventHandler(this.pictureBoxYellow_Click);
            // 
            // pictureBoxLime
            // 
            this.pictureBoxLime.BackColor = System.Drawing.Color.Lime;
            this.pictureBoxLime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLime.Image = global::ServiceMonitorEVK.Properties.Resources.lime;
            this.pictureBoxLime.Location = new System.Drawing.Point(45, 3);
            this.pictureBoxLime.Name = "pictureBoxLime";
            this.pictureBoxLime.Size = new System.Drawing.Size(36, 30);
            this.pictureBoxLime.TabIndex = 1;
            this.pictureBoxLime.TabStop = false;
            this.pictureBoxLime.Click += new System.EventHandler(this.pictureBoxLime_Click);
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRed.Image = global::ServiceMonitorEVK.Properties.Resources.red2;
            this.pictureBoxRed.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(36, 30);
            this.pictureBoxRed.TabIndex = 0;
            this.pictureBoxRed.TabStop = false;
            this.pictureBoxRed.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MonitorTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 122);
            this.Controls.Add(this.materialSliderOpasity);
            this.Controls.Add(this.selectColorButton);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.monitorComboBox1);
            this.Controls.Add(this.testPatternComboBox1);
            this.Controls.Add(this.testModeComboBox1);
            this.DrawerIsOpen = true;
            this.DrawerUseColors = true;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MonitorTestForm";
            this.Opacity = 0.9D;
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonitorTestForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.monitorTestForm_KeyDown);
            this.colorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectColorButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSilver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagneta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Timer colorChangeTimer;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.PictureBox pictureBoxRed;
        private System.Windows.Forms.PictureBox pictureBoxChoose;
        private System.Windows.Forms.PictureBox pictureBoxBlack;
        private System.Windows.Forms.PictureBox pictureBoxWhite;
        private System.Windows.Forms.PictureBox pictureBoxSilver;
        private System.Windows.Forms.PictureBox pictureBoxBlue;
        private System.Windows.Forms.PictureBox pictureBoxMagneta;
        private System.Windows.Forms.PictureBox pictureBoxAqua;
        private System.Windows.Forms.PictureBox pictureBoxYellow;
        private System.Windows.Forms.PictureBox pictureBoxLime;
        private System.Windows.Forms.PictureBox selectColorButton;
        private MaterialSkin.Controls.MaterialComboBox monitorComboBox1;
        private MaterialSkin.Controls.MaterialComboBox testModeComboBox1;
        private MaterialSkin.Controls.MaterialComboBox testPatternComboBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSlider materialSliderOpasity;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}