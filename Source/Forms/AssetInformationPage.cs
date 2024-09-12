using MaterialSkin.Controls;
using ServiceMonitorEVK.Source.Database;
using ServiceMonitorEVK.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ServiceMonitorEVK.Source.Forms
{
    public partial class AssetInformationPage : MaterialForm
    {

        private DatabaseManager databaseManager;
        public AssetInformationPage()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            UiUtil uiUtil = new UiUtil(this);
            uiUtil.InitializeTheme();
        }



        internal void SearchInfoFromAsset(string searchValue, string searchBy = "IdEvk")
        {
            var whereClause = searchBy == "NumerSeryjny" ? "NumerSeryjny" : "IdEvk";

            var query =
                "SELECT aa.Marka, " +
                "aa.Model, " +
                "aa.NumerSeryjny, " +
                "aa.KlasaEvk, " +
                "aa.MiejsceMagazynowe, " +
                "CONCAT(p1.Imie, ' ', p1.Nazwisko) AS TestowaniePracownik, " +
                "aa.TestowanieData, " +
                "CONCAT(p2.Imie, ' ', p2.Nazwisko) AS CzyszczeniePracownik, " +
                "aa.CzyszczenieData, " +
                "m.TypWyswietlacz AS Type, " +
                "m.WielkoscMonitor AS Diagonal, " +
                "c.CountryName AS Country, " +
                "CASE WHEN aa.CzyTestowany = 1 THEN 'Yes' ELSE 'No' END AS CzyTestowany, " +
                "CASE WHEN aa.CzyCzyszczony = 1 THEN 'Yes' ELSE 'No' END AS CzyCzyszczony, " +
                "aa.IdEvk, " +
                "aa.Zdjecia " +
                "FROM admin_asset.sprzet AS aa " +
                "LEFT JOIN admin_asset.pracownik AS p1 ON aa.EtapTestowanie = p1.IdPracownik " +
                "LEFT JOIN admin_asset.pracownik AS p2 ON aa.EtapCzyszczenie = p2.IdPracownik " +
                "LEFT JOIN admin_asset.monitor AS m ON aa.IdSprzet = m.IdSprzet " +
                "LEFT JOIN admin_asset.slownikcountry AS c ON aa.IdCountry = c.IdCountry " +
            $"WHERE aa.{whereClause} = '{searchValue}'";


            var parameters = databaseManager.ExecuteQueryFindProductAndGet(query);

            if (parameters == null || parameters.Count == 0)
                new MaterialSnackBar($"No data found in the database for the provided {searchBy}: {searchValue}").Show(this);
            else
                FillParametersToLabels(parameters);
        }


        private void FillParametersToLabels(Dictionary<string, string> parameters)
        {
            foreach (var kvp in parameters)
                switch (kvp.Key)
                {
                    case "Manufacturer":
                        materialLabelManufacturer.Text = kvp.Value;
                        break;
                    case "Model":
                        labelEvkModel.Text = kvp.Value;
                        break;
                    case "SerialNumber":
                        textBoxSerial.Text = kvp.Value;
                        break;
                    case "IdEvk":
                        textBoxIdEVK.Text = kvp.Value;
                        break;
                    case "Class":
                        labelAssetClass.Text = kvp.Value;
                        break;
                    case "TestowaniePracownik":
                        labelAssetTester.Text = kvp.Value;
                        break;
                    case "TestowanieData":
                        labelAssetDateTesting.Text = kvp.Value;
                        break;
                    case "CzyszczeniePracownik":
                        labelAssetCleaner.Text = kvp.Value;
                        break;
                    case "CzyszczenieData":
                        labelAssetDateCleaning.Text = kvp.Value;
                        break;
                    case "MiejsceMagazynowe":
                        labelAssetPlace.Text = kvp.Value;
                        break;
                    case "Zdjecia":
                        labelAssetIsPictured.Text = CheckImageUrls(kvp.Value);
                        break;
                    case "Type":
                        labelAssetType.Text = kvp.Value;
                        break;
                    case "Diagonal":
                        labelAssetDiagonalDB.Text = kvp.Value;
                        break;
                    case "Country":
                        labelAssetCountry.Text = kvp.Value;
                        break;
                }
            this.ShowDialog();
        }
        private static string CheckImageUrls(string imageUrls)
        {
            var urls = imageUrls.Split(' ');
            var y = urls.Select(t => t.Trim()).Count(url => !string.IsNullOrEmpty(url));

            return $"Images available: {y}";
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
