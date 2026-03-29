using System;
using OrbitalSim.Models;

namespace OrbitalSim.Services
{
    public class OrbitService
    {
        private static Random rand = new Random();

        public static void updateLocation(Satellite sat)
        {
            if (sat == null) return;

            sat.Lat = rand.NextDouble();
            sat.Lon = rand.NextDouble();

        }
    }
}