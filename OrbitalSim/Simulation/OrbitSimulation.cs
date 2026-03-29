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
                new Satellite("Weather", "Active", 37.7749, -122.4194, 1000.0),
                new Satellite("WiFi", "Pending", 34.0522, -118.2437, 500.0),
                new Satellite("WiFi", "Completed", 40.7128, -74.0060, 600.0),
                new Satellite("Surveillance", "Active", 51.5074, -0.1278, 1200.0),
                new Satellite("Radio", "Pending", 48.8566, 2.3522, 800.0)
             };

            while (true)
            {
                foreach (Satellite sat in satellites)
                {
                    Telemetry tel = new Telemetry();
                    OrbitService.updateLocation(sat);
                    tel = TelemetryService.GetTelemetry(sat);
                    Console.WriteLine(tel.ToString());
                }
                await Task.Delay(5000); // 5sec
            }
        }
    }
}