using DataAccess.Data;
using DataAccess.Data.Seeding;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    internal class DataAccessProgram
    {
        public static void Main(string[] args)
        {
            // This pice or code is used to seed the database with initial data.
            // It checks if there are any wood types in the database, and if not, it adds a predefined list of wood types from the SeedData class. This ensures that the database has some initial data to work with when the application is first run.
            // ==============This style because the migration does not work with the default style of seeding data in the AppDbContext class, so we have to use this style to seed the data.================
            using (AppDbContext context = new AppDbContext())
            {
                context.Database.EnsureCreated();

                if(!context.WoodTypes.Any())
                {
                    context.WoodTypes.AddRange(SeedData.GetWoods());
                    context.SaveChanges();
                }
                Console.WriteLine("Adding wood types... Done");
            }
        }
    }
}
