using System;
using SpeedTest;
using SpeedTest.Models;

namespace SpeedTestLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Azure Workshop!");

            var client   = new SpeedTestClient();
            var settings = client.GetSettings();
        }
    }
}
