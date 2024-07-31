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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.MonitorComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResolutionComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SetMaxResolution = new MaterialSkin.Controls.MaterialButton();
            this.SetResolution = new MaterialSkin.Controls.MaterialButton();
            this.showFullInfoButton = new MaterialSkin.Controls.MaterialButton();
            this.ShowInformationButton = new MaterialSkin.Controls.MaterialButton();
            this.fixDisplayButton = new MaterialSkin.Controls.MaterialButton();
            this.testFormButton = new MaterialSkin.Controls.MaterialButton();
            this.searchInfoButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 40);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = ":)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 567);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "duplicate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 567);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "extend";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(113, 596);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "primary only";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(234, 596);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "secondary only";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = ";)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1402, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = ";)";
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
            this.button7.Location = new System.Drawing.Point(32, 595);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 21;
            this.button7.Text = "search info";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(13, 27);
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
            this.materialLabel2.Location = new System.Drawing.Point(13, 79);
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
            this.MonitorComboBox.Location = new System.Drawing.Point(148, 12);
            this.MonitorComboBox.MaxDropDownItems = 4;
            this.MonitorComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.MonitorComboBox.Name = "MonitorComboBox";
            this.MonitorComboBox.Size = new System.Drawing.Size(283, 35);
            this.MonitorComboBox.StartIndex = 0;
            this.MonitorComboBox.TabIndex = 26;
            this.MonitorComboBox.UseTallSize = false;
            this.MonitorComboBox.SelectedIndexChanged += new System.EventHandler(this.MonitorComboBox_SelectedIndexChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ServiceMonitorEVK.Properties.Resources.DA;
            this.pictureBox1.Location = new System.Drawing.Point(12, 624);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.ResolutionComboBox.Location = new System.Drawing.Point(148, 63);
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
            this.SetMaxResolution.Location = new System.Drawing.Point(148, 107);
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
            this.SetResolution.Location = new System.Drawing.Point(303, 107);
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
            // showFullInfoButton
            // 
            this.showFullInfoButton.AutoSize = false;
            this.showFullInfoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showFullInfoButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.showFullInfoButton.Depth = 0;
            this.showFullInfoButton.HighEmphasis = true;
            this.showFullInfoButton.Icon = null;
            this.showFullInfoButton.Location = new System.Drawing.Point(16, 190);
            this.showFullInfoButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.showFullInfoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.showFullInfoButton.Name = "showFullInfoButton";
            this.showFullInfoButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.showFullInfoButton.Size = new System.Drawing.Size(134, 36);
            this.showFullInfoButton.TabIndex = 30;
            this.showFullInfoButton.Text = "Show full info";
            this.showFullInfoButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.showFullInfoButton.UseAccentColor = false;
            this.showFullInfoButton.UseVisualStyleBackColor = true;
            this.showFullInfoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowInformationButton
            // 
            this.ShowInformationButton.AutoSize = false;
            this.ShowInformationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowInformationButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ShowInformationButton.Depth = 0;
            this.ShowInformationButton.HighEmphasis = true;
            this.ShowInformationButton.Icon = null;
            this.ShowInformationButton.Location = new System.Drawing.Point(171, 190);
            this.ShowInformationButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ShowInformationButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowInformationButton.Name = "ShowInformationButton";
            this.ShowInformationButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ShowInformationButton.Size = new System.Drawing.Size(134, 36);
            this.ShowInformationButton.TabIndex = 31;
            this.ShowInformationButton.Text = "Show information";
            this.ShowInformationButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ShowInformationButton.UseAccentColor = false;
            this.ShowInformationButton.UseVisualStyleBackColor = true;
            this.ShowInformationButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // fixDisplayButton
            // 
            this.fixDisplayButton.AutoSize = false;
            this.fixDisplayButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fixDisplayButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.fixDisplayButton.Depth = 0;
            this.fixDisplayButton.HighEmphasis = true;
            this.fixDisplayButton.Icon = null;
            this.fixDisplayButton.Location = new System.Drawing.Point(16, 238);
            this.fixDisplayButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fixDisplayButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.fixDisplayButton.Name = "fixDisplayButton";
            this.fixDisplayButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.fixDisplayButton.Size = new System.Drawing.Size(134, 36);
            this.fixDisplayButton.TabIndex = 32;
            this.fixDisplayButton.Text = "Fix pixel";
            this.fixDisplayButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.fixDisplayButton.UseAccentColor = false;
            this.fixDisplayButton.UseVisualStyleBackColor = true;
            this.fixDisplayButton.Click += new System.EventHandler(this.fixDisplayButton_Click);
            // 
            // testFormButton
            // 
            this.testFormButton.AutoSize = false;
            this.testFormButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.testFormButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.testFormButton.Depth = 0;
            this.testFormButton.HighEmphasis = true;
            this.testFormButton.Icon = null;
            this.testFormButton.Location = new System.Drawing.Point(171, 238);
            this.testFormButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.testFormButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.testFormButton.Name = "testFormButton";
            this.testFormButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.testFormButton.Size = new System.Drawing.Size(134, 36);
            this.testFormButton.TabIndex = 33;
            this.testFormButton.Text = "Test Monitor";
            this.testFormButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.testFormButton.UseAccentColor = false;
            this.testFormButton.UseVisualStyleBackColor = true;
            this.testFormButton.Click += new System.EventHandler(this.testFormButton_Click);
            // 
            // searchInfoButton
            // 
            this.searchInfoButton.AutoSize = false;
            this.searchInfoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchInfoButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchInfoButton.Depth = 0;
            this.searchInfoButton.HighEmphasis = true;
            this.searchInfoButton.Icon = null;
            this.searchInfoButton.Location = new System.Drawing.Point(16, 286);
            this.searchInfoButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchInfoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchInfoButton.Name = "searchInfoButton";
            this.searchInfoButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchInfoButton.Size = new System.Drawing.Size(134, 36);
            this.searchInfoButton.TabIndex = 34;
            this.searchInfoButton.Text = "Search info";
            this.searchInfoButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchInfoButton.UseAccentColor = false;
            this.searchInfoButton.UseVisualStyleBackColor = true;
            this.searchInfoButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(771, 648);
            this.Controls.Add(this.searchInfoButton);
            this.Controls.Add(this.testFormButton);
            this.Controls.Add(this.fixDisplayButton);
            this.Controls.Add(this.ShowInformationButton);
            this.Controls.Add(this.showFullInfoButton);
            this.Controls.Add(this.SetResolution);
            this.Controls.Add(this.SetMaxResolution);
            this.Controls.Add(this.ResolutionComboBox);
            this.Controls.Add(this.MonitorComboBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button7;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox MonitorComboBox;
        private MaterialSkin.Controls.MaterialComboBox ResolutionComboBox;
        private MaterialSkin.Controls.MaterialButton SetMaxResolution;
        private MaterialSkin.Controls.MaterialButton SetResolution;
        private MaterialSkin.Controls.MaterialButton showFullInfoButton;
        private MaterialSkin.Controls.MaterialButton ShowInformationButton;
        private MaterialSkin.Controls.MaterialButton fixDisplayButton;
        private MaterialSkin.Controls.MaterialButton testFormButton;
        private MaterialSkin.Controls.MaterialButton searchInfoButton;
    }
}

