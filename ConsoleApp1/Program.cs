using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using SampleWcfService;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ServiceHost serviceHost = new ServiceHost(typeof(Process));
            serviceHost.AddServiceEndpoint(typeof(IProcess), new NetTcpBinding(), "net.tcp://localhost:12345/");
            serviceHost.Open();
            Console.WriteLine("server is running.....");
            Console.ReadLine();
        }
   
    }
}
