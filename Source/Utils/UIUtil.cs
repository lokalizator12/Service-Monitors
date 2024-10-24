using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using ServiceMonitorEVK.Util_Managers;

namespace ServiceMonitorEVK.Source.Utils
{
    public class UiUtil
    {
        private readonly Timer animationTimer;


        private readonly MaterialForm mainForm;
        private readonly MaterialSkinManager materialSkinManager;
        private bool _isClosing;
        private int colorSchemeIndex;
        public static Color LogoBackColor { get; private set; }

        public UiUtil(MaterialForm form)
        {
            mainForm = form;
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(mainForm);
            ThemeManager.ThemeChanged += UpdateTheme;
            InitializeTheme();

            animationTimer = new Timer();
            animationTimer.Interval = 20; 
            animationTimer.Tick += AnimationTimer_Tick;
        }



        public void InitializeTheme()
        {
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            UpdateTheme();
        }

        private void UpdateTheme()
        {
            materialSkinManager.Theme = ThemeManager.IsDarkTheme
                ? MaterialSkinManager.Themes.DARK
                : MaterialSkinManager.Themes.LIGHT;

            UpdateColorScheme();
        }

        private void UpdateColorScheme()
        {
            materialSkinManager.ColorScheme = new ColorScheme(
                materialSkinManager.Theme == MaterialSkinManager.Themes.DARK
                    ? Primary.Grey900
                    : Primary.BlueGrey800,
                materialSkinManager.Theme == MaterialSkinManager.Themes.DARK
                    ? Primary.Grey800
                    : Primary.BlueGrey900,
                materialSkinManager.Theme == MaterialSkinManager.Themes.DARK
                    ? Primary.Grey700
                    : Primary.BlueGrey500,
                Accent.Red400,
                TextShade.WHITE);

            mainForm.Invalidate();
        }

        public static void RegisterLogoForThemeChange(PictureBox logo)
        {
            ThemeManager.LogoBackColorChanged += color => logo.BackColor = color;
            LogoBackColor = logo.BackColor = ThemeManager.LogoBackColor; 
        }

        public void StartOpening()
        {
            mainForm.Opacity = 0;
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
                if (mainForm.Opacity > 0)
                {
                    mainForm.Opacity -= 0.08;
                }
                else
                {
                    animationTimer.Stop();
                    mainForm.Close();
                }
            }
            else
            {
                if (mainForm.Opacity < 1)
                    mainForm.Opacity += 0.05;
                else
                    animationTimer.Stop();
            }
        }

    }
}