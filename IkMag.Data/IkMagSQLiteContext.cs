using System;
using IkMag.Domain;
using Microsoft.EntityFrameworkCore;

namespace IkMag.Data
{
    public class IkMagSQLiteContext : DbContext
    {
        public DbSet<Allowed> Allowed { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseSqlite("Data Source=IkMagDB.db;");
        }



    }
}
