using OrbitalSim.Models;
using System;
using System.Net.Http.Headers;
using OrbitalSim.Models;
using OrbitalSim.Services;

namespace OrbitalSim.Simulation {
    public class OrbitSimulation
    {
        public static async Task<string> OrbitSimulationEngine()
        {

            Satellite[] satellites = new Satellite[]
             {
                new Satellite("Weather", "Active", 37.77, -122.41, 1000.0),
                new Satellite("WiFi", "Pending", 34.05, -118.24, 500.0),
                new Satellite("WiFi", "Completed", 40.71, -74.00, 600.0),
                new Satellite("Surveillance", "Active", 51.50, -0.12, 1200.0),
                new Satellite("Radio", "Pending", 48.85, 2.35, 800.0)
             };

            while (true)
            {
                Console.WriteLine("");
                foreach (Satellite sat in satellites)
                {
                    Telemetry tel = new Telemetry();
                    OrbitService.updateLocation(sat);
                    tel = TelemetryService.GetTelemetry(sat);
                    Console.WriteLine("       " + tel.ToString());
                }
                Console.WriteLine("");
                await Task.Delay(5000); // 5sec
            }
        }
    }
}