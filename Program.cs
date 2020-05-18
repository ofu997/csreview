using System;
using System.Collections.Generic;
using System.Threading;
namespace csreview
{
    class Program
    {
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
                    case "bubblesort":
                    {
                        BubbleSort.SortBubble();
                        break;
                    }
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
        } // main
    } // Program
} // namespace
