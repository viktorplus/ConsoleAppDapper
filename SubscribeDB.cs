using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDapper
{
    public class SubscribeDB
    {
        public string connectionString { get; set; }
        public SubscribeDB(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void MultiString<T>(string SqlQuery, object param = null)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var results = connection.Query<T>(SqlQuery, param);
                    foreach (var result in results)
                    {
                        Console.WriteLine(result.ToString() + "\n");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Помилка SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            // MultiString<string>("SELECT * FROM YourTable WHERE Column1 = @param", new { param = "someValue" });

        }

    }


}