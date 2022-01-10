using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crtz.SignalRSelfHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:6118";
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine($"The server is: {url}");
                Console.ReadLine();
            }
        }
    }
}
