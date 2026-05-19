using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.Helper
{
    public static class clsMainEquations
    {
        // f = (Vf * PI * D) / (Z * Vc) [m]  // The feed per teeth depends on Vc and Vf (at this context)
        public static double FeedPerTeeth_Unit_MeterPerTeeth(double CuttingVelocityInMeterPerMin, double FeedVelocityInMeterPerMin, double BladeDiameterInMeter, int NumberOfTooth)
        {
            return (FeedVelocityInMeterPerMin * Math.PI * BladeDiameterInMeter) / (NumberOfTooth * CuttingVelocityInMeterPerMin);
        }


        // n = Vf / f * Z // The number or rotations depends on Vf (at this context)
        public static double NumberOfRotations_Unit_RPM(double FeedVelocityInMeterPerMin, double FeedPerTeethInMiterPerTeeth, int NumberOfTooth)
        {
            return FeedVelocityInMeterPerMin / (FeedPerTeethInMiterPerTeeth * NumberOfTooth);
        }

        // tan invers (Miw)
        public static double FrictionAngle_Unit_Degrees(double CoefficientOfFriction)
        {
            return Convert.ToDouble(clsHelper.RadiansToDegrees(Math.Atan(CoefficientOfFriction)));
        }

        
        public static double ShearAngle_Unit_Degrees(double FrictionAngleInRadians, double RakeAngleInRadians)
        {
            double valueInRadials = (Math.PI / 4.0) - 0.5 * (FrictionAngleInRadians - RakeAngleInRadians);

            return (double)clsHelper.RadiansToDegrees((double)valueInRadials);
        }

        public static double FrictionCorrectionCoefficient_Unit_None(double FrictionAngleInRadians , double ShearAngleInRadians , double RakeAngleInRadians)
        {
            return 1.0 - (Math.Sin(FrictionAngleInRadians) * Math.Sin(ShearAngleInRadians)) / (Math.Cos(FrictionAngleInRadians - RakeAngleInRadians) * Math.Cos(ShearAngleInRadians - RakeAngleInRadians));
        }

        public static double ShearingStrainAlongShearPlane(double ShearAngleInRadians, double RakeAngleInRadians)
        {
            return Math.Cos(RakeAngleInRadians) / (Math.Cos(ShearAngleInRadians - RakeAngleInRadians) * Math.Sin(ShearAngleInRadians));
        }
        /// <summary>
        /// Calculate the enter angle
        /// </summary>
        /// <param name="eInMeter">Depth Of Cut Wood.</param>
        /// <param name="aInMeter">The Distance Between The Center Of The Disc And The Lowest Point Of The Wood.</param>
        /// <param name="RoInMeter">Radius Of Cutting Disk.</param>
        /// <returns>Enter Disk Angle</returns>
        public static double EnterAngle_Unit_Degrees(double eInMeter, double aInMeter, double RoInMeter)
        {
            return clsHelper.RadiansToDegrees(Math.Acos((aInMeter + eInMeter) / RoInMeter));
        }

        /// <summary>
        /// Calculate the exit angle
        /// </summary>
        /// <param name="aInMeter">The Distance Between The Center Of The Disc And The Lowest Point Of The Wood.</param>
        /// <param name="RoInMeter">Radius Of Cutting Disk.</param>
        /// <returns>exit Disk Angle</returns>
        public static double ExitAngle_Unit_Degrees(double aInMeter, double RoInMeter)
        {
            return clsHelper.RadiansToDegrees(Math.Acos(aInMeter / RoInMeter));
        }

        /// <summary>
        /// Calculate the Center angle
        /// </summary>
        /// <param name="eInMeter">Depth Of Cut Wood.</param>
        /// <param name="aInMeter">The Distance Between The Center Of The Disc And The Lowest Point Of The Wood.</param>
        /// <param name="RoInMeter">Radius Of Cutting Disk.</param>
        /// <returns>Center Disk Angle</returns>
        public static double CenterAngleOfCutting(double eInMeter, double aInMeter, double RoInMeter)
        {
            return (EnterAngle_Unit_Degrees(eInMeter, aInMeter, RoInMeter) + ExitAngle_Unit_Degrees(aInMeter, RoInMeter)) / 2;
        }

        public static double TheMeanChipThickness_Unit_Meter(double CenterAngleInDegrees , double FeedPerTeethInMeter)
        {
            return _TheChipThicknessInCustomAngle(CenterAngleInDegrees, FeedPerTeethInMeter);
        }
        private static double _TheChipThicknessInCustomAngle(double AngleInDegrees, double FeedPerTeethInMeter)
        {
            return FeedPerTeethInMeter * Math.Sin(clsHelper.DegreesToRadians(AngleInDegrees)); 
        }
        public static Dictionary<double, double> ChipThicknessAtStudiedAngles(List<double> AnglesInDegrees, double FeedPerTeethInMeter)
        {
            Dictionary<double, double> PairOfAngleWithChipThickness = new Dictionary<double, double>();

           

            foreach (double Angle in AnglesInDegrees)
            {
                PairOfAngleWithChipThickness.Add(Angle, _TheChipThicknessInCustomAngle(Angle, FeedPerTeethInMeter));
               
            }
            return PairOfAngleWithChipThickness;
        }
        public static double CuttingForce_Unit_Newton(double ShearYieldStressInMegaPas , double KerfThicknessInMeter , double ShearStrainAlongTheShearPlane,
            double FrictionCorrectionCoefficient,double TheMeanChipThicknessInMeter,double SpecificWorkOfASurfaceSeparationInJoulPerSqarMeter)
        {
            return (ShearYieldStressInMegaPas * 1000000 * KerfThicknessInMeter * ShearStrainAlongTheShearPlane / FrictionCorrectionCoefficient) * TheMeanChipThicknessInMeter
                + (SpecificWorkOfASurfaceSeparationInJoulPerSqarMeter * KerfThicknessInMeter / FrictionCorrectionCoefficient);
        }
        private static double _CalculateTheta_Unit_Radians()
        {
            double FrictionAngleInRadians = FrictionAngle_Unit_Degrees(Convert.ToDouble(clsHelper.ReadFromConfiguration("CoefficientOfFriction")));
            double RakeAngleInRadians = Convert.ToDouble(clsHelper.ReadFromConfiguration("RakeAngle"));
            return clsHelper.DegreesToRadians(90 - RakeAngleInRadians - (90 - FrictionAngleInRadians));
        }
        public static double ActiveForce_Unit_Newton( double CuttingForceInNewton) // F(a)
        {
            return CuttingForceInNewton / Math.Cos(_CalculateTheta_Unit_Radians());
        }
        public static double FrictionForceOnRake_Unit_Newton(double FrictionAngleInRadians,double CuttingForceInNewton) // F(gama)
        {
            return CuttingForceInNewton * Math.Sin(FrictionAngleInRadians);
        }
        public static double ThrustForce_Unit_Newton( double CuttingForceInNewton) // F(t)
        {
            return Math.Tan(_CalculateTheta_Unit_Radians()) * CuttingForceInNewton;
        }
        public static double ShearForce_Unit_Newton(double ShearAngleInRadians, double CuttingForceInNewton) // F(s)
        {
            return CuttingForceInNewton * Math.Cos(_CalculateTheta_Unit_Radians() + ShearAngleInRadians);
        }
        public static double NormalForceToShearPlane_Unit_Newton( double ShearAngleInRadians, double CuttingForceInNewton) // N(s)
        {
            return CuttingForceInNewton * Math.Sin(_CalculateTheta_Unit_Radians() + ShearAngleInRadians);
        }
        public static double NormalForceToRake_Unit_Newton(double FrictionAngleInRadians,double CuttingForceInNewton) // N(gama)
        {
            return CuttingForceInNewton * Math.Cos(FrictionAngleInRadians);
        }

        private static double _TheDistanceBetweenTwoAdjacentTeeth_Unit_Degrees(int TotalNumberOfTeeth)
        {
            return 360 / TotalNumberOfTeeth;
        }
        private static int NumberOfTeethInvolvedInCutting(double EnterAngle , double ExitAngle, int TotalNumberOfTeeth)
        {
            double _CuttingAngle = ExitAngle - EnterAngle;
            return (int)Math.Ceiling(_CuttingAngle / _TheDistanceBetweenTwoAdjacentTeeth_Unit_Degrees(TotalNumberOfTeeth));
        }
        public static List<double> GetStudiedAngles(double eInMeter, double aInMeter, double RoInMeter,int TotalNumberOfTeeth)
        {
            List<double> Angles = new List<double>();
            double _EnterAngle = EnterAngle_Unit_Degrees(eInMeter, aInMeter, RoInMeter);
            double _ExitAngle = ExitAngle_Unit_Degrees(aInMeter, RoInMeter);
            double TheDistanceBetweenTwoAdjacentTeethInDegrees = _TheDistanceBetweenTwoAdjacentTeeth_Unit_Degrees(TotalNumberOfTeeth);
            int _NumberOfTeethInvolvedInCutting = NumberOfTeethInvolvedInCutting(_EnterAngle, _ExitAngle, TotalNumberOfTeeth);
            

            for (int i = 0; i < _NumberOfTeethInvolvedInCutting; i++)
            {
                Angles.Add(_ExitAngle - (i * TheDistanceBetweenTwoAdjacentTeethInDegrees));
            }
            Angles.Add(_EnterAngle);

            return Angles.OrderByDescending(e => e).ToList();
        }

        public static double MomentOfCuttingForce_Unit_NewtonMeter(double CuttingForceInNewton, double RadiusOfCuttingDiskInMeter)
        {
            return CuttingForceInNewton * RadiusOfCuttingDiskInMeter;
        }

        public static double VolumetricProductionRateMeter3PerHour(double FeedVelocityInMeterPerSecond, double ProductSectionAreaInMeter2)
        {
            return (FeedVelocityInMeterPerSecond * ProductSectionAreaInMeter2) * 60 * 60;
        }
    }
}