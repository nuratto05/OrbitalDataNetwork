using System;

namespace GroundStation.Models
{
    public class TelemetryData
    {
        public DateTime TimeStamp { get; set; }
        public int Id { get; set; }
        public string Status { get; set; }
        public double Temperature { get; set; }
        public int Battery { get; set; }
        public double Velocity { get; set; }

        public TelemetryData()
        {
        }

        public override string ToString()
        {
            return $"[Timestamp: {TimeStamp}] IDN: {Id}, Status: {Status}, Temperature: {Temperature}, Battery: {Battery}, Velocity: {Velocity}";
        }
    }
}