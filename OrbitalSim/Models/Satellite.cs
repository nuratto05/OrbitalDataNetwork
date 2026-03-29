using System;

namespace OrbitalSim.Models
{
    public class Satellite
    {
        public int Id { get; set; }
        public string MissionType { get; set; }
        public string Status { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public double Altitude { get; set; }

        Random rand = new Random();

        public Satellite(string missionType, string status, double lat, double lon, double altitude)
        {
            Id = rand.Next(1111, 2222);
            MissionType = missionType;
            Status = status;
            Lat = lat;
            Lon = lon;
            Altitude = altitude;
        }
    }
}