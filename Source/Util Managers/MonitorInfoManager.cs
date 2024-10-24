using MaterialSkin.Controls;
using ServiceMonitorEVK.Source.Constants;
using ServiceMonitorEVK.Source.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceMonitorEVK.Source.Util_Managers
{
    public class MonitorInfoManager
    {
        private double maxHorizontalSizeCm;
        private double maxVerticalSizeCm;
        private readonly Dictionary<string, string> monitorNameToIdentifierMap = new Dictionary<string, string>();
        private int resolutionHeight;
        private int resolutionWidth;

        
        public async Task<string> GetMonitorNamesAsync()
        {
            var st = new StringBuilder();
            try
            {
                await Task.Run(() =>
                {
                    var searcher =
                        new ManagementObjectSearcher("root\\WMI", "SELECT * FROM WmiMonitorBasicDisplayParams");

                    foreach (var o in searcher.Get())
                    {
                        var queryObj = (ManagementObject)o;
                        maxHorizontalSizeCm = Convert.ToDouble(queryObj["MaxHorizontalImageSize"]);
                        maxVerticalSizeCm = Convert.ToDouble(queryObj["MaxVerticalImageSize"]);
                        st.AppendLine("InstanceName: " + queryObj["InstanceName"] + "\n");
                        st.AppendLine("Active: " + queryObj["Active"] + "\n");
                        st.AppendLine("DisplayTransferCharacteristic: " + queryObj["DisplayTransferCharacteristic"] +
                                      "\n");
                        st.AppendLine("MaxHorizontalImageSize: " + maxHorizontalSizeCm + "\n");
                        st.AppendLine("MaxVerticalImageSize: " + maxVerticalSizeCm + "\n");
                        st.AppendLine("SupportedDisplayFeatures: " + queryObj["SupportedDisplayFeatures"] + "\n");
                        st.AppendLine("VideoInputType: " + queryObj["VideoInputType"] + "\n");
                        st.AppendLine("--------------------------------------------");
                    }
                });
            }
            catch (ManagementException ex)
            {
                MessageBox.Show(@"An error occurred while querying for WMI data: " + ex.Message);
            }

            return st.ToString();
        }

        public async Task<string> GetMonitorInfoAsync()
        {
            var stringBuilder = new StringBuilder();

            try
            {
                await Task.Run(() =>
                {
                    var searcher =
                        new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE PNPClass = 'Monitor'");

                    foreach (var o in searcher.Get())
                    {
                        var queryObj = (ManagementObject)o;

                        foreach (var property in queryObj.Properties)
                        {
                            stringBuilder.AppendLine($"{property.Name}: {property.Value}");
                        }

                        stringBuilder.AppendLine("--------------------------------------------");
                    }
                });
            }
            catch (ManagementException ex)
            {
                MessageBox.Show(@"An error occurred while querying for WMI data: " + ex.Message);
            }

            return stringBuilder.ToString();
        }


        [DllImport("user32.dll")]
        public static extern bool EnumDisplayDevices(string lpDevice, uint iDevNum, ref DISPLAY_DEVICE lpDisplayDevice,
            uint dwFlags);

        [DllImport("user32.dll")]
        private static extern bool EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref DEVMODE lpDevMode);

        public async Task<string> GetDisplayInfo1Async()
        {
            var sb = new StringBuilder();

            await Task.Run(() =>
            {
                var d = new DISPLAY_DEVICE();
                d.cb = Marshal.SizeOf(d);

                var deviceIndex = 0;
                while (EnumDisplayDevices(null, (uint)deviceIndex, ref d, 0))
                {
                    sb.AppendLine($"Monitor {deviceIndex + 1}:");
                    sb.AppendLine($"Device Name: {d.DeviceName}");
                    sb.AppendLine($"Device String: {d.DeviceString}");
                    sb.AppendLine($"State Flags: {d.StateFlags}");
                    sb.AppendLine($"Device ID: {d.DeviceID}");
                    sb.AppendLine($"Device Key: {d.DeviceKey}");

                    var devMode = new DEVMODE
                    {
                        dmSize = (ushort)Marshal.SizeOf(typeof(DEVMODE))
                    };

                    if (EnumDisplaySettings(d.DeviceName, -1, ref devMode))
                    {
                        sb.AppendLine("Active Signal Mode:");
                        sb.AppendLine($"Resolution: {devMode.dmPelsWidth} x {devMode.dmPelsHeight}");
                        sb.AppendLine($"Frequency: {devMode.dmDisplayFrequency} Hz");
                        sb.AppendLine($"Color Depth: {devMode.dmBitsPerPel} bits");
                        sb.AppendLine($"Display Flags: {devMode.dmDisplayFlags}");
                        sb.AppendLine($"Display Orientation: {devMode.dmDisplayOrientation}");
                        sb.AppendLine($"Form Name: {devMode.dmFormName}");
                        sb.AppendLine($"Log Pixels: {devMode.dmLogPixels}");
                        sb.AppendLine($"Bits per Pixel: {devMode.dmBitsPerPel}");
                        sb.AppendLine($"Panning Width: {devMode.dmPanningWidth}");
                        sb.AppendLine($"Panning Height: {devMode.dmPanningHeight}");
                        sb.AppendLine($"Display Fixed Output: {devMode.dmDisplayFixedOutput}");
                        resolutionWidth = (int)devMode.dmPelsWidth;
                        resolutionHeight = (int)devMode.dmPelsHeight;
                    }

                    if (EnumDisplaySettings(d.DeviceName, 0, ref devMode))
                    {
                        sb.AppendLine("Desktop Mode:");
                        sb.AppendLine($"Resolution: {devMode.dmPelsWidth} x {devMode.dmPelsHeight}");
                        sb.AppendLine($"Frequency: {devMode.dmDisplayFrequency} Hz");
                        sb.AppendLine($"Color Depth: {devMode.dmBitsPerPel} bits");
                        sb.AppendLine($"Display Flags: {devMode.dmDisplayFlags}");
                        sb.AppendLine($"Display Orientation: {devMode.dmDisplayOrientation}");
                        sb.AppendLine($"Form Name: {devMode.dmFormName}");
                        sb.AppendLine($"Log Pixels: {devMode.dmLogPixels}");
                        sb.AppendLine($"Bits per Pixel: {devMode.dmBitsPerPel}");
                        sb.AppendLine($"Panning Width: {devMode.dmPanningWidth}");
                        sb.AppendLine($"Panning Height: {devMode.dmPanningHeight}");
                        sb.AppendLine($"Display Fixed Output: {devMode.dmDisplayFixedOutput}");
                    }

                    sb.AppendLine("--------------------------------------------");
                    deviceIndex++;
                    d.cb = Marshal.SizeOf(d);
                }
            });

            return sb.ToString();
        }


        public static double CalculatePpi(double widthCm, double heightCm, int widthPx, int heightPx)
        {
            var diagonalInches = CalculateDiagonalInInches(widthCm, heightCm);
            var diagonalPx = Math.Sqrt(Math.Pow(widthPx, 2) + Math.Pow(heightPx, 2));
            return diagonalPx / diagonalInches;
        }

        public static double CalculateDiagonalInInches(double widthCm, double heightCm)
        {
            var diagonalCm = Math.Sqrt(Math.Pow(widthCm, 2) + Math.Pow(heightCm, 2));
            return diagonalCm / 2.54;
        }

        public string GetDiagonal()
        {
            var stringBuilder = new StringBuilder();
            var diagonalSizeCm = Math.Sqrt(Math.Pow(maxHorizontalSizeCm, 2) + Math.Pow(maxVerticalSizeCm, 2));
            var diagonalSizeInches = diagonalSizeCm / 2.54;
            stringBuilder.AppendLine("Diagonal from hight/width:" + diagonalSizeInches + Environment.NewLine);

            var horizontalDpi = resolutionWidth / (maxHorizontalSizeCm / 2.54);
            var verticalDpi = resolutionHeight / (maxVerticalSizeCm / 2.54);
            var averageDpi = (horizontalDpi + verticalDpi) / 2;
            var diagonalPixels = Math.Sqrt(Math.Pow(resolutionWidth, 2) + Math.Pow(resolutionHeight, 2));
            var diagonalInches = diagonalPixels / averageDpi;
            stringBuilder.AppendLine("Diagonal from resolution:" + diagonalInches + Environment.NewLine);
            stringBuilder.AppendLine("PPI: " +
                                     CalculatePpi(maxVerticalSizeCm, maxHorizontalSizeCm, resolutionWidth,
                                         resolutionHeight));
            return stringBuilder.ToString();
        }


        public async Task<string> GetEdidInfoAsync()
        {
            var edidInfo = new StringBuilder();

            try
            {
                await Task.Run(() =>
                {
                    var searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM WmiMonitorID");

                    foreach (var o in searcher.Get())
                    {
                        foreach (PropertyData property in o.Properties)
                        {
                            edidInfo.AppendLine($"{property.Name}: {property.Value}");
                        }
                        var queryObj = (ManagementObject)o;
                        var instanceName = queryObj["InstanceName"].ToString();
                        var yearOfManufacture = queryObj["YearOfManufacture"].ToString();
                        var weekOfManufacture = queryObj["WeekOfManufacture"].ToString();
                        var serialNumberId = queryObj["SerialNumberID"];
                        var productCodeId = queryObj["ProductCodeID"];


                        edidInfo.AppendLine("Month Of Manufacture: " +
                                            ConvertWeeksToMonths(Convert.ToInt16(weekOfManufacture)) + "\n");

                        if (serialNumberId is string[] serialNumber)
                        {
                            edidInfo.AppendLine("Serial Number: " +
                                                string.Join("",
                                                    serialNumber.Select(s => ((char)int.Parse(s)).ToString())) +
                                                "dfdsf\n");
                        }

                        if (serialNumberId != null)
                        {
                            var decodeEdidString = DecodeEdidString((ushort[])serialNumberId);
                            edidInfo.AppendLine("Serial Numberff: " + decodeEdidString + "\n");
                        }
                        else
                        {
                            edidInfo.AppendLine("Serial Number: Not Available\n");
                        }

                        var manufacturerNameUshorts = (ushort[])queryObj["ManufacturerName"];
                        var manufacturerNameFull = DecodeMonitorString(manufacturerNameUshorts);


                        var userfrendlyNameUshorts = (ushort[])queryObj["UserFriendlyName"];
                        var userfrendlyNameFull = DecodeMonitorString(userfrendlyNameUshorts);


                        var manufacturer = "";
                        foreach (var entry in MonitorConstants.ManufacturerDictionary.
                                     Where(entry => manufacturerNameFull.IndexOf(entry.Key, StringComparison.OrdinalIgnoreCase) >= 0))
                            manufacturer = entry.Value;
                        edidInfo.AppendLine("Manufacturer: " + manufacturer + Environment.NewLine);
                        edidInfo.AppendLine("SystemModel: " + userfrendlyNameFull + Environment.NewLine);

                        if (productCodeId is ushort[] productCode)
                            edidInfo.AppendLine("Product Code ID: " +
                                                string.Join("", productCode.Select(p => p.ToString("X"))) + "\n");
                        edidInfo.AppendLine("\n--------------------------------------------");
                    }
                });
            }
            catch (ManagementException ex)
            {
                MessageBox.Show(@"An error occurred while querying for WMI data: " + ex.Message);
            }

            return edidInfo.ToString();
        }

        private static string DecodeMonitorString(ushort[] data)
        {
            if (data == null) return string.Empty;

            var result = new StringBuilder();
            foreach (var code in data)
            {
                if (code == 0) break;
                result.Append((char)code);
            }

            return result.ToString();
        }

        private static int ConvertWeeksToMonths(int weeks)
        {
            const double weeksInMonth = 4.345;
            return (int)Math.Round(weeks / weeksInMonth);
        }



        private static string DecodeEdidString(ushort[] rawData)
        {
            var decodedString = new StringBuilder();
            foreach (var data in rawData)
                if (data > 0)
                    decodedString.Append((char)data);
            return decodedString.ToString();
        }


        public List<string> GetFriendlyMonitorNames()
        {
            var friendlyNames = new List<string>();

            try
            {
                var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE PNPClass = 'Monitor'");

                foreach (var o in searcher.Get())
                {
                    var queryObj = (ManagementObject)o;
                    var name = queryObj["Name"].ToString();
                    friendlyNames.Add(name);
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show(@"An error occurred while querying for WMI data: " + ex.Message);
            }


            return friendlyNames;
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

    }
}