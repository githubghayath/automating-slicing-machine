using DataAccess.Data;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.DataBase.Utility
{
    public static class Utility
    {
        public static double ElectrcityPricePerKiloWatt
        {
            get 
            {
                using(var context = new AppDbContext())
                {
                    return Convert.ToDouble(context.ConstantValues.First().ElectrcityPricePerKiloWatt);
                }
            }
        }

        public static double FeesPerCubicMetter
        {
            get
            {
                using (var context = new AppDbContext())
                {
                    return Convert.ToDouble(context.ConstantValues.First().FeesPerCubicMetter);
                }
            }
        }

        public static List<OperationsProcess> GetOperationsProcessHistory()
        {
            using (var context = new AppDbContext()) 
            {
                return context.OperationsProcesses
                    .Include(op => op.WoodType)
                    .Include(op => op.OperationCondition)
                    .Include(op => op.ProductionCondition)
                    .Include(op => op.CriticalValues)
                    .ToList();
            }
        }

    }
}
