using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csreview
{
    class UProgram
    {
        public string name {get;set;}
        public static int instances = 0;        
        public List<Degree> degrees = new List<Degree>();
        public int numberOfStudents=Student.instances;
        public UProgram(string _name)
        {
            // can't be name = this.name. Should be: this.name = name;
            name = _name;
            instances = instances + 1;
        }

        public List<Degree> AddDegree(Degree degree)
        {
            degrees.Add(degree);
            return degrees;
        }
    }

}