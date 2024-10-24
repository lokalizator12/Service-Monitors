using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace changeResolution1
{
    public partial class MonitorInfoForm : Form
    {
        private Dictionary<string, string> monitorNameToIdentifierMap;
        private MonitorInfoManager monitorInfoManager;
        private ResolutionDisplayManager resolutionManager;
        MonitorInfo[] monitors;

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
        public MonitorInfoForm()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM WmiMonitorID");
            monitors = new MonitorInfo[searcher.Get().Count];
            InitializeComponent();
            monitorInfoManager = new MonitorInfoManager();
            resolutionManager = new ResolutionDisplayManager();
            FillMonitorComboBox();
            GetMonitorInfos();

        }

        private void FillMonitorComboBox()
        {
            MonitorComboBox.Items.Clear();
            monitorNameToIdentifierMap = new Dictionary<string, string>();

            var monitorNames = resolutionManager.GetMonitorNames();
            Console.WriteLine(monitorNames);
            var friendlyNames = monitorInfoManager.GetFriendlyMonitorNames();

            for (int i = 0; i < monitorNames.Count; i++)
            {
                var identifier = monitorNames[i];
                var friendlyName = friendlyNames[i];
                monitorNameToIdentifierMap[friendlyName] = identifier;
                MonitorComboBox.Items.Add(friendlyName);
            }

            if (MonitorComboBox.Items.Count > 0)
            {
                MonitorComboBox.SelectedIndex = 0;
            }
        }

        public MonitorInfo[] GetMonitorInfos()
        {
            for (int i = 0; i < monitors.Length; i++)
                monitors[i] = (new MonitorInfo()
                { });

            monitors = SetEdidInfoAsync(monitors);
            monitors = SetMonitorSizes(monitors);
            return monitors;
        }




        public MonitorInfo[] SetEdidInfoAsync(MonitorInfo[] monitors)
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM WmiMonitorID");
                int i = 0;
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    var yearOfManufacture = queryObj["YearOfManufacture"].ToString();
                    var weekOfManufacture = queryObj["WeekOfManufacture"].ToString();
                    var productCodeID = queryObj["ProductCodeID"];

                    ushort[] manufacturerNameUshorts = (ushort[])queryObj["ManufacturerName"];
                    string manufacturerNameFull = DecodeMonitorString(manufacturerNameUshorts);


                    ushort[] userfrendlyNameUshorts = (ushort[])queryObj["UserFriendlyName"];
                    string userfrendlyNameFull = DecodeMonitorString(userfrendlyNameUshorts);

                    Dictionary<string, string> manufacturerDictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
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

                    string manufacturer = "";
                    foreach (var entry in manufacturerDictionary)
                    {
                        if (manufacturerNameFull.IndexOf(entry.Key, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            manufacturer = entry.Value;

                        }
                    }
                    string productCodeFull = "";
                    if (productCodeID is ushort[] productCode)
                    {
                        productCodeFull = string.Join("", productCode.Select(p => p.ToString("X")));
                    }

                    var serialNumberID = (ushort[])queryObj["SerialNumberID"];
                    if (serialNumberID != null && serialNumberID.Length > 0)
                    {
                        string serialNumber = DecodeMonitorString(serialNumberID);
                        monitors[i].SerialNumber = serialNumber;
                    }
                    else
                    {
                        monitors[i].SerialNumber = "N/A";
                    }

                    monitors[i].YearOfProduction = yearOfManufacture;
                    monitors[i].MonthOfProduction = ConvertWeeksToMonths(Convert.ToInt16(weekOfManufacture));
                    monitors[i].Manufacturer = manufacturer;
                    monitors[i].Model = userfrendlyNameFull;
                    monitors[i].ProductCodeID = productCodeFull;
                    i++;
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }
            return monitors;
        }


        private double GetDiagonalFromSize(double mV, double mH)
        {
            double diagonalSizeCm = Math.Sqrt(Math.Pow(mH, 2) + Math.Pow(mV, 2));
            return diagonalSizeCm / 2.54;
        }


        private double GetDiagonalFromResoluton(double mV, double mH, double mRv, double mRh)
        {
            double horizontalDpi = mRv / (mH / 2.54);
            double verticalDpi = mRh / (mV / 2.54);
            double averageDpi = (horizontalDpi + verticalDpi) / 2;
            double diagonalPixels = Math.Sqrt(Math.Pow(mRv, 2) + Math.Pow(mRh, 2));
            return diagonalPixels / averageDpi;
        }

        public double CalculatePPI(double widthCm, double heightCm, int widthPx, int heightPx)
        {
            double diagonalInches = GetDiagonalFromSize(widthCm, heightCm);
            double diagonalPx = Math.Sqrt(Math.Pow(widthPx, 2) + Math.Pow(heightPx, 2));
            return diagonalPx / diagonalInches;
        }
        public MonitorInfo[] SetMonitorSizes(MonitorInfo[] monitors)
        {
            double maxHorizontalSizeCm = 0.0d;
            double maxVerticalSizeCm = 0.0d;
            int resolutionWidth = 0;
            int resolutionHeight = 0;
            int displayFrequency = 0;
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM WmiMonitorBasicDisplayParams");
                int i = 0;
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    maxHorizontalSizeCm = Convert.ToDouble(queryObj["MaxHorizontalImageSize"]);
                    maxVerticalSizeCm = Convert.ToDouble(queryObj["MaxVerticalImageSize"]);
                    monitors[i].MaxHorizontalSize = maxHorizontalSizeCm;
                    monitors[i].MaxVerticalSize = maxVerticalSizeCm;
                    monitors[i].SizeMonitor = maxHorizontalSizeCm + "x" + maxVerticalSizeCm;
                    monitors[i].Diagonal1 = GetDiagonalFromSize(maxVerticalSizeCm, maxHorizontalSizeCm);
                    i++;
                }


                DISPLAY_DEVICE d = new DISPLAY_DEVICE();
                d.cb = Marshal.SizeOf(d);

                int deviceIndex = 0;
                while (EnumDisplayDevices(null, (uint)deviceIndex, ref d, 0))
                {
                    DEVMODE devMode = new DEVMODE();
                    devMode.dmSize = (ushort)Marshal.SizeOf(typeof(DEVMODE));

                    if (EnumDisplaySettings(d.DeviceName, -1, ref devMode))
                    {
                        resolutionWidth = (int)devMode.dmPelsWidth;
                        resolutionHeight = (int)devMode.dmPelsHeight;
                        displayFrequency = (int)devMode.dmDisplayFrequency;
                        monitors[deviceIndex].Resolution = resolutionWidth + " x" + resolutionHeight;
                        monitors[deviceIndex].Frequency = displayFrequency;
                        monitors[deviceIndex].PPI =
                            CalculatePPI(monitors[deviceIndex].MaxVerticalSize,
                            monitors[deviceIndex].MaxHorizontalSize,
                            resolutionWidth, resolutionHeight).ToString();

                        monitors[deviceIndex].Diagonal2 =
                            GetDiagonalFromResoluton(
                            monitors[deviceIndex].MaxVerticalSize,
                            monitors[deviceIndex].MaxHorizontalSize,
                            resolutionWidth,
                            resolutionHeight).ToString();
                    }

                    deviceIndex++;
                    d.cb = Marshal.SizeOf(d);
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }
            return monitors;
        }



        static string DecodeMonitorString(ushort[] data)
        {
            if (data == null)
            {
                return string.Empty;
            }

            StringBuilder result = new StringBuilder();
            foreach (ushort code in data)
            {
                if (code == 0)
                {
                    break;
                }
                result.Append((char)code);
            }

            return result.ToString();
        }
        static string ConvertWeeksToMonths(int weeks)
        {
            const double weeksInMonth = 4.345;
            int result = (int)Math.Round(weeks / weeksInMonth);
            return result.ToString();
        }
        private void DisplayMonitorInfo(MonitorInfo monitorInfo)
        {
            lblManufacturer.Text = monitorInfo.Manufacturer;
            lblModel.Text = monitorInfo.Model;
            lblSerialNo.Text = monitorInfo.SerialNumber;
            lblYearOfProduction.Text = monitorInfo.YearOfProduction;
            lblMonthOfProduction.Text = monitorInfo.MonthOfProduction;
            lblProductCodeID.Text = monitorInfo.ProductCodeID;
            lblDiagonal1.Text = monitorInfo.Diagonal1.ToString();
            lblDiagonal2.Text = monitorInfo.Diagonal2;
            lblResolution.Text = monitorInfo.Resolution;
            lblFrequency.Text = monitorInfo.Frequency.ToString();
            lblPPI.Text = monitorInfo.PPI;
            lblSizeMonitor.Text = monitorInfo.SizeMonitor;
        }

        private void CopyToClipboard(string text)
        {
            Clipboard.SetText(text);
        }
        private void lblManufacturer_Click(object sender, EventArgs e)
        {
            CopyToClipboard(lblManufacturer.Text);
        }

        private void lblModel_Click(object sender, EventArgs e)
        {
            CopyToClipboard(lblModel.Text);
        }

        private void lblSerialNo_Click(object sender, EventArgs e)
        {
            CopyToClipboard(lblSerialNo.Text);
        }

        private void lblYearOfProduction_Click(object sender, EventArgs e)
        {
            CopyToClipboard(lblYearOfProduction.Text);
        }

        private void lblMonthOfProduction_Click(object sender, EventArgs e)
        {
            CopyToClipboard(lblMonthOfProduction.Text);
        }

        private void lblProductCodeID_Click(object sender, EventArgs e)
        {
            CopyToClipboard(lblProductCodeID.Text);
        }

        private void lblDiagonal1_Click(object sender, EventArgs e)
        {
            CopyToClipboard(lblDiagonal1.Text);
        }

        private void lblDiagonal2_Click(object sender, EventArgs e)
        {
            CopyToClipboard(lblDiagonal2.Text);
        }

        private void lblResolution_Click(object sender, EventArgs e)
        {
            CopyToClipboard(lblResolution.Text);
        }

        private void lblFrequency_Click(object sender, EventArgs e)
        {
            CopyToClipboard(lblFrequency.Text);
        }

        private void lblPPI_Click(object sender, EventArgs e)
        {
            CopyToClipboard(lblPPI.Text);
        }

        private void lblSizeMonitor_Click(object sender, EventArgs e)
        {
            CopyToClipboard(lblSizeMonitor.Text);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (monitors[0] != null)
            {
                DisplayMonitorInfo(monitors[MonitorComboBox.SelectedIndex]);
            }
        }

        private void MonitorInfoForm_Load(object sender, EventArgs e)
        {
            if (monitors[0] != null)
            {
                DisplayMonitorInfo(monitors[MonitorComboBox.SelectedIndex]);
            }
        }
    }
}
