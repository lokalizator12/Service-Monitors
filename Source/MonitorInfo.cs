using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceMonitorEVK.Source
{
    public class MonitorInfo
    {
        public MonitorInfo()
        {
            ParametersMonitorList = new List<string>
            {
                nameof(Manufacturer),
                nameof(SystemModel),
                nameof(SerialNumber),
                nameof(YearOfProduction),
                nameof(MonthOfProduction),
                nameof(ProductCodeId),
                nameof(Diagonal1),
                nameof(Resolution),
                nameof(Frequency),
                nameof(PPI),
                nameof(SizeMonitor),
                nameof(IdEVK),
                nameof(TesterInitials),
                nameof(IdCountry),
                nameof(CableTypes),
                nameof(Brightness),
                nameof(ResponseTime),
                nameof(ViewingAngles),
                nameof(Weight),
                nameof(AspectRatio),
                nameof(PanelType),
                nameof(Dimensions),
                nameof(IdSpecMonitor)
            };

            Manufacturer = "Manufacturer";
            SystemModel = "SystemModel";
            SerialNumber = "SerialNumber";
            YearOfProduction = "Year Of Production";
            MonthOfProduction = "Month Of Production";
            ProductCodeId = "ProductCodeID";
            Diagonal1 = 0.0d;
            Diagonal2 = "Diagonal2";
            Resolution = "Resolution";
            Frequency = 0;
            PPI = "PPI";
            SizeMonitor = MaxHorizontalSize + "x" + MaxVerticalSize;
            MaxHorizontalSize = 0;
            MaxVerticalSize = 0;
            FriendlyName = "Name";
            Identifier = "DISPLAY";
            IdEVK = "";
            TesterInitials = "";
            IdCountry = 0;
            CableTypes = "";
            IdSpecMonitor = 0;
        }
        public string Manufacturer { get; set; }
        public string SystemModel { get; set; }
        public int IdSpecMonitor { get; set; }
        public string SerialNumber { get; set; }
        public string YearOfProduction { get; set; }
        public string MonthOfProduction { get; set; }
        public string ProductCodeId { get; set; }
        public string EvkModel { get; set; }
        public double Diagonal1 { get; set; }
        public string Diagonal2 { get; set; }
        public string Resolution { get; set; }
        public int Frequency { get; set; }
        public string PPI { get; set; }
        public string SizeMonitor { get; set; }
        public double MaxVerticalSize { get; set; }
        public double MaxHorizontalSize { get; set; }
        public string Identifier { get; set; }
        public string FriendlyName { get; set; }
        public string IdEVK { get; set; }
        public string TesterInitials { get; set; }
        public int IdCountry { get; set; }
        public string CableTypes { get; set; }
        public string Brightness { get; set; }
        public string ResponseTime { get; set; }
        public string ViewingAngles { get; set; }
        public string Weight { get; set; }
        public string Dimensions { get; set; }

        public string AspectRatio { get; set; }

        public string PanelType { get; set; }
        public List<string> ParametersMonitorList { get; private set; }


        public void UpdateSize(double maxHorizontalSize, double maxVerticalSize)
        {
            MaxHorizontalSize = maxHorizontalSize;
            MaxVerticalSize = maxVerticalSize;
            SizeMonitor = $"{maxHorizontalSize} x {maxVerticalSize}";

            var diagonalInInches = Math.Sqrt(Math.Pow(maxVerticalSize, 2) + Math.Pow(maxHorizontalSize, 2)) / 2.54;

            Diagonal1 = Math.Floor(diagonalInInches * 2) / 2;
        }

        public string UpdateCableTypes(Dictionary<string, int> cables)
        {
            CableTypes = string.Join("; ", cables
                .Where(kvp => kvp.Value > 0)
                .Select(kvp => kvp.Value >= 1 ? $"{kvp.Key} x{kvp.Value}" : kvp.Key));
            return CableTypes;
        }

        public void UpdateResolutionAndFrequency(int width, int height, int frequency)
        {
            Resolution = $"{width} x {height}";
            Frequency = frequency;
        }

        public override string ToString()
        {
            return $"Manufacturer: {Manufacturer}, SystemModel: {SystemModel}, SerialNumber: {SerialNumber}, " +
                   $"YearOfProduction: {YearOfProduction}, MonthOfProduction: {MonthOfProduction}, " +
                   $"ProductCodeID: {ProductCodeId}, Diagonal1: {Diagonal1}, Diagonal2: {Diagonal2}, " +
                   $"Resolution: {Resolution}, Frequency: {Frequency}, PPI: {PPI}, " +
                   $"SizeMonitor: {SizeMonitor}, MaxVerticalSize: {MaxVerticalSize}, " +
                   $"MaxHorizontalSize: {MaxHorizontalSize}, Identifier: {Identifier}, " +
                   $"FriendlyName: {FriendlyName}, IdCountry: {IdCountry}, " +
                   $"CableTypes: {CableTypes}, Brightness: {Brightness}, ResponseTime: {ResponseTime}, " +
                   $"ViewingAngles: {ViewingAngles}, Weight: {Weight}, Dimensions: {Dimensions}, " +
                   $"IdSpecMonitor: {IdSpecMonitor}, IdEvk: {IdEVK}";
        }
    }
}
