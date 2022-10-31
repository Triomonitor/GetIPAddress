using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GetIPAddress
{
    public class IPAddr
    {
        public string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return null;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            IPAddr xIP = new IPAddr();
            File.WriteAllText(@"D:\Temp\IP.bin", xIP.GetLocalIPAddress());
            Process.Start("notepad", @"D:\Temp\IP.bin");
        }
    }
}
