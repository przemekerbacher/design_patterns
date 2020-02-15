using Builder.Builders;
using Builder.Directors;
using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var scooters = new List<Scooter>();
            var factory = new Factory();
            var normalScooter = factory.Build(new NormalScooter());
            var extremeScooter = factory.Build(new ExtremeScooter());

            scooters.Add(normalScooter);
            scooters.Add(extremeScooter);

            foreach (var scooter in scooters)
            {
                Console.WriteLine($"Name: {scooter.Name}, Type: {scooter.Type}");
            }

            Console.ReadKey();
        }
    }
}
