using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ServiceMonitorEVK.Source.Testing_Monitor
{
    partial class MonitorTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        int cornerRadius = 20;
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
        private void RoundPictureBoxCorners(PictureBox pictureBox, int cornerRadius)
        {

            GraphicsPath roundedPath = new GraphicsPath();

            // Устанавливаем закругленные углы
            roundedPath.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            roundedPath.AddArc(pictureBox.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // Верхний правый угол
            roundedPath.AddArc(pictureBox.Width - cornerRadius, pictureBox.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Нижний правый угол
            roundedPath.AddArc(0, pictureBox.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Нижний левый угол

            roundedPath.CloseAllFigures(); 

            pictureBox.Region = new Region(roundedPath);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorTestForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
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
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorChangeTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialSliderOpasity = new MaterialSkin.Controls.MaterialSlider();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.monitorComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.testModeComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.testPatternComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.selectColorButton = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectColorButton)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.delete_symbol_option;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Location = new System.Drawing.Point(4, 667);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(47, 43);
            this.pictureBox10.TabIndex = 19;
            this.pictureBox10.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox10, "Key: X");
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.save_prtscr;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Location = new System.Drawing.Point(4, 616);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(47, 43);
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox9, "Key: Ctrl+S");
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.select_yello;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Location = new System.Drawing.Point(4, 718);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(47, 43);
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox8, "Key: A");
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.select_blue;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Location = new System.Drawing.Point(4, 769);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(47, 43);
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox7, "Key: S");
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(4, 565);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(46, 43);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox6, "Key: W");
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.win_back;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(4, 514);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 43);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Key: Q ");
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.select_red2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(4, 820);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 43);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Key: D");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBoxChoose
            // 
            this.pictureBoxChoose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChoose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxChoose.Image = global::ServiceMonitorEVK.Properties.Resources.color_wheel;
            this.pictureBoxChoose.InitialImage = global::ServiceMonitorEVK.Properties.Resources.color_wheel;
            this.pictureBoxChoose.Location = new System.Drawing.Point(4, 463);
            this.pictureBoxChoose.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxChoose.Name = "pictureBoxChoose";
            this.pictureBoxChoose.Size = new System.Drawing.Size(46, 43);
            this.pictureBoxChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxChoose.TabIndex = 9;
            this.pictureBoxChoose.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxChoose, "Key: Tab");
            this.pictureBoxChoose.Click += new System.EventHandler(this.pictureBoxChoose_Click);
            // 
            // pictureBoxBlack
            // 
            this.pictureBoxBlack.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBlack.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.black;
            this.pictureBoxBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBlack.Location = new System.Drawing.Point(4, 412);
            this.pictureBoxBlack.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBlack.Name = "pictureBoxBlack";
            this.pictureBoxBlack.Size = new System.Drawing.Size(46, 43);
            this.pictureBoxBlack.TabIndex = 8;
            this.pictureBoxBlack.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxBlack, "Key: 9 or Num9");
            this.pictureBoxBlack.Click += new System.EventHandler(this.pictureBoxBlack_Click);
            // 
            // pictureBoxWhite
            // 
            this.pictureBoxWhite.BackColor = System.Drawing.Color.White;
            this.pictureBoxWhite.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.white;
            this.pictureBoxWhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxWhite.Location = new System.Drawing.Point(4, 361);
            this.pictureBoxWhite.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxWhite.Name = "pictureBoxWhite";
            this.pictureBoxWhite.Size = new System.Drawing.Size(46, 43);
            this.pictureBoxWhite.TabIndex = 7;
            this.pictureBoxWhite.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxWhite, "Key: 8 or Num8");
            this.pictureBoxWhite.Click += new System.EventHandler(this.pictureBoxWhite_Click);
            // 
            // pictureBoxSilver
            // 
            this.pictureBoxSilver.BackColor = System.Drawing.Color.Gray;
            this.pictureBoxSilver.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.silver;
            this.pictureBoxSilver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSilver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSilver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSilver.Location = new System.Drawing.Point(4, 310);
            this.pictureBoxSilver.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSilver.Name = "pictureBoxSilver";
            this.pictureBoxSilver.Size = new System.Drawing.Size(46, 43);
            this.pictureBoxSilver.TabIndex = 6;
            this.pictureBoxSilver.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxSilver, "Key: 7 or Num7");
            this.pictureBoxSilver.Click += new System.EventHandler(this.pictureBoxSilver_Click);
            // 
            // pictureBoxBlue
            // 
            this.pictureBoxBlue.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxBlue.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.blue;
            this.pictureBoxBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBlue.Location = new System.Drawing.Point(4, 259);
            this.pictureBoxBlue.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBlue.Name = "pictureBoxBlue";
            this.pictureBoxBlue.Size = new System.Drawing.Size(46, 43);
            this.pictureBoxBlue.TabIndex = 5;
            this.pictureBoxBlue.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxBlue, "Key: 6 or Num6");
            this.pictureBoxBlue.Click += new System.EventHandler(this.pictureBoxBlue_Click);
            // 
            // pictureBoxMagneta
            // 
            this.pictureBoxMagneta.BackColor = System.Drawing.Color.Magenta;
            this.pictureBoxMagneta.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.magenta;
            this.pictureBoxMagneta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxMagneta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMagneta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMagneta.Location = new System.Drawing.Point(4, 208);
            this.pictureBoxMagneta.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxMagneta.Name = "pictureBoxMagneta";
            this.pictureBoxMagneta.Size = new System.Drawing.Size(46, 43);
            this.pictureBoxMagneta.TabIndex = 4;
            this.pictureBoxMagneta.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxMagneta, "Key: 5 or Num5");
            this.pictureBoxMagneta.Click += new System.EventHandler(this.pictureBoxMagneta_Click);
            // 
            // pictureBoxAqua
            // 
            this.pictureBoxAqua.BackColor = System.Drawing.Color.Aqua;
            this.pictureBoxAqua.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.aqua;
            this.pictureBoxAqua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAqua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAqua.Location = new System.Drawing.Point(4, 157);
            this.pictureBoxAqua.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAqua.Name = "pictureBoxAqua";
            this.pictureBoxAqua.Size = new System.Drawing.Size(46, 43);
            this.pictureBoxAqua.TabIndex = 3;
            this.pictureBoxAqua.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxAqua, "Key: 4 or Num4");
            this.pictureBoxAqua.Click += new System.EventHandler(this.pictureBoxAqua_Click);
            // 
            // pictureBoxYellow
            // 
            this.pictureBoxYellow.BackColor = System.Drawing.Color.Yellow;
            this.pictureBoxYellow.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.yellow;
            this.pictureBoxYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxYellow.Location = new System.Drawing.Point(4, 106);
            this.pictureBoxYellow.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxYellow.Name = "pictureBoxYellow";
            this.pictureBoxYellow.Size = new System.Drawing.Size(46, 43);
            this.pictureBoxYellow.TabIndex = 2;
            this.pictureBoxYellow.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxYellow, "Key: 3 or Num3");
            this.pictureBoxYellow.Click += new System.EventHandler(this.pictureBoxYellow_Click);
            // 
            // pictureBoxLime
            // 
            this.pictureBoxLime.BackColor = System.Drawing.Color.Lime;
            this.pictureBoxLime.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.lime;
            this.pictureBoxLime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLime.Location = new System.Drawing.Point(4, 55);
            this.pictureBoxLime.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLime.Name = "pictureBoxLime";
            this.pictureBoxLime.Size = new System.Drawing.Size(46, 43);
            this.pictureBoxLime.TabIndex = 1;
            this.pictureBoxLime.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxLime, "Key: 2 or Num2");
            this.pictureBoxLime.Click += new System.EventHandler(this.pictureBoxLime_Click);
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.BackColor = System.Drawing.Color.Red;
            this.pictureBoxRed.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.red1;
            this.pictureBoxRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRed.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxRed.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(46, 43);
            this.pictureBoxRed.TabIndex = 0;
            this.pictureBoxRed.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxRed, "Key: 1 or Num1");
            this.pictureBoxRed.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // colorDialog2
            // 
            this.colorDialog2.ShowHelp = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ServiceMonitorEVK.Properties.Resources.push_pin;
            this.pictureBox2.Location = new System.Drawing.Point(70, 233);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.Move += new System.EventHandler(this.pictureBox2_Move);
            // 
            // materialSliderOpasity
            // 
            this.materialSliderOpasity.Depth = 0;
            this.materialSliderOpasity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSliderOpasity.Location = new System.Drawing.Point(4, 185);
            this.materialSliderOpasity.Margin = new System.Windows.Forms.Padding(4);
            this.materialSliderOpasity.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSliderOpasity.Name = "materialSliderOpasity";
            this.materialSliderOpasity.ShowText = false;
            this.materialSliderOpasity.ShowValue = false;
            this.materialSliderOpasity.Size = new System.Drawing.Size(107, 40);
            this.materialSliderOpasity.TabIndex = 37;
            this.materialSliderOpasity.Text = "Opacity";
            this.materialSliderOpasity.Value = 100;
            this.materialSliderOpasity.ValueMax = 100;
            this.materialSliderOpasity.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.materialSliderOpasity_onValueChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.exit_test;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(4, 871);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 43);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // monitorComboBox1
            // 
            this.monitorComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monitorComboBox1.AutoResize = false;
            this.monitorComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monitorComboBox1.Depth = 0;
            this.monitorComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.monitorComboBox1.DropDownHeight = 118;
            this.monitorComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monitorComboBox1.DropDownWidth = 121;
            this.monitorComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.monitorComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.monitorComboBox1.FormattingEnabled = true;
            this.monitorComboBox1.Hint = "Monitor";
            this.monitorComboBox1.IntegralHeight = false;
            this.monitorComboBox1.ItemHeight = 29;
            this.monitorComboBox1.Location = new System.Drawing.Point(4, 4);
            this.monitorComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.monitorComboBox1.MaxDropDownItems = 4;
            this.monitorComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.monitorComboBox1.Name = "monitorComboBox1";
            this.monitorComboBox1.Size = new System.Drawing.Size(107, 35);
            this.monitorComboBox1.StartIndex = 0;
            this.monitorComboBox1.TabIndex = 34;
            this.monitorComboBox1.UseTallSize = false;
            // 
            // testModeComboBox1
            // 
            this.testModeComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testModeComboBox1.AutoResize = false;
            this.testModeComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.testModeComboBox1.Depth = 0;
            this.testModeComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.testModeComboBox1.DropDownHeight = 118;
            this.testModeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testModeComboBox1.DropDownWidth = 121;
            this.testModeComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.testModeComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.testModeComboBox1.FormattingEnabled = true;
            this.testModeComboBox1.Hint = "Test mode";
            this.testModeComboBox1.IntegralHeight = false;
            this.testModeComboBox1.ItemHeight = 29;
            this.testModeComboBox1.Items.AddRange(new object[] {
            "Custom Pattern",
            "Color Spectrum",
            "Grayscale Gradient",
            "Color Lines",
            "Checkerboard",
            "Circular Gradient"});
            this.testModeComboBox1.Location = new System.Drawing.Point(4, 90);
            this.testModeComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.testModeComboBox1.MaxDropDownItems = 4;
            this.testModeComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.testModeComboBox1.Name = "testModeComboBox1";
            this.testModeComboBox1.Size = new System.Drawing.Size(107, 35);
            this.testModeComboBox1.StartIndex = 0;
            this.testModeComboBox1.TabIndex = 35;
            this.testModeComboBox1.UseTallSize = false;
            this.testModeComboBox1.SelectedIndexChanged += new System.EventHandler(this.testModeComboBox1_SelectedIndexChanged);
            this.testModeComboBox1.SelectionChangeCommitted += new System.EventHandler(this.testModeComboBox_SelectedIndexChanged);
            // 
            // testPatternComboBox1
            // 
            this.testPatternComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testPatternComboBox1.AutoResize = false;
            this.testPatternComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.testPatternComboBox1.Depth = 0;
            this.testPatternComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.testPatternComboBox1.DropDownHeight = 118;
            this.testPatternComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testPatternComboBox1.DropDownWidth = 121;
            this.testPatternComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.testPatternComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.testPatternComboBox1.FormattingEnabled = true;
            this.testPatternComboBox1.Hint = "Test pattern";
            this.testPatternComboBox1.IntegralHeight = false;
            this.testPatternComboBox1.ItemHeight = 29;
            this.testPatternComboBox1.Items.AddRange(new object[] {
            "Chessboard",
            "Circles",
            "Lines"});
            this.testPatternComboBox1.Location = new System.Drawing.Point(4, 47);
            this.testPatternComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.testPatternComboBox1.MaxDropDownItems = 4;
            this.testPatternComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.testPatternComboBox1.Name = "testPatternComboBox1";
            this.testPatternComboBox1.Size = new System.Drawing.Size(107, 35);
            this.testPatternComboBox1.StartIndex = 0;
            this.testPatternComboBox1.TabIndex = 36;
            this.testPatternComboBox1.UseTallSize = false;
            this.testPatternComboBox1.SelectedIndexChanged += new System.EventHandler(this.testPatternComboBox1_SelectedIndexChanged);
            // 
            // selectColorButton
            // 
            this.selectColorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectColorButton.BackColor = System.Drawing.Color.Transparent;
            this.selectColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectColorButton.Image = global::ServiceMonitorEVK.Properties.Resources.color_wheel1;
            this.selectColorButton.Location = new System.Drawing.Point(15, 133);
            this.selectColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectColorButton.Name = "selectColorButton";
            this.selectColorButton.Size = new System.Drawing.Size(84, 44);
            this.selectColorButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectColorButton.TabIndex = 32;
            this.selectColorButton.TabStop = false;
            this.selectColorButton.Click += new System.EventHandler(this.selectColorButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxRed);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxLime);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxYellow);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxAqua);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxMagneta);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxBlue);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxSilver);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxWhite);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxBlack);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxChoose);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox5);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox6);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox9);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox10);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox8);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox7);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox4);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(119, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanel1, 6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(55, 918);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.monitorComboBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.testPatternComboBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.testModeComboBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.selectColorButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.materialSliderOpasity, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 30);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(178, 933);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // MonitorTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(193, 967);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DrawerIsOpen = true;
            this.DrawerUseColors = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MonitorTestForm";
            this.Opacity = 0.9D;
            this.Padding = new System.Windows.Forms.Padding(4, 30, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MonitorTestForm_FormClosed);
            this.Load += new System.EventHandler(this.MonitorTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectColorButton)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Timer colorChangeTimer;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSlider materialSliderOpasity;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}