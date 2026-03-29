using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitalSim.Models
{
    public class TelemetryLocation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Altitude { get; set; }
        public double Inclination { get; set; }

        public TelemetryLocation()
        {
        }

        public TelemetryLocation(Satellite sat)
        {
            Id = sat.Id;
            Name = sat.Name;
            X = sat.X;
            Y = sat.Y;
            Z = sat.Z;
            Altitude = sat.Altitude;
            Inclination = sat.Inclination;
        }

        public override string ToString()
        {
            return $"[TimeStamp: {DateTime.Now}] Name: {Name}-{Id}, X: {X}, Y: {Y} ,Z: {Z}";
        }
    }
}
