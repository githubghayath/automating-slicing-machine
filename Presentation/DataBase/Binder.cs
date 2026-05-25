using DataAccess.Data;
using DataAccess.Entities;

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Presentation.DataBase
{
    public static class Binder
    {
        public static void Bind(double stadiedTheta,
            double cuttingForce,
            double activeForce,
            double frictionForceOnRake,
            double thrustForce,
            double shearForce,
            double normalForceToShear,
            double normalForceToRake,
            double cuttingMoment,
            double frictionAngle,
            double shearAngle,
            double frictionCorrectionCofficient,
            double enterAngle,
            double leavingAngle,
            double centerAngle, double cuttingSpeed,
            double feedRate,
            double sheftSpeed,
            int productWidth,
            int productHeight,
            double ProductionVolumePerHour,
            int WoodTypeId, DateTime StartAt, DateTime EndAt)
        {
            CriticalValues criticalValues = new CriticalValues(stadiedTheta, cuttingForce, activeForce,
                frictionForceOnRake, thrustForce, shearForce, normalForceToShear, normalForceToRake, cuttingMoment,
                frictionAngle, shearAngle, frictionCorrectionCofficient, enterAngle, leavingAngle, centerAngle);



            int NumberOfPowerHours = (int)(EndAt - StartAt).TotalHours;

            int consumedElectricity = (int)Presentation.DataBase.Utility.Utility.ElectrcityPricePerKiloWatt * NumberOfPowerHours; // [KWh]

            OperationCondition operationCondition = new OperationCondition(cuttingSpeed, feedRate, sheftSpeed, consumedElectricity);


            double productionVolume = ProductionVolumePerHour * NumberOfPowerHours;  // [m³]
            double totalFees = productionVolume * (int)Presentation.DataBase.Utility.Utility.FeesPerCubicMetter; // [Doller]

            ProductionCondition productionCondition = new ProductionCondition(productWidth, productHeight, productionVolume, totalFees);



            OperationsProcess operationsProcess = new OperationsProcess(WoodTypeId, productionCondition, operationCondition, criticalValues, StartAt, EndAt);

            using (var context = new AppDbContext())
            {
                context.OperationsProcesses.Add(operationsProcess);
                context.SaveChanges();
            }
        }
    }
}
