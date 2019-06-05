using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Color="white";
            myCar.Year=2007;
            myCar.Mileage=123492;
            // Console.WriteLine("Hello World!");            
            // Output to the console window
            Console.WriteLine($"This car is painted {myCar.Color}, was built in {myCar.Year}, and has {myCar.Mileage} miles on it.");
        }
    }

    class Car{
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
    }
}
