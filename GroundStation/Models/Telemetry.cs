using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroundStation.Models
{

    public class Telemetry
    {
        public TelemetryData Data { get; set; }
        public TelemetryLocation Location { get; set; }

        public Telemetry() { }

        public override string ToString()
        {
            return $"TelemetryData: {Data}, TelemetryLocation: {Location}";
        }
    }
}
