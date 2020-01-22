using System;
using System.Collections.Generic;

namespace csreview{
    class Prime
    {
        // If it is greater than 1 and cannot be written as the product of two smaller natural numbers
        public static Boolean DetermineIfPrime(int value) 
        {
            List<int> factors = new List<int>();
            bool greaterThanOne = value > 1? true: false; 
            // note: numbers less than 1 won't run here 
            for (int i = 1; i < value; i++){
                if(value % i == 0){
                    factors.Add(i);
                }
            }
            Console.WriteLine("greater than 1: {0}", greaterThanOne);
            Console.WriteLine("number of factors smaller than {0}: {1}", value, factors.Count);
            factors.ForEach(i => Console.Write("factor: {0}\t", i));
            Console.WriteLine("\nPrime?");
            // if not prime
            if ( factors.Count > 1 || value <= 1 ){
                return false;
            }
            // if prime
            else {
                return true;
            }
        } // determine if prime
    } // class Prime
} //namespace