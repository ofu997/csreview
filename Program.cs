using System;
using System.Collections.Generic;
using System.Threading;
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
            // Instantiate three Student objects.
            Student student1 = new Student("Abbi");
            Student student2 = new Student("Blake");
            Student student3 = new Student("Cari");
            Console.WriteLine("student names: {0}, {1}, {2}", student1.name, student2.name, student3.name);

            // Instantiate a Course object called Programming with C#.
            Course cSharpCourse = new Course("Programming with C#");
            Console.WriteLine("New course name: {0}", cSharpCourse.name);
            Thread.Sleep(2000);
            Console.WriteLine("Number of courses: {0}", Course.instances);
            Course cyberSec = new Course("Cybersecurity");
            Thread.Sleep(2000);
            Console.WriteLine("New course name: {0}", cyberSec.name);
            Thread.Sleep(2000);
            Console.WriteLine("Number of courses: {0}", Course.instances);
            Course computerArch = new Course("Computer Architecture");
            Thread.Sleep(2000);
            Console.WriteLine("New course name: {0}", computerArch.name);
            Thread.Sleep(2000);
            Console.WriteLine("Number of courses: {0}", Course.instances);
            // Add your three students to this Course object.
            cSharpCourse.AddStudent(student1);
            cSharpCourse.AddStudent(student2);
            cSharpCourse.AddStudent(student3);

            Console.WriteLine("students in C# course: ");
            foreach(Student s in cSharpCourse.studentList){
                Console.WriteLine("{0}\t", s.name);
            };
            Thread.Sleep(2000);
            // Instantiate at least one Teacher object.
            Teacher teacher1 = new Teacher("Mr. Robotik", 14);
            // Add that Teacher object to your Course object.
            cSharpCourse.teacher = teacher1;
            Console.WriteLine("C# teacher: {0}", cSharpCourse.teacher.name);
            Thread.Sleep(2000);
            Console.WriteLine("C# teacher grade level: {0}", cSharpCourse.teacher.gradeLevel);
            Thread.Sleep(2000);
            // Instantiate a Degree object, such as Bachelor.
            Degree myDegree = new Degree("Computer Science", "Bachelor of Science");
            Degree secondDegree = new Degree("System Administration", "Bachelor of Science");
            // Add your Course object to the Degree object.
            myDegree.addCourse(cSharpCourse);
            myDegree.addCourse(computerArch);
            Console.WriteLine("\n\nCourses in {0}:", myDegree.name);
            foreach(Course c in myDegree.courses){
                Console.WriteLine("{0}\t", c.name);
            }
            Thread.Sleep(2000);
            // Add a Course object to the Degree object.
            Course networkEng = new Course("Network Engineering");
            secondDegree.addCourse(cyberSec);
            secondDegree.addCourse(networkEng);
            Console.WriteLine("\n\nCourses in {0}:", secondDegree.name);
            foreach(Course c in secondDegree.courses){
                Console.WriteLine("{0}\t", c.name);
            }
            // Add the Degree object to the UProgram object.
            informationTechnology.AddDegree(myDegree);
            informationTechnology.AddDegree(secondDegree);
            // Using Console.WriteLine statements, output the following information to the console window:
            // The name of the program and the degree(s) it contains
            Console.WriteLine("\n\n {0} degrees: \t", informationTechnology.name);
            Thread.Sleep(2000);
            foreach(Degree degree in informationTechnology.degrees)
            {
                Console.WriteLine("{0}\t", degree.name);
            }
            Thread.Sleep(2000);
            // The name of the course(s) in the degree(s)
            Console.WriteLine("\n\nCourses in degrees:");
            foreach(Degree degree in informationTechnology.degrees)
            {
                foreach(Course c in degree.courses)
                {
                    Console.WriteLine("{0}: {1}\t", degree.name, c.name);
                }
            }
            Thread.Sleep(2000);
            // The count of the number of students in the course.
            Student student4 = new Student("Cardi"); 
            Student student5 = new Student("Brad");
            Student student6 = new Student("Ellen");
            cyberSec.AddStudent(student4);
            computerArch.AddStudent(student5);
            computerArch.AddStudent(student6);
            networkEng.AddStudent(student1);
            networkEng.AddStudent(student4);
            foreach(Degree degree in informationTechnology.degrees)
            {
                Console.WriteLine("\n\n\nDEGREE: {0}", degree.name);
                foreach(Course course in degree.courses)
                {
                    Console.WriteLine("{0} number of students: {1}",course.name, course.studentList.Count);
                    foreach(Student student in course.studentList)
                    {
                        Console.WriteLine("{0}", student.name);
                    }
                }
            }
            Thread.Sleep(2000);
            Console.WriteLine("\n\nTest if a number is prime (greater than 1, and not the product of two smaller natural numbers).");
            String answer = Console.ReadLine();
            Console.WriteLine("You picked {0}", answer);
            Console.WriteLine(
                Prime.DetermineIfPrime(
                    int.Parse(answer)
                )
            );
            bool askLoop = true;
            while (askLoop)
            {
                Console.WriteLine("Test another number?(y/n)");
                String testAgain = Console.ReadLine();
                if (testAgain == "y"){
                    askLoop = true;
                    Console.WriteLine("Enter new number:");
                    String answer2 = Console.ReadLine();
                    Console.WriteLine("You picked {0}", answer2);    
                    Console.WriteLine(
                        Prime.DetermineIfPrime(
                            int.Parse(answer2)
                        )
                    );
                }
                else if(testAgain == "n"){
                    askLoop=false;
                }
                else {
                    askLoop=false;
                }
            }
            Console.WriteLine("Which nth number of the Fibonacci sequence do you want to see?");
            String fibInput=Console.ReadLine();
            Fibonacci.FibCalculate(int.Parse(fibInput));
        } // main
    } // Program
} // namespace
