using System;
using OrbitalSim.Models;

namespace OrbitalSim.Services
{
    public class TelemetryService
    {
        Random rand = new Random();

        public Telemetry GetTelemetry(Satellite sat)
        {
            Telemetry tel = new Telemetry();

            tel.Temperature = rand.Next(50, 70);
            tel.Battery = rand.Next(0, 100);
            tel.Velocity = rand.Next(100, 300);

            return tel;
        }
    }
}