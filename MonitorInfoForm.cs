using MaterialSkin.Controls;
using Microsoft.Win32;
using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace changeResolution1
{
    public partial class MonitorInfoForm : MaterialForm
    {
        private Dictionary<string, MonitorInfo> modelToMonitorInfoMap;

        private Dictionary<string, string> monitorNameToIdentifierMap;
        private MonitorInfoManager monitorInfoManager;
        private ResolutionDisplayManager resolutionManager;
        private Form1 _form1;
        public MonitorInfo[] monitors { get; set; }


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

        Dictionary<string, string> manufacturerDictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                            {
                                { "ACER", "Acer" },
                                {"ACR", "Acer" },
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
        public MonitorInfoForm(Form1 form1)
        {
            _form1 = form1;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM WmiMonitorID");
            monitors = new MonitorInfo[searcher.Get().Count];
            InitializeComponent();
            monitorInfoManager = new MonitorInfoManager();
            resolutionManager = new ResolutionDisplayManager();
            // FillMonitorComboBox();
            //GetMonitorInfos();
            _ = InitializeAsync();
            SystemEvents.DisplaySettingsChanged += SystemEvents_DisplaySettingsChanged;
        }
        private async Task InitializeAsync()
        {
            await FillMonitorComboBoxAsync();
            await GetMonitorInfosAsync();
        }
        private async Task FillMonitorComboBoxAsync()
        {
            _form1.isUpdatingComboBox = true;
            _form1.materialComboBoxMonitors.Items.Clear();
           
            modelToMonitorInfoMap = new Dictionary<string, MonitorInfo>();

            var friendlyNames = monitorInfoManager.GetFriendlyMonitorNames();
            monitors = await GetMonitorInfosAsync();

            for (int i = 0; i < monitors.Length; i++)
            {
                var monitor = monitors[i];
                var modelName = string.IsNullOrWhiteSpace(monitor.Model) ? "Integrated Monitor" : monitor.Model;
                modelToMonitorInfoMap[modelName] = monitor;
                _form1.materialComboBoxMonitors.Items.Add(modelName);
            }

            if (_form1.materialComboBoxMonitors.Items.Count > 0)
            {
                _form1.materialComboBoxMonitors.SelectedIndex = 0;
            }
            _form1.isUpdatingComboBox = false;
        }

        public async Task<MonitorInfo[]> GetMonitorInfosAsync()
        {
            monitors = await GetMonitorInfos1Async();
            monitors = await SetMonitorSizesAsync(monitors);
            return monitors;
        }


        private async Task<MonitorInfo[]> GetMonitorInfos1Async()
        {
            var monitorInfoList = new List<MonitorInfo>();

            await Task.Run(() =>
            {
                var searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM WmiMonitorID");
                var queryObjects = searcher.Get().Cast<ManagementObject>();

                Parallel.ForEach(queryObjects, queryObj =>
                {
                    string manufacturerNameFull = DecodeMonitorString((ushort[])queryObj["ManufacturerName"]);
                    string manufacturer = manufacturerDictionary.FirstOrDefault(entry => manufacturerNameFull.IndexOf(entry.Key, StringComparison.OrdinalIgnoreCase) >= 0).Value;

                    var monitorInfo = new MonitorInfo
                    {
                        YearOfProduction = queryObj["YearOfManufacture"].ToString(),
                        MonthOfProduction = ConvertWeeksToMonths(Convert.ToInt16(queryObj["WeekOfManufacture"].ToString())),
                        ProductCodeID = ((ushort[])queryObj["ProductCodeID"]).Aggregate("", (current, p) => current + p.ToString("X")),
                        Manufacturer = manufacturer,
                        Model = DecodeMonitorString((ushort[])queryObj["UserFriendlyName"]),
                        SerialNumber = queryObj["SerialNumberID"] != null ? DecodeMonitorString((ushort[])queryObj["SerialNumberID"]) : "N/A"
                    };

                    lock (monitorInfoList)
                    {
                        monitorInfoList.Add(monitorInfo);
                    }
                });
            });

            return monitorInfoList.ToArray();
        }

        private async Task<MonitorInfo[]> SetMonitorSizesAsync(MonitorInfo[] monitors)
        {
            await Task.Run(() =>
            {
                var searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM WmiMonitorBasicDisplayParams");
                var queryObjects = searcher.Get().Cast<ManagementObject>().ToArray();

                Parallel.For(0, queryObjects.Length, i =>
                {
                    var queryObj = queryObjects[i];
                    double maxHorizontalSizeCm = Convert.ToDouble(queryObj["MaxHorizontalImageSize"]);
                    double maxVerticalSizeCm = Convert.ToDouble(queryObj["MaxVerticalImageSize"]);
                    monitors[i].UpdateSize(maxHorizontalSizeCm, maxVerticalSizeCm);
                });

                DISPLAY_DEVICE d = new DISPLAY_DEVICE();
                d.cb = Marshal.SizeOf(d);

                int deviceIndex = 0;
                while (EnumDisplayDevices(null, (uint)deviceIndex, ref d, 0))
                {
                    DEVMODE devMode = new DEVMODE();
                    devMode.dmSize = (ushort)Marshal.SizeOf(typeof(DEVMODE));

                    if (EnumDisplaySettings(d.DeviceName, -1, ref devMode))
                    {
                        int resolutionWidth = (int)devMode.dmPelsWidth;
                        int resolutionHeight = (int)devMode.dmPelsHeight;
                        int displayFrequency = (int)devMode.dmDisplayFrequency;

                        if (monitors.Length > deviceIndex)
                        {
                            monitors[deviceIndex].UpdateResolutionAndFrequency(resolutionWidth, resolutionHeight, displayFrequency);
                            monitors[deviceIndex].PPI = CalculatePPI(monitors[deviceIndex].MaxVerticalSize, monitors[deviceIndex].MaxHorizontalSize, resolutionWidth, resolutionHeight).ToString();
                            monitors[deviceIndex].Diagonal2 = GetDiagonalFromResoluton(monitors[deviceIndex].MaxVerticalSize, monitors[deviceIndex].MaxHorizontalSize, resolutionWidth, resolutionHeight).ToString();
                        }
                    }

                    deviceIndex++;
                    d.cb = Marshal.SizeOf(d);
                }
            });

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
                    monitors[i].UpdateSize(maxHorizontalSizeCm, maxVerticalSizeCm);
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
                        if (monitors.Length > deviceIndex)
                        {
                            monitors[deviceIndex].UpdateResolutionAndFrequency(resolutionWidth, resolutionHeight, displayFrequency);

                            monitors[deviceIndex].PPI = CalculatePPI(monitors[deviceIndex].MaxVerticalSize, monitors[deviceIndex].MaxHorizontalSize, resolutionWidth, resolutionHeight).ToString();

                            monitors[deviceIndex].Diagonal2 = GetDiagonalFromResoluton(monitors[deviceIndex].MaxVerticalSize, monitors[deviceIndex].MaxHorizontalSize, resolutionWidth, resolutionHeight).ToString();
                        }
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
           /* _form1.materialLabelManufacturer.Text = monitorInfo.Manufacturer;
            _form1.materialLabelModel.Text = monitorInfo.Model;
            _form1.materialLabelSerialNo.Text = monitorInfo.SerialNumber;
            _form1.materialLabelYearOfProduction.Text = monitorInfo.YearOfProduction;
            _form1.materialLabelMonthOfProduction.Text = monitorInfo.MonthOfProduction;
            _form1.materialLabelProductCodeID.Text = monitorInfo.ProductCodeID;
            _form1.materialLabelDiagonal1.Text = monitorInfo.Diagonal1.ToString();
            _form1.materialLabelDiagonal2.Text = monitorInfo.Diagonal2;
            _form1.materialLabelResolution.Text = monitorInfo.Resolution;
            _form1.materialLabelFrequency.Text = monitorInfo.Frequency.ToString();
            _form1.materialLabelPPI.Text = monitorInfo.PPI;
            _form1.materialLabelSizeMonitor.Text = monitorInfo.SizeMonitor;*/
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


        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (monitors[0] != null)
            {
                DisplayMonitorInfo(monitors[_form1.materialComboBoxMonitors.SelectedIndex]);
            }
        }

        private void MonitorInfoForm_Load(object sender, EventArgs e)
        {
            if (monitors[0] != null)
            {
                DisplayMonitorInfo(monitors[_form1.materialComboBoxMonitors.SelectedIndex]);
            }
        }
        private async void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            await RefreshMonitorInfoAsync();
        }

        private async Task RefreshMonitorInfoAsync()
        {
            await FillMonitorComboBoxAsync();
            await GetMonitorInfosAsync();
            if (_form1.materialComboBoxMonitors.Items.Count > 0)
            {
                _form1.materialComboBoxMonitors.SelectedIndex = 0;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
