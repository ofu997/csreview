using System;
using System.Collections.Generic;

namespace csreview
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a UProgram object called Information Technology.
            UProgram informationTechnology = new UProgram("Information Technology");
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
            Course cyberSec = new Course("Cybersecurity");
            // Add your three students to this Course object.
            cSharpCourse.AddStudent(student1);
            cSharpCourse.AddStudent(student2);
            cSharpCourse.AddStudent(student3);

            Console.WriteLine("students in C# course: ");
            foreach(Student s in cSharpCourse.studentList){
                Console.WriteLine("{0}\t", s.name);
            };
            // Instantiate at least one Teacher object.
            Teacher teacher1 = new Teacher("Mr. Robotik");
            // Add that Teacher object to your Course object.
            cSharpCourse.teacher = teacher1;
            Console.WriteLine("C# teacher: {0}", cSharpCourse.teacher.name);
            // Instantiate a Degree object, such as Bachelor.
            Degree myDegree = new Degree("Computer Science", "Bachelor of Science");
            Degree secondDegree = new Degree("System Administration", "Bachelor of Science");
            // Add your Course object to the Degree object.
            myDegree.addCourse(cSharpCourse);
            Console.WriteLine("Courses in {0}", myDegree.name);
            foreach(Course c in myDegree.courses){
                Console.WriteLine("{0}\t", c.name);
            }
            secondDegree.addCourse(cyberSec);
            // Add the Degree object to the UProgram object.
            informationTechnology.AddDegree(myDegree);
            informationTechnology.AddDegree(secondDegree);
            // Using Console.WriteLine statements, output the following information to the console window:
            // The name of the program and the degree(s) it contains
            Console.WriteLine(informationTechnology.name + " degrees: \t");
            foreach(Degree degree in informationTechnology.degrees)
            {
                Console.WriteLine("{0}\t", degree.name);
            }
            // The name of the course(s) in the degree(s)
            Console.WriteLine("courses in degrees:");
            foreach(Degree degree in informationTechnology.degrees)
            {
                foreach(Course c in degree.courses)
                {
                    Console.WriteLine("{0}: {1}\t", degree.name, c.name);
                }
            }

            // The count of the number of students in the course.
            foreach(Degree degree in informationTechnology.degrees)
            {
                foreach(Course c in degree.courses)
                {
                    Console.WriteLine("{0}: {1}",c.name, c.studentList.Count);
                }
            }
            
            bool isPos=false;
            while(isPos==false)
            {
                Console.WriteLine("Now for something unrelated: test if a number is prime");
                String answer = Console.ReadLine();
                if(int.Parse(answer)>0)
                {
                    isPos=true;
                    Console.WriteLine(
                        Prime.DetermineIfPrime(
                            int.Parse(answer)
                        )
                    );
                }
            }
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
