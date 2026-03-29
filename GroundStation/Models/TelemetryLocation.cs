using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroundStation.Models
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

        public override string ToString()
        {
            return $"[TimeStamp: {DateTime.Now}] Name: {Name}-{Id}, X: {X}, Y: {Y} ,Z: {Z}";
        }
    }
}
