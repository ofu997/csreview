using System;
using System.Collections.Generic;
// using csreview.Student;

namespace csreview
{
    class Course
    {
        public string name;
        public List<Student> studentList;
        public string teacher;
        public static int instances=0;

        public Course(string name, List<Student> studentList)
        {

            instances = instances +1;
        }
    }
}