using System;

namespace CSharpIntermediate
{
    class Student
    {
        public string name {get;set;}
        public static int instances {get;set;}
        public Student(string _name)
        {
            instances = instances +1;
            this.name = _name;
        }
    }
}