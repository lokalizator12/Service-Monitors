using changeResolution1;
using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        internal Dictionary<string, string> ExecuteQueryFindProductAndGet(string query)
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
                       

                        string czyszczenieData = "No Data";
                        if (reader["CzyCzyszczony"].ToString().Equals("Yes"))
                        {
                            czyszczenieData = reader["CzyszczenieData"] != DBNull.Value && reader["CzyszczenieData"].ToString() != "0000-00-00 00:00:00"
                                ? reader["CzyszczenieData"].ToString()
                                : "No Data";
                        }
                        parametersStrings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                            {
                    { "Manufacturer", reader["Marka"].ToString() },
                    { "Model", reader["Model"].ToString() },
                    { "SerialNumber", reader["NumerSeryjny"].ToString() },
                    { "Class", reader["KlasaEvk"].ToString() },
                    { "TestowaniePracownik", reader["TestowaniePracownik"].ToString() },
                    { "TestowanieData", reader["TestowanieData"] != DBNull.Value && reader["TestowanieData"].ToString() != "0000-00-00 00:00:00" ? reader["TestowanieData"].ToString() : "No Data"},
                    { "CzyszczeniePracownik", reader["CzyszczeniePracownik"].ToString()},
                    { "CzyszczenieData", czyszczenieData },
                    { "CzyTestowany", reader["CzyTestowany"].ToString() },
                    { "CzyCzyszczony", reader["CzyCzyszczony"].ToString()},
                    { "MiejsceMagazynowe", reader["MiejsceMagazynowe"].ToString() },
                    { "IdEvk", reader["IdEvk"].ToString() },
                    { "Zdjecia", reader["Zdjecia"].ToString() },
                    { "Type", reader["Type"].ToString() },
                    { "Diagonal", reader["Diagonal"].ToString() },
                    { "Country", reader["Country"].ToString() }
                };
                    }
                    foreach (var kvp in parametersStrings)
                    {
                        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                    }
                }

                catch (MySqlException ex)
                {
                    Console.WriteLine("Ошибка выполнения запроса: " + ex.Message);
                }
            }
            return parametersStrings;
        }
        internal void FillCountryComboBox(ComboBox comboBox)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionStringMysql))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT CountryName FROM slownikcountry ORDER BY CountryName ASC";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader["CountryName"].ToString());
                    }

                    comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                    comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Ошибка загрузки стран: " + ex.Message);
                }
            }
        }

        public async Task InsertMonitorInfoPostgres(MonitorInfo monitorInfo)
        {
            var connection = new NpgsqlConnection(connectionStringPostgres);
            await connection.OpenAsync();

            var cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            Console.WriteLine("233");
            cmd.CommandText = @"
INSERT INTO monitors (manufacturer, model, year_of_production, month_of_production, product_code_id, diagonal_hw, diagonal_res, serial_number, frequency, size_monitor, resolution, ppi, id_evk, tester_initials, country, cable_types)
VALUES (@manufacturer, @model, @year_of_production, @month_of_production, @product_code_id, @diagonal_hw, @diagonal_res, @serial_number, @frequency, @size_monitor, @resolution, @ppi, @id_evk, @tester_initials, @country, @cable_types)";
            Console.WriteLine("234233");
            cmd.Parameters.AddWithValue("manufacturer", monitorInfo.Manufacturer);
            Console.WriteLine("234233");
            cmd.Parameters.AddWithValue("model", monitorInfo.Model);
            Console.WriteLine("234233");
            cmd.Parameters.AddWithValue("year_of_production", int.Parse(monitorInfo.YearOfProduction));
            Console.WriteLine("234233");
            cmd.Parameters.AddWithValue("month_of_production", int.Parse(monitorInfo.MonthOfProduction));
            Console.WriteLine("234233");
            cmd.Parameters.AddWithValue("product_code_id", monitorInfo.ProductCodeID);
            Console.WriteLine("234233");
            cmd.Parameters.AddWithValue("diagonal_hw", Convert.ToDecimal(monitorInfo.Diagonal1));
            Console.WriteLine("234233q");
            cmd.Parameters.AddWithValue("diagonal_res", Convert.ToDecimal(monitorInfo.Diagonal2));
            Console.WriteLine("2342331w");
            cmd.Parameters.AddWithValue("serial_number", monitorInfo.SerialNumber);
            Console.WriteLine("23423w3");
            cmd.Parameters.AddWithValue("frequency", monitorInfo.Frequency);
            Console.WriteLine("23423w253");
            cmd.Parameters.AddWithValue("size_monitor", monitorInfo.SizeMonitor);
            Console.WriteLine("23423sdfds3");
            cmd.Parameters.AddWithValue("resolution", monitorInfo.Resolution);
            Console.WriteLine("2342331111111");
            cmd.Parameters.AddWithValue("ppi", Convert.ToDecimal(monitorInfo.PPI));
            Console.WriteLine("23423gdfg3");
            cmd.Parameters.AddWithValue("country", monitorInfo.Country);
            Console.WriteLine("234233eeeeeee");
            cmd.Parameters.AddWithValue("cable_types", monitorInfo.CableTypes);
            Console.WriteLine("23423ddddddddd3");
            cmd.Parameters.AddWithValue("tester_initials", monitorInfo.TesterInitials);
            Console.WriteLine("23423234asd3");

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
            Console.WriteLine("234233");
            await cmd.ExecuteNonQueryAsync();
        }
    }
}

