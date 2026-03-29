using System;

namespace OrbitalSim.Models
{
    public class Telemetry
    {
        public DateTime TimeStamp { get; set; }
        public int Id { get; set; }
        public string Status { get; set; }
        public double Temperature { get; set; }
        public int Battery { get; set; }
        public double Velocity { get; set; }

        public Telemetry()
        {
        }

        public Telemetry(DateTime timeStamp, int id, string status, double temperature, int battery, double velocity)
        {
            TimeStamp = timeStamp;
            Id = id;
            Status = status;
            Temperature = temperature;
            Battery = battery;
            Velocity = velocity;
        }
    }
}