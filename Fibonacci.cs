using System;

namespace csreview
{
    class Fibonacci
    {
        public static void FibCalculate()
        {
            Console.WriteLine("Which nth number of the Fibonacci sequence do you want to see?");
            String fibInput=Console.ReadLine();
            int first = 0;
            int second = 1; 
            for (var i=0; i<int.Parse(fibInput)-2; i++)
            {
                int next = first + second; 
                Console.WriteLine("{0},{1},{2}", first, second, next.ToString());
                first = second;
                second = next; 
            }
        }
    }
}