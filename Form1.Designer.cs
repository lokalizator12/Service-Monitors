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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MonitorComboBox = new System.Windows.Forms.ComboBox();
            this.ResolutionComboBox = new System.Windows.Forms.ComboBox();
            this.SetResolution1 = new System.Windows.Forms.Button();
            this.SetMaxResolution = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.fixDisplayButton = new System.Windows.Forms.Button();
            this.testFormButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MonitorComboBox
            // 
            this.MonitorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonitorComboBox.FormattingEnabled = true;
            this.MonitorComboBox.Location = new System.Drawing.Point(127, 25);
            this.MonitorComboBox.Name = "MonitorComboBox";
            this.MonitorComboBox.Size = new System.Drawing.Size(167, 21);
            this.MonitorComboBox.TabIndex = 0;
            this.MonitorComboBox.SelectedIndexChanged += new System.EventHandler(this.MonitorComboBox_SelectedIndexChanged);
            // 
            // ResolutionComboBox
            // 
            this.ResolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResolutionComboBox.FormattingEnabled = true;
            this.ResolutionComboBox.Location = new System.Drawing.Point(127, 59);
            this.ResolutionComboBox.Name = "ResolutionComboBox";
            this.ResolutionComboBox.Size = new System.Drawing.Size(167, 21);
            this.ResolutionComboBox.TabIndex = 1;
            // 
            // SetResolution1
            // 
            this.SetResolution1.Location = new System.Drawing.Point(136, 113);
            this.SetResolution1.Name = "SetResolution1";
            this.SetResolution1.Size = new System.Drawing.Size(112, 23);
            this.SetResolution1.TabIndex = 2;
            this.SetResolution1.Text = "Set Resolution";
            this.SetResolution1.UseVisualStyleBackColor = true;
            this.SetResolution1.Click += new System.EventHandler(this.SetResolution1_Click);
            // 
            // SetMaxResolution
            // 
            this.SetMaxResolution.Location = new System.Drawing.Point(12, 113);
            this.SetMaxResolution.Name = "SetMaxResolution";
            this.SetMaxResolution.Size = new System.Drawing.Size(112, 23);
            this.SetMaxResolution.TabIndex = 3;
            this.SetMaxResolution.Text = "Set Max. Resolution";
            this.SetMaxResolution.UseVisualStyleBackColor = true;
            this.SetMaxResolution.Click += new System.EventHandler(this.SetMaxResolution_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Display";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Change Resolution";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = ";)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = ":)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1023, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = ":)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Show information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = ":)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "duplicate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(134, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "extend";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "primary only";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(136, 255);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "secondary only";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // fixDisplayButton
            // 
            this.fixDisplayButton.Location = new System.Drawing.Point(16, 296);
            this.fixDisplayButton.Name = "fixDisplayButton";
            this.fixDisplayButton.Size = new System.Drawing.Size(75, 23);
            this.fixDisplayButton.TabIndex = 15;
            this.fixDisplayButton.Text = "fix pixel";
            this.fixDisplayButton.UseVisualStyleBackColor = true;
            this.fixDisplayButton.Click += new System.EventHandler(this.fixDisplayButton_Click);
            // 
            // testFormButton
            // 
            this.testFormButton.Location = new System.Drawing.Point(136, 296);
            this.testFormButton.Name = "testFormButton";
            this.testFormButton.Size = new System.Drawing.Size(75, 23);
            this.testFormButton.TabIndex = 16;
            this.testFormButton.Text = "test monitor";
            this.testFormButton.UseVisualStyleBackColor = true;
            this.testFormButton.Click += new System.EventHandler(this.testFormButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = ";)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1023, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = ";)";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(136, 325);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "search info";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1390, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = ":)";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(219, 325);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 21;
            this.button7.Text = "search info";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::changeResolution1.Properties.Resources.DA;
            this.pictureBox1.Location = new System.Drawing.Point(1589, 650);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1743, 777);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.testFormButton);
            this.Controls.Add(this.fixDisplayButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetMaxResolution);
            this.Controls.Add(this.SetResolution1);
            this.Controls.Add(this.ResolutionComboBox);
            this.Controls.Add(this.MonitorComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button SetMaxResolution;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label6;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button fixDisplayButton;
        private Button testFormButton;
        private Label label7;
        private Label label8;
        private Button button6;
        private Label label9;
        private Button button7;
        private PictureBox pictureBox1;
    }
}

