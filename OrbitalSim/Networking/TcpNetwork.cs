using OrbitalSim.Models;
using System;
using System.Collections;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace OrbitalSim.Networking
{
	public class TcpNetwork
	{

        public static async Task<string> SendTelViaTCP(Queue<TelemetryData> queue)
        {
            while (true)
            {
                if(queue.Count > 0)
                {
                    SendData("127.0.0.1", 1302, queue);
                }
            }
        }

		public static void SendData(String Url, int Port, Queue<TelemetryData> queue)
		{
            if(queue.Count > 0)
            {
                try
                {
                    TcpClient client = new TcpClient("127.0.0.1", 1302);
                    NetworkStream stream = client.GetStream();

                    while (queue.Count > 0)
                    {
                        TelemetryData tel = queue.Dequeue();
                        string message = tel.ToString();

                        Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                        stream.Write(data, 0, data.Length);
                        Console.WriteLine("Sent: {0}", message);

                        data = new Byte[256];
                        String responseData = String.Empty;

                        Int32 bytes = stream.Read(data, 0, data.Length);
                        responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                        Console.WriteLine("Received: {0}", responseData);
                    }
                    Console.WriteLine("Closing Connection: Queue Empty");
                    stream.Close();
                    client.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: Failed Connecting...");
                }
            }
        }
	}
}