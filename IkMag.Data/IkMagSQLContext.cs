using System;
using IkMag.Domain;
using IkMag.Secrets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace IkMag.Data
{
    public class IkMagSQLContext : DbContext
    {
        public DbSet<Allowed> Allowed { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStrings.AzureSQLConnectionString);
        }
    }
}
