using changeResolution1;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceMonitorEVK.Utils
{
    internal class UIUtil : MaterialForm
    {
        private int colorSchemeIndex;
        private readonly MaterialSkinManager materialSkinManager;


        private readonly Form _form;
        private readonly Timer _animationTimer;
        private bool _isClosing;

        public UIUtil(MaterialForm form)
        {
            _form = form;
            _animationTimer = new Timer();
            _animationTimer.Interval = 20; // Интервал обновления таймера в миллисекундах
            _animationTimer.Tick += AnimationTimer_Tick;
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
            _form.Opacity = 0;
            _isClosing = false;
            _animationTimer.Start();
        }

        public void StartClosing()
        {
            _isClosing = true;
            _animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (_isClosing)
            {
                if (_form.Opacity > 0)
                {
                    _form.Opacity -= 0.08; 
                }
                else
                {
                    _animationTimer.Stop();
                    _form.Close();
                }
            }
            else
            {
                if (_form.Opacity < 1)
                {
                    _form.Opacity += 0.05; 
                }
                else
                {
                    _animationTimer.Stop();
                }
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
