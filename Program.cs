using System;

namespace csreview
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Color="white";
            myCar.Year=2007;
            myCar.Mileage=123492;
            // Output to the console window
            // Console.WriteLine($"This car is painted {myCar.Color}, was built in {myCar.Year}, and has {myCar.Mileage} miles on it.");
            var secondCar = new Car("Red", 2008);
            int carCount = Car.CountCars();
            Console.WriteLine($"There are {carCount} cars on inventory now.");
        }
    }

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
    }

}
