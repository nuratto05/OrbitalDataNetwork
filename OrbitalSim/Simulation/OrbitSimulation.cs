using OrbitalSim.Models;
using System;
using System.Net.Http.Headers;
using OrbitalSim.Models;
using OrbitalSim.Services;

namespace OrbitalSim.Simulation {
    public class OrbitSimulation
    {
        public static async Task<string> OrbitSimulationEngine(Queue<Telemetry> stack)
        {

            Satellite[] satellites = new Satellite[]
             {
                new Satellite("Weather", "ONLINE", 37.77, -122.41, 1000.0),
                new Satellite("WiFi", "ONLINE", 34.05, -118.24, 500.0),
                new Satellite("WiFi", "ONLINE", 40.71, -74.00, 600.0),
                new Satellite("Surveillance", "ONLINE", 51.50, -0.12, 1200.0),
                new Satellite("Radio", "ONLINE", 48.85, 2.35, 800.0)
             };

            while (true)
            {
                Console.WriteLine("");
                foreach (Satellite sat in satellites)
                {
                    Telemetry tel = new Telemetry();
                    OrbitService.updateLocation(sat);
                    tel = TelemetryService.GetTelemetry(sat);
                    Console.WriteLine(tel.ToString());
                    stack.Enqueue(tel);
                }
                Console.WriteLine("");
                await Task.Delay(60000); // 5sec
            }
        }
    }
}