using changeResolution1;
using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceMonitorEVK.Database
{
    public class DatabaseManager
    {
        private string connectionStringPostgres;
        private string connectionStringMysql;
        internal Dictionary<string, string> parametersStrings;

        public DatabaseManager(string host, string username, string password, string database)
        {
            connectionStringPostgres = $"Host={host};Username={username};Password={password};Database={database}";
            connectionStringMysql = $"server={host};port=3310;uid={username};pwd={password};database={database};";
        }


        internal Dictionary<string, string> ExecuteQuery(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionStringMysql))
            {
                try
                {
                    connection.Open();
                    //query = "SELECT * FROM admin_asset.sprzet where IdEvk = 'M027359'";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        parametersStrings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                            {
                    { "Manufacturer", reader["Marka"].ToString() },
                    { "Model", reader["Model"].ToString() },
                    { "SerialNumber", reader["NumerSeryjny"].ToString() },
                    { "Class", reader["KlasaEvk"].ToString() },
                    { "TestowaniePracownik", reader["TestowaniePracownik"].ToString() },
                    { "TestowanieData", reader["TestowanieData"].ToString() },
                    { "CzyszczeniePracownik", reader["CzyszczeniePracownik"].ToString()},
                    { "CzyszczenieData", reader["CzyszczenieData"].ToString() },
                    { "CzyTestowany", reader["CzyTestowany"].ToString() },
                    { "CzyCzyszczony", reader["CzyCzyszczony"].ToString()},
                    { "MiejsceMagazynowe", reader["MiejsceMagazynowe"].ToString() },
                    { "IdEvk", reader["IdEvk"].ToString() },
                    { "Zdjecia", reader["Zdjecia"].ToString() }
                };
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Ошибка выполнения запроса: " + ex.Message);
                }
            }
            return parametersStrings;
        }


        public async Task InsertMonitorInfoPostgres(MonitorInfo monitorInfo)
        {
            var connection = new NpgsqlConnection(connectionStringPostgres);
            await connection.OpenAsync();

            var cmd = new NpgsqlCommand();
            cmd.Connection = connection;

            cmd.CommandText = @"
            INSERT INTO monitors (manufacturer, model, year_of_production, month_of_production, product_code_id, diagonal_hw, diagonal_res, serial_number, frequency, size_monitor, resolution, ppi, id_evk, tester_initials)
            VALUES (@manufacturer, @model, @year_of_production, @month_of_production, @product_code_id, @diagonal_hw, @diagonal_res, @serial_number, @frequency, @size_monitor, @resolution, @ppi, @id_evk, @tester_initials)";

            cmd.Parameters.AddWithValue("manufacturer", monitorInfo.Manufacturer);
            cmd.Parameters.AddWithValue("model", monitorInfo.Model);
            cmd.Parameters.AddWithValue("year_of_production", int.Parse(monitorInfo.YearOfProduction));
            cmd.Parameters.AddWithValue("month_of_production", int.Parse(monitorInfo.MonthOfProduction));
            cmd.Parameters.AddWithValue("product_code_id", monitorInfo.ProductCodeID);
            cmd.Parameters.AddWithValue("diagonal_hw", Convert.ToDecimal(monitorInfo.Diagonal1));
            cmd.Parameters.AddWithValue("diagonal_res", Convert.ToDecimal(monitorInfo.Diagonal2));
            cmd.Parameters.AddWithValue("serial_number", monitorInfo.SerialNumber);
            cmd.Parameters.AddWithValue("frequency", monitorInfo.Frequency);
            cmd.Parameters.AddWithValue("size_monitor", monitorInfo.SizeMonitor);
            cmd.Parameters.AddWithValue("resolution", monitorInfo.Resolution);
            cmd.Parameters.AddWithValue("ppi", Convert.ToDecimal(monitorInfo.PPI));
            //cmd.Parameters.AddWithValue("tester_initials", monitorInfo.TesterInitials);



            if (!string.IsNullOrEmpty(monitorInfo.TesterInitials))
            {
                cmd.Parameters.AddWithValue("tester_initials", monitorInfo.TesterInitials);
            }
            else
            {
                cmd.Parameters.AddWithValue("tester_initials", DBNull.Value);
            }
            if (!string.IsNullOrEmpty(monitorInfo.IdEVK))
            {
                cmd.Parameters.AddWithValue("id_evk", monitorInfo.IdEVK);
            }
            else
            {
                cmd.Parameters.AddWithValue("id_evk", DBNull.Value);
            }

            await cmd.ExecuteNonQueryAsync();
        }
    }
}

