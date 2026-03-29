using System;

namespace OrbitalSim.Models
{
    public class Satellite
    {
        public int Id { get; set; }
        public string MissionType { get; set; }
        public string Status { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Altitude { get; set; }
        public double Inclination { get; set;}

        Random rand = new Random();

        public Satellite(string missionType, string status, double x, double y, double z, double altitude, double inclination)
        {
            Id = rand.Next(1111, 2222);
            MissionType = missionType;
            Status = status;
            X = x;
            Y = y;
            Z = z;
            Altitude = altitude;
            Inclination = inclination;
        }
    }
}