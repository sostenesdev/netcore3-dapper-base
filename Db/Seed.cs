using System.Data;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace meu_blog_netcore.Db
{
    public class Seed
    {
        private static IDbConnection _dbConnection;

        public static void CreateDb(IConfiguration configuration)
        {
            // var connectionString = configuration.GetValue<string>("DBInfo:ConnectionString");
            // var dbFilePath = configuration.GetValue<string>("DBInfo:ConnectionString");
            // if (!File.Exists(dbFilePath))
            // {
                var connectionString = configuration["ConnectionStrings:DefaultConnection"];
                _dbConnection = new MySqlConnection(connectionString);
                _dbConnection.Open();

                // Create a Category table
                _dbConnection.Execute(@"
                    CREATE TABLE IF NOT EXISTS Category (
                        Id INT NOT NULL AUTO_INCREMENT,
                        Description VARCHAR(200) NOT NULL,
                         PRIMARY KEY (Id)
                    )");
                                _dbConnection.Execute(@"
                    CREATE TABLE IF NOT EXISTS Test (
                        Id INT NOT NULL AUTO_INCREMENT,
                        Description VARCHAR(200) NOT NULL,
                         PRIMARY KEY (Id)
                    )");


                _dbConnection.Close();
            // }

        }
    }
}