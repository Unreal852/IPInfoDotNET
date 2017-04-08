using IPInfoDotNET;
using System;
using System.Net;

namespace IPInfoDotNETExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a IP address to checkup ( leave blank to use your own IP ): ");
            string input = Console.ReadLine();

            IPAddress ip = null;

            IPInfo info = (input.Length > 1 && IPAddress.TryParse(input, out ip)) ? IPInfo.Get(input) : IPInfo.Get();

            if (info != null)
            {
                Console.WriteLine($"IP: {info.IP}");
                Console.WriteLine($"Country: {info.Country}");
                Console.WriteLine($"Region: {info.Region}");
                Console.WriteLine($"City: {info.City}");
                Console.WriteLine($"Postal: {info.Postal}");
                Console.WriteLine($"Location: {info.Location}");
                Console.WriteLine($"Organisation: {info.Organitation}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("A error occured while trying to get the informations. Press any key to exit");
                Console.ReadLine();
            }
        }
    }
}
