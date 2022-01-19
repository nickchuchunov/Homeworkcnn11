using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SecureDevelopment_1
{
    public class DatabaseContext: DbContext
    {

       public  DatabaseContext() { Database.EnsureCreated(); }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=bankcard; Trusted_Connection = True; ");
        }


    }
}
