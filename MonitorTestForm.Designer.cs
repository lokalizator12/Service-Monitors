using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows;
using System.Windows.Forms;

namespace changeResolution1
{
    partial class MonitorTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        int cornerRadius = 20;
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
        private void RoundPictureBoxCorners(PictureBox pictureBox, int cornerRadius)
        {

            GraphicsPath roundedPath = new GraphicsPath();

            // Устанавливаем закругленные углы
            roundedPath.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            roundedPath.AddArc(pictureBox.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // Верхний правый угол
            roundedPath.AddArc(pictureBox.Width - cornerRadius, pictureBox.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Нижний правый угол
            roundedPath.AddArc(0, pictureBox.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Нижний левый угол

            roundedPath.CloseAllFigures(); 

            pictureBox.Region = new Region(roundedPath);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorChangeTimer = new System.Windows.Forms.Timer(this.components);
            this.colorPanel = new System.Windows.Forms.Panel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialSliderOpasity = new MaterialSkin.Controls.MaterialSlider();
            this.materialLabel28 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel33 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel34 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.monitorComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.testModeComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.testPatternComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.selectColorButton = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxChoose = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlack = new System.Windows.Forms.PictureBox();
            this.pictureBoxWhite = new System.Windows.Forms.PictureBox();
            this.pictureBoxSilver = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
            this.pictureBoxMagneta = new System.Windows.Forms.PictureBox();
            this.pictureBoxAqua = new System.Windows.Forms.PictureBox();
            this.pictureBoxYellow = new System.Windows.Forms.PictureBox();
            this.pictureBoxLime = new System.Windows.Forms.PictureBox();
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.colorPanel.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectColorButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSilver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagneta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            this.SuspendLayout();
            // 
            // colorDialog2
            // 
            this.colorDialog2.ShowHelp = true;
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Gray;
            this.colorPanel.Controls.Add(this.materialCard2);
            this.colorPanel.Controls.Add(this.materialCard1);
            this.colorPanel.Controls.Add(this.pictureBox10);
            this.colorPanel.Controls.Add(this.pictureBox9);
            this.colorPanel.Controls.Add(this.pictureBox8);
            this.colorPanel.Controls.Add(this.pictureBox7);
            this.colorPanel.Controls.Add(this.pictureBox6);
            this.colorPanel.Controls.Add(this.pictureBox5);
            this.colorPanel.Controls.Add(this.pictureBox4);
            this.colorPanel.Controls.Add(this.pictureBox1);
            this.colorPanel.Controls.Add(this.pictureBoxChoose);
            this.colorPanel.Controls.Add(this.pictureBoxBlack);
            this.colorPanel.Controls.Add(this.pictureBoxWhite);
            this.colorPanel.Controls.Add(this.pictureBoxSilver);
            this.colorPanel.Controls.Add(this.pictureBoxBlue);
            this.colorPanel.Controls.Add(this.pictureBoxMagneta);
            this.colorPanel.Controls.Add(this.pictureBoxAqua);
            this.colorPanel.Controls.Add(this.pictureBoxYellow);
            this.colorPanel.Controls.Add(this.pictureBoxLime);
            this.colorPanel.Controls.Add(this.pictureBoxRed);
            this.colorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.colorPanel.Location = new System.Drawing.Point(3, 117);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(985, 112);
            this.colorPanel.TabIndex = 6;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.pictureBox2);
            this.materialCard2.Controls.Add(this.materialSliderOpasity);
            this.materialCard2.Controls.Add(this.materialLabel28);
            this.materialCard2.Controls.Add(this.materialLabel33);
            this.materialCard2.Controls.Add(this.materialLabel34);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(3, 78);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(962, 31);
            this.materialCard2.TabIndex = 55;
            // 
            // materialSliderOpasity
            // 
            this.materialSliderOpasity.Depth = 0;
            this.materialSliderOpasity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSliderOpasity.Location = new System.Drawing.Point(182, -5);
            this.materialSliderOpasity.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSliderOpasity.Name = "materialSliderOpasity";
            this.materialSliderOpasity.ShowValue = false;
            this.materialSliderOpasity.Size = new System.Drawing.Size(231, 40);
            this.materialSliderOpasity.TabIndex = 37;
            this.materialSliderOpasity.Text = "Opacity";
            this.materialSliderOpasity.Value = 100;
            this.materialSliderOpasity.ValueMax = 100;
            this.materialSliderOpasity.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.materialSliderOpasity_onValueChanged);
            // 
            // materialLabel28
            // 
            this.materialLabel28.AutoSize = true;
            this.materialLabel28.Depth = 0;
            this.materialLabel28.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel28.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel28.Location = new System.Drawing.Point(118, 14);
            this.materialLabel28.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel28.Name = "materialLabel28";
            this.materialLabel28.Size = new System.Drawing.Size(49, 14);
            this.materialLabel28.TabIndex = 44;
            this.materialLabel28.Text = "Exit: ESC";
            // 
            // materialLabel33
            // 
            this.materialLabel33.AutoSize = true;
            this.materialLabel33.Depth = 0;
            this.materialLabel33.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel33.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel33.Location = new System.Drawing.Point(0, 14);
            this.materialLabel33.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel33.Name = "materialLabel33";
            this.materialLabel33.Size = new System.Drawing.Size(83, 14);
            this.materialLabel33.TabIndex = 39;
            this.materialLabel33.Text = "Previous: left <-";
            // 
            // materialLabel34
            // 
            this.materialLabel34.AutoSize = true;
            this.materialLabel34.Depth = 0;
            this.materialLabel34.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel34.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel34.Location = new System.Drawing.Point(0, 0);
            this.materialLabel34.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel34.Name = "materialLabel34";
            this.materialLabel34.Size = new System.Drawing.Size(112, 14);
            this.materialLabel34.TabIndex = 38;
            this.materialLabel34.Text = "Next: right -> / space";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel17);
            this.materialCard1.Controls.Add(this.materialLabel16);
            this.materialCard1.Controls.Add(this.materialLabel15);
            this.materialCard1.Controls.Add(this.materialLabel14);
            this.materialCard1.Controls.Add(this.materialLabel13);
            this.materialCard1.Controls.Add(this.materialLabel12);
            this.materialCard1.Controls.Add(this.materialLabel11);
            this.materialCard1.Controls.Add(this.materialLabel10);
            this.materialCard1.Controls.Add(this.materialLabel9);
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 50);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(962, 25);
            this.materialCard1.TabIndex = 38;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.Location = new System.Drawing.Point(933, 1);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(12, 19);
            this.materialLabel17.TabIndex = 54;
            this.materialLabel17.Text = "D";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.Location = new System.Drawing.Point(877, 1);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(11, 19);
            this.materialLabel16.TabIndex = 53;
            this.materialLabel16.Text = "S";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.Location = new System.Drawing.Point(825, 1);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(11, 19);
            this.materialLabel15.TabIndex = 52;
            this.materialLabel15.Text = "A";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(772, 1);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(11, 19);
            this.materialLabel14.TabIndex = 51;
            this.materialLabel14.Text = "X";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(702, 1);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(44, 19);
            this.materialLabel13.TabIndex = 50;
            this.materialLabel13.Text = "Ctrl+S";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(663, 1);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(15, 19);
            this.materialLabel12.TabIndex = 49;
            this.materialLabel12.Text = "W";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(609, 1);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(12, 19);
            this.materialLabel11.TabIndex = 48;
            this.materialLabel11.Text = "Q";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(485, 1);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(29, 19);
            this.materialLabel10.TabIndex = 47;
            this.materialLabel10.Text = "Tab";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(448, 1);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(10, 19);
            this.materialLabel9.TabIndex = 46;
            this.materialLabel9.Text = "9";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(397, 1);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(10, 19);
            this.materialLabel8.TabIndex = 45;
            this.materialLabel8.Text = "8";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(339, 1);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(10, 19);
            this.materialLabel7.TabIndex = 44;
            this.materialLabel7.Text = "7";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(284, 1);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(10, 19);
            this.materialLabel6.TabIndex = 43;
            this.materialLabel6.Text = "6";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(236, 1);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(10, 19);
            this.materialLabel5.TabIndex = 42;
            this.materialLabel5.Text = "5";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(179, 1);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(10, 19);
            this.materialLabel4.TabIndex = 41;
            this.materialLabel4.Text = "4";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(128, 1);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(10, 19);
            this.materialLabel3.TabIndex = 40;
            this.materialLabel3.Text = "3";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(71, 1);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(10, 19);
            this.materialLabel2.TabIndex = 39;
            this.materialLabel2.Text = "2";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 1);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(10, 19);
            this.materialLabel1.TabIndex = 38;
            this.materialLabel1.Text = "1";
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
            this.monitorComboBox1.FormattingEnabled = true;
            this.monitorComboBox1.Hint = "Monitor";
            this.monitorComboBox1.IntegralHeight = false;
            this.monitorComboBox1.ItemHeight = 43;
            this.monitorComboBox1.Location = new System.Drawing.Point(6, 27);
            this.monitorComboBox1.MaxDropDownItems = 4;
            this.monitorComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.monitorComboBox1.Name = "monitorComboBox1";
            this.monitorComboBox1.Size = new System.Drawing.Size(201, 49);
            this.monitorComboBox1.StartIndex = 0;
            this.monitorComboBox1.TabIndex = 34;
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
            this.testModeComboBox1.Hint = "Test mode";
            this.testModeComboBox1.IntegralHeight = false;
            this.testModeComboBox1.ItemHeight = 43;
            this.testModeComboBox1.Items.AddRange(new object[] {
            "Custom Pattern",
            "Color Spectrum",
            "Grayscale Gradient",
            "Color Lines",
            "Checkerboard",
            "Circular Gradient"});
            this.testModeComboBox1.Location = new System.Drawing.Point(369, 27);
            this.testModeComboBox1.MaxDropDownItems = 4;
            this.testModeComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.testModeComboBox1.Name = "testModeComboBox1";
            this.testModeComboBox1.Size = new System.Drawing.Size(150, 49);
            this.testModeComboBox1.StartIndex = 0;
            this.testModeComboBox1.TabIndex = 35;
            this.testModeComboBox1.SelectedIndexChanged += new System.EventHandler(this.testModeComboBox1_SelectedIndexChanged);
            this.testModeComboBox1.SelectionChangeCommitted += new System.EventHandler(this.testModeComboBox_SelectedIndexChanged);
            // 
            // testPatternComboBox1
            // 
            this.testPatternComboBox1.AutoResize = false;
            this.testPatternComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.testPatternComboBox1.Depth = 0;
            this.testPatternComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.testPatternComboBox1.DropDownHeight = 174;
            this.testPatternComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testPatternComboBox1.DropDownWidth = 121;
            this.testPatternComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.testPatternComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.testPatternComboBox1.FormattingEnabled = true;
            this.testPatternComboBox1.Hint = "Test pattern";
            this.testPatternComboBox1.IntegralHeight = false;
            this.testPatternComboBox1.ItemHeight = 43;
            this.testPatternComboBox1.Items.AddRange(new object[] {
            "Chessboard",
            "Circles",
            "Lines"});
            this.testPatternComboBox1.Location = new System.Drawing.Point(213, 27);
            this.testPatternComboBox1.MaxDropDownItems = 4;
            this.testPatternComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.testPatternComboBox1.Name = "testPatternComboBox1";
            this.testPatternComboBox1.Size = new System.Drawing.Size(150, 49);
            this.testPatternComboBox1.StartIndex = 0;
            this.testPatternComboBox1.TabIndex = 36;
            this.testPatternComboBox1.SelectedIndexChanged += new System.EventHandler(this.testPatternComboBox1_SelectedIndexChanged);
            // 
            // selectColorButton
            // 
            this.selectColorButton.BackColor = System.Drawing.Color.Transparent;
            this.selectColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectColorButton.Image = global::ServiceMonitorEVK.Properties.Resources.color_wheel1;
            this.selectColorButton.Location = new System.Drawing.Point(526, 27);
            this.selectColorButton.Name = "selectColorButton";
            this.selectColorButton.Size = new System.Drawing.Size(68, 49);
            this.selectColorButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectColorButton.TabIndex = 32;
            this.selectColorButton.TabStop = false;
            this.selectColorButton.Click += new System.EventHandler(this.selectColorButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ServiceMonitorEVK.Properties.Resources.push_pin;
            this.pictureBox2.Location = new System.Drawing.Point(931, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.Move += new System.EventHandler(this.pictureBox2_Move);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.delete_symbol_option;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Location = new System.Drawing.Point(755, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(48, 45);
            this.pictureBox10.TabIndex = 19;
            this.pictureBox10.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox10, "Key: X");
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.save_prtscr;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Location = new System.Drawing.Point(701, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(48, 45);
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox9, "Key: Ctrl+S");
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.select_yello;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Location = new System.Drawing.Point(809, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(48, 45);
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox8, "Key: A");
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.select_blue;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Location = new System.Drawing.Point(863, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(48, 45);
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox7, "Key: S");
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.color_pallete;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(647, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 45);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox6, "Key: W");
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.win_back;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(593, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 45);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Key: Q ");
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Red;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(539, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 45);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.select_red2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(917, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 45);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Key: D");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBoxChoose
            // 
            this.pictureBoxChoose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChoose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxChoose.Image = global::ServiceMonitorEVK.Properties.Resources.color_wheel;
            this.pictureBoxChoose.InitialImage = global::ServiceMonitorEVK.Properties.Resources.color_wheel;
            this.pictureBoxChoose.Location = new System.Drawing.Point(485, 3);
            this.pictureBoxChoose.Name = "pictureBoxChoose";
            this.pictureBoxChoose.Size = new System.Drawing.Size(48, 45);
            this.pictureBoxChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxChoose.TabIndex = 9;
            this.pictureBoxChoose.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxChoose, "Key: Tab");
            this.pictureBoxChoose.Click += new System.EventHandler(this.pictureBoxChoose_Click);
            // 
            // pictureBoxBlack
            // 
            this.pictureBoxBlack.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBlack.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.black;
            this.pictureBoxBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBlack.Location = new System.Drawing.Point(432, 3);
            this.pictureBoxBlack.Name = "pictureBoxBlack";
            this.pictureBoxBlack.Size = new System.Drawing.Size(48, 45);
            this.pictureBoxBlack.TabIndex = 8;
            this.pictureBoxBlack.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxBlack, "Key: 9 or Num9");
            this.pictureBoxBlack.Click += new System.EventHandler(this.pictureBoxBlack_Click);
            // 
            // pictureBoxWhite
            // 
            this.pictureBoxWhite.BackColor = System.Drawing.Color.White;
            this.pictureBoxWhite.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.white;
            this.pictureBoxWhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxWhite.Location = new System.Drawing.Point(378, 3);
            this.pictureBoxWhite.Name = "pictureBoxWhite";
            this.pictureBoxWhite.Size = new System.Drawing.Size(48, 45);
            this.pictureBoxWhite.TabIndex = 7;
            this.pictureBoxWhite.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxWhite, "Key: 8 or Num8");
            this.pictureBoxWhite.Click += new System.EventHandler(this.pictureBoxWhite_Click);
            // 
            // pictureBoxSilver
            // 
            this.pictureBoxSilver.BackColor = System.Drawing.Color.Gray;
            this.pictureBoxSilver.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.silver;
            this.pictureBoxSilver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSilver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSilver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSilver.Location = new System.Drawing.Point(324, 4);
            this.pictureBoxSilver.Name = "pictureBoxSilver";
            this.pictureBoxSilver.Size = new System.Drawing.Size(48, 45);
            this.pictureBoxSilver.TabIndex = 6;
            this.pictureBoxSilver.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxSilver, "Key: 7 or Num7");
            this.pictureBoxSilver.Click += new System.EventHandler(this.pictureBoxSilver_Click);
            // 
            // pictureBoxBlue
            // 
            this.pictureBoxBlue.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxBlue.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.blue;
            this.pictureBoxBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBlue.Location = new System.Drawing.Point(270, 3);
            this.pictureBoxBlue.Name = "pictureBoxBlue";
            this.pictureBoxBlue.Size = new System.Drawing.Size(48, 45);
            this.pictureBoxBlue.TabIndex = 5;
            this.pictureBoxBlue.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxBlue, "Key: 6 or Num6");
            this.pictureBoxBlue.Click += new System.EventHandler(this.pictureBoxBlue_Click);
            // 
            // pictureBoxMagneta
            // 
            this.pictureBoxMagneta.BackColor = System.Drawing.Color.Magenta;
            this.pictureBoxMagneta.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.magenta;
            this.pictureBoxMagneta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxMagneta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMagneta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMagneta.Location = new System.Drawing.Point(219, 3);
            this.pictureBoxMagneta.Name = "pictureBoxMagneta";
            this.pictureBoxMagneta.Size = new System.Drawing.Size(48, 45);
            this.pictureBoxMagneta.TabIndex = 4;
            this.pictureBoxMagneta.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxMagneta, "Key: 5 or Num5");
            this.pictureBoxMagneta.Click += new System.EventHandler(this.pictureBoxMagneta_Click);
            // 
            // pictureBoxAqua
            // 
            this.pictureBoxAqua.BackColor = System.Drawing.Color.Aqua;
            this.pictureBoxAqua.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.aqua;
            this.pictureBoxAqua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAqua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAqua.Location = new System.Drawing.Point(165, 4);
            this.pictureBoxAqua.Name = "pictureBoxAqua";
            this.pictureBoxAqua.Size = new System.Drawing.Size(48, 45);
            this.pictureBoxAqua.TabIndex = 3;
            this.pictureBoxAqua.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxAqua, "Key: 4 or Num4");
            this.pictureBoxAqua.Click += new System.EventHandler(this.pictureBoxAqua_Click);
            // 
            // pictureBoxYellow
            // 
            this.pictureBoxYellow.BackColor = System.Drawing.Color.Yellow;
            this.pictureBoxYellow.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.yellow;
            this.pictureBoxYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxYellow.Location = new System.Drawing.Point(111, 3);
            this.pictureBoxYellow.Name = "pictureBoxYellow";
            this.pictureBoxYellow.Size = new System.Drawing.Size(48, 45);
            this.pictureBoxYellow.TabIndex = 2;
            this.pictureBoxYellow.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxYellow, "Key: 3 or Num3");
            this.pictureBoxYellow.Click += new System.EventHandler(this.pictureBoxYellow_Click);
            // 
            // pictureBoxLime
            // 
            this.pictureBoxLime.BackColor = System.Drawing.Color.Lime;
            this.pictureBoxLime.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.lime;
            this.pictureBoxLime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLime.Location = new System.Drawing.Point(57, 3);
            this.pictureBoxLime.Name = "pictureBoxLime";
            this.pictureBoxLime.Size = new System.Drawing.Size(48, 45);
            this.pictureBoxLime.TabIndex = 1;
            this.pictureBoxLime.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxLime, "Key: 2 or Num2");
            this.pictureBoxLime.Click += new System.EventHandler(this.pictureBoxLime_Click);
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.BackColor = System.Drawing.Color.Red;
            this.pictureBoxRed.BackgroundImage = global::ServiceMonitorEVK.Properties.Resources.red1;
            this.pictureBoxRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRed.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(48, 45);
            this.pictureBoxRed.TabIndex = 0;
            this.pictureBoxRed.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxRed, "Key: 1 or Num1");
            this.pictureBoxRed.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MonitorTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 232);
            this.Controls.Add(this.selectColorButton);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.monitorComboBox1);
            this.Controls.Add(this.testPatternComboBox1);
            this.Controls.Add(this.testModeComboBox1);
            this.DrawerIsOpen = true;
            this.DrawerUseColors = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MonitorTestForm";
            this.Opacity = 0.9D;
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MonitorTestForm_FormClosed);
            this.Load += new System.EventHandler(this.MonitorTestForm_Load);
            this.colorPanel.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectColorButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSilver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagneta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Timer colorChangeTimer;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.PictureBox pictureBoxRed;
        private System.Windows.Forms.PictureBox pictureBoxChoose;
        private System.Windows.Forms.PictureBox pictureBoxBlack;
        private System.Windows.Forms.PictureBox pictureBoxWhite;
        private System.Windows.Forms.PictureBox pictureBoxSilver;
        private System.Windows.Forms.PictureBox pictureBoxBlue;
        private System.Windows.Forms.PictureBox pictureBoxMagneta;
        private System.Windows.Forms.PictureBox pictureBoxAqua;
        private System.Windows.Forms.PictureBox pictureBoxYellow;
        private System.Windows.Forms.PictureBox pictureBoxLime;
        private System.Windows.Forms.PictureBox selectColorButton;
        private MaterialSkin.Controls.MaterialComboBox monitorComboBox1;
        private MaterialSkin.Controls.MaterialComboBox testModeComboBox1;
        private MaterialSkin.Controls.MaterialComboBox testPatternComboBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSlider materialSliderOpasity;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel28;
        private MaterialSkin.Controls.MaterialLabel materialLabel33;
        private MaterialSkin.Controls.MaterialLabel materialLabel34;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private PictureBox pictureBox2;
    }
}