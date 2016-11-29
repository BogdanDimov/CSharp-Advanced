using System;
using System.Text;

namespace ParseURL
{
    class ParseURL
    {
        static void Main()
        {
            StringBuilder url = new StringBuilder(Console.ReadLine());
            string protocol = url.ToString().Substring(0, url.ToString().IndexOf("://"));
            Console.WriteLine("[protocol] = " + protocol);
            url.Remove(0, protocol.Length + 3);
            string server = url.ToString().Substring(0, url.ToString().IndexOf("/"));
            Console.WriteLine("[server] = " + server);
            url.Remove(0, server.Length);
            string resource = url.ToString();
            Console.WriteLine("[resource] = " + resource);
        }
    }
}
