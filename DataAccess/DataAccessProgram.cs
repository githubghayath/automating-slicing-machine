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

                //// -------------------------
                //// Wood Types
                //// -------------------------
                //if (!context.WoodTypes.Any())
                //{
                //    context.WoodTypes.AddRange(SeedData.GetWoods());
                //    context.SaveChanges();
                //    Console.WriteLine("Adding wood types... Done");
                //}

                //// -------------------------
                //// Production Conditions
                //// -------------------------
                //if (!context.ProductionConditions.Any())
                //{
                //    context.ProductionConditions.AddRange(SeedData.GetProductionConditions());
                //    context.SaveChanges();
                //    Console.WriteLine("Adding production conditions... Done");
                //}

                //// -------------------------
                //// Operation Conditions
                //// -------------------------
                //if (!context.OperationConditions.Any())
                //{
                //    context.OperationConditions.AddRange(SeedData.GetOperationConditions());
                //    context.SaveChanges();
                //    Console.WriteLine("Adding operation conditions... Done");
                //}

                //// -------------------------
                //// Critical Values
                //// -------------------------
                //if (!context.CriticalValues.Any())
                //{
                //    context.CriticalValues.AddRange(SeedData.GetCriticalValues());
                //    context.SaveChanges();
                //    Console.WriteLine("Adding critical values... Done");
                //}

                //if(!context.OperationsProcesses.Any())
                //{
                //    context.OperationsProcesses.AddRange(SeedData.GetOperationsProcesses());
                //    context.SaveChanges();
                //    Console.WriteLine("Adding operations processes... Done");
                //}

               
                

                Console.WriteLine("Seeding completed successfully.");
            }
        }
    }
}
