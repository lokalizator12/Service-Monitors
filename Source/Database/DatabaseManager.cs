using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceMonitorEVK.Source.Database
{
    public class DatabaseManager
    {
        private readonly string connectionStringMysql = $"server=localhost;port=3310;uid=root;pwd=moodle;database=admin_asset;";
        internal Dictionary<string, string> ParametersStrings;

        public async Task<bool> MonitorExistsInDatabase(string manufacturer, string systemModel, string evkModel)
        {
            using (var connection = new MySqlConnection(connectionStringMysql))
            {
                await connection.OpenAsync();
                var query = "SELECT COUNT(*) FROM monitor_specs WHERE LOWER(manufacturer) = LOWER(@manufacturer) AND (LOWER(system_model) = LOWER(@systemModel) OR LOWER(evk_model) = LOWER(@evkModel))";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@manufacturer", manufacturer);
                command.Parameters.AddWithValue("@systemModel", systemModel);
                command.Parameters.AddWithValue("@evkModel", evkModel);
                Console.WriteLine(command.CommandText);
                var count = Convert.ToInt32(await command.ExecuteScalarAsync());
                return count > 0;
            }
        }

        public async Task InsertOrUpdateMonitorSpecs(MonitorInfo monitorInfo)
        {
            using (var connection = new MySqlConnection(connectionStringMysql))
            {
                await connection.OpenAsync();

                // SQL-запрос для вставки или обновления записи с 14 полями
                const string query = """
                             INSERT INTO monitor_specs 
                             (manufacturer, system_model, evk_model, diagonal, resolution, frequency, brightness, response_time, viewing_angles, weight, dimensions, panel_type, aspect_ratio, cable_types)
                             VALUES (@manufacturer, @system_model, @evk_model, @diagonal, @resolution, @frequency, @brightness, @response_time, @viewing_angles, @weight, @dimensions, @panel_type, @aspect_ratio, @cable_types)
                             ON DUPLICATE KEY UPDATE 
                             evk_model = @evk_model, diagonal = @diagonal, resolution = @resolution, frequency = @frequency, brightness = @brightness, response_time = @response_time, viewing_angles = @viewing_angles, weight = @weight, 
                             dimensions = @dimensions, panel_type = @panel_type, aspect_ratio = @aspect_ratio, cable_types = @cable_types
                             """;

                var command = new MySqlCommand(query, connection);

                // Привязываем параметры к запросу
                command.Parameters.AddWithValue("@manufacturer", monitorInfo.Manufacturer);
                command.Parameters.AddWithValue("@system_model", monitorInfo.SystemModel);
                command.Parameters.AddWithValue("@evk_model", monitorInfo.EvkModel);  // Обработка null значений для evk_model
                command.Parameters.AddWithValue("@diagonal", monitorInfo.Diagonal1);
                command.Parameters.AddWithValue("@resolution", monitorInfo.Resolution);
                command.Parameters.AddWithValue("@frequency", monitorInfo.Frequency);
                command.Parameters.AddWithValue("@brightness", monitorInfo.Brightness);  // Обработка null значений для brightness
                command.Parameters.AddWithValue("@response_time", monitorInfo.ResponseTime);
                command.Parameters.AddWithValue("@viewing_angles", monitorInfo.ViewingAngles);
                command.Parameters.AddWithValue("@weight", monitorInfo.Weight);
                command.Parameters.AddWithValue("@dimensions", monitorInfo.Dimensions);
                command.Parameters.AddWithValue("@panel_type", monitorInfo.PanelType);
                command.Parameters.AddWithValue("@aspect_ratio", monitorInfo.AspectRatio);
                command.Parameters.AddWithValue("@cable_types", monitorInfo.CableTypes);
                Console.WriteLine(query);
                await command.ExecuteScalarAsync();
            }
        }




        public async Task<bool> MonitorExistsInDatabase(string manufacturer, string model)
        {
            using (var connection = new MySqlConnection(connectionStringMysql))
            {
                await connection.OpenAsync();
                var query = "SELECT COUNT(*) FROM monitor_specs WHERE LOWER(manufacturer) = LOWER(@manufacturer) AND LOWER(system_model) = LOWER(@model)";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@manufacturer", manufacturer);
                command.Parameters.AddWithValue("@model", model);

                var count = Convert.ToInt32(await command.ExecuteScalarAsync());
                return count > 0;
            }
        }
        public async Task InsertOrUpdateSprzetAsync(MonitorInfo monitorInfo, bool withSerial)
        {
            using (var connection = new MySqlConnection(connectionStringMysql))
            {
                await connection.OpenAsync();
                string query = "";
                if (withSerial)
                {
                    query = """
                            
                                        UPDATE admin_asset.sprzet
                            SET idCountry = @idCountry, 
                                IdSpecs = @idSpecs, 
                                NumerSeryjnyBIOS = @serialNumber, 
                                Inicjaly = @testerInitials
                            WHERE NumerSeryjny = @serialNumber;

                            """;
                }
                else
                {
                    query = """


                            UPDATE admin_asset.sprzet
                            SET idCountry = @idCountry, 
                                IdSpecs = @idSpecs, 
                                NumerSeryjnyBIOS = @serialNumber, 
                                Inicjaly = @testerInitials
                            WHERE IdEvk = @idEvk;
                                                                 
                            """;

                }

                var command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@idCountry", monitorInfo.IdCountry);
                command.Parameters.AddWithValue("@idSpecs", monitorInfo.IdSpecMonitor);
                command.Parameters.AddWithValue("@serialNumber", monitorInfo.SerialNumber);
                command.Parameters.AddWithValue("@testerInitials", monitorInfo.TesterInitials);
                command.Parameters.AddWithValue("@idEvk", monitorInfo.IdEVK);
                string fullQuery = query
                    .Replace("@idCountry", monitorInfo.IdCountry.ToString())
                    .Replace("@idSpecs", monitorInfo.IdSpecMonitor.ToString())
                    .Replace("@serialNumber", $"'{monitorInfo.SerialNumber}'")
                    .Replace("@testerInitials", $"'{monitorInfo.TesterInitials}'")
                    .Replace("@idEvk", $"'{monitorInfo.IdEVK}'");

                // Логирование строки с данными
                Console.WriteLine("SQL Query: " + fullQuery);
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task<bool> CheckSerialNumberExists(string serialNumber)
        {
            using (var connection = new MySqlConnection(connectionStringMysql))
            {
                await connection.OpenAsync();
                var query = "SELECT COUNT(*) FROM admin_asset.sprzet WHERE NumerSeryjny = @serialNumber";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@serialNumber", serialNumber);

                var count = Convert.ToInt32(await command.ExecuteScalarAsync());
                return count > 0;
            }
        }


        public async Task<string> GetMonitorInfoFromDatabase(string manufacturer, string systemModel, string evkModel = null)
        {
            string query = "SELECT * FROM monitor_specs WHERE (system_model = @systemModel AND manufacturer = @manufacturer)";

            // Добавляем условие для evk_model, если оно задано
            if (!string.IsNullOrEmpty(evkModel))
            {
                query += " AND (evk_model = @evkModel)";
            }
            else
            {
                query += " AND (evk_model IS NULL OR evk_model = '')";
            }

            string result = string.Empty;

            using (var connection = new MySqlConnection(connectionStringMysql))
            {
                try
                {
                    await connection.OpenAsync();

                    using (var command = new MySqlCommand(query, connection))
                    {
                        // Передаем параметры для защиты от SQL-инъекций
                        command.Parameters.AddWithValue("@systemModel", systemModel);
                        command.Parameters.AddWithValue("@manufacturer", manufacturer);

                        if (!string.IsNullOrEmpty(evkModel))
                        {
                            command.Parameters.AddWithValue("@evkModel", evkModel);
                        }

                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                // Собираем строку с данными, аналогичную строке из OpenAI
                                result = $"{reader["panel_type"]}, {reader["diagonal"]}, {reader["cable_types"]}, {reader["resolution"]}, " +
                                         $"{reader["aspect_ratio"]}, {reader["brightness"]}, {reader["response_time"]}, {reader["viewing_angles"]}, " +
                                         $"{reader["frequency"]}Hz, {reader["weight"]}, {reader["dimensions"]}, {reader["id_spec_monitor"]}";
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error querying database: " + ex.Message);
                }
            }

            return result;
        }



        internal Dictionary<string, string> ExecuteQueryFindProductAndGet(string query, Dictionary<string, string> parameters)
        {
            var result = new Dictionary<string, string>();

            using (var connection = new MySqlConnection(connectionStringMysql))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);

                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result.Add("manufacturer", reader["manufacturer"].ToString());
                        result.Add("model", reader["model"].ToString());
                        result.Add("resolution", reader["resolution"].ToString());
                        result.Add("frequency", reader["frequency"].ToString());
                        // result.Add("size_monitor", reader["size_monitor"].ToString());
                        result.Add("brightness", reader["brightness"].ToString());
                        result.Add("response_time", reader["response_time"].ToString());
                        result.Add("viewing_angles", reader["viewing_angles"].ToString());
                        result.Add("weight", reader["weight"].ToString());
                        result.Add("dimensions", reader["dimensions"].ToString());
                        result.Add("panel_type", reader["panel_type"].ToString());
                        result.Add("aspect_ratio", reader["aspect_ratio"].ToString());
                    }
                }
            }

            return result;
        }

        internal Dictionary<string, string> GetEvkModelFormSerialNumber(string searchValue)
        {
            var query =
                "SELECT aa.Model, aa.IdEvk " +
                "FROM admin_asset.sprzet AS aa " +
                $"WHERE aa.NumerSeryjny = '{searchValue}'";

            var resultDictionary = ExecuteQueryAndGetResultsAsDictionary(query);


            if (resultDictionary.Count > 0)
            {
                Console.WriteLine(@"Model: " + resultDictionary["Model"]);
                Console.WriteLine(@"IdEvk: " + resultDictionary["IdEvk"]);
            }

            return resultDictionary;
        }

        internal string ExecuteQueryWithSingleParametrFindProductAndGet(string query)
        {
            string model = "";
            using (var connection = new MySqlConnection(connectionStringMysql))
            {
                try
                {
                    connection.Open();

                    // Используем команду для выполнения запроса
                    using (var command = new MySqlCommand(query, connection))
                    {
                        // Выполняем запрос и получаем одно значение
                        var result = command.ExecuteScalar();

                        if (result != null)
                        {
                            model = result.ToString();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Ошибка запроса: " + ex.Message);
                }
            }

            return model;
        }

        internal Dictionary<string, string> ExecuteQueryAndGetResultsAsDictionary(string query)
        {
            var resultDictionary = new Dictionary<string, string>();

            using (var connection = new MySqlConnection(connectionStringMysql))
            {
                try
                {
                    connection.Open();

                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())  // Читаем первую строку результата
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    var columnName = reader.GetName(i);  // Получаем название колонки
                                    var columnValue = reader.IsDBNull(i) ? null : reader[i].ToString();  // Получаем значение
                                    resultDictionary[columnName] = columnValue;
                                }
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Ошибка запроса: " + ex.Message);
                }
            }

            return resultDictionary;
        }

        internal Dictionary<string, string> ExecuteQueryFindProductAndGet(string query)
        {
            using (var connection = new MySqlConnection(connectionStringMysql))
            {
                try
                {
                    connection.Open();

                    var command = new MySqlCommand(query, connection);

                    var reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        var czyszczenieData = "No Data";
                        if (reader["CzyCzyszczony"].ToString().Equals("Yes"))
                            czyszczenieData = reader["CzyszczenieData"] != DBNull.Value &&
                                              reader["CzyszczenieData"].ToString() != "0000-00-00 00:00:00"
                                ? reader["CzyszczenieData"].ToString()
                                : "No Data";
                        ParametersStrings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                        {
                            { "Manufacturer", reader["Manufacturer"].ToString() },
                            { "Model", reader["EvkModel"].ToString() },
                            { "SerialNumber", reader["NumerSeryjny"].ToString() },
                            { "SerialNumberBIOS", reader["NumerSeryjnyBIOS"].ToString() },
                            { "Class", reader["KlasaEvk"].ToString() },
                            { "TestowaniePracownik", reader["TestowaniePracownik"].ToString() },
                            {
                                "TestowanieData",
                                reader["TestowanieData"] != DBNull.Value &&
                                reader["TestowanieData"].ToString() != "0000-00-00 00:00:00"
                                    ? reader["TestowanieData"].ToString()
                                    : "No Data"
                            },
                            { "CzyszczeniePracownik", reader["CzyszczeniePracownik"].ToString() },
                            { "CzyszczenieData", czyszczenieData },
                            { "CzyTestowany", reader["CzyTestowany"].ToString() },
                            { "CzyCzyszczony", reader["CzyCzyszczony"].ToString() },
                            { "MiejsceMagazynowe", reader["MiejsceMagazynowe"].ToString() },
                            { "IdEvk", reader["IdEvk"].ToString() },
                            { "Zdjecia", reader["Zdjecia"].ToString() },
                            { "Country", reader["Country"].ToString() },

                            { "SystemModel", reader["system_model"].ToString() },
                        { "Diagonal", reader["diagonal"].ToString() },
                        { "Resolution", reader["resolution"].ToString() },
                        { "Frequency", reader["frequency"].ToString() },
                        { "Brightness", reader["brightness"].ToString() },
                        { "ResponseTime", reader["response_time"].ToString() },
                        { "ViewingAngles", reader["viewing_angles"].ToString() },
                        { "Weight", reader["weight"].ToString() },
                        { "Dimensions", reader["dimensions"].ToString() },
                        { "PanelType", reader["panel_type"].ToString() },
                        { "AspectRatio", reader["aspect_ratio"].ToString() },
                        { "CableTypes", reader["cable_types"].ToString() }
                        };
                    }
                }

                catch (MySqlException ex)
                {
                    Console.WriteLine(@"Error request: " + ex.Message);
                }
            }

            return ParametersStrings;
        }


        internal Dictionary<int, string> FillCountryComboBox(ComboBox comboBox)
        {
            var countries = new Dictionary<int, string>();
            using (var connection = new MySqlConnection(connectionStringMysql))
            {
                try
                {
                    connection.Open();
                    var query = "SELECT * FROM slownikcountry ORDER BY CountryName ASC";
                    var command = new MySqlCommand(query, connection);
                    var reader = command.ExecuteReader();
                    var countryList = new List<KeyValuePair<string, string>>();

                    while (reader.Read())
                    {
                        countryList.Add(new KeyValuePair<string, string>(
                            reader["IdCountry"].ToString(),
                            reader["CountryName"].ToString()
                        ));
                    }
                    comboBox.DataSource = countryList;
                    comboBox.DisplayMember = "Value";
                    comboBox.ValueMember = "Key";
                    comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                    comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(@"Ошибка загрузки стран: " + ex.Message);
                }
            }

            return countries;
        }


    }
}