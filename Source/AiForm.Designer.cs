namespace ServiceMonitorEVK.Source
{
    partial class AiForm
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
            this.txtChatHistory = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.switchIsInfoMonitor = new MaterialSkin.Controls.MaterialSwitch();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textPrompt = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSend = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtChatHistory
            // 
            this.txtChatHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChatHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtChatHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChatHistory.Depth = 0;
            this.txtChatHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtChatHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtChatHistory.Location = new System.Drawing.Point(3, 53);
            this.txtChatHistory.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtChatHistory.Name = "txtChatHistory";
            this.txtChatHistory.ReadOnly = true;
            this.txtChatHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtChatHistory.Size = new System.Drawing.Size(889, 506);
            this.txtChatHistory.TabIndex = 2;
            this.txtChatHistory.Text = "";
            // 
            // switchIsInfoMonitor
            // 
            this.switchIsInfoMonitor.AutoSize = true;
            this.switchIsInfoMonitor.Checked = true;
            this.switchIsInfoMonitor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.switchIsInfoMonitor.Depth = 0;
            this.switchIsInfoMonitor.Location = new System.Drawing.Point(0, 13);
            this.switchIsInfoMonitor.Margin = new System.Windows.Forms.Padding(0);
            this.switchIsInfoMonitor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchIsInfoMonitor.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchIsInfoMonitor.Name = "switchIsInfoMonitor";
            this.switchIsInfoMonitor.Ripple = true;
            this.switchIsInfoMonitor.Size = new System.Drawing.Size(253, 37);
            this.switchIsInfoMonitor.TabIndex = 3;
            this.switchIsInfoMonitor.Text = "Information about monitors";
            this.switchIsInfoMonitor.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.txtChatHistory);
            this.flowLayoutPanel1.Controls.Add(this.switchIsInfoMonitor);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(904, 624);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.textPrompt);
            this.flowLayoutPanel2.Controls.Add(this.btnSend);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 565);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(889, 56);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // textPrompt
            // 
            this.textPrompt.AnimateReadOnly = false;
            this.textPrompt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrompt.Depth = 0;
            this.textPrompt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textPrompt.LeadingIcon = null;
            this.textPrompt.Location = new System.Drawing.Point(3, 3);
            this.textPrompt.MaxLength = 50;
            this.textPrompt.MouseState = MaterialSkin.MouseState.OUT;
            this.textPrompt.Multiline = false;
            this.textPrompt.Name = "textPrompt";
            this.textPrompt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textPrompt.Size = new System.Drawing.Size(811, 50);
            this.textPrompt.TabIndex = 1;
            this.textPrompt.Text = "";
            this.textPrompt.TrailingIcon = null;
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = false;
            this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSend.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSend.Depth = 0;
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.HighEmphasis = true;
            this.btnSend.Icon = global::ServiceMonitorEVK.Properties.Resources.send;
            this.btnSend.Location = new System.Drawing.Point(821, 6);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSend.Size = new System.Drawing.Size(64, 44);
            this.btnSend.TabIndex = 0;
            this.btnSend.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSend.UseAccentColor = false;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // AiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 691);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AiForm";
            this.Text = "AiForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialMultiLineTextBox txtChatHistory;
        private MaterialSkin.Controls.MaterialSwitch switchIsInfoMonitor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialTextBox textPrompt;
        private MaterialSkin.Controls.MaterialButton btnSend;
    }
}