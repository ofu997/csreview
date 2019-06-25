using System;
using System.Collections.Generic;

namespace csreview
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
            name = this.name;
            type = this.type;
            instances = instances +1;
        }

        public List<Course> addCourse (Course course){
            courses.Add(course);
            return courses;
        }
    }
}