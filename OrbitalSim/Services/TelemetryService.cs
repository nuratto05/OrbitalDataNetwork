using System;
using OrbitalSim.Models;

namespace OrbitalSim.Services
{
    public class TelemetryService
    {
        private static Random rand = new Random();

        public static Telemetry GetTelemetry(Satellite sat)
        {
            Telemetry tel = new Telemetry();

            tel.Id = sat.Id;
            tel.Status = sat.Status;
            tel.Temperature = rand.Next(50, 70);
            tel.Battery = rand.Next(0, 100);
            tel.Velocity = rand.Next(100, 300);

            return tel;
        }
    }
}