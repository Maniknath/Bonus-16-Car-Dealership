using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16_Car_Dealership
{
    class Car
    {



        private int year;
        private string make;
        private string model;
        private double price;

        public int Year { get => year; set => year = value; }
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public double Price { get => price; set => price = value; }

        public Car()
        {
            ;

        }

        public Car(int year, string make, string model, double price)
        {
            this.year = year;
            this.price = price;
            this.make = make;
            this.model = model;
        }


    }
}
