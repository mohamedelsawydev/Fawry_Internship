using Fawry_Internship.Enums;
using Fawry_Internship.Models;
using Fawry_Internship.Rules;

namespace Fawry_Internship
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var system = new RadarSystem();

            // Register Rules
            system.AddRule( new PrivateSpeedRule());
            system.AddRule( new TruckSpeedRule());
            system.AddRule(new SeatbeltRule());

            // Observation 1
            system.Check(new Observation(
                "ABC1234",
                DateTime.Now,
                CarType.Private,
                94,
                false));

            // Observation 2
            system.Check(new Observation(
                "XYZ5678",
                DateTime.Now,
                CarType.Truck,
                70,
                true));

            // Observation 3
            system.Check(new Observation(
                "MMM1111",
                DateTime.Now,
                CarType.Private,
                60,
                true));

            Console.WriteLine();
            Console.WriteLine("===== All Fines =====");
            system.GetAllFines();

            Console.WriteLine();
            Console.WriteLine("===== Violated Rules =====");
            system.GetAllViolatedRules();



        }
    }
}
