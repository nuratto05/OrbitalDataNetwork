using OrbitalSim.Simulation;
using System;
using OrbitalSim.Simulation;

namespace OrbitalSim
{
    class Program
    {
        static async Task Main()
        {
            string tel = await OrbitSimulation.OrbitSimulationEngine();
        }
    }
}