using System;

namespace OrbitalSim.Models
{
    public class Telemetry
    {
        public DateTime TimeStamp { get; set; }
        public double Temperature { get; set; }
        public int Battery { get; set; }
        public double Velocity { get; set; }

        public Telemetry()
        {
        }

        public Telemetry(double temperature, string battery, double velocity)
        {
            TimeStamp = DateTime.Now;
            Temperature = temperature;
            Battery = battery;
            Velocity = velocity;
        }
    }
}