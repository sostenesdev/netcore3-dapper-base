using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace meu_blog_netcore.Repository {
    public abstract class AbstractRepository<T> {
        private string _connectionString;
        protected string ConnectionString => _connectionString;
        public AbstractRepository (IConfiguration configuration){
            // _connectionString = configuration.GetValue<string>("DBInfo:ConnectionString");
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
            // Console.WriteLine("Connection string:"+_connectionString);
            meu_blog_netcore.Db.Seed.CreateDb(configuration);

        }
        public abstract List<T> GetAll ();
        public abstract void Add(T item);
        // public abstract void Remove(int id);
        // public abstract void Update(T item);
        // public abstract T FindByID(int id);
        // public abstract IEnumerable<T> FindAll();
    }
}