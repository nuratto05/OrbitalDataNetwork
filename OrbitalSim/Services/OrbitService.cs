using System;
using OrbitalSim.Models;

namespace OrbitalSim.Services
{
    public class OrbitService
    {
        public static readonly double Gravity = 6.674e-11;
        public static readonly double EarthMass = 5.972e24;
        public static readonly double EarthRadius = 6371000;
        //public static readonly double Altitude = 400000; // 400 km orbit
        //public static readonly double Radius = EarthRadius + Altitude;
        //public static readonly double Omega = Math.Sqrt(Gravity * EarthMass / (Radius * Radius * Radius));
        //public static readonly double Time = 1;

        private static Random rand = new Random();

        public static void updateLocation(Satellite sat, double time)
        {
            if (sat == null) return;

            double Radius = sat.Altitude + EarthRadius;
            double Omega = Math.Sqrt(Gravity * EarthMass / (Radius * Radius * Radius));
            double Time = time;
            double Inclination = sat.Inclination * Math.PI / 100;

            double x = Radius * Math.Cos(Omega * Time);
            double y = Radius * Math.Sin(Omega * Time) * Math.Cos(Inclination);
            double z = Radius * Math.Sin(Omega * Time) * Math.Sin(Inclination);

            sat.X = x; 
            sat.Y = y; 
            sat.Z = z;

        }
    }
    
}