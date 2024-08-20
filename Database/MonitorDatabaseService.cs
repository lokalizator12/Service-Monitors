using changeResolution1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceMonitorEVK.Database
{
    public class MonitorDatabaseService
    {
        private DatabaseManager databaseManager;

        public MonitorDatabaseService()
        {
            databaseManager = new DatabaseManager("localhost", "postgres", "moodle", "test_asset");
        }

        public async Task SendMonitorInfoAsync(MonitorInfo monitorInfo, Dictionary<string, int> cables)
        {
            monitorInfo.UpdateCableTypes(cables);
            await databaseManager.InsertMonitorInfoPostgres(monitorInfo);
        }

        public Dictionary<string, string> SearchInfoFromAsset(string searchValue, string searchBy = "IdEvk")
        {
            string whereClause = searchBy == "NumerSeryjny" ? "NumerSeryjny" : "IdEvk";

            string query =
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

            return databaseManager.ExecuteQueryFindProductAndGet(query);
        }
    }
}
