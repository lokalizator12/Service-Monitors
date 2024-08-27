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
        private readonly UiUtil uiUtil;
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public InitialsForm()
        {
            InitializeComponent();
            uiUtil = new UiUtil(this);
            uiUtil.StartOpening();
            CustomSetTheme();
        }

        public string Initials { get; private set; }


        private void CustomSetTheme()
        {
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey900,
                Primary.Grey800,
                Primary.Grey700,
                Accent.Red400,
                TextShade.WHITE);
            pictureBoxLogo.BackColor = Color.FromArgb(0x21, 0x21, 0x21);
        }

        private void textBoxTester_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTester.Text.Length == 2)
            {
                Initials = textBoxTester.Text;
                DialogResult = DialogResult.OK;
                uiUtil.StartClosing();
            }

        }
    }
}