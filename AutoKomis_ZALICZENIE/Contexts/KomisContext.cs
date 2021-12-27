using AutoKomis_ZALICZENIE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoKomis_ZALICZENIE.Contexts
{
    public class KomisContext : DbContext
    {
        public DbSet<KomisModel> Pojazdy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            var cs = @"Data Source=AS-PC;Initial Catalog=KomisDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;MultiSubnetFailover=False";
            dbContextOptions.UseSqlServer(cs);
        }
    }
}
