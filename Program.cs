﻿using System;
using System.Collections; 
using System.Collections.Generic;
using System.Threading;
namespace CSharpIntermediate
{
    class Program
    {
      static void Main(string[] args)
      {
        AbstractShape.createAbstract();
      }

      static void boxingExamples()
      {
        // boxing 
        int number = 10;
        object obj = number;

        // unboxing
        object obj2 = 10;
        int number2 = (int) obj; 

        var list = new ArrayList();
        // Add takes object. Adding value type like 1 causes 'boxing', which has a performance penalty
        list.Add(1);
        // string type is a reference, doesn't cause 'boxing'
        list.Add("me");
        // structure is a value type, causes 'boxing' 
        list.Add(DateTime.Today);

        // can't cast
        var number3 = (int) list[1];

        var anotherList = new List<int>();
        var names = new List<string>();
        names.Add("nn"); 
      }

      static void castingUpAndDownExamples()
      {
        Writing writing = new Writing();
        // Upcasting example. 
        Shape shape = writing; 

        writing.Width = 200; 
        shape.Width = 100; 
        // 100
        System.Console.WriteLine(writing.Width);

        // Downcasting example
        // shape2 is of type Writing
        Shape shape2 = new Writing();
        // convert shape2 to type Writing
        Writing writing2 = (Writing) shape2; 
      }

      static void createCar()
      {
        var car = new Automobile("ndf8709h");
        
      }

      static void createText()
      {
        var myText = new Text();
        myText.Width = 100;
        myText.Copy();
      }

      static void createPost()
      {
        var myPost = new Post();
        bool loop = true;
        while (loop)
        {
          System.Console.WriteLine("Enter upvote, downvote, seevote, or end");
          string answer = Console.ReadLine();
          switch(answer)
          {
            case "upvote":
            {
              myPost.Upvote();
              break;
            }
            case "downvote":
            {
              myPost.Downvote();
              break;
            }

            case "seevote":
            {
              myPost.Seevotes();
              break;
            }
            case "end":
            {
              loop = false;
              break;
            }
            default :
            {
              break;
            }
          }
        }
      }

      static void makeStopwatch()
      {
        var myStopwatch = new Stopwatch();
        myStopwatch.Start();
        System.Console.WriteLine("type stop to stop or restart to restart.");
        string answer = Console.ReadLine();
        if (answer == "stop")
        {
          myStopwatch.Stop();
        }
        if (answer == "restart")
        {
          myStopwatch.Start();
        }
      }

      static void createCookie()
      {
        var cookie = new HttpCookie();
        cookie["name"] = "Cookie";
        System.Console.WriteLine(cookie["name"]);
      }

      static void createPerson()
      {
        var myPerson = new Person(new DateTime (1933, 1,22));
        // myPerson.Birthdate = new DateTime(1933, 1, 22);h
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
