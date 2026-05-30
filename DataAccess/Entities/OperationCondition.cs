using System;
using System.Collections.Generic;
using System.Security.Cryptography.Pkcs;
using System.Text;

namespace DataAccess.Entities
{
    public class OperationCondition
    {
        // Required by EF Core
        private OperationCondition()
        {
        }

        public OperationCondition(
            double cuttingSpeed,
            double feedRate,
            double sheftSpeed,
            int consumedElectricity)
        {
            CuttingSpeed = cuttingSpeed;
            FeedRate = feedRate;
            SheftSpeed = sheftSpeed;
            ConsumedElectricity = consumedElectricity;
        }

        public int Id { get; private set; }

        public double CuttingSpeed { get; private set; } // [m/min]

        public double FeedRate { get; private set; } // [m/min]

        public double SheftSpeed { get; private set; } // [RPM]

        public int ConsumedElectricity { get; private set; }  // [KW]

        public virtual OperationsProcess OperationsProcess { get; private set; } = null!;
    }
}
