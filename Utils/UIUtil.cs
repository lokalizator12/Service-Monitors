using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ServiceMonitorEVK.Utils
{
    internal class UiUtil : MaterialForm
    {
        private readonly Timer animationTimer;


        private readonly Form form;
        private readonly MaterialSkinManager materialSkinManager;
        private bool _isClosing;
        private int colorSchemeIndex;

        public UiUtil(MaterialForm form)
        {
            this.form = form;
            animationTimer = new Timer();
            animationTimer.Interval = 20; // Интервал обновления таймера в миллисекундах
            animationTimer.Tick += AnimationTimer_Tick;
        }

        /* public UIUtil(MaterialForm form)
         {
             materialSkinManager.EnforceBackcolorOnAllComponents = true;
             materialSkinManager.AddFormToManage(form);
             DrawerAutoShow = true;
             materialSkinManager = MaterialSkinManager.Instance;
         }
 */
        public void StartOpening()
        {
            form.Opacity = 0;
            _isClosing = false;
            animationTimer.Start();
        }

        public void StartClosing()
        {
            _isClosing = true;
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (_isClosing)
            {
                if (form.Opacity > 0)
                {
                    form.Opacity -= 0.08;
                }
                else
                {
                    animationTimer.Stop();
                    form.Close();
                }
            }
            else
            {
                if (form.Opacity < 1)
                    form.Opacity += 0.05;
                else
                    animationTimer.Stop();
            }
        }

        private void checkTheme(MaterialSwitch switchTheme)
        {
            /* if (switchTheme.Checked)
             {
                 materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                 pictureBoxLogo.BackColor = Color.Black;

             }
             else
             {
                 materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                 pictureBoxLogo.BackColor = Color.White;
             }
             updateColor();*/
        }

        private void updateColor(Form form)
        {
            /* switch (colorSchemeIndex)
             {
                 case 0:
                     materialSkinManager.ColorScheme = new ColorScheme(
                         materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey900 : Primary.BlueGrey800,
                         materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey800 : Primary.BlueGrey900,
                         materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Grey700 : Primary.BlueGrey500,
                         Accent.Red400,
                         TextShade.WHITE);
                      form.pictureBoxLogo.BackColor = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK
                 ? Color.FromArgb(0x21, 0x21, 0x21)
                 : Color.FromArgb(0x37, 0x47, 0x4F);
                     break;

                 case 1:
                     materialSkinManager.ColorScheme = new ColorScheme(
                         Primary.Green600,
                         Primary.Green700,
                         Primary.Green200,
                         Accent.Red100,
                         TextShade.WHITE);
                     pictureBoxLogo.BackColor = Color.Blue;
                     break;

                 case 2:
                     materialSkinManager.ColorScheme = new ColorScheme(
                         Primary.BlueGrey800,
                         Primary.BlueGrey900,
                         Primary.BlueGrey500,
                         Accent.LightBlue200,
                         TextShade.WHITE);
                     pictureBoxLogo.BackColor = Color.White;
                     break;
             }
             Invalidate();*/
        }
    }
}