using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class ClassDemo
    {
        public ClassDemo(int rollno, string name, string course, int fees,int Rfees)
        {
            Rollno = rollno;
            Name = name;
            this.course = course;
            this.fees = fees;
            this.Rfess = Rfess;
        }
    
        public int Rollno { get; set; } 
        public string Name { get; set; }    
        public string course { get; set; }
        public int fees { get; set; }
        public int Rfess { get; set; }  
        public void Display()
        {
            Console.WriteLine(Rollno);
            Console.WriteLine(Name);
            Console.WriteLine(course);
            Console.WriteLine(fees);
            Console.WriteLine(Rfess);

        }
    }

}