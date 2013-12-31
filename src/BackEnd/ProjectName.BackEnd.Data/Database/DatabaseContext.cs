using Microsoft.EntityFrameworkCore;
using ProjectName.BackEnd.Data.Entiteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName.BackEnd.Data.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product>? Product { get; set; }

        private readonly string _connectionString;

        public DatabaseContext(string connectionString)
        {
            _connectionString = connectionString;
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(_connectionString);
        }
    }
}
