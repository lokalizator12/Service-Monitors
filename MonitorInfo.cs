using System;
using System.Collections.Generic;

namespace changeResolution1
{


    public class MonitorInfo
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string YearOfProduction { get; set; }
        public string MonthOfProduction { get; set; }
        public string ProductCodeID { get; set; }
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

        public List<string> ParametersMonitorList { get; private set; }


        public void UpdateSize(double maxHorizontalSize, double maxVerticalSize)
        {
            MaxHorizontalSize = maxHorizontalSize;
            MaxVerticalSize = maxVerticalSize;
            SizeMonitor = $"{maxHorizontalSize} x {maxVerticalSize}";
            Diagonal1 = Math.Sqrt(Math.Pow(maxVerticalSize, 2) + Math.Pow(maxHorizontalSize, 2)) / 2.54;
        }

        public void UpdateResolutionAndFrequency(int width, int height, int frequency)
        {
            Resolution = $"{width} x {height}";
            Frequency = frequency;
        }

        public override string ToString()
        {
            return $"Manufacturer: {Manufacturer}, Model: {Model}, SerialNumber: {SerialNumber}, " +
                   $"YearOfProduction: {YearOfProduction}, MonthOfProduction: {MonthOfProduction}, " +
                   $"ProductCodeID: {ProductCodeID}, Diagonal1: {Diagonal1}, Diagonal2: {Diagonal2}, " +
                   $"Resolution: {Resolution}, Frequency: {Frequency}, PPI: {PPI}, " +
                   $"SizeMonitor: {SizeMonitor}, MaxVerticalSize: {MaxVerticalSize}, " +
                   $"MaxHorizontalSize: {MaxHorizontalSize}, Identifier: {Identifier}, " +
                   $"FriendlyName: {FriendlyName}, " +
                   $"ID EVK: {IdEVK},Tester Initials: {TesterInitials}";
        }

        public MonitorInfo()
        {
            ParametersMonitorList = new List<string>
        {
            nameof(Manufacturer),
            nameof(Model),
            nameof(SerialNumber),
            nameof(YearOfProduction),
            nameof(MonthOfProduction),
            nameof(ProductCodeID),
            nameof(Diagonal1),
            nameof(Resolution),
            nameof(Frequency),
            nameof(PPI),
            nameof(SizeMonitor),
            nameof(IdEVK),
            nameof(TesterInitials)
        };
            Manufacturer = "Manufacturer";
            Model = "Model";
            SerialNumber = "SerialNumber";
            YearOfProduction = "Year Of Production";
            MonthOfProduction = "Month Of Production";
            ProductCodeID = "ProductCodeID";
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
        }

    }
}
