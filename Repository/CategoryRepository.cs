using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using meu_blog_netcore.Models;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace meu_blog_netcore.Repository {
    public class CategoryRepository : AbstractRepository<Category> {
        public CategoryRepository (IConfiguration configuration) : base (configuration) { }

        public override List<Category> GetAll () {
            using (IDbConnection dbConnection = new MySqlConnection (ConnectionString)) {
                dbConnection.Open ();
                return dbConnection.Query<Category> ("SELECT * FROM Category").ToList ();
            }
        }

        public override void Add(Category item)
        {
            using (IDbConnection dbConnection = new MySqlConnection(ConnectionString))
            {
                string sQuery = "INSERT INTO Product (Description)"
                                + " VALUES(@Description)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, item);
            }
        }
    }
}