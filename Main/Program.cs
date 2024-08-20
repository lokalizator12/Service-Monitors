using ServiceMonitorEVK;
using System;
using System.Windows.Forms;

namespace changeResolution1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var initialsForm = new InitialsForm();
           
            if (initialsForm.ShowDialog() == DialogResult.OK)
            {
                var mainForm = new Form1(initialsForm.Initials);
                FadeInForm(mainForm);
                Application.Run(mainForm);
            }

        }

        private static void FadeInForm(Form form)
        {
            form.Opacity = 0;
            form.Show();
            Timer timer = new Timer();
            timer.Interval = 20; // Интервал обновления таймера в миллисекундах
            timer.Tick += (sender, e) =>
            {
                if (form.Opacity < 1)
                {
                    form.Opacity += 0.05; // Изменяйте значение для управления скоростью открытия
                }
                else
                {
                    timer.Stop();
                }
            };
            timer.Start();
        }
    }
}
