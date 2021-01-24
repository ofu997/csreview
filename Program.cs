using System;
using System.Collections.Generic;
using System.Threading;
namespace CSharpIntermediate
{
    class Program
    {
      static void Main(string[] args)
      {
        createPerson();
      }

      static void createPerson()
      {
        var myPerson = new Person();
        myPerson.Birthdate = new DateTime(1933, 1, 22);
        System.Console.WriteLine(myPerson.Age);
      }

      static void personWithAccessModifiers()
      {
        var person = new PersonWithManualGetterAndSetter();
        person.SetBirthdate(new DateTime(1982, 1, 1));
        System.Console.WriteLine(person.GetBirthdate());
      }

      static void createCustomer()
      {
        // create an object with an object initializer 
        // (creates an object without the need to call a constructor)
        var myCustomer = new Customer { Id=3, Name="Francine" };

        Console.WriteLine(myCustomer.Name);
      }

      static void useParams()
      {
        // var calculator = new Calculator();
        Console.WriteLine(Calculator.Add(1,2,3,4));   
      }

      static void UsePoints()
      {
        try
        {
          var point = new Point(10, 20);
          point.Move(new Point(40, 60));
          Console.WriteLine("point is at ({0}, {1})", point.X, point.Y);
        }
        catch (Exception)
        {
          System.Console.WriteLine("An unexpected error occurred.");
        }
      }

      /*
      from object oriented programming course
      static void Main(string[] args)
      {
          bool playagain=true;
          while(playagain)
          {
              Console.WriteLine("Fibonacci, prime, school, garbage collection, or interface program?(f/p/s/i/gc)");
              string answer = Console.ReadLine();
              switch(answer)
              {
                  case "f":
                  {
                      int result=Fibonacci.FibRecursive();
                      Console.WriteLine(result.ToString());
                      break;
                  }
                  case "s":
                  {
                      School.MakeSchool(); 
                      break;
                  }
                  case "p":
                  {
                      Prime.DetermineIfPrime();
                      Prime.AskAgain();
                      break;
                  }
                  case "i":
                  {
                      ImplementInterface.EmployeeSimulation();
                      break; 
                  }
                  case "gc":
                  {
                      GarbageCollector.CollectGarbage(); 
                      break;
                  }
                  // case "bsort":
                  // {
                  //     Algos.SortBubble();
                  //     break;
                  // }
                  // case "isort":
                  // {
                  //     Algos.InsertionSort();
                  //     break; 
                  // }
                  default :
                  {
                      break;
                  }
              }
              Console.WriteLine("another round? (y/n)");
              string playagainanswer=Console.ReadLine();
              if(playagainanswer=="y")
              {
                  playagain=true;
              }
              else
              {
                  playagain=false; 
              }
          }
      } // main */
    } // Program
} // namespace
