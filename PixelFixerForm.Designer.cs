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
            this.startStopButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorPickerButton = new System.Windows.Forms.Button();
            this.intervalTrackBar = new System.Windows.Forms.TrackBar();
            this.monitorComboBox = new System.Windows.Forms.ComboBox();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.multi_colorCheckBox = new System.Windows.Forms.CheckBox();
            this.locateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.intervalTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(15, 93);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(98, 23);
            this.startStopButton.TabIndex = 1;
            this.startStopButton.Text = "START/STOP";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // colorPickerButton
            // 
            this.colorPickerButton.Location = new System.Drawing.Point(15, 64);
            this.colorPickerButton.Name = "colorPickerButton";
            this.colorPickerButton.Size = new System.Drawing.Size(75, 23);
            this.colorPickerButton.TabIndex = 4;
            this.colorPickerButton.Text = "COLOR";
            this.colorPickerButton.UseVisualStyleBackColor = true;
            this.colorPickerButton.Click += new System.EventHandler(this.colorPickerButton_Click_1);
            // 
            // intervalTrackBar
            // 
            this.intervalTrackBar.Location = new System.Drawing.Point(12, 122);
            this.intervalTrackBar.Maximum = 100;
            this.intervalTrackBar.Minimum = 1;
            this.intervalTrackBar.Name = "intervalTrackBar";
            this.intervalTrackBar.Size = new System.Drawing.Size(121, 45);
            this.intervalTrackBar.TabIndex = 5;
            this.intervalTrackBar.Value = 10;
            this.intervalTrackBar.Scroll += new System.EventHandler(this.intervalTrackBar_Scroll_1);
            // 
            // monitorComboBox
            // 
            this.monitorComboBox.FormattingEnabled = true;
            this.monitorComboBox.Location = new System.Drawing.Point(12, 26);
            this.monitorComboBox.Name = "monitorComboBox";
            this.monitorComboBox.Size = new System.Drawing.Size(121, 21);
            this.monitorComboBox.TabIndex = 7;
            this.monitorComboBox.SelectedIndexChanged += new System.EventHandler(this.monitorComboBox_SelectedIndexChanged);
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(12, 170);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(10, 13);
            this.intervalLabel.TabIndex = 8;
            this.intervalLabel.Text = " ";
            // 
            // multi_colorCheckBox
            // 
            this.multi_colorCheckBox.AutoSize = true;
            this.multi_colorCheckBox.Location = new System.Drawing.Point(108, 68);
            this.multi_colorCheckBox.Name = "multi_colorCheckBox";
            this.multi_colorCheckBox.Size = new System.Drawing.Size(71, 17);
            this.multi_colorCheckBox.TabIndex = 9;
            this.multi_colorCheckBox.Text = "Multicolor";
            this.multi_colorCheckBox.UseVisualStyleBackColor = true;
            this.multi_colorCheckBox.CheckedChanged += new System.EventHandler(this.multi_colorCheckBox_CheckedChanged);
            // 
            // locateButton
            // 
            this.locateButton.Location = new System.Drawing.Point(146, 174);
            this.locateButton.Name = "locateButton";
            this.locateButton.Size = new System.Drawing.Size(75, 23);
            this.locateButton.TabIndex = 10;
            this.locateButton.Text = "locate ";
            this.locateButton.UseVisualStyleBackColor = true;
            this.locateButton.Click += new System.EventHandler(this.locateButton_Click);
            // 
            // PixelFixerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 205);
            this.Controls.Add(this.locateButton);
            this.Controls.Add(this.multi_colorCheckBox);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.monitorComboBox);
            this.Controls.Add(this.intervalTrackBar);
            this.Controls.Add(this.colorPickerButton);
            this.Controls.Add(this.startStopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PixelFixerForm";
            this.Text = "PixelFixerForm";
            ((System.ComponentModel.ISupportInitialize)(this.intervalTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}