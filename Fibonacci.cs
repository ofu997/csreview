using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class FibonacciSequence
    {

        public static List<int> sequence = new List<int>(); 

        public static int Fibonacci()
        {
            int a = 0;
            int b = 1;

            Console.WriteLine("How many fibonucci numbers?");
            string fibString = Console.ReadLine();            
            int n =int.Parse(fibString);

            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    sequence.Add(a);
                }
                else // 2nd number and beyond
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                    sequence.Add(a);
                }
            }
            return a;
        }
    }

    class Fibonacci
    {
        public static void FibCalculate()
        {
            Console.WriteLine("Which nth number of the Fibonacci sequence do you want to see?");
            String fibInput=Console.ReadLine();
            int nthnumber=int.Parse(fibInput);
            int first = 0;
            int second = 1; 
            if(nthnumber==1)
            {
                Console.WriteLine("0");
            }
            else if (nthnumber==2)
            {
                Console.WriteLine("1");
            }
            for (var i=3; i<=nthnumber; i++)
            {
                int next = first + second; 
                Console.WriteLine("{0}", next.ToString());
                first = second;
                second = next; 
            }
        }

        public static int FibRecursive()
        {
        int result; 
		//int first = 0;
		//int second = 1; 
		//if (x==1)
		//{
		//	Console.WriteLine("0");
		//}
		//else if (x==2)
		//{
		//	Console.WriteLine("1");
		//}
		//for (var i=0; i<x-2; i++)
		//{
		//	int next = first + second; 
		//	Console.WriteLine(next.ToString());
		//	first = second;
		//	second = next; 
		//}
        Console.WriteLine("Which nth number of the Fibonacci sequence do you want to see?");
        String fibInput=Console.ReadLine();
        int x=int.Parse(fibInput);
        result=FibRecursiveCalclate(x);
        return result;
        }
        public static int FibRecursiveCalclate(int x)
        {
            if (x==1)
            {
                return 0; 
            }
            else if (x==2)
            {
                return 1;
            }
            else 
            // Console.WriteLine(
            //     (FibRecursiveCalclate(x-2)+FibRecursiveCalclate(x-1))
            //     .ToString()
            //     );
            return FibRecursiveCalclate(x-2)+FibRecursiveCalclate(x-1);
        }
    }
}