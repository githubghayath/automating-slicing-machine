using DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class WoodType
    {
        public required enWoodCategory Category { get; set; }
        public int Id { get; set; }
        public required string Type { get; set; }
        public required double ShearYieldStressInMpa { get; set; }
        public required double SpecificWorkToSurfaceSeparationJoulPerMeter2 { get; set; }
        public required double CoefficientOfFriction { get; set; }

    }
}
