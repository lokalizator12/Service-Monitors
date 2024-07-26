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
            this.startStopButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorPickerButton = new System.Windows.Forms.Button();
            this.intervalTrackBar = new System.Windows.Forms.TrackBar();
            this.monitorComboBox = new System.Windows.Forms.ComboBox();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.multi_colorCheckBox = new System.Windows.Forms.CheckBox();
            this.locateButton = new System.Windows.Forms.Button();
            this.monitorLabel = new System.Windows.Forms.Label();
            this.intervalDescriptionLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.testModeComboBox = new System.Windows.Forms.ComboBox();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hoursUpDown = new System.Windows.Forms.NumericUpDown();
            this.minutesUpDown = new System.Windows.Forms.NumericUpDown();
            this.timerLabel = new System.Windows.Forms.Label();
            this.secondsUpDown = new System.Windows.Forms.NumericUpDown();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.presetColorLabel = new System.Windows.Forms.Label();
            this.presetColorComboBox = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.intervalTrackBar)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(118, 294);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(98, 23);
            this.startStopButton.TabIndex = 1;
            this.startStopButton.Text = "START/STOP";
            this.toolTip1.SetToolTip(this.startStopButton, "Rozpocznij lub przestań migać");
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // colorPickerButton
            // 
            this.colorPickerButton.Location = new System.Drawing.Point(15, 105);
            this.colorPickerButton.Name = "colorPickerButton";
            this.colorPickerButton.Size = new System.Drawing.Size(89, 32);
            this.colorPickerButton.TabIndex = 4;
            this.colorPickerButton.Text = "Wybrać kolor";
            this.toolTip1.SetToolTip(this.colorPickerButton, "Wybierz kolor do migania");
            this.colorPickerButton.UseVisualStyleBackColor = true;
            this.colorPickerButton.Click += new System.EventHandler(this.colorPickerButton_Click_1);
            // 
            // intervalTrackBar
            // 
            this.intervalTrackBar.Location = new System.Drawing.Point(85, 59);
            this.intervalTrackBar.Maximum = 100;
            this.intervalTrackBar.Minimum = 1;
            this.intervalTrackBar.Name = "intervalTrackBar";
            this.intervalTrackBar.Size = new System.Drawing.Size(121, 45);
            this.intervalTrackBar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.intervalTrackBar, "Ustaw interwał migania");
            this.intervalTrackBar.Value = 10;
            this.intervalTrackBar.Scroll += new System.EventHandler(this.intervalTrackBar_Scroll_1);
            // 
            // monitorComboBox
            // 
            this.monitorComboBox.FormattingEnabled = true;
            this.monitorComboBox.Location = new System.Drawing.Point(77, 21);
            this.monitorComboBox.Name = "monitorComboBox";
            this.monitorComboBox.Size = new System.Drawing.Size(121, 21);
            this.monitorComboBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.monitorComboBox, "Wybierz monitor do naprawy pikseli");
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(212, 69);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(19, 13);
            this.intervalLabel.TabIndex = 8;
            this.intervalLabel.Text = "10";
            // 
            // multi_colorCheckBox
            // 
            this.multi_colorCheckBox.AutoSize = true;
            this.multi_colorCheckBox.Location = new System.Drawing.Point(118, 114);
            this.multi_colorCheckBox.Name = "multi_colorCheckBox";
            this.multi_colorCheckBox.Size = new System.Drawing.Size(124, 17);
            this.multi_colorCheckBox.TabIndex = 9;
            this.multi_colorCheckBox.Text = "WIELOBARWNOŚĆ";
            this.toolTip1.SetToolTip(this.multi_colorCheckBox, "Włącz tryb migania wielokolorowego");
            this.multi_colorCheckBox.UseVisualStyleBackColor = true;
            this.multi_colorCheckBox.CheckedChanged += new System.EventHandler(this.multi_colorCheckBox_CheckedChanged);
            // 
            // locateButton
            // 
            this.locateButton.Location = new System.Drawing.Point(232, 21);
            this.locateButton.Name = "locateButton";
            this.locateButton.Size = new System.Drawing.Size(105, 23);
            this.locateButton.TabIndex = 10;
            this.locateButton.Text = "Wybrać obszar";
            this.toolTip1.SetToolTip(this.locateButton, "Wybierz obszary na ekranie do naprawy pikseli");
            this.locateButton.UseVisualStyleBackColor = true;
            this.locateButton.Click += new System.EventHandler(this.locateButton_Click);
            // 
            // monitorLabel
            // 
            this.monitorLabel.AutoSize = true;
            this.monitorLabel.Location = new System.Drawing.Point(26, 24);
            this.monitorLabel.Name = "monitorLabel";
            this.monitorLabel.Size = new System.Drawing.Size(45, 13);
            this.monitorLabel.TabIndex = 11;
            this.monitorLabel.Text = "Monitor:";
            // 
            // intervalDescriptionLabel
            // 
            this.intervalDescriptionLabel.AutoSize = true;
            this.intervalDescriptionLabel.Location = new System.Drawing.Point(26, 59);
            this.intervalDescriptionLabel.Name = "intervalDescriptionLabel";
            this.intervalDescriptionLabel.Size = new System.Drawing.Size(49, 13);
            this.intervalDescriptionLabel.TabIndex = 12;
            this.intervalDescriptionLabel.Text = "Interwał:";
            // 
            // controlPanel
            // 
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlPanel.Controls.Add(this.siticoneTextBox1);
            this.controlPanel.Controls.Add(this.pictureBox1);
            this.controlPanel.Controls.Add(this.testModeComboBox);
            this.controlPanel.Controls.Add(this.timeLeftLabel);
            this.controlPanel.Controls.Add(this.label3);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.hoursUpDown);
            this.controlPanel.Controls.Add(this.minutesUpDown);
            this.controlPanel.Controls.Add(this.timerLabel);
            this.controlPanel.Controls.Add(this.secondsUpDown);
            this.controlPanel.Controls.Add(this.progressBar);
            this.controlPanel.Controls.Add(this.presetColorLabel);
            this.controlPanel.Controls.Add(this.presetColorComboBox);
            this.controlPanel.Controls.Add(this.startStopButton);
            this.controlPanel.Controls.Add(this.colorPickerButton);
            this.controlPanel.Controls.Add(this.intervalTrackBar);
            this.controlPanel.Controls.Add(this.monitorComboBox);
            this.controlPanel.Controls.Add(this.intervalLabel);
            this.controlPanel.Controls.Add(this.multi_colorCheckBox);
            this.controlPanel.Controls.Add(this.locateButton);
            this.controlPanel.Controls.Add(this.monitorLabel);
            this.controlPanel.Controls.Add(this.intervalDescriptionLabel);
            this.controlPanel.Location = new System.Drawing.Point(12, 12);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(372, 351);
            this.controlPanel.TabIndex = 0;
            // 
            // testModeComboBox
            // 
            this.testModeComboBox.FormattingEnabled = true;
            this.testModeComboBox.Items.AddRange(new object[] {
            "None",
            "Color Spectrum",
            "Grayscale Gradient"});
            this.testModeComboBox.Location = new System.Drawing.Point(264, 66);
            this.testModeComboBox.Name = "testModeComboBox";
            this.testModeComboBox.Size = new System.Drawing.Size(91, 21);
            this.testModeComboBox.TabIndex = 24;
            this.toolTip1.SetToolTip(this.testModeComboBox, "Select a test mode for color spectrum or gradient");
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.Location = new System.Drawing.Point(261, 333);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(10, 13);
            this.timeLeftLabel.TabIndex = 23;
            this.timeLeftLabel.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "s.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "m.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "g.";
            // 
            // hoursUpDown
            // 
            this.hoursUpDown.Location = new System.Drawing.Point(118, 183);
            this.hoursUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursUpDown.Name = "hoursUpDown";
            this.hoursUpDown.Size = new System.Drawing.Size(46, 20);
            this.hoursUpDown.TabIndex = 19;
            this.hoursUpDown.ValueChanged += new System.EventHandler(this.hoursUpDown_ValueChanged);
            // 
            // minutesUpDown
            // 
            this.minutesUpDown.Location = new System.Drawing.Point(185, 183);
            this.minutesUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesUpDown.Name = "minutesUpDown";
            this.minutesUpDown.Size = new System.Drawing.Size(46, 20);
            this.minutesUpDown.TabIndex = 18;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(26, 190);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(36, 13);
            this.timerLabel.TabIndex = 17;
            this.timerLabel.Text = "Timer:";
            // 
            // secondsUpDown
            // 
            this.secondsUpDown.Location = new System.Drawing.Point(248, 183);
            this.secondsUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsUpDown.Name = "secondsUpDown";
            this.secondsUpDown.Size = new System.Drawing.Size(46, 20);
            this.secondsUpDown.TabIndex = 16;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 323);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(240, 23);
            this.progressBar.TabIndex = 15;
            // 
            // presetColorLabel
            // 
            this.presetColorLabel.AutoSize = true;
            this.presetColorLabel.Location = new System.Drawing.Point(26, 156);
            this.presetColorLabel.Name = "presetColorLabel";
            this.presetColorLabel.Size = new System.Drawing.Size(102, 13);
            this.presetColorLabel.TabIndex = 14;
            this.presetColorLabel.Text = "Ustawienia kolorów:";
            // 
            // presetColorComboBox
            // 
            this.presetColorComboBox.Enabled = false;
            this.presetColorComboBox.FormattingEnabled = true;
            this.presetColorComboBox.Items.AddRange(new object[] {
            "RGB Cycle",
            "Black & White",
            "Red & Green & Blue"});
            this.presetColorComboBox.Location = new System.Drawing.Point(134, 153);
            this.presetColorComboBox.Name = "presetColorComboBox";
            this.presetColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.presetColorComboBox.TabIndex = 13;
            this.presetColorComboBox.SelectedIndexChanged += new System.EventHandler(this.presetColorComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.BackColor = System.Drawing.Color.Khaki;
            this.siticoneTextBox1.BorderColor = System.Drawing.Color.Yellow;
            this.siticoneTextBox1.BorderRadius = 4;
            this.siticoneTextBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.Enabled = false;
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.siticoneTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Location = new System.Drawing.Point(100, 209);
            this.siticoneTextBox1.Multiline = true;
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderText = "";
            this.siticoneTextBox1.ReadOnly = true;
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.Size = new System.Drawing.Size(255, 81);
            this.siticoneTextBox1.TabIndex = 27;
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // PixelFixerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 375);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PixelFixerForm";
            this.Text = "PixelFixerForm";
            ((System.ComponentModel.ISupportInitialize)(this.intervalTrackBar)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button colorPickerButton;
        private System.Windows.Forms.TrackBar intervalTrackBar;
        private System.Windows.Forms.ComboBox monitorComboBox;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.CheckBox multi_colorCheckBox;
        private System.Windows.Forms.Button locateButton;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label monitorLabel;
        private System.Windows.Forms.Label intervalDescriptionLabel;
        private System.Windows.Forms.ComboBox presetColorComboBox;
        private System.Windows.Forms.Label presetColorLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.NumericUpDown secondsUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown hoursUpDown;
        private System.Windows.Forms.NumericUpDown minutesUpDown;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.ComboBox testModeComboBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
    }
}