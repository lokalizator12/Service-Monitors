using changeResolution1;
using MaterialSkin;
using MaterialSkin.Controls;
using ServiceMonitorEVK.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ServiceMonitorEVK
{
    public partial class InitialsForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public string Initials { get; private set; }
        private readonly UIUtil _formAnimator;

        public InitialsForm()
        {
            InitializeComponent();
            CustomSetTheme();
            _formAnimator = new UIUtil(this);
            _formAnimator.StartOpening();
        }


        private void CustomSetTheme()
        {
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey900 : Primary.BlueGrey800,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey800 : Primary.BlueGrey900,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey700 : Primary.BlueGrey500,
                        Accent.Red400,
                        TextShade.WHITE);
            pictureBoxLogo.BackColor = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK
       ? Color.FromArgb(0x21, 0x21, 0x21)
       : Color.FromArgb(0x37, 0x47, 0x4F);
        }
        private void textBoxTester_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTester.Text.Length == 2)
            {
                Initials = textBoxTester.Text;
                this.DialogResult = DialogResult.OK;
                _formAnimator.StartClosing();
            };
        }

       
       


    }
}
