

namespace changeResolution1
{
    partial class PixelFixerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PixelFixerForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hoursUpDown = new System.Windows.Forms.NumericUpDown();
            this.minutesUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondsUpDown = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.monitorComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.monitorLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.intervalLavel1 = new MaterialSkin.Controls.MaterialLabel();
            this.intervalTrackBar1 = new MaterialSkin.Controls.MaterialSlider();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.multi_colorCheckBox1 = new MaterialSkin.Controls.MaterialSwitch();
            this.presetColorComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel38 = new MaterialSkin.Controls.MaterialLabel();
            this.startStopButton1 = new MaterialSkin.Controls.MaterialButton();
            this.progressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.timeLeftLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.testModeComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorPickerButton1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hoursUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsUpDown)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickerButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "s.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "m.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "g.";
            // 
            // hoursUpDown
            // 
            this.hoursUpDown.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.hoursUpDown.Location = new System.Drawing.Point(167, 289);
            this.hoursUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursUpDown.Name = "hoursUpDown";
            this.hoursUpDown.Size = new System.Drawing.Size(46, 20);
            this.hoursUpDown.TabIndex = 19;
            // 
            // minutesUpDown
            // 
            this.minutesUpDown.Location = new System.Drawing.Point(241, 289);
            this.minutesUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesUpDown.Name = "minutesUpDown";
            this.minutesUpDown.Size = new System.Drawing.Size(46, 20);
            this.minutesUpDown.TabIndex = 18;
            // 
            // secondsUpDown
            // 
            this.secondsUpDown.Location = new System.Drawing.Point(317, 289);
            this.secondsUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsUpDown.Name = "secondsUpDown";
            this.secondsUpDown.Size = new System.Drawing.Size(46, 20);
            this.secondsUpDown.TabIndex = 16;
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
            this.monitorComboBox1.IntegralHeight = false;
            this.monitorComboBox1.ItemHeight = 43;
            this.monitorComboBox1.Location = new System.Drawing.Point(125, 44);
            this.monitorComboBox1.MaxDropDownItems = 4;
            this.monitorComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.monitorComboBox1.Name = "monitorComboBox1";
            this.monitorComboBox1.Size = new System.Drawing.Size(247, 49);
            this.monitorComboBox1.StartIndex = 0;
            this.monitorComboBox1.TabIndex = 33;
            this.toolTip1.SetToolTip(this.monitorComboBox1, "Choose monitor to repair pixel");
            // 
            // monitorLabel1
            // 
            this.monitorLabel1.AutoSize = true;
            this.monitorLabel1.Depth = 0;
            this.monitorLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.monitorLabel1.Location = new System.Drawing.Point(53, 65);
            this.monitorLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.monitorLabel1.Name = "monitorLabel1";
            this.monitorLabel1.Size = new System.Drawing.Size(60, 19);
            this.monitorLabel1.TabIndex = 1;
            this.monitorLabel1.Text = "Monitor:";
            // 
            // intervalLavel1
            // 
            this.intervalLavel1.AutoSize = true;
            this.intervalLavel1.Depth = 0;
            this.intervalLavel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.intervalLavel1.Location = new System.Drawing.Point(104, 289);
            this.intervalLavel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.intervalLavel1.Name = "intervalLavel1";
            this.intervalLavel1.Size = new System.Drawing.Size(46, 19);
            this.intervalLavel1.TabIndex = 2;
            this.intervalLavel1.Text = "Timer:";
            // 
            // intervalTrackBar1
            // 
            this.intervalTrackBar1.Depth = 0;
            this.intervalTrackBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.intervalTrackBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.intervalTrackBar1.Location = new System.Drawing.Point(56, 116);
            this.intervalTrackBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.intervalTrackBar1.Name = "intervalTrackBar1";
            this.intervalTrackBar1.RangeMin = 1;
            this.intervalTrackBar1.Size = new System.Drawing.Size(496, 40);
            this.intervalTrackBar1.TabIndex = 27;
            this.intervalTrackBar1.Text = "Interval:";
            this.intervalTrackBar1.Value = 10;
            this.intervalTrackBar1.ValueMax = 100;
            this.intervalTrackBar1.ValueSuffix = " ms.";
            this.intervalTrackBar1.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.intervalTrackBar_Scroll_1);
            // 
            // multi_colorCheckBox1
            // 
            this.multi_colorCheckBox1.AutoSize = true;
            this.multi_colorCheckBox1.Depth = 0;
            this.multi_colorCheckBox1.Location = new System.Drawing.Point(45, 249);
            this.multi_colorCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.multi_colorCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.multi_colorCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.multi_colorCheckBox1.Name = "multi_colorCheckBox1";
            this.multi_colorCheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.multi_colorCheckBox1.Ripple = true;
            this.multi_colorCheckBox1.Size = new System.Drawing.Size(129, 37);
            this.multi_colorCheckBox1.TabIndex = 32;
            this.multi_colorCheckBox1.Text = "Multicolor";
            this.multi_colorCheckBox1.UseVisualStyleBackColor = true;
            this.multi_colorCheckBox1.CheckedChanged += new System.EventHandler(this.multi_colorCheckBox1_CheckedChanged);
            // 
            // presetColorComboBox1
            // 
            this.presetColorComboBox1.AutoResize = false;
            this.presetColorComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.presetColorComboBox1.Depth = 0;
            this.presetColorComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.presetColorComboBox1.DropDownHeight = 174;
            this.presetColorComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presetColorComboBox1.DropDownWidth = 121;
            this.presetColorComboBox1.Enabled = false;
            this.presetColorComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.presetColorComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.presetColorComboBox1.FormattingEnabled = true;
            this.presetColorComboBox1.IntegralHeight = false;
            this.presetColorComboBox1.ItemHeight = 43;
            this.presetColorComboBox1.Items.AddRange(new object[] {
            "RGB Cycle",
            "Black & White",
            "Red & Green & Blue"});
            this.presetColorComboBox1.Location = new System.Drawing.Point(125, 178);
            this.presetColorComboBox1.MaxDropDownItems = 4;
            this.presetColorComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.presetColorComboBox1.Name = "presetColorComboBox1";
            this.presetColorComboBox1.Size = new System.Drawing.Size(203, 49);
            this.presetColorComboBox1.StartIndex = 0;
            this.presetColorComboBox1.TabIndex = 34;
            this.presetColorComboBox1.SelectedIndexChanged += new System.EventHandler(this.materialComboBox2_SelectedIndexChanged);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.materialLabel38);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(45, 328);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(7);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(494, 159);
            this.materialCard1.TabIndex = 67;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.HighEmphasis = true;
            this.materialLabel4.Location = new System.Drawing.Point(194, 14);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(98, 24);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "WARNIING";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel38
            // 
            this.materialLabel38.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel38.Depth = 0;
            this.materialLabel38.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel38.Location = new System.Drawing.Point(112, 43);
            this.materialLabel38.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel38.Name = "materialLabel38";
            this.materialLabel38.Size = new System.Drawing.Size(366, 102);
            this.materialLabel38.TabIndex = 2;
            this.materialLabel38.Text = "OSTRZEŻENIE: Proces ten spowoduje miganie świateł, które mogą wywołać drgawki u o" +
    "sób cierpiących na padaczkę światłoczułą. Postępuj ostrożnie.";
            this.materialLabel38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startStopButton1
            // 
            this.startStopButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startStopButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.startStopButton1.Depth = 0;
            this.startStopButton1.HighEmphasis = true;
            this.startStopButton1.Icon = null;
            this.startStopButton1.Location = new System.Drawing.Point(222, 489);
            this.startStopButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startStopButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.startStopButton1.Name = "startStopButton1";
            this.startStopButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.startStopButton1.Size = new System.Drawing.Size(110, 36);
            this.startStopButton1.TabIndex = 68;
            this.startStopButton1.Text = "START/STOP";
            this.startStopButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.startStopButton1.UseAccentColor = false;
            this.startStopButton1.UseVisualStyleBackColor = true;
            this.startStopButton1.Click += new System.EventHandler(this.startStopButton_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Depth = 0;
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(13, 534);
            this.progressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(500, 5);
            this.progressBar1.TabIndex = 25;
            // 
            // timeLeftLabel1
            // 
            this.timeLeftLabel1.AutoSize = true;
            this.timeLeftLabel1.Depth = 0;
            this.timeLeftLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.timeLeftLabel1.Location = new System.Drawing.Point(234, 559);
            this.timeLeftLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.timeLeftLabel1.Name = "timeLeftLabel1";
            this.timeLeftLabel1.Size = new System.Drawing.Size(1, 0);
            this.timeLeftLabel1.TabIndex = 69;
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
            this.testModeComboBox1.IntegralHeight = false;
            this.testModeComboBox1.ItemHeight = 43;
            this.testModeComboBox1.Items.AddRange(new object[] {
            "None",
            "Color Spectrum",
            "Grayscale Gradient"});
            this.testModeComboBox1.Location = new System.Drawing.Point(334, 178);
            this.testModeComboBox1.MaxDropDownItems = 4;
            this.testModeComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.testModeComboBox1.Name = "testModeComboBox1";
            this.testModeComboBox1.Size = new System.Drawing.Size(218, 49);
            this.testModeComboBox1.StartIndex = 0;
            this.testModeComboBox1.TabIndex = 70;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ServiceMonitorEVK.Properties.Resources.select;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(423, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.locateButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton1.Image = global::ServiceMonitorEVK.Properties.Resources.color_wheel;
            this.colorPickerButton1.Location = new System.Drawing.Point(52, 162);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.Size = new System.Drawing.Size(61, 72);
            this.colorPickerButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colorPickerButton1.TabIndex = 31;
            this.colorPickerButton1.TabStop = false;
            this.colorPickerButton1.Click += new System.EventHandler(this.colorPickerButton_Click_1);
            // 
            // PixelFixerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 610);
            this.Controls.Add(this.testModeComboBox1);
            this.Controls.Add(this.timeLeftLabel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.startStopButton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.presetColorComboBox1);
            this.Controls.Add(this.monitorComboBox1);
            this.Controls.Add(this.multi_colorCheckBox1);
            this.Controls.Add(this.intervalTrackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.intervalLavel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monitorLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hoursUpDown);
            this.Controls.Add(this.colorPickerButton1);
            this.Controls.Add(this.minutesUpDown);
            this.Controls.Add(this.secondsUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.Name = "PixelFixerForm";
            this.Opacity = 0.9D;
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "PixelFixerForm";
            ((System.ComponentModel.ISupportInitialize)(this.hoursUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsUpDown)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickerButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown secondsUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown hoursUpDown;
        private System.Windows.Forms.NumericUpDown minutesUpDown;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel monitorLabel1;
        private MaterialSkin.Controls.MaterialLabel intervalLavel1;
        private MaterialSkin.Controls.MaterialSlider intervalTrackBar1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox colorPickerButton1;
        private MaterialSkin.Controls.MaterialSwitch multi_colorCheckBox1;
        private MaterialSkin.Controls.MaterialComboBox monitorComboBox1;
        private MaterialSkin.Controls.MaterialComboBox presetColorComboBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel38;
        private MaterialSkin.Controls.MaterialButton startStopButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialProgressBar progressBar1;
        private MaterialSkin.Controls.MaterialLabel timeLeftLabel1;
        private MaterialSkin.Controls.MaterialComboBox testModeComboBox1;
    }
}