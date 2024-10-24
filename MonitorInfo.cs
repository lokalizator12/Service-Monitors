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




        public MonitorInfo()
        {
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
        }

    }
}
