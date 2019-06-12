using System;

namespace csreview
{
    class Student
    {
        public string name {get;set;}
        private static int instances {get;set;}
        public Student()
        {
            instances = instances +1;
        }
    }
}