using System;
using System.Collections.Generic;

namespace csreview{
    class Prime
    {
        public static bool DetermineIfPrime(int value) 
        {
            List<int> factors = new List<int>();
            // if (value == 1)
            // {
            //     return false;
            // }
            // if (value == 2)
            // {
            //     return true;
            // }
            for (int i=1; i<=value; i++){
                if(value % i == 0){
                    factors.Add(i);
                }
            }
            if (factors.Count>2 || factors.Count==1){
                if(factors.Count>2)
                {
                    factors.RemoveAt(factors.Count-1);
                    factors.RemoveAt(0);
                    for(var i=0; i < factors.Count; i++){
                        Console.WriteLine("factor: {0}",factors[i]);
                    }
                }
                return false;
            }
            return true;
        }

    }


}