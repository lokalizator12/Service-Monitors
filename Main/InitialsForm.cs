using MaterialSkin;
using MaterialSkin.Controls;
using ServiceMonitorEVK.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ServiceMonitorEVK.Main
{
    public partial class InitialsForm : MaterialForm
    {
        private readonly UiUtil formAnimator;
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public InitialsForm()
        {
            InitializeComponent();
            CustomSetTheme();
            formAnimator = new UiUtil(this);
            formAnimator.StartOpening();
        }

        public string Initials { get; private set; }


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
                DialogResult = DialogResult.OK;
                formAnimator.StartClosing();
            }

        }
    }
}