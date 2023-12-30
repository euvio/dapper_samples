using Npgsql;
using System.Data;
using Dapper;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sql = 
                """
                SELECT @Name AS "Name",@Age "Age"
                """;

            IDbConnection connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=123456;Database=postgres");
            var results = connection.Query(sql, new {Name="Jack",Age=18}).ToArray();
            Console.WriteLine(results[0].Name);
            Console.WriteLine(results[0].Age);

            ;
            string sqlsql =
                """
                SELECT
                	Count(*) 
                FROM
                	"Dog";
                SELECT
                	* 
                FROM
                	"Dog";
                """;

            NpgsqlCommand d = new NpgsqlCommand();
            d.ExecuteNonQuery();
            d.ExecuteReader();
            d.ExecuteScalar();

            //NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=123456;Database=postgres");
            //connection.Open();
            //NpgsqlCommand command = connection.CreateCommand();
            //command.CommandText = sqlsql;
            //int duid = System.Convert.ToInt32(command.ExecuteScalar());
        }
    }
}
