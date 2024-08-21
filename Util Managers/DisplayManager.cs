using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ServiceMonitorEVK.Util_Managers
{
    public class DisplayManager
    {
      

        public enum DisplayMode
        {
            Duplicate,
            Extend,
            PrimaryOnly,
            SecondaryOnly
        }

        private const int DM_POSITION = 0x00000020;
        private const int DM_PELSHEIGHT = 0x00100000;
        private const int DM_PELSWIDTH = 0x00080000;
        private const int ENUM_CURRENT_SETTINGS = -1;
        private const int CDS_UPDATEREGISTRY = 0x01;
        private const int DISP_CHANGE_SUCCESSFUL = 0;
        private const int DISP_CHANGE_FAILED = -1;

        [DllImport("user32.dll")]
        private static extern bool EnumDisplayDevices(string lpDevice, uint iDevNum, ref DISPLAY_DEVICE lpDisplayDevice,
            uint dwFlags);

        [DllImport("user32.dll")]
        private static extern bool EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref DEVMODE lpDevMode);

        [DllImport("user32.dll")]
        private static extern int ChangeDisplaySettingsEx(string lpszDeviceName, ref DEVMODE lpDevMode, IntPtr hwnd,
            int dwflags, IntPtr lParam);

       /* public void SetDisplayMode(DisplayMode mode)
        {
            var screens = Screen.AllScreens;
            if (screens.Length < 2) throw new InvalidOperationException("At least two screens are required.");

            var primaryScreen = screens[0];
            var secondaryScreen = screens[1];

            var primaryDevice = GetDisplayDevice(primaryScreen.DeviceName);
            var secondaryDevice = GetDisplayDevice(secondaryScreen.DeviceName);

            var devModePrimary = GetDevMode(primaryDevice.DeviceName);
            var devModeSecondary = GetDevMode(secondaryDevice.DeviceName);

            switch (mode)
            {
                case DisplayMode.Duplicate:
                    SetDuplicateMode(primaryDevice, secondaryDevice, devModePrimary);
                    break;
                case DisplayMode.Extend:
                    SetExtendMode(primaryDevice, secondaryDevice, devModePrimary, devModeSecondary);
                    break;
                case DisplayMode.PrimaryOnly:
                    SetPrimaryOnlyMode(primaryDevice, secondaryDevice, devModePrimary, devModeSecondary);
                    break;
                case DisplayMode.SecondaryOnly:
                    SetSecondaryOnlyMode(primaryDevice, secondaryDevice, devModePrimary, devModeSecondary);
                    break;
            }
        }*/

        private void SetDuplicateMode(DISPLAY_DEVICE primaryDevice, DISPLAY_DEVICE secondaryDevice, DEVMODE devMode)
        {
            devMode.dmFields = unchecked((short)(DM_POSITION | DM_PELSWIDTH | DM_PELSHEIGHT));
            var result = ChangeDisplaySettingsEx(primaryDevice.DeviceName, ref devMode, IntPtr.Zero, CDS_UPDATEREGISTRY,
                IntPtr.Zero);
            if (result != DISP_CHANGE_SUCCESSFUL)
                throw new InvalidOperationException(
                    $"Failed to change display settings for {primaryDevice.DeviceName}. Error code: {result}");

            result = ChangeDisplaySettingsEx(secondaryDevice.DeviceName, ref devMode, IntPtr.Zero, CDS_UPDATEREGISTRY,
                IntPtr.Zero);
            if (result != DISP_CHANGE_SUCCESSFUL)
                throw new InvalidOperationException(
                    $"Failed to change display settings for {secondaryDevice.DeviceName}. Error code: {result}");
        }

        private void SetExtendMode(DISPLAY_DEVICE primaryDevice, DISPLAY_DEVICE secondaryDevice, DEVMODE devModePrimary,
            DEVMODE devModeSecondary)
        {
            devModePrimary.dmFields = unchecked((short)(DM_POSITION | DM_PELSWIDTH | DM_PELSHEIGHT));

            var result = ChangeDisplaySettingsEx(primaryDevice.DeviceName, ref devModePrimary, IntPtr.Zero,
                CDS_UPDATEREGISTRY, IntPtr.Zero);
            if (result != DISP_CHANGE_SUCCESSFUL)
                throw new InvalidOperationException(
                    $"Failed to change display settings for {primaryDevice.DeviceName}. Error code: {result}");

            devModeSecondary.dmPositionX = devModePrimary.dmPelsWidth;
            devModeSecondary.dmPositionY = 0;
            devModeSecondary.dmFields = unchecked((short)(DM_POSITION | DM_PELSWIDTH | DM_PELSHEIGHT));

            result = ChangeDisplaySettingsEx(secondaryDevice.DeviceName, ref devModeSecondary, IntPtr.Zero,
                CDS_UPDATEREGISTRY, IntPtr.Zero);
            if (result != DISP_CHANGE_SUCCESSFUL)
                throw new InvalidOperationException(
                    $"Failed to change display settings for {secondaryDevice.DeviceName}. Error code: {result}");
        }

        private void SetPrimaryOnlyMode(DISPLAY_DEVICE primaryDevice, DISPLAY_DEVICE secondaryDevice,
            DEVMODE devModePrimary, DEVMODE devModeSecondary)
        {
            devModePrimary.dmPositionX = 0;
            devModePrimary.dmPositionY = 0;
            devModePrimary.dmFields = unchecked((short)(DM_POSITION | DM_PELSWIDTH | DM_PELSHEIGHT));

            var result = ChangeDisplaySettingsEx(primaryDevice.DeviceName, ref devModePrimary, IntPtr.Zero,
                CDS_UPDATEREGISTRY, IntPtr.Zero);
            if (result != DISP_CHANGE_SUCCESSFUL)
                throw new InvalidOperationException(
                    $"Failed to change display settings for {primaryDevice.DeviceName}. Error code: {result}");

            devModeSecondary.dmPositionX = -devModeSecondary.dmPelsWidth;
            devModeSecondary.dmPositionY = 0;
            devModePrimary.dmFields = unchecked((short)(DM_POSITION | DM_PELSWIDTH | DM_PELSHEIGHT));

            result = ChangeDisplaySettingsEx(secondaryDevice.DeviceName, ref devModeSecondary, IntPtr.Zero,
                CDS_UPDATEREGISTRY, IntPtr.Zero);
            if (result != DISP_CHANGE_SUCCESSFUL)
                throw new InvalidOperationException(
                    $"Failed to change display settings for {secondaryDevice.DeviceName}. Error code: {result}");
        }

        private void SetSecondaryOnlyMode(DISPLAY_DEVICE primaryDevice, DISPLAY_DEVICE secondaryDevice,
            DEVMODE devModePrimary, DEVMODE devModeSecondary)
        {
            devModeSecondary.dmPositionX = 0;
            devModeSecondary.dmPositionY = 0;
            devModePrimary.dmFields = unchecked((short)(DM_POSITION | DM_PELSWIDTH | DM_PELSHEIGHT));

            var result = ChangeDisplaySettingsEx(secondaryDevice.DeviceName, ref devModeSecondary, IntPtr.Zero,
                CDS_UPDATEREGISTRY, IntPtr.Zero);
            if (result != DISP_CHANGE_SUCCESSFUL)
                throw new InvalidOperationException(
                    $"Failed to change display settings for {secondaryDevice.DeviceName}. Error code: {result}");

            devModePrimary.dmPositionX = -devModePrimary.dmPelsWidth;
            devModePrimary.dmPositionY = 0;
            devModePrimary.dmFields = unchecked((short)(DM_POSITION | DM_PELSWIDTH | DM_PELSHEIGHT));

            result = ChangeDisplaySettingsEx(primaryDevice.DeviceName, ref devModePrimary, IntPtr.Zero,
                CDS_UPDATEREGISTRY, IntPtr.Zero);
            if (result != DISP_CHANGE_SUCCESSFUL)
                throw new InvalidOperationException(
                    $"Failed to change display settings for {primaryDevice.DeviceName}. Error code: {result}");
        }

        private DISPLAY_DEVICE GetDisplayDevice(string deviceName)
        {
            var displayDevice = new DISPLAY_DEVICE();
            displayDevice.cb = Marshal.SizeOf(displayDevice);

            uint deviceIndex = 0;
            while (EnumDisplayDevices(null, deviceIndex, ref displayDevice, 0))
            {
                if (displayDevice.DeviceName == deviceName) return displayDevice;
                deviceIndex++;
            }

            throw new InvalidOperationException($"Display device not found: {deviceName}");
        }

        private DEVMODE GetDevMode(string deviceName)
        {
            var devMode = new DEVMODE();
            devMode.dmSize = (short)Marshal.SizeOf(devMode);

            if (!EnumDisplaySettings(deviceName, ENUM_CURRENT_SETTINGS, ref devMode))
                throw new InvalidOperationException($"Unable to get display settings for {deviceName}");

            return devMode;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct DISPLAY_DEVICE
        {
            public int cb;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string DeviceName;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string DeviceString;

            public int StateFlags;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string DeviceID;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string DeviceKey;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DEVMODE
        {
            private const int CCHDEVICENAME = 32;
            private const int CCHFORMNAME = 32;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)]
            public string dmDeviceName;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHFORMNAME)]
            public string dmFormName;

            public short dmSize;
            public short dmDriverVersion;
            public short dmSpecVersion;
            public short dmFields;
            public int dmPositionX;
            public int dmPositionY;
            public int dmDisplayOrientation;
            public int dmDisplayFixedOutput;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;
            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;
            public int dmPanningWidth;
            public int dmPanningHeight;
        }
    }
}