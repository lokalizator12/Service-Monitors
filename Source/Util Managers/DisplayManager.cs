using System;
using System.Diagnostics;
using System.IO;

namespace ServiceMonitorEVK.Source.Util_Managers
{
    public class DisplayManager
    {
        public enum DisplayMode
        {
            PC_SCREEN_ONLY = 1,
            DUPLICATE = 2,
            EXTEND = 3,
            SECOND_SCREEN_ONLY = 4
        }

        public void SetDisplayMode(DisplayMode mode)
        {
            var argument = mode switch
            {
                DisplayMode.PC_SCREEN_ONLY => "/internal",
                DisplayMode.DUPLICATE => "/clone",
                DisplayMode.EXTEND => "/extend",
                DisplayMode.SECOND_SCREEN_ONLY => "/external",
                _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null)
            };
            var displaySwitchPath = Path.Combine(
                Environment.Is64BitOperatingSystem && !Environment.Is64BitProcess
                    ? Environment.GetFolderPath(Environment.SpecialFolder.SystemX86)
                    : Environment.GetFolderPath(Environment.SpecialFolder.System),
                "DisplaySwitch.exe");

            Process.Start(displaySwitchPath, argument);
        }


    }
}