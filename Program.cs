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
                Console.WriteLine("Fibonacci, prime, or school program?(f/p/s)");
                string answer = Console.ReadLine();
                switch(answer)
                {
                    case "f":
                    {
                        Fibonacci.FibCalculate();
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
                    default :
                    {
                        break;
                    }
                }
                Console.WriteLine("another round?");
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
