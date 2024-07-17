using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace changeResolution1
{
    public partial class Form1 : Form
    {
        double maxHorizontalImageSize = new double();
        double maxVerticalImageSize = new double();
        int resolutionWidth = new int();
        int resolutionHeight = new int();
        public Form1()
        {
            InitializeComponent();
            FillMonitorComboBox();
        }

        private void FillMonitorComboBox()
        {
            MonitorComboBox.Items.Clear();

            foreach (var screen in Screen.AllScreens)
            {
                MonitorComboBox.Items.Add(screen.DeviceName);
            }

            if (MonitorComboBox.Items.Count > 0)
            {
                MonitorComboBox.SelectedIndex = 0;
            }
        }

        private void MonitorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResolutionComboBox();
        }

        private void UpdateResolutionComboBox()
        {
            ResolutionComboBox.Items.Clear();
            var selectedScreen = Screen.AllScreens[MonitorComboBox.SelectedIndex];
            var resolutions = GetAvailableResolutions(selectedScreen.DeviceName);
            foreach (var resolution in resolutions)
            {
                ResolutionComboBox.Items.Add(resolution);
            }
            if (ResolutionComboBox.Items.Count > 0)
            {
                ResolutionComboBox.SelectedIndex = 0;
            }
        }

        private List<string> GetAvailableResolutions(string deviceName)
        {
            var resolutions = new List<string>();
            DEVMODE devMode = new DEVMODE();
            int modeIndex = 0;

            while (EnumDisplaySettings(deviceName, modeIndex, ref devMode))
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

        private void SetResolutionButton_Click(object sender, EventArgs e)
        {
            var selectedScreen = Screen.AllScreens[MonitorComboBox.SelectedIndex];

            if (ResolutionComboBox.SelectedItem != null)
            {
                string selectedResolution = ResolutionComboBox.SelectedItem.ToString();
                string[] parts = selectedResolution.Split('x');

                int width = int.Parse(parts[0].Trim());
                int height = int.Parse(parts[1].Trim());

                SetResolution(selectedScreen, width, height);
            }
        }

        private void SetResolution(Screen screen, int width, int height)
        {
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

        // Константы и функции для работы с разрешением экрана
        const int DISP_CHANGE_SUCCESSFUL = 0;
        const int CDS_UPDATEREGISTRY = 0x01;
        const int DM_PELSWIDTH = 0x80000;
        const int DM_PELSHEIGHT = 0x100000;

        [DllImport("user32.dll")]
        private static extern int ChangeDisplaySettingsEx(string lpszDeviceName, ref DEVMODE lpDevMode, IntPtr hwnd, int dwflags, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref DEVMODE lpDevMode);

        private ComboBox MonitorComboBox;
        private ComboBox ResolutionComboBox;
        private Button SetResolution1;

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

        private void SetResolution1_Click(object sender, EventArgs e)
        {
            var selectedScreen = Screen.AllScreens[MonitorComboBox.SelectedIndex];

            if (ResolutionComboBox.SelectedItem != null)
            {
                string selectedResolution = ResolutionComboBox.SelectedItem.ToString();
                string[] parts = selectedResolution.Split('x');

                int width = int.Parse(parts[0].Trim());
                int height = int.Parse(parts[1].Trim());

                SetResolution(selectedScreen, width, height);
            }
        }

        private void SetMaxResolution_Click(object sender, EventArgs e)
        {
            var selectedScreen = Screen.AllScreens[MonitorComboBox.SelectedIndex];
            var resolutions = GetAvailableResolutions(selectedScreen.DeviceName);

            var maxResolution = resolutions
                .Select(r => r.Split('x'))
                .Where(parts => parts.Length == 2 &&
                                int.TryParse(parts[0], out _) &&
                                int.TryParse(parts[1], out _))
                .Select(parts => (Width: int.Parse(parts[0]), Height: int.Parse(parts[1])))
                .OrderByDescending(r => r.Width * r.Height)
                .FirstOrDefault();

            if (maxResolution != default)
            {
                MessageBox.Show($"Max resolution: {maxResolution.Width}x{maxResolution.Height}");
                SetResolution(selectedScreen, maxResolution.Width, maxResolution.Height);
            }
            else
            {
                MessageBox.Show("No valid resolution found.");
            }
        }









        /*private void GetMonitorNames()
        {
            StringBuilder st = new StringBuilder();
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("root\\WMI",
                "SELECT * FROM WmiMonitorBasicDisplayParams");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                st.AppendLine("InstanceName: " + queryObj["InstanceName"].ToString() + "\n");
                st.AppendLine("Active:" + queryObj["Active"].ToString() + "\n");
                st.AppendLine("DisplayTransferCharacteristic:" + queryObj["DisplayTransferCharacteristic"].ToString() + "\n");
                maxHorizontalImageSize = Convert.ToDouble(queryObj["MaxHorizontalImageSize"]);
                maxVerticalImageSize = Convert.ToDouble(queryObj["MaxVerticalImageSize"]);
                st.AppendLine("MaxHorizontalImageSize:" + queryObj["MaxHorizontalImageSize"].ToString() + "\n");
                st.AppendLine("MaxVerticalImageSize:" + queryObj["MaxVerticalImageSize"].ToString() + "\n");
                st.AppendLine("SupportedDisplayFeatures:" + queryObj["SupportedDisplayFeatures"].ToString() + "\n");
                st.AppendLine("VideoInputType:" + queryObj["VideoInputType"].ToString() + "\n");
            }
            label1.Text = st.ToString();
        }

        private void GetDisplayInfo1()
        {
            StringBuilder sb = new StringBuilder();

            DISPLAY_DEVICE d = new DISPLAY_DEVICE();
            d.cb = Marshal.SizeOf(d);

            int deviceIndex = 0;
            while (EnumDisplayDevices(null, (uint)deviceIndex, ref d, 0))
            {
                sb.AppendLine($"Monitor {deviceIndex + 1}:");
                sb.AppendLine($"Device Name: {d.DeviceName}");
                sb.AppendLine($"Device String: {d.DeviceString}");

                DEVMODE devMode = new DEVMODE();
                devMode.dmSize = (ushort)Marshal.SizeOf(typeof(DEVMODE));

                // Получаем текущее разрешение и частоту обновления (Active Signal Mode)
                if (EnumDisplaySettings(d.DeviceName, -1, ref devMode))
                {
                    sb.AppendLine("Active Signal Mode:");
                    sb.AppendLine($"Resolution: {devMode.dmPelsWidth} x {devMode.dmPelsHeight}");
                    resolutionWidth = devMode.dmPelsWidth;
                    resolutionHeight = devMode.dmPelsHeight;
                    sb.AppendLine($"Frequency: {devMode.dmDisplayFrequency} Hz");
                    sb.AppendLine($"Color Depth: {devMode.dmBitsPerPel} bits");
                }

                // Получаем разрешение рабочего стола
                if (EnumDisplaySettings(d.DeviceName, 0, ref devMode))
                {
                    sb.AppendLine("Desktop Mode:");

                    sb.AppendLine($"Resolution: {devMode.dmPelsWidth} x {devMode.dmPelsHeight}");

                    sb.AppendLine($"Frequency: {devMode.dmDisplayFrequency} Hz");
                    sb.AppendLine($"Color Depth: {devMode.dmBitsPerPel} bits");
                }

                sb.AppendLine();

                deviceIndex++;
                d.cb = Marshal.SizeOf(d);
            }
            label2.Text = sb.ToString();
            
        }

        private void GetMonitorInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE PNPClass = 'Monitor'");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    string deviceId = queryObj["DeviceID"].ToString();
                    string description = queryObj["Description"].ToString();
                    string manufacturer = queryObj["Manufacturer"].ToString();
                    string name = queryObj["Name"].ToString();
                    string pnpDeviceId = queryObj["PNPDeviceID"].ToString();
                    string status = queryObj["Status"].ToString();

                    stringBuilder.AppendLine("DeviceID: " + deviceId + Environment.NewLine);
                    stringBuilder.AppendLine("Description: " + description + Environment.NewLine);
                    stringBuilder.AppendLine("Manufacturer: " + manufacturer + Environment.NewLine);
                    stringBuilder.AppendLine("Name: " + name + Environment.NewLine);
                    stringBuilder.AppendLine("PNPDeviceID: " + pnpDeviceId + Environment.NewLine);
                    stringBuilder.AppendLine("Status: " + status + Environment.NewLine);

                    // Извлечение модели из строки Name
                    string model = ExtractModelFromName(name);
                    stringBuilder.AppendLine("Model: " + model + Environment.NewLine);

                    // Проверка и преобразование производителя
                    if (name.Contains("LEN"))
                    {
                        manufacturer = "Lenovo";
                    }
                    stringBuilder.AppendLine("Manufacturer: " + manufacturer + Environment.NewLine);

                    stringBuilder.AppendLine("================" + Environment.NewLine);
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }

            label3.Text = stringBuilder.ToString();
        }

        static string ExtractModelFromName(string name)
        {
            string pattern = @"\((.*?)\)";
            Match match = Regex.Match(name, pattern);
            if (match.Success)
            {
                return match.Groups[1].Value.Trim();
            }
            else
            {
                return "";
            }
        }

        static double CalculateScreenDiagonal(double maxHorizontalSizeCm, double maxVerticalSizeCm)
        {
            double diagonalSizeCm = Math.Sqrt(Math.Pow(maxHorizontalSizeCm, 2) + Math.Pow(maxVerticalSizeCm, 2));
            double diagonalSizeInches = diagonalSizeCm / 2.54;
            return diagonalSizeInches;
        }

        static double CalculateDiagonalFromResolution(int resolutionWidth, int resolutionHeight, double maxHorizontalSizeCm, double maxVerticalSizeCm)
        {
            double horizontalDpi = resolutionWidth / (maxHorizontalSizeCm / 2.54);
            double verticalDpi = resolutionHeight / (maxVerticalSizeCm / 2.54);
            double averageDpi = (horizontalDpi + verticalDpi) / 2;
            double diagonalPixels = Math.Sqrt(Math.Pow(resolutionWidth, 2) + Math.Pow(resolutionHeight, 2));
            double diagonalInches = diagonalPixels / averageDpi;

            return diagonalInches;
        }
*/

    }
}

