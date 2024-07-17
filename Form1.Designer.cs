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
            this.MonitorComboBox = new System.Windows.Forms.ComboBox();
            this.ResolutionComboBox = new System.Windows.Forms.ComboBox();
            this.SetResolution1 = new System.Windows.Forms.Button();
            this.SetMaxResolution = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MonitorComboBox
            // 
            this.MonitorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonitorComboBox.FormattingEnabled = true;
            this.MonitorComboBox.Location = new System.Drawing.Point(127, 25);
            this.MonitorComboBox.Name = "MonitorComboBox";
            this.MonitorComboBox.Size = new System.Drawing.Size(121, 21);
            this.MonitorComboBox.TabIndex = 0;
            this.MonitorComboBox.SelectedIndexChanged += new System.EventHandler(this.MonitorComboBox_SelectedIndexChanged);
            // 
            // ResolutionComboBox
            // 
            this.ResolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResolutionComboBox.FormattingEnabled = true;
            this.ResolutionComboBox.Location = new System.Drawing.Point(127, 73);
            this.ResolutionComboBox.Name = "ResolutionComboBox";
            this.ResolutionComboBox.Size = new System.Drawing.Size(121, 21);
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
            this.label2.Location = new System.Drawing.Point(12, 76);
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
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Display";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Change Resolution";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1023, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Change Resolution";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1256, 576);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetMaxResolution);
            this.Controls.Add(this.SetResolution1);
            this.Controls.Add(this.ResolutionComboBox);
            this.Controls.Add(this.MonitorComboBox);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button SetMaxResolution;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}

