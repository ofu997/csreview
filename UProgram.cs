using System;
using System.Collections.Generic;


namespace csreview
{
    class UProgram
    {
        public string name;
        private static int instances = 0;        
        public List<Degree> degrees;
        public int numberOfStudents=Student.instances;
        public UProgram()
        {
            instances = instances + 1;
        }
    }

}