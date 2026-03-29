using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitalSim.Models
{

    public class Telemetry
    {
        public TelemetryData Data { get; set; }
        public TelemetryLocation Location { get; set; }

        public Telemetry() { }

        public Telemetry(TelemetryData data, TelemetryLocation location)
        {
            Data = data;
            Location = location;
        }

        public override string ToString()
        {
            return $"TelemetryData: {Data}, TelemetryLocation: {Location}";
        }
    }
}
