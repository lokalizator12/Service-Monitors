using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceMonitorEVK.Util_Managers
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
                        var deviceId = queryObj["DeviceID"].ToString();
                        var description = queryObj["Description"].ToString();
                        var manufacturer = queryObj["Manufacturer"].ToString();
                        var name = queryObj["Name"].ToString();
                        var pnpDeviceId = queryObj["PNPDeviceID"].ToString();
                        var status = queryObj["Status"].ToString();

                        stringBuilder.AppendLine("DeviceID: " + deviceId + Environment.NewLine);
                        stringBuilder.AppendLine("Description: " + description + Environment.NewLine);
                        stringBuilder.AppendLine("Manufacturer: " + manufacturer + Environment.NewLine);
                        stringBuilder.AppendLine("Name: " + name + Environment.NewLine);
                        stringBuilder.AppendLine("PNPDeviceID: " + pnpDeviceId + Environment.NewLine);
                        stringBuilder.AppendLine("Status: " + status + Environment.NewLine);
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
                    sb.AppendLine($"Device id: {d.DeviceID}");

                    sb.AppendLine($"Device String: {d.DeviceString}");

                    var devMode = new DEVMODE
                    {
                        dmSize = (ushort)Marshal.SizeOf(typeof(DEVMODE))
                    };

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

                    sb.AppendLine("--------------------------------------------");
                    deviceIndex++;
                    d.cb = Marshal.SizeOf(d);
                }
            });

            return sb.ToString();
        }

        private static string ExtractModelFromName(string name)
        {
            var pattern = @"\((.*?)\)";
            var match = Regex.Match(name, pattern);
            return match.Success ? match.Groups[1].Value.Trim() : "";
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
                        var queryObj = (ManagementObject)o;
                        var instanceName = queryObj["InstanceName"].ToString();
                        var yearOfManufacture = queryObj["YearOfManufacture"].ToString();
                        var weekOfManufacture = queryObj["WeekOfManufacture"].ToString();
                        var serialNumberId = queryObj["SerialNumberID"];
                        var productCodeId = queryObj["ProductCodeID"];

                        edidInfo.AppendLine("Instance Name: " + instanceName + "\n");
                        edidInfo.AppendLine("Month and Year Of Manufacture: " + yearOfManufacture + "\n");
                        edidInfo.AppendLine("Month Of Manufacture: " +
                                            ConvertWeeksToMonths(Convert.ToInt16(weekOfManufacture)) + "\n");

                        if (serialNumberId is string[] serialNumber)
                            edidInfo.AppendLine("Serial Number: " +
                                                string.Join("",
                                                    serialNumber.Select(s => ((char)int.Parse(s)).ToString())) + "\n");

                        var manufacturerNameUshorts = (ushort[])queryObj["ManufacturerName"];
                        var manufacturerNameFull = DecodeMonitorString(manufacturerNameUshorts);


                        var userfrendlyNameUshorts = (ushort[])queryObj["UserFriendlyName"];
                        var userfrendlyNameFull = DecodeMonitorString(userfrendlyNameUshorts);

                        var manufacturerDictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                        {
                            { "ACER", "Acer" },
                            { "ACI", "Asus (ASUSTeK Computer Inc.)" },
                            { "ACT", "Targa" },
                            { "ADI", "ADI Corporation" },
                            { "AMW", "AMW" },
                            { "AOC", "AOC International (USA) Ltd." },
                            { "API", "Acer America Corp." },
                            { "APP", "Apple" },
                            { "ART", "ArtMedia" },
                            { "AST", "AST Research" },
                            { "ASUS", "ASUS" },
                            { "AUO", "AU Optronics" },
                            { "BENQ", "BenQ" },
                            { "BNQ", "BenQ Corporation" },
                            { "BOE", "BOE Display Technology" },
                            { "CASIO", "Casio" },
                            { "CMN", "Chi Mei" },
                            { "CPQ", "COMPAQ Computer Corp." },
                            { "CPL", "Compal Electronics, Inc. / ALFA" },
                            { "CTX", "CTX / Chuntex Electronic Co." },
                            { "DEC", "Digital Equipment Corporation" },
                            { "DELL", "Dell" },
                            { "DPC", "Delta Electronics, Inc." },
                            { "DWE", "Daewoo Telecom Ltd" },
                            { "ECS", "ELITEGROUP Computer Systems" },
                            { "EIZ", "EIZO Corporation" },
                            { "EPI", "Envision Peripherals, Inc." },
                            { "FCM", "Funai Electric Company of Taiwan" },
                            { "FUS", "Fujitsu Siemens" },
                            { "GIGABYTE", "Gigabyte" },
                            { "GSM", "LG Electronics Inc. (GoldStar Technology, Inc.)" },
                            { "GWY", "Gateway 2000" },
                            { "HAIER", "Haier" },
                            { "HANNSTAR", "HannStar" },
                            { "HISENSE", "Hisense" },
                            { "HEI", "Hyundai Electronics Industries Co., Ltd." },
                            { "HIQ", "Hyundai ImageQuest" },
                            { "HIT", "Hitachi" },
                            { "HP", "Hewlett-Packard" },
                            { "HSD", "Hannspree Inc." },
                            { "HSL", "Hansol Electronics" },
                            { "HTC", "Hitachi Ltd. / Nissei Sangyo America Ltd." },
                            { "HUA", "Huawei" },
                            { "HWP", "Hewlett Packard (HP)" },
                            { "IBM", "IBM PC Company" },
                            { "ICL", "Fujitsu ICL" },
                            { "IFS", "InFocus" },
                            { "INSIGNIA", "Insignia" },
                            { "IQT", "Hyundai" },
                            { "IVM", "Iiyama" },
                            { "JVC", "JVC" },
                            { "KDS", "KDS USA" },
                            { "KFC", "KFC Computek" },
                            { "KOIZUMI", "Koizumi" },
                            { "KONKA", "Konka" },
                            { "LEN", "Lenovo" },
                            { "LG", "LG" },
                            { "LGD", "LG Display" },
                            { "LKM", "ADLAS / AZALEA" },
                            { "LNK", "LINK Technologies, Inc." },
                            { "LPL", "LG Philips" },
                            { "LTN", "Lite-On" },
                            { "MAG", "MAG InnoVision" },
                            { "MAX", "Maxdata Computer GmbH" },
                            { "MEI", "Panasonic Comm. & Systems Co." },
                            { "MEL", "Mitsubishi Electronics" },
                            { "MIC", "Microsoft" },
                            { "MIR", "Miro Computer Products AG" },
                            { "MITSUBISHI", "Mitsubishi Electric" },
                            { "MSI", "MSI" },
                            { "NAN", "NANAO" },
                            { "NEC", "NEC Display Solutions" },
                            { "NOK", "Nokia" },
                            { "NVD", "Nvidia" },
                            { "OQI", "OPTIQUEST" },
                            { "PACKARD BELL", "Packard Bell" },
                            { "PBN", "Packard Bell" },
                            { "PCK", "Daewoo" },
                            { "PDC", "Polaroid" },
                            { "PHILIPS", "Philips" },
                            { "PHL", "Philips Consumer Electronics Co." },
                            { "PLANAR", "Planar Systems" },
                            { "PGS", "Princeton Graphic Systems" },
                            { "PROVIEW", "Proview" },
                            { "PRT", "Princeton" },
                            { "RAZER", "Razer" },
                            { "REL", "Relisys" },
                            { "SAMSUNG", "Samsung" },
                            { "SANYO", "Sanyo" },
                            { "SEC", "Seiko Epson Corporation" },
                            { "SHARP", "Sharp" },
                            { "SKYWORTH", "Skyworth" },
                            { "SMC", "Samtron" },
                            { "SMI", "Smile" },
                            { "SNI", "Siemens Nixdorf" },
                            { "SONY", "Sony" },
                            { "SPT", "Sceptre" },
                            { "SRC", "Shamrock Technology" },
                            { "STN", "Samtron" },
                            { "STP", "Sceptre" },
                            { "TAT", "Tatung Co. of America, Inc." },
                            { "TATUNG", "Tatung" },
                            { "TCL", "TCL Technology" },
                            { "THOMSON", "Thomson" },
                            { "TSB", "Toshiba" },
                            { "UNM", "Unisys Corporation" },
                            { "VESTEL", "Vestel" },
                            { "VIEW", "ViewSonic" },
                            { "VIZIO", "Vizio" },
                            { "VSC", "ViewSonic Corporation" },
                            { "WTC", "Wen Technology" },
                            { "ZCM", "Zenith Data Systems" },
                            { "WESTINGHOUSE", "Westinghouse" }
                        };
                        // string model = ExtractModelFromName(userfrendlyNameFull);
                        var manufacturer = "";
                        foreach (var entry in manufacturerDictionary.Where(entry => manufacturerNameFull.IndexOf(entry.Key, StringComparison.OrdinalIgnoreCase) >= 0))
                            manufacturer = entry.Value;
                        edidInfo.AppendLine("Manufacturer: " + manufacturer + Environment.NewLine);
                        edidInfo.AppendLine("Model: " + userfrendlyNameFull + Environment.NewLine);

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

        public async Task<string> GetMonitorSerialNumberAsync()
        {
            var serialNumberInfo = new StringBuilder();

            try
            {
                await Task.Run(() =>
                {
                    var searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM WmiMonitorID");

                    foreach (var o in searcher.Get())
                    {
                        var queryObj = (ManagementObject)o;
                        var instanceName = queryObj["InstanceName"].ToString();
                        var serialNumberId = (ushort[])queryObj["SerialNumberID"];

                        serialNumberInfo.AppendLine("Instance Name: " + instanceName + "\n");

                        if (serialNumberId != null && serialNumberId.Length > 0)
                        {
                            var serialNumber = DecodeEdidString(serialNumberId);
                            serialNumberInfo.AppendLine("Serial Number: " + serialNumber + "\n");
                        }
                        else
                        {
                            serialNumberInfo.AppendLine("Serial Number: Not Available\n");
                        }

                        serialNumberInfo.AppendLine("\n");
                    }
                });
            }
            catch (ManagementException ex)
            {
                MessageBox.Show(@"An error occurred while querying for WMI data: " + ex.Message);
            }

            return serialNumberInfo.ToString();
        }

        private static string DecodeEdidString(ushort[] rawData)
        {
            var decodedString = new StringBuilder();
            foreach (var data in rawData)
                if (data > 0)
                    decodedString.Append((char)data);
            return decodedString.ToString();
        }
/*
        public Screen SetScreenToComboBoxAndGetNonIntegred(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            monitorNameToIdentifierMap.Clear();

            var monitorNames = Screen.AllScreens.Select(screen => screen.DeviceName).ToList();
            var friendlyNames = GetFriendlyMonitorNames();

            for (var i = 0; i < monitorNames.Count; i++)
            {
                var identifier = monitorNames[i];
                var friendlyName = friendlyNames[i];
                monitorNameToIdentifierMap[friendlyName] = identifier;
                comboBox.Items.Add(friendlyName);
            }

            // Select the first non-integrated monitor
            var nonIntegratedIndex = comboBox.Items.Count > 1 ? 1 : 0;
            comboBox.SelectedIndex = nonIntegratedIndex;
            return Screen.AllScreens[nonIntegratedIndex];
        }*/

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

        public string GetIdentifierFromFriendlyName(string friendlyName)
        {
            if (monitorNameToIdentifierMap.ContainsKey(friendlyName)) return monitorNameToIdentifierMap[friendlyName];
            return null;
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