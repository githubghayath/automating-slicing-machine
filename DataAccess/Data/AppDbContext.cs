using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<WoodType> WoodTypes {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=.;Database=WoodCuttingMachine_V1;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }
    }
}
