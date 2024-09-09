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
                nameof(Model),
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
                nameof(Country),
                nameof(CableTypes),
                nameof(Brightness),
                nameof(ResponseTime),
                nameof(ViewingAngles),
                nameof(Weight),
                nameof(AspectRatio),
                nameof(PanelType),
                nameof(Dimensions)
            };
            Manufacturer = "Manufacturer";
            Model = "Model";
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
            Country = "";
            CableTypes = "";
        }

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string YearOfProduction { get; set; }
        public string MonthOfProduction { get; set; }
        public string ProductCodeId { get; set; }
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
        public string Country { get; set; }
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

        public void UpdateCableTypes(Dictionary<string, int> cables)
        {
            CableTypes = string.Join(", ", cables
                .Where(kvp => kvp.Value > 0)
                .Select(kvp => kvp.Value > 1 ? $"{kvp.Key} x{kvp.Value}" : kvp.Key));
        }

        public void UpdateResolutionAndFrequency(int width, int height, int frequency)
        {
            Resolution = $"{width} x {height}";
            Frequency = frequency;
        }

        /*public void UpdateFromApiResponse(string apiResponse)
        {
            var fields = apiResponse.Split(',').Select(f => f.Trim()).ToArray();

            if (fields.Length >= 13)
            {
                PanelType = fields[0];
                Diagonal1 = double.Parse(fields[1]);
                UpdateCableTypes(fields[2].Split(';').ToDictionary(c => c.Trim(), c => 1)); 
                Resolution = fields[3];
                AspectRatio = fields[4];
                Brightness = fields[5];
                ResponseTime = fields[6];
                ViewingAngles = fields[7];
                Frequency = int.Parse(fields[8].Replace("Hz", "").Trim());
                Weight = fields[9];
                Dimensions = fields[10];
            }
        }*/


        public override string ToString()
        {
            return $"Manufacturer: {Manufacturer}, Model: {Model}, SerialNumber: {SerialNumber}, " +
                   $"YearOfProduction: {YearOfProduction}, MonthOfProduction: {MonthOfProduction}, " +
                   $"ProductCodeID: {ProductCodeId}, Diagonal1: {Diagonal1}, Diagonal2: {Diagonal2}, " +
                   $"Resolution: {Resolution}, Frequency: {Frequency}, PPI: {PPI}, " +
                   $"SizeMonitor: {SizeMonitor}, MaxVerticalSize: {MaxVerticalSize}, " +
                   $"MaxHorizontalSize: {MaxHorizontalSize}, Identifier: {Identifier}, " +
                   $"FriendlyName: {FriendlyName}, Country: {Country}, " +
                   $"CableTypes: {CableTypes}, Brightness: {Brightness}, ResponseTime: {ResponseTime}, " +
                   $"ViewingAngles: {ViewingAngles}, Weight: {Weight}, Dimensions: {Dimensions}";
        }
    }
}
