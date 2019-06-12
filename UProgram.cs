using System;
using System.Collections.Generic;


namespace csreview
{
    class UProgram
    {
        public string name="University Program"; 
        private static int instances = 0;        
    
        public UProgram()
        {
            instances = instances + 1;
        }
    }

}