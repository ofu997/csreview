using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    class Prime
    {
        // If it is greater than 1 and cannot be written as the product of two smaller natural numbers
        public static Boolean DetermineIfPrime() 
        {
            Console.WriteLine("\n\nTest if a number is prime (greater than 1, and not the product of two smaller natural numbers).");
            String answer=Console.ReadLine();
            int intAnswer=int.Parse(answer);
            List<int> factors = new List<int>();
            bool greaterThanOne = intAnswer > 1? true: false; 
            // note: numbers less than 1 won't run here 
            for (int i = 1; i < intAnswer; i++){
                if(intAnswer % i == 0){
                    factors.Add(i);
                }
            }
            bool isPrime; 
            Console.WriteLine("greater than 1: {0}", greaterThanOne);
            Console.WriteLine("number of factors smaller than {0}: {1}", intAnswer, factors.Count);
            factors.ForEach(i => Console.Write("factor: {0}\t", i));
            Console.WriteLine("\nPrime?");
            // if not prime
            if ( factors.Count > 1 || intAnswer <= 1 ){
                isPrime=false; 
                Console.WriteLine("false");

                // return false;
            }
            // if prime
            else {
                isPrime=true; 
                Console.WriteLine("true");
                // return true;
            }
            return isPrime; 

        } // determine if prime

        public static void AskAgain()
        {
            bool askLoop = true;
            while (askLoop)
            {
                Console.WriteLine("Test another number?(y/n)");
                String testAgain = Console.ReadLine();
                if (testAgain == "y"){
                    askLoop = true;
                    // Console.WriteLine("Enter new number:");
                    // String answer2 = Console.ReadLine();
                    // Console.WriteLine("You picked {0}", answer2);    
                    Prime.DetermineIfPrime();
                }
                else if(testAgain == "n"){
                    askLoop=false;
                }
                else {
                    askLoop=false;
                }
            }   
        }

        private static void ListPrime()
        {
            Console.WriteLine("pick limit of primes");
            string limit = Console.ReadLine();
            int intLimit = int.Parse(limit);
            int top, bottom;
            
            for (top = 2; top < intLimit; top++) {
                // checks if top is divisible up to its square root
                for (bottom = 2; bottom <= (top / bottom); bottom++)
                    if ((top % bottom) == 0) 
                        break; // if factor found, not prime
                    if (bottom > (top / bottom)) 
                        Console.WriteLine("{0} is prime", top);
            }
        }     
        static int simpleArraySum(int[] ar) {
            int sum = 0;
            foreach(int item in ar)
            {  
                sum += item; 
            }
            return sum; 
        }      
    } // class Prime
} //namespace