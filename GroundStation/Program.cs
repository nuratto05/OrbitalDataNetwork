using GroundStation.Networking;
using System;

namespace GroundStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = TcpServer.StartServer();
        }
    }
}