using changeResolution1;
using Npgsql;
using System;
using System.Threading.Tasks;

namespace ServiceMonitorEVK.Database
{
    public class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager(string host, string username, string password, string database)
        {
            connectionString = $"Host={host};Username={username};Password={password};Database={database}";
        }

        public async Task InsertMonitorInfo(MonitorInfo monitorInfo)
        {
             var connection = new NpgsqlConnection(connectionString);
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

