using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceMonitorEVK.Source.Util_Managers
{
    internal class AppManager
    {

        public TimeSpan TargetTime;
        private bool isRunning;

        public AppManager()
        {
        }
        internal static void FadeInForm(Form form)
        {
            form.Opacity = 0;
            form.Show();
            var timer = new Timer();
            timer.Interval = 20; // Интервал обновления таймера в миллисекундах
            timer.Tick += (sender, e) =>
            {
                if (form.Opacity < 1)
                    form.Opacity += 0.05; // Изменяйте значение для управления скоростью открытия
                else
                    timer.Stop();
            };
            timer.Start();
        }
        /// <summary>
        /// Запускает процесс отсчета времени до закрытия приложения.
        /// </summary>
        public TimeSpan StartClosingTimer()
        {
            string settingsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Settings", "settings.json");
            if (!File.Exists(settingsFilePath))
            {
                throw new FileNotFoundException("Could not find the settings file.", settingsFilePath);
            }
            string settingsJson = File.ReadAllText(settingsFilePath);
            dynamic settings = JsonConvert.DeserializeObject(settingsJson);

            TargetTime = TimeSpan.TryParse(settings.TargetTime.ToString(), out TimeSpan time) ? time : new TimeSpan(8, 0, 0); // значение по умолчанию
         
            if (isRunning) return TargetTime;
            isRunning = true;
            Task.Run(async () => await ScheduleApplicationClose());
            return TargetTime;
        }

        /// <summary>
        /// Метод для установки нового времени закрытия.
        /// </summary>
        /// <param name="newTargetTime">Новое время закрытия.</param>
        public void UpdateTargetTime(TimeSpan newTargetTime)
        {
            TargetTime = newTargetTime;
        }

        /// <summary>
        /// Метод для расчета времени до следующего закрытия.
        /// </summary>
        /// <returns>Время в миллисекундах до следующего закрытия.</returns>
        private int GetMillisecondsUntilTargetTime()
        {
            var currentTime = DateTime.Now.TimeOfDay;
            var timeToClose = TargetTime > currentTime ? TargetTime - currentTime : TargetTime.Add(new TimeSpan(24, 0, 0)) - currentTime;
            Console.WriteLine($"Time until close: {timeToClose.TotalMilliseconds} ms");
            return (int)timeToClose.TotalMilliseconds;
        }

        /// <summary>
        /// Асинхронный метод, который выполняет отсчет времени и закрывает приложение.
        /// </summary>
        private async Task ScheduleApplicationClose()
        {
            while (isRunning)
            {
                int delay = GetMillisecondsUntilTargetTime();
                await Task.Delay(delay);
                isRunning = false; // остановка выполнения дальнейших циклов
                Application.Exit();
            }
        }

    }
}
