using DataAccess.Entities;
using DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Data.Seeding
{
    public static class SeedData
    {
        public static List<WoodType> GetWoods()
        {

            return new List<WoodType>
                                    {
                                        new WoodType
                                        {
                                            Category = enWoodCategory.Hardwood,
                                            Type = "Native beech",
                                            ShearYieldStressInMpa = 52.054,
                                            SpecificWorkToSurfaceSeparationJoulPerMeter2 = 1345.917,
                                            CoefficientOfFriction = 0.651
                                        },

                                        new WoodType
                                        {
                                            Category = enWoodCategory.Hardwood,
                                            Type = "Bendywood",
                                            ShearYieldStressInMpa = 49.75,
                                            SpecificWorkToSurfaceSeparationJoulPerMeter2 = 905.139,
                                            CoefficientOfFriction = 0.69
                                        },

                                        new WoodType
                                        {
                                            Category = enWoodCategory.Hardwood,
                                            Type = "DMDHEU",
                                            ShearYieldStressInMpa = 22.411,
                                            SpecificWorkToSurfaceSeparationJoulPerMeter2 = 1236.611,
                                            CoefficientOfFriction = 0.848
                                        },

                                        new WoodType
                                        {
                                            Category = enWoodCategory.Hardwood,
                                            Type = "Lignamon 783",
                                            ShearYieldStressInMpa = 43.292,
                                            SpecificWorkToSurfaceSeparationJoulPerMeter2 = 3265.556,
                                            CoefficientOfFriction = 0.69
                                        },

                                        new WoodType
                                        {
                                            Category = enWoodCategory.Hardwood,
                                            Type = "Lignamon 1185",
                                            ShearYieldStressInMpa = 30.39,
                                            SpecificWorkToSurfaceSeparationJoulPerMeter2 = 3736.389,
                                            CoefficientOfFriction = 0.79
                                        },

                                        new WoodType
                                        {
                                            Category = enWoodCategory.Hardwood,
                                            Type = "Beech 8",
                                            ShearYieldStressInMpa = 57.155,
                                            SpecificWorkToSurfaceSeparationJoulPerMeter2 = 1772.611,
                                            CoefficientOfFriction = 0.565
                                        },

                                        new WoodType
                                        {
                                            Category = enWoodCategory.Hardwood,
                                            Type = "Beech 16",
                                            ShearYieldStressInMpa = 50.609,
                                            SpecificWorkToSurfaceSeparationJoulPerMeter2 = 1656.028,
                                            CoefficientOfFriction = 0.661
                                        },

                                        new WoodType
                                        {
                                            Category = enWoodCategory.Softwood,
                                            Type = "Spruce 8",
                                            ShearYieldStressInMpa = 41.532,
                                            SpecificWorkToSurfaceSeparationJoulPerMeter2 = 1555.361,
                                            CoefficientOfFriction = 0.455
                                        },

                                        new WoodType
                                        {
                                            Category = enWoodCategory.Softwood,
                                            Type = "Spruce 16",
                                            ShearYieldStressInMpa = 35.994,
                                            SpecificWorkToSurfaceSeparationJoulPerMeter2 = 1472.444,
                                            CoefficientOfFriction = 0.541
                                        }
                                    };
        }

        public static List<ProductionCondition> GetProductionConditions()
        {
            return new List<ProductionCondition>
        {
            new ProductionCondition(30, 200, 0.85, 1200),
            new ProductionCondition(30, 200, 1.10, 1350),
            new ProductionCondition(30, 200, 1.35, 1500),
            new ProductionCondition(30, 200, 1.60, 1650),
            new ProductionCondition(30, 200, 1.90, 1800),
            new ProductionCondition(30, 200, 2.10, 1950),
            new ProductionCondition(30, 200, 2.35, 2100),
            new ProductionCondition(30, 200, 2.60, 2250),
            new ProductionCondition(30, 200, 2.90, 2400),
            new ProductionCondition(30, 200, 3.20, 2550),
            new ProductionCondition(30, 200, 3.50, 2700),
            new ProductionCondition(30, 200, 3.80, 2850)
        };
        }

        public static List<OperationCondition> GetOperationConditions()
        {
            return new List<OperationCondition>
        {
            new OperationCondition(15, 0.10, 3000, 80),
            new OperationCondition(16, 0.12, 3200, 85),
            new OperationCondition(18, 0.14, 3400, 90),
            new OperationCondition(20, 0.16, 3600, 95),
            new OperationCondition(22, 0.18, 3800, 100),
            new OperationCondition(24, 0.20, 4000, 110),
            new OperationCondition(26, 0.22, 4200, 120),
            new OperationCondition(28, 0.24, 4400, 130),
            new OperationCondition(30, 0.26, 4600, 140),
            new OperationCondition(32, 0.28, 4800, 150),
            new OperationCondition(34, 0.30, 5000, 160),
            new OperationCondition(36, 0.32, 5200, 170)
        };
        }
        public static List<CriticalValues> GetCriticalValues()
        {
            return new List<CriticalValues>
        {
            new CriticalValues(64.62, 53.49, 54.23, 26.31, 8.91, 34.57, 40.81, 46.57, 14.55, 0.565, 29.46, 0.65, 0, 64.62, 32.31),
            new CriticalValues(60.10, 50.12, 52.10, 25.10, 8.40, 33.10, 39.50, 45.20, 13.90, 0.580, 28.90, 0.66, 0, 60.10, 30.05),
            new CriticalValues(58.30, 48.90, 51.00, 24.00, 8.10, 32.00, 38.20, 44.10, 13.40, 0.590, 28.10, 0.67, 0, 58.30, 29.15),
            new CriticalValues(66.80, 55.00, 56.20, 27.10, 9.20, 35.40, 41.20, 47.80, 15.10, 0.600, 30.10, 0.68, 0, 66.80, 33.40),
            new CriticalValues(70.50, 58.20, 59.00, 28.50, 9.80, 36.80, 43.00, 49.10, 16.00, 0.610, 31.20, 0.69, 0, 70.50, 35.25),
            new CriticalValues(72.10, 60.40, 61.30, 29.20, 10.10, 37.50, 44.20, 50.40, 16.50, 0.620, 32.00, 0.70, 0, 72.10, 36.05),
            new CriticalValues(68.90, 56.80, 57.60, 27.90, 9.50, 35.90, 42.10, 48.50, 15.40, 0.630, 30.80, 0.71, 0, 68.90, 34.45),
            new CriticalValues(65.30, 54.10, 55.20, 26.40, 9.10, 34.20, 40.60, 46.90, 14.80, 0.640, 29.70, 0.72, 0, 65.30, 32.65),
            new CriticalValues(63.00, 52.00, 53.50, 25.80, 8.80, 33.00, 39.40, 45.60, 14.20, 0.650, 29.10, 0.73, 0, 63.00, 31.50),
            new CriticalValues(61.50, 51.00, 52.20, 25.00, 8.60, 32.20, 38.90, 44.80, 13.80, 0.660, 28.60, 0.74, 0, 61.50, 30.75),
            new CriticalValues(59.80, 49.80, 50.90, 24.50, 8.30, 31.50, 38.00, 43.90, 13.50, 0.670, 28.00, 0.75, 0, 59.80, 29.90),
            new CriticalValues(57.90, 48.60, 49.70, 23.90, 8.00, 30.80, 37.20, 42.80, 13.10, 0.680, 27.50, 0.76, 0, 57.90, 28.95)
        };
        }

     
        public static List<OperationsProcess> GetOperationsProcesses()
        {
            return new List<OperationsProcess>
    {
        new OperationsProcess(
            1,
            new ProductionCondition(110, 55, 1.2, 1100),
            new OperationCondition(16, 0.11, 3100, 85),
            new CriticalValues(51, 42, 47, 21, 11, 31, 36, 41, 13, 0.555, 26, 0.61, 0, 61, 31)
        ),

        new OperationsProcess(
            2,
            new ProductionCondition(120, 60, 1.4, 1200),
            new OperationCondition(17, 0.12, 3200, 90),
            new CriticalValues(52, 44, 49, 22, 12, 32, 37, 42, 14, 0.560, 27, 0.62, 0, 62, 31)
        ),

        new OperationsProcess(
            3,
            new ProductionCondition(130, 65, 1.6, 1300),
            new OperationCondition(18, 0.13, 3300, 95),
            new CriticalValues(53, 46, 51, 23, 13, 33, 38, 43, 15, 0.565, 28, 0.63, 0, 63, 31)
        ),

        new OperationsProcess(
            4,
            new ProductionCondition(140, 70, 1.8, 1400),
            new OperationCondition(19, 0.14, 3400, 100),
            new CriticalValues(54, 48, 53, 24, 14, 34, 39, 44, 16, 0.570, 29, 0.64, 0, 64, 32)
        ),

        new OperationsProcess(
            5,
            new ProductionCondition(150, 75, 2.0, 1500),
            new OperationCondition(20, 0.15, 3500, 105),
            new CriticalValues(55, 50, 55, 25, 15, 35, 40, 45, 17, 0.575, 30, 0.65, 0, 65, 32)
        ),

        new OperationsProcess(
            6,
            new ProductionCondition(160, 80, 2.2, 1600),
            new OperationCondition(21, 0.16, 3600, 110),
            new CriticalValues(56, 52, 57, 26, 16, 36, 41, 46, 18, 0.580, 31, 0.66, 0, 66, 33)
        ),

        new OperationsProcess(
            7,
            new ProductionCondition(170, 85, 2.4, 1700),
            new OperationCondition(22, 0.17, 3700, 115),
            new CriticalValues(57, 54, 59, 27, 17, 37, 42, 47, 19, 0.585, 32, 0.67, 0, 67, 33)
        ),

        new OperationsProcess(
            8,
            new ProductionCondition(180, 90, 2.6, 1800),
            new OperationCondition(23, 0.18, 3800, 120),
            new CriticalValues(58, 56, 61, 28, 18, 38, 43, 48, 20, 0.590, 33, 0.68, 0, 68, 34)
        ),

        new OperationsProcess(
            9,
            new ProductionCondition(190, 95, 2.8, 1900),
            new OperationCondition(24, 0.19, 3900, 125),
            new CriticalValues(59, 58, 63, 29, 19, 39, 44, 49, 21, 0.595, 34, 0.69, 0, 69, 34)
        ),

        new OperationsProcess(
            1,
            new ProductionCondition(200, 100, 3.0, 2000),
            new OperationCondition(25, 0.20, 4000, 130),
            new CriticalValues(60, 60, 65, 30, 20, 40, 45, 50, 22, 0.600, 35, 0.70, 0, 70, 35)
        ),

        new OperationsProcess(
            2,
            new ProductionCondition(210, 105, 3.2, 2100),
            new OperationCondition(26, 0.21, 4100, 135),
            new CriticalValues(61, 62, 67, 31, 21, 41, 46, 51, 23, 0.605, 36, 0.71, 0, 71, 35)
        ),

        new OperationsProcess(
            3,
            new ProductionCondition(220, 110, 3.4, 2200),
            new OperationCondition(27, 0.22, 4200, 140),
            new CriticalValues(62, 64, 69, 32, 22, 42, 47, 52, 24, 0.610, 37, 0.72, 0, 72, 36)
        )
    };
        }
    }
}
