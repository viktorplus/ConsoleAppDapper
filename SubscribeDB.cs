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

        public IEnumerable<dynamic> MultiString(string SqlQuery, object param = null)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var results = connection.Query(SqlQuery, param);
                    return results;
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

            return null;

            /*var results = MultiString(Constants.GetCountCustomersFromCity);
                foreach (dynamic result in results)
                {
                    Console.WriteLine($"CityName: {result.CityName}, CustomerCount: {result.CustomerCount}");
                }

            */
        }



        public void Execute(string SqlQuery, object param=null)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var affectedRows = connection.Execute(SqlQuery, param);
                    Console.WriteLine($"Affected Rows: {affectedRows}");
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
            //    object[] param19 = { new { id = 1003 } };
            //    db.Execute(Constants.DeleteCountry, param19);
        }

        public void ExecuteScalar(string SqlQuery, object param=null)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var result = connection.ExecuteScalar(SqlQuery, param);
                    Console.WriteLine($"Result: {result}");
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
            //    object[] param19 = { new { id = 1003 } };
            //    db.Execute(Constants.DeleteCountry, param19);

        }

        /*CREATE PROCEDURE GetCustomerById 
            (@id int)  
            AS  
            BEGIN    
                SELECT * FROM Customer WHERE CustomerID = @id  
            END


        using(var connection = new SqlConnection(connectionString))
{
            //Set up DynamicParameters object to pass parameters  https://www.learndapper.com/stored-procedures
            DynamicParameters parameters = new DynamicParameters();   
            parameters.Add("id", 1);  
	
            //Execute stored procedure and map the returned result to a Customer object  
            var customer = conn.QuerySingleOrDefault<Customer>("GetCustomerById", parameters, commandType: CommandType.StoredProcedure);
}
        */

    }


}