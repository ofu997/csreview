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
        Student student1 = new Student("Abbi");
        Student student2 = new Student("Blake");
        Student student3 = new Student("Cari");
        Console.WriteLine("student names: {0}, {1}, {2}", student1.name, student2.name, student3.name);

        // Instantiate a Course object called Programming with C#.
        Course cSharpCourse = new Course("Programming with C#");
        Console.WriteLine("course name: {0}", cSharpCourse.name);
        // Add your three students to this Course object.
        cSharpCourse.AddStudent(student1);
        cSharpCourse.AddStudent(student2);
        cSharpCourse.AddStudent(student3);

        Console.WriteLine("students in C# course: ");
        foreach(Student i in cSharpCourse.studentList){
            Console.WriteLine("{0}\t", i.name);
        };
        // Instantiate at least one Teacher object.
        Teacher teacher1 = new Teacher("Mr. Robotik");
        // Add that Teacher object to your Course object.
        cSharpCourse.teacher = teacher1;
        Console.WriteLine("C# teacher: {0}", cSharpCourse.teacher.name);
        // Instantiate a Degree object, such as Bachelor.
        Degree myDegree = new Degree("Computer Science", "Bachelor of Science");
        // Add your Course object to the Degree object.
        myDegree.addCourse(cSharpCourse);
        foreach(Course c in myDegree.courses){
            Console.WriteLine("Courses in myDegree: {0}\t", c.name);
        }
        // Instantiate a UProgram object called Information Technology.
        // Add the Degree object to the UProgram object.//
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
