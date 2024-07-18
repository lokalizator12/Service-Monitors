using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static changeResolution1.DisplayManager;
using System.Windows.Forms;

namespace changeResolution1
{
    internal class ResolutionDisplayManager
    {
        private const int DISP_CHANGE_SUCCESSFUL = 0;
        private const int CDS_UPDATEREGISTRY = 0x01;
        private const int DM_PELSWIDTH = 0x80000;
        private const int DM_PELSHEIGHT = 0x100000;

        [DllImport("user32.dll")]
        private static extern int ChangeDisplaySettingsEx(string lpszDeviceName, ref DEVMODE lpDevMode, IntPtr hwnd, int dwflags, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref DEVMODE lpDevMode);

        [StructLayout(LayoutKind.Sequential)]
        private struct DEVMODE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string dmDeviceName;
            public ushort dmSpecVersion;
            public ushort dmDriverVersion;
            public ushort dmSize;
            public ushort dmDriverExtra;
            public uint dmFields;
            public int dmPositionX;
            public int dmPositionY;
            public uint dmDisplayOrientation;
            public uint dmDisplayFixedOutput;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string dmFormName;
            public ushort dmLogPixels;
            public uint dmBitsPerPel;
            public uint dmPelsWidth;
            public uint dmPelsHeight;
            public uint dmDisplayFlags;
            public uint dmDisplayFrequency;
            public uint dmICMMethod;
            public uint dmICMIntent;
            public uint dmMediaType;
            public uint dmDitherType;
            public uint dmReserved1;
            public uint dmReserved2;
            public uint dmPanningWidth;
            public uint dmPanningHeight;
        }

        public List<string> GetAvailableResolutions(int screenIndex)
        {
            var screen = Screen.AllScreens[screenIndex];
            var resolutions = new List<string>();
            DEVMODE devMode = new DEVMODE();
            int modeIndex = 0;

            while (EnumDisplaySettings(screen.DeviceName, modeIndex, ref devMode))
            {
                string resolution = $"{devMode.dmPelsWidth}x{devMode.dmPelsHeight}";
                if (!resolutions.Contains(resolution))
                {
                    resolutions.Add(resolution);
                }
                modeIndex++;
            }

            return resolutions;
        }

        public void SetResolution(int screenIndex, int width, int height)
        {
            var screen = Screen.AllScreens[screenIndex];
            DEVMODE devMode = new DEVMODE();
            devMode.dmSize = (ushort)Marshal.SizeOf(devMode);
            devMode.dmPelsWidth = (uint)width;
            devMode.dmPelsHeight = (uint)height;
            devMode.dmFields = DM_PELSWIDTH | DM_PELSHEIGHT;

            int result = ChangeDisplaySettingsEx(screen.DeviceName, ref devMode, IntPtr.Zero, CDS_UPDATEREGISTRY, IntPtr.Zero);
            if (result != DISP_CHANGE_SUCCESSFUL)
            {
                MessageBox.Show($"Failed to change display settings. Error code: {result}");
            }
            else
            {
                MessageBox.Show($"Resolution changed successfully to {width}x{height}.");
            }
        }

        public (int Width, int Height) GetMaxResolution(int screenIndex)
        {
            var screen = Screen.AllScreens[screenIndex];
            var resolutions = GetAvailableResolutions(screenIndex);

            var maxResolution = resolutions
                .Select(r => r.Split('x'))
                .Where(parts => parts.Length == 2 &&
                                int.TryParse(parts[0], out _) &&
                                int.TryParse(parts[1], out _))
                .Select(parts => (Width: int.Parse(parts[0]), Height: int.Parse(parts[1])))
                .OrderByDescending(r => r.Width * r.Height)
                .FirstOrDefault();

            return maxResolution;
        }

        public List<string> GetMonitorNames()
        {
            return Screen.AllScreens.Select(screen => screen.DeviceName).ToList();
        }
    }
}

