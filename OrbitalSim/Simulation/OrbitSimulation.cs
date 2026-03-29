using OrbitalSim.Models;
using System;
using System.Text.Json;
using System.Text;
using System.Net.Http.Headers;
using OrbitalSim.Models;
using OrbitalSim.Services;
using System.Text.Json.Nodes;

namespace OrbitalSim.Simulation {
    public class OrbitSimulation
    {
        public static async Task<string> OrbitSimulationEngine(Queue<Telemetry> stack)
        {

            Satellite[] satellites = new Satellite[]
             {
                new Satellite("SAT", "Weather", "ONLINE", 37.77, -122.41,-122.41, 1000.0, 10),
                new Satellite("SAT", "WiFi", "ONLINE", 34.05, -118.24,-122.41, 500.0, 21),
                new Satellite("SAT", "WiFi", "ONLINE", 40.71, -74.00,-122.41, 600.0, 32),
                new Satellite("SAT", "Surveillance", "ONLINE", 51.50,-122.41, -0.12, 1200.0, 43),
                new Satellite("SAT", "Radio", "ONLINE", 48.85, 2.35,-122.41, 800.0, 54)
             };

            while (true)
            {
                Console.WriteLine("");
                // Time loop (simulate 1 orbit for each)
                int steps = 1000;
                double dt = 10; // seconds per step

                for (int i = 0; i < steps; i++)
                {
                    double t = i * dt; // current time in seconds
                    foreach (Satellite sat in satellites)
                    {
                        OrbitService.updateLocation(sat, t);

                        TelemetryData telData = TelemetryService.GetTelemetryData(sat);
                        TelemetryLocation telLocation = TelemetryService.GetTelemetryLocation(sat);

                        Telemetry packet = new Telemetry(telData, telLocation);
                        //Console.WriteLine(telData.ToString());
                        //Console.WriteLine(telLocation.ToString());
                        //Console.WriteLine(packet.ToString());
                        stack.Enqueue(packet);
                    }
                    await Task.Delay(60000);  
                }
            }
        }
    }
}