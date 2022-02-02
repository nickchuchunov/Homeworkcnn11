using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
namespace SecureDevelopment_1
{
    public class DatabaseContext: DbContext
    {
       internal  string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=bankcard; Trusted_Connection = True; ";

       public  DatabaseContext() { Database.EnsureCreated(); }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }


    }
}
