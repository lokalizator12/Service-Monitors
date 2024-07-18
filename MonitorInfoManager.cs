using System;
using System.Collections.Generic;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static changeResolution1.DisplayManager;

namespace changeResolution1
{
    internal class MonitorInfoManager
    {

        private int resolutionWidth;
        private int resolutionHeight;
        private double maxHorizontalSizeCm;
        private double maxVerticalSizeCm;
        public async Task<string> GetMonitorNamesAsync()
        {
            StringBuilder st = new StringBuilder();
            try
            {
                await Task.Run(() =>
                {
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM WmiMonitorBasicDisplayParams");

                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        maxHorizontalSizeCm = Convert.ToDouble(queryObj["MaxHorizontalImageSize"]);
                        maxVerticalSizeCm = Convert.ToDouble(queryObj["MaxVerticalImageSize"]);
                        st.AppendLine("InstanceName: " + queryObj["InstanceName"].ToString() + "\n");
                        st.AppendLine("Active: " + queryObj["Active"].ToString() + "\n");
                        st.AppendLine("DisplayTransferCharacteristic: " + queryObj["DisplayTransferCharacteristic"].ToString() + "\n");
                        st.AppendLine("MaxHorizontalImageSize: " + maxHorizontalSizeCm.ToString() + "\n");
                        st.AppendLine("MaxVerticalImageSize: " + maxVerticalSizeCm.ToString() + "\n");
                        st.AppendLine("SupportedDisplayFeatures: " + queryObj["SupportedDisplayFeatures"].ToString() + "\n");
                        st.AppendLine("VideoInputType: " + queryObj["VideoInputType"].ToString() + "\n");
                    }
                });
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }

            return st.ToString();
        }

        public async Task<string> GetMonitorInfoAsync()
        {
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                await Task.Run(() =>
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

                        Dictionary<string, string> manufacturerDictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                        {
                            { "LEN", "Lenovo" },
                            { "HP", "Hewlett-Packard" },
                            { "DELL", "Dell" },
                            { "ASUS", "ASUS" },
                            { "ACER", "Acer" },
                            { "MSI", "MSI" },
                            { "SAMSUNG", "Samsung" },
                            { "LG", "LG" },
                            { "SONY", "Sony" },
                            { "TOSHIBA", "Toshiba" },
                            { "APPLE", "Apple" },
                            { "HUAWEI", "Huawei" },
                            { "MICROSOFT", "Microsoft" },
                            { "XIAOMI", "Xiaomi" }
                        };

                        string model = ExtractModelFromName(name);

                        foreach (var entry in manufacturerDictionary)
                        {
                            if (name.IndexOf(entry.Key, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                manufacturer = entry.Value;
                                model = Regex.Replace(model, entry.Key, string.Empty, RegexOptions.IgnoreCase);
                                break;
                            }
                        }

                        stringBuilder.AppendLine("Model: " + model.Trim() + Environment.NewLine);
                        stringBuilder.AppendLine("Manufacturer: " + manufacturer + Environment.NewLine);
                    }
                });
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }

            return stringBuilder.ToString();
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


        [DllImport("user32.dll")]
        public static extern bool EnumDisplayDevices(string lpDevice, uint iDevNum, ref DISPLAY_DEVICE lpDisplayDevice, uint dwFlags);

        [DllImport("user32.dll")]
        private static extern bool EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref DEVMODE lpDevMode);

        public async Task<string> GetDisplayInfo1Async()
        {
            StringBuilder sb = new StringBuilder();

            await Task.Run(() =>
            {
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

                    if (EnumDisplaySettings(d.DeviceName, -1, ref devMode))
                    {
                        sb.AppendLine("Active Signal Mode:");
                        sb.AppendLine($"Resolution: {devMode.dmPelsWidth} x {devMode.dmPelsHeight}");
                        resolutionWidth = (int)devMode.dmPelsWidth;
                        resolutionHeight = (int)devMode.dmPelsHeight;
                        sb.AppendLine($"Frequency: {devMode.dmDisplayFrequency} Hz");
                        sb.AppendLine($"Color Depth: {devMode.dmBitsPerPel} bits");
                    }

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
            });

            return sb.ToString();
        }

        private static string ExtractModelFromName(string name)
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


        public string GetDiagonal()
        {
            StringBuilder stringBuilder = new StringBuilder();
            double diagonalSizeCm = Math.Sqrt(Math.Pow(maxHorizontalSizeCm, 2) + Math.Pow(maxVerticalSizeCm, 2));
            double diagonalSizeInches = diagonalSizeCm / 2.54;
            stringBuilder.AppendLine("Diagonal from hidht/width:" + diagonalSizeInches.ToString() + Environment.NewLine);

            double horizontalDpi = resolutionWidth / (maxHorizontalSizeCm / 2.54);
            double verticalDpi = resolutionHeight / (maxVerticalSizeCm / 2.54);
            double averageDpi = (horizontalDpi + verticalDpi) / 2;
            double diagonalPixels = Math.Sqrt(Math.Pow(resolutionWidth, 2) + Math.Pow(resolutionHeight, 2));
            double diagonalInches = diagonalPixels / averageDpi;
            stringBuilder.AppendLine("Diagonal from resolution:" + diagonalInches.ToString() + Environment.NewLine);
            return stringBuilder.ToString();
        }
    }
}
