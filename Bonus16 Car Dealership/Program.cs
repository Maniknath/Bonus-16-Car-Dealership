using System;
using System.Collections.Generic;

namespace Bonus16_Car_Dealership
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> Inventory = new List<Car>();


            Car c = new Car();

            Console.WriteLine("How many cars do you want");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("Car " + (i + 1));
                c = new Car();
                Console.WriteLine("Make of the car:");
                c.Make = Console.ReadLine();
                Console.WriteLine("Model of the car:");
                c.Model = Console.ReadLine();
                Console.WriteLine("Year of the Car:");
                c.Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Price of the car:");
                c.Price = Convert.ToInt32(Console.ReadLine());

                Inventory.Add(c);
            }

            Console.WriteLine("Current Inventory:");
            foreach (var car in Inventory)
            {
                Console.WriteLine($" {car.Make} {car.Model} Year {car.Year} Price {car.Price}");

            }



            Console.ReadKey();



        }
    }
}
