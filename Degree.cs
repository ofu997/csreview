using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    class Degree
    {
        public string name {get;set;}

        public string type {get;set;}
        // new List<T>(); is required
        public List<Course> courses = new List<Course>();
        public int instances;

        public Degree(string name, string type)
        {
            this.name = name;
            this.type = type;
            instances = instances +1;
        }

        public List<Course> addCourse (Course course){
            courses.Add(course);
            return courses;
        }
    }
}