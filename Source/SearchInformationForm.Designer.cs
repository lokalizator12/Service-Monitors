namespace ServiceMonitorEVK
{
    partial class SearchInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchInformationForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchButton1 = new MaterialSkin.Controls.MaterialButton();
            this.manufacturerComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.infoLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.modelLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.infoDisplayTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.serialNumberTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.modelTextBox = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // searchButton1
            // 
            this.searchButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchButton1.Depth = 0;
            this.searchButton1.HighEmphasis = true;
            this.searchButton1.Icon = null;
            this.searchButton1.Location = new System.Drawing.Point(211, 233);
            this.searchButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchButton1.Name = "searchButton1";
            this.searchButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchButton1.Size = new System.Drawing.Size(78, 36);
            this.searchButton1.TabIndex = 12;
            this.searchButton1.Text = "Search";
            this.searchButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchButton1.UseAccentColor = false;
            this.searchButton1.UseVisualStyleBackColor = true;
            this.searchButton1.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // manufacturerComboBox1
            // 
            this.manufacturerComboBox1.AutoResize = false;
            this.manufacturerComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.manufacturerComboBox1.Depth = 0;
            this.manufacturerComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.manufacturerComboBox1.DropDownHeight = 118;
            this.manufacturerComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerComboBox1.DropDownWidth = 121;
            this.manufacturerComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.manufacturerComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.manufacturerComboBox1.FormattingEnabled = true;
            this.manufacturerComboBox1.Hint = "Choose manufacturer";
            this.manufacturerComboBox1.IntegralHeight = false;
            this.manufacturerComboBox1.ItemHeight = 29;
            this.manufacturerComboBox1.Items.AddRange(new object[] {
            "Dell",
            "Lenovo"});
            this.manufacturerComboBox1.Location = new System.Drawing.Point(164, 79);
            this.manufacturerComboBox1.MaxDropDownItems = 4;
            this.manufacturerComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.manufacturerComboBox1.Name = "manufacturerComboBox1";
            this.manufacturerComboBox1.Size = new System.Drawing.Size(200, 35);
            this.manufacturerComboBox1.StartIndex = 0;
            this.manufacturerComboBox1.TabIndex = 13;
            this.manufacturerComboBox1.UseTallSize = false;
            this.manufacturerComboBox1.SelectedIndexChanged += new System.EventHandler(this.manufacturerComboBox_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(16, 95);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(97, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Manufacturer";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(16, 134);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(131, 19);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Serial number S\\N";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(16, 177);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(49, 19);
            this.materialLabel3.TabIndex = 18;
            this.materialLabel3.Text = "SystemModel ";
            // 
            // infoLabel1
            // 
            this.infoLabel1.AutoSize = true;
            this.infoLabel1.Depth = 0;
            this.infoLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.infoLabel1.Location = new System.Drawing.Point(389, 100);
            this.infoLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(11, 19);
            this.infoLabel1.TabIndex = 19;
            this.infoLabel1.Text = ":)";
            // 
            // modelLabel1
            // 
            this.modelLabel1.AutoSize = true;
            this.modelLabel1.Depth = 0;
            this.modelLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.modelLabel1.Location = new System.Drawing.Point(389, 174);
            this.modelLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.modelLabel1.Name = "modelLabel1";
            this.modelLabel1.Size = new System.Drawing.Size(11, 19);
            this.modelLabel1.TabIndex = 20;
            this.modelLabel1.Text = ":)";
            // 
            // infoDisplayTextBox
            // 
            this.infoDisplayTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.infoDisplayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoDisplayTextBox.Depth = 0;
            this.infoDisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.infoDisplayTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.infoDisplayTextBox.Location = new System.Drawing.Point(392, 282);
            this.infoDisplayTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoDisplayTextBox.Name = "infoDisplayTextBox";
            this.infoDisplayTextBox.ReadOnly = true;
            this.infoDisplayTextBox.Size = new System.Drawing.Size(642, 230);
            this.infoDisplayTextBox.TabIndex = 32;
            this.infoDisplayTextBox.Text = "";
            // 
            // serialNumberTextBox
            // 
            this.serialNumberTextBox.AnimateReadOnly = false;
            this.serialNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serialNumberTextBox.Depth = 0;
            this.serialNumberTextBox.Enabled = false;
            this.serialNumberTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.serialNumberTextBox.Hint = "ex. V1K49985";
            this.serialNumberTextBox.LeadingIcon = null;
            this.serialNumberTextBox.Location = new System.Drawing.Point(164, 120);
            this.serialNumberTextBox.MaxLength = 50;
            this.serialNumberTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.serialNumberTextBox.Multiline = false;
            this.serialNumberTextBox.Name = "serialNumberTextBox";
            this.serialNumberTextBox.Size = new System.Drawing.Size(200, 50);
            this.serialNumberTextBox.TabIndex = 33;
            this.serialNumberTextBox.Text = "";
            this.serialNumberTextBox.TrailingIcon = null;
            this.serialNumberTextBox.TextChanged += new System.EventHandler(this.serialNumberTextBox_TextChanged);
            // 
            // modelTextBox
            // 
            this.modelTextBox.AnimateReadOnly = false;
            this.modelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modelTextBox.Depth = 0;
            this.modelTextBox.Enabled = false;
            this.modelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.modelTextBox.Hint = "ex. S2421HS";
            this.modelTextBox.LeadingIcon = null;
            this.modelTextBox.Location = new System.Drawing.Point(164, 174);
            this.modelTextBox.MaxLength = 50;
            this.modelTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.modelTextBox.Multiline = false;
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(200, 50);
            this.modelTextBox.TabIndex = 34;
            this.modelTextBox.Text = "";
            this.modelTextBox.TrailingIcon = null;
            this.modelTextBox.TextChanged += new System.EventHandler(this.modelTextBox_TextChanged);
            // 
            // SearchInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 542);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.serialNumberTextBox);
            this.Controls.Add(this.infoDisplayTextBox);
            this.Controls.Add(this.modelLabel1);
            this.Controls.Add(this.infoLabel1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.manufacturerComboBox1);
            this.Controls.Add(this.searchButton1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search information ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BrightnessContrastForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton searchButton1;
        private MaterialSkin.Controls.MaterialComboBox manufacturerComboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel infoLabel1;
        private MaterialSkin.Controls.MaterialLabel modelLabel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox infoDisplayTextBox;
        private MaterialSkin.Controls.MaterialTextBox serialNumberTextBox;
        private MaterialSkin.Controls.MaterialTextBox modelTextBox;
    }
}