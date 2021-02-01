using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        private static int instances = 0;

        // if we have constructors WITH parameters, we also need one without
        // public Car(){}

        public Car (string color, int year)
        {
            this.Color = color;
            this.Year = year; 
            instances++;
        }

        public Car (int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage; 
            instances++;
            // Console.WriteLine($"There are {Car.CountCars()} cars (2 params)");            
        }


        public Car()
        {
            instances++;
            // Console.WriteLine($"There are {Car.CountCars()} cars");
        }

        public static int CountCars()
        {
            return instances;
        }

        public static void createCar()
        {
          var car = new Automobile("ndf8709h");
        }
    }    
}
