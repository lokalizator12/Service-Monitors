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
            this.monitorLabel = new System.Windows.Forms.Label();
            this.startTestButton = new System.Windows.Forms.Button();
            this.monitorComboBox = new System.Windows.Forms.ComboBox();
            this.testPatternComboBox = new System.Windows.Forms.ComboBox();
            this.testModeComboBox = new System.Windows.Forms.ComboBox();
            this.selectColorButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorChangeTimer = new System.Windows.Forms.Timer(this.components);
            this.colorPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // monitorLabel
            // 
            this.monitorLabel.AutoSize = true;
            this.monitorLabel.Location = new System.Drawing.Point(12, 9);
            this.monitorLabel.Name = "monitorLabel";
            this.monitorLabel.Size = new System.Drawing.Size(45, 13);
            this.monitorLabel.TabIndex = 0;
            this.monitorLabel.Text = "Monitor:";
            // 
            // startTestButton
            // 
            this.startTestButton.Location = new System.Drawing.Point(116, 126);
            this.startTestButton.Name = "startTestButton";
            this.startTestButton.Size = new System.Drawing.Size(75, 23);
            this.startTestButton.TabIndex = 1;
            this.startTestButton.Text = "test";
            this.startTestButton.UseVisualStyleBackColor = true;
            this.startTestButton.Click += new System.EventHandler(this.testMonitorButton_Click);
            // 
            // monitorComboBox
            // 
            this.monitorComboBox.FormattingEnabled = true;
            this.monitorComboBox.Location = new System.Drawing.Point(93, 6);
            this.monitorComboBox.Name = "monitorComboBox";
            this.monitorComboBox.Size = new System.Drawing.Size(121, 21);
            this.monitorComboBox.TabIndex = 2;
            // 
            // testPatternComboBox
            // 
            this.testPatternComboBox.Enabled = false;
            this.testPatternComboBox.FormattingEnabled = true;
            this.testPatternComboBox.Items.AddRange(new object[] {
            "Chessboard",
            "Circles",
            "Lines"});
            this.testPatternComboBox.Location = new System.Drawing.Point(93, 47);
            this.testPatternComboBox.Name = "testPatternComboBox";
            this.testPatternComboBox.Size = new System.Drawing.Size(121, 21);
            this.testPatternComboBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.testPatternComboBox, "Select a test pattern");
            // 
            // testModeComboBox
            // 
            this.testModeComboBox.FormattingEnabled = true;
            this.testModeComboBox.Items.AddRange(new object[] {
            "Custom Pattern",
            "Color Spectrum",
            "Grayscale Gradient",
            "Color Lines",
            "Checkerboard",
            "Circular Gradient"});
            this.testModeComboBox.Location = new System.Drawing.Point(93, 85);
            this.testModeComboBox.Name = "testModeComboBox";
            this.testModeComboBox.Size = new System.Drawing.Size(121, 21);
            this.testModeComboBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.testModeComboBox, "Select a test mode for color spectrum or gradient");
            this.testModeComboBox.SelectedIndexChanged += new System.EventHandler(this.testModeComboBox_SelectedIndexChanged);
            // 
            // selectColorButton
            // 
            this.selectColorButton.Enabled = false;
            this.selectColorButton.Location = new System.Drawing.Point(12, 85);
            this.selectColorButton.Name = "selectColorButton";
            this.selectColorButton.Size = new System.Drawing.Size(75, 23);
            this.selectColorButton.TabIndex = 5;
            this.selectColorButton.Text = "color";
            this.selectColorButton.UseVisualStyleBackColor = true;
            this.selectColorButton.Click += new System.EventHandler(this.selectColorButton_Click);
            // 
            // colorChangeTimer
            // 
            this.colorChangeTimer.Tick += new System.EventHandler(this.colorChangeTimer_Tick);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Gray;
            this.colorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.colorPanel.Location = new System.Drawing.Point(0, 322);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(800, 128);
            this.colorPanel.TabIndex = 6;
            // 
            // MonitorTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.selectColorButton);
            this.Controls.Add(this.testModeComboBox);
            this.Controls.Add(this.testPatternComboBox);
            this.Controls.Add(this.monitorComboBox);
            this.Controls.Add(this.startTestButton);
            this.Controls.Add(this.monitorLabel);
            this.Name = "MonitorTestForm";
            this.Text = "MonitorTestForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MonitorTestForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label monitorLabel;
        private System.Windows.Forms.Button startTestButton;
        private System.Windows.Forms.ComboBox monitorComboBox;
        private System.Windows.Forms.ComboBox testPatternComboBox;
        private System.Windows.Forms.ComboBox testModeComboBox;
        private System.Windows.Forms.Button selectColorButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer colorChangeTimer;
        private System.Windows.Forms.Panel colorPanel;
    }
}