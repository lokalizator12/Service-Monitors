namespace ServiceMonitorEVK.Main
{
    partial class InitialsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialsForm));
            this.textBoxTester = new MaterialSkin.Controls.MaterialTextBox2();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTester
            // 
            this.textBoxTester.AnimateReadOnly = false;
            this.textBoxTester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxTester.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxTester.Depth = 0;
            this.textBoxTester.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxTester.HideSelection = true;
            this.textBoxTester.Hint = "Initials (AF)";
            this.textBoxTester.LeadingIcon = null;
            this.textBoxTester.Location = new System.Drawing.Point(6, 73);
            this.textBoxTester.MaxLength = 2;
            this.textBoxTester.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxTester.Name = "textBoxTester";
            this.textBoxTester.PasswordChar = '\0';
            this.textBoxTester.PrefixSuffixText = null;
            this.textBoxTester.ReadOnly = false;
            this.textBoxTester.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTester.SelectedText = "";
            this.textBoxTester.SelectionLength = 0;
            this.textBoxTester.SelectionStart = 0;
            this.textBoxTester.ShortcutsEnabled = true;
            this.textBoxTester.Size = new System.Drawing.Size(250, 48);
            this.textBoxTester.TabIndex = 1;
            this.textBoxTester.TabStop = false;
            this.textBoxTester.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxTester.TrailingIcon = global::ServiceMonitorEVK.Properties.Resources.web;
            this.textBoxTester.UseSystemPasswordChar = false;
            this.textBoxTester.TextChanged += new System.EventHandler(this.textBoxTester_TextChanged);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::ServiceMonitorEVK.Properties.Resources.logo__1_;
            this.pictureBoxLogo.Location = new System.Drawing.Point(89, 28);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(97, 33);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 42;
            this.pictureBoxLogo.TabStop = false;
            // 
            // InitialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 127);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.textBoxTester);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InitialsForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 textBoxTester;
        public System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}