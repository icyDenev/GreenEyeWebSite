
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LitWebSite.Models;
using Microsoft.EntityFrameworkCore;

namespace LitWebSite.Data
{
    public class SensorDBContext : DbContext
    {
        public DbSet<Sensors> SensorsData { get; set; }

        public SensorDBContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=SensorsDB;Integrated Security=true");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
