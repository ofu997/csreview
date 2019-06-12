using System;

namespace csreview
{
    class Program
    {
        static void Main(string[] args)
        {
        // Instantiate a UProgram object called Information Technology.
        UProgram informationTechnology = new UProgram("Information Technology");
        // informationTechnology.name = "learn";
        string itName = informationTechnology.name;
        Console.WriteLine("name of program: {0}", itName);
        int instanceProgram = UProgram.instances;
        Console.WriteLine("instances: {0}", instanceProgram);
        // Instantiate three Student objects.
        // Instantiate a Course object called Programming with C#.
        // Add your three students to this Course object.
        // Instantiate at least one Teacher object.
        // Add that Teacher object to your Course object.
        // Instantiate a Degree object, such as Bachelor.
        // Add your Course object to the Degree object.
        // Instantiate a UProgram object called Information Technology.
        // Add the Degree object to the UProgram object.
        // Using Console.WriteLine statements, output the following information to the console window:
        // The name of the program and the degree it contains
        // The name of the course in the degree
        // The count of the number of students in the course.
            // var myCar = new Car();
            // myCar.Color="white";
            // myCar.Year=2007;
            // myCar.Mileage=123492;
            // // Output to the console window
            // // Console.WriteLine($"This car is painted {myCar.Color}, was built in {myCar.Year}, and has {myCar.Mileage} miles on it.");
            // var secondCar = new Car("Red", 2008);
            // int carCount = Car.CountCars();
            // Console.WriteLine($"There are {carCount} cars on inventory now.");
        }
    }



}
