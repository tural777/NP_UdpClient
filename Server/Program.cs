using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new UdpClient(45678);
            var ep = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                var bytes = client.Receive(ref ep);
                var str = Encoding.Default.GetString(bytes);
                Console.WriteLine(str);
            }
        }
    }
}
