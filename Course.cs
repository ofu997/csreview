using System;
using System.Collections.Generic;
// using csreview.Student;

namespace csreview
{
    class Course
    {
        public string name;
        public List<Student> studentList = new List<Student>();
        public Teacher teacher;
        public static int instances=0;

        public Course(string name)
        {
            this.name = name;
            instances = instances +1;
        }

        public List<Student> AddStudent(Student _student)
        {
            studentList.Add(_student);
            return studentList;
        }
    }
}