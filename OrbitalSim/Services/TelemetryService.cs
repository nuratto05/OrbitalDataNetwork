using System;
using OrbitalSim.Models;

namespace OrbitalSim.Services
{
    public class TelemetryService
    {
        private static Random rand = new Random();

        public static TelemetryData GetTelemetry(Satellite sat)
        {
            TelemetryData tel = new TelemetryData();

            tel.Id = sat.Id;
            tel.Status = sat.Status;
            tel.Temperature = rand.Next(50, 70);
            tel.Battery = rand.Next(0, 100);
            tel.Velocity = rand.Next(100, 300);

            return tel;
        }
    }
}