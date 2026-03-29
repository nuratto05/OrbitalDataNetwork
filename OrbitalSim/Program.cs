using OrbitalSim.Simulation;
using System;
using OrbitalSim.Simulation;
using OrbitalSim.Models;
using OrbitalSim.Networking;

namespace OrbitalSim
{
    class Program
    {
        
        static async Task Main()
        {
            Queue<Telemetry> telemetryQueue = new Queue<Telemetry>();

            var tel = OrbitSimulation.OrbitSimulationEngine(telemetryQueue);
            var send = TcpNetwork.SendTelViaTCP(telemetryQueue);
        }
    }
}