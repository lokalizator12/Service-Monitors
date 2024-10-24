using MaterialSkin.Controls;
using Microsoft.Win32;
using ServiceMonitorEVK.Source;
using ServiceMonitorEVK.Source.Main;
using ServiceMonitorEVK.Source.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ServiceMonitorEVK
{
    public class MonitorInfoForm
    {
        private readonly Form1 _form1;
        private readonly OpenAIService _openAiService;

        private readonly Dictionary<string, string> manufacturerDictionary =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "ACER", "Acer" },
                { "ACR", "Acer" },
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
                { "DEL", "Dell" },
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




        public MonitorInfoForm(Form1 form1)
        {
            _openAiService = new OpenAIService();
            _form1 = form1;
            var searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM WmiMonitorID");
            Monitors = new MonitorInfo[searcher.Get().Count];

            _ = InitializeAsync();
            SystemEvents.DisplaySettingsChanged += SystemEvents_DisplaySettingsChanged;
        }
        private async Task<MonitorInfo[]> IntegrateAndUpdateMonitorInfoAsync(MonitorInfo[] monitors)
        {
            try
            {
                foreach (var monitorInfo in monitors)
                {
                    // Получение данных от OpenAI
                    string monitorQuery = $"{monitorInfo.Manufacturer} {monitorInfo.SystemModel}";
                    string openAiResponse = await _openAiService.GetResponseAsync(monitorQuery, isInfoMonitors: true);

                    if (!string.IsNullOrEmpty(openAiResponse))
                    {
                        var fields = openAiResponse.Split(',').Select(f => f.Trim()).ToArray();

                        if (fields.Length >= 10)
                        {
                            // Приоритет данным от OpenAI
                            monitorInfo.PanelType = fields[0];
                            monitorInfo.Diagonal1 = double.Parse(fields[1]);
                            monitorInfo.UpdateCableTypes(fields[2].Split(';').ToDictionary(c => c.Trim(), c => 1));
                            monitorInfo.Resolution = fields[3];
                            monitorInfo.AspectRatio = fields[4];
                            monitorInfo.Brightness = fields[5];
                            monitorInfo.ResponseTime = fields[6];
                            monitorInfo.ViewingAngles = fields[7];
                            monitorInfo.Frequency = int.Parse(fields[8].Replace("Hz", "").Trim());
                            monitorInfo.Weight = fields[9];
                            monitorInfo.Dimensions = fields[10];
                        }
                    }

                }
                // DisplayMonitorInfo(monitorInfo); // Обновление интерфейса

            }
            catch (Exception ex)
            {
                new MaterialSnackBar($"Error integrating OpenAI data: {ex.Message}");
            }
            return monitors;
        }
        public MonitorInfo[] Monitors { get; set; }

        [DllImport("user32.dll")]
        public static extern bool EnumDisplayDevices(string lpDevice, uint iDevNum, ref DISPLAY_DEVICE lpDisplayDevice,
            uint dwFlags);

        [DllImport("user32.dll")]
        private static extern bool EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref DEVMODE lpDevMode);

        private async Task InitializeAsync()
        {
            await FillMonitorComboBoxAsync();
            await GetMonitorInfosAsync();
        }

        private async Task FillMonitorComboBoxAsync()
        {
            _form1.IsUpdatingComboBox = true;
            _form1.materialComboBoxMonitors.Items.Clear();

            Monitors = await GetMonitorInfosAsync();

            foreach (var monitor in Monitors)
            {
                if (string.IsNullOrWhiteSpace(monitor.SystemModel))
                {
                    continue;
                }

                _form1.materialComboBoxMonitors.Items.Add(monitor.SystemModel);
                Console.WriteLine("add" + monitor.SystemModel);
            }

            if (_form1.materialComboBoxMonitors.Items.Count > 0) _form1.materialComboBoxMonitors.SelectedIndex = 0;
            _form1.IsUpdatingComboBox = false;
        }

        public async Task<MonitorInfo[]> GetMonitorInfosAsync()
        {
            Monitors = await GetMonitorInfos1Async();
            foreach (var VARIABLE in Monitors)
            {

                Console.WriteLine("show" + VARIABLE);
            }
           // Monitors = await SetMonitorSizesAsync(Monitors);

            foreach (var VARIABLE in Monitors)
            {

                Console.WriteLine("show1" + VARIABLE);
            }
            return Monitors;
        }


        private async Task<MonitorInfo[]> GetMonitorInfos1Async()
        {
            var searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM WmiMonitorID");
            var queryObjects = searcher.Get().Cast<ManagementObject>().ToArray();
            var monitorInfoList = new MonitorInfo[queryObjects.Count()]; // Инициализируем массив с фиксированным размером

            await Task.Run(() =>
            {


                Parallel.ForEach(queryObjects, (queryObj, state, index) =>
                {
                    var manufacturerNameFull = DecodeMonitorString((ushort[])queryObj["ManufacturerName"]);
                    var manufacturer = manufacturerDictionary.FirstOrDefault(entry =>
                        manufacturerNameFull.IndexOf(entry.Key, StringComparison.OrdinalIgnoreCase) >= 0).Value;
                    var userFriendlyName = DecodeMonitorString((ushort[])queryObj["UserFriendlyName"]);

                    if (string.IsNullOrWhiteSpace(userFriendlyName) || userFriendlyName.Length == 0)
                    {
                        return; // Пропускаем интегрированный монитор
                    }
                    var monitorInfo = new MonitorInfo
                    {
                        YearOfProduction = queryObj["YearOfManufacture"].ToString(),
                        MonthOfProduction = ConvertWeeksToMonths(Convert.ToInt16(queryObj["WeekOfManufacture"].ToString())),
                        ProductCodeId = ((ushort[])queryObj["ProductCodeID"]).Aggregate("", (current, p) => current + p.ToString("X")),
                        Manufacturer = manufacturer,
                        SystemModel = userFriendlyName,
                        SerialNumber = queryObj["SerialNumberID"] != null ? DecodeMonitorString((ushort[])queryObj["SerialNumberID"]) : "N/A"
                    };

                    monitorInfoList[index] = monitorInfo; // Сохраняем объект по индексу, чтобы сохранить порядок
                });
            });

            return monitorInfoList.Where(info => info != null).ToArray();
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
                    var maxHorizontalSizeCm = Convert.ToDouble(queryObj["MaxHorizontalImageSize"]);
                    var maxVerticalSizeCm = Convert.ToDouble(queryObj["MaxVerticalImageSize"]);
                    monitors[i].UpdateSize(maxHorizontalSizeCm, maxVerticalSizeCm);
                });

                var d = new DISPLAY_DEVICE();
                d.cb = Marshal.SizeOf(d);

                var deviceIndex = 0;
                while (EnumDisplayDevices(null, (uint)deviceIndex, ref d, 0))
                {
                    var devMode = new DEVMODE();
                    devMode.dmSize = (ushort)Marshal.SizeOf(typeof(DEVMODE));

                    if (EnumDisplaySettings(d.DeviceName, -1, ref devMode))
                    {
                        var resolutionWidth = (int)devMode.dmPelsWidth;
                        var resolutionHeight = (int)devMode.dmPelsHeight;
                        var displayFrequency = (int)devMode.dmDisplayFrequency;

                        if (monitors.Length > deviceIndex)
                        {
                            monitors[deviceIndex]
                                .UpdateResolutionAndFrequency(resolutionWidth, resolutionHeight, displayFrequency);
                            monitors[deviceIndex].PPI = CalculatePpi(monitors[deviceIndex].MaxVerticalSize,
                                monitors[deviceIndex].MaxHorizontalSize, resolutionWidth, resolutionHeight).ToString();
                            monitors[deviceIndex].Diagonal2 =
                                GetDiagonalFromResoluton(monitors[deviceIndex].MaxVerticalSize,
                                        monitors[deviceIndex].MaxHorizontalSize, resolutionWidth, resolutionHeight)
                                    .ToString();
                        }
                    }

                    deviceIndex++;
                    d.cb = Marshal.SizeOf(d);
                }
            });

            return monitors;
        }

        private static double GetDiagonalFromSize(double mV, double mH)
        {
            var diagonalSizeCm = Math.Sqrt(Math.Pow(mH, 2) + Math.Pow(mV, 2));
            return diagonalSizeCm / 2.54;
        }


        private static double GetDiagonalFromResoluton(double mV, double mH, double mRv, double mRh)
        {
            var horizontalDpi = mRv / (mH / 2.54);
            var verticalDpi = mRh / (mV / 2.54);
            var averageDpi = (horizontalDpi + verticalDpi) / 2;
            var diagonalPixels = Math.Sqrt(Math.Pow(mRv, 2) + Math.Pow(mRh, 2));
            return Math.Floor(diagonalPixels / averageDpi * 2) / 2;
        }

        public double CalculatePpi(double widthCm, double heightCm, int widthPx, int heightPx)
        {
            var diagonalInches = GetDiagonalFromSize(widthCm, heightCm);
            var diagonalPx = Math.Sqrt(Math.Pow(widthPx, 2) + Math.Pow(heightPx, 2));
            return diagonalPx / diagonalInches;
        }
        /* public MonitorInfo[] SetMonitorSizes(MonitorInfo[] monitors)
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
         }*/

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

        private static string ConvertWeeksToMonths(int weeks)
        {
            const double weeksInMonth = 4.345;
            var result = (int)Math.Round(weeks / weeksInMonth);
            return result.ToString();
        }

        private void DisplayMonitorInfo(MonitorInfo monitorInfo)
        {
            /* _form1.materialLabelManufacturer.Text = monitorInfo.Manufacturer;
             _form1.materialLabelModel.Text = monitorInfo.SystemModel;
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



        private async void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            await RefreshMonitorInfoAsync();
        }

        private async Task RefreshMonitorInfoAsync()
        {
            await FillMonitorComboBoxAsync();
            await GetMonitorInfosAsync();
            if (_form1.materialComboBoxMonitors.Items.Count > 0) _form1.materialComboBoxMonitors.SelectedIndex = 0;
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