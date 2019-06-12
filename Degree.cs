using System;
using System.Collections.Generic;

namespace csreview
{
    class Degree
    {
        public string name {get;set;}

        public string type {get;set;}
        public List<Course> courses;
        public int instances;

        public Degree(string name, string type)
        {
            name = this.name;
            type = this.type;
            instances = instances +1;
        }
    }
}