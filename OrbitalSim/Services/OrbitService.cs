using System;
using OrbitalSim.Models;

namespace OrbitalSim.Services
{
    public class OrbitService
    {
        Random rand = new Random();

        public void updateLocation(Satellite sat)
        {
            if (sat == null) return;

            sat.Lat = rand.NextDouble();
            sat.Lon = rand.NextDouble();

        }
    }
}