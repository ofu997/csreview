using System;
using System.Collections; 
using System.Collections.Generic;
using System.Threading;
namespace CSharpIntermediate
{
    class Program
    {
      static void Main(string[] args)
      {
        // static methods from Classes, Interfaces, Object-oriented couse
        
        // AbstractShape.createAbstract();
        // BoxingAndUnboxing.boxingExamples();
        // BoxingAndUnboxing.castingUpAndDownExamples();
        // Calculator.useParams();
        // Canvas.createShapes();
        // Car.createCar();
        // Customer.createCustomer();
        // HttpCookie.createCookie();
        // Person.createPerson();
        // PersonWithManualGetterAndSetter.personWithAccessModifiers();
        // Point.UsePoints();
        // Post.createPost();
        // Stack.stackMethods();
        // Stopwatch.makeStopwatch();
        // Text.createText();
        // VideoEncoder.createEncoder();
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
