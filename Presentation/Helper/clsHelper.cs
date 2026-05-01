using System;
using System.Configuration;

namespace WindowsFormsApp1.Helper
{
    public static class clsHelper
    {
        public static string ReadFromConfiguration(string Key)
        {
            
            return ConfigurationManager.AppSettings[Key].ToString();
        }

        public static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        public static double RadiansToDegrees(double radians)
        {
            return radians * 180.0 / Math.PI;
        }

        public static double MeterToMillimeter(double meters)
        {
            return meters * 1000.0;
        }

        public static double MillimeterToMeter(double millimeters)
        {
            return millimeters / 1000.0;
        }

        public static double MeterPerMinToMeterPerSec(double mPerMin)
        {
            return mPerMin / 60.0;
        }

        public static double MeterPerSecToMeterPerMin(double mPerSec)
        {
            return mPerSec * 60.0;
        }

    }
}
