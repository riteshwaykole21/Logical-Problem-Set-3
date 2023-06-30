using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class LowerCase
    {
        public void Result()
        {
            Console.WriteLine("Enter Your Full Name");
            string Name = Console.ReadLine();
            Console.WriteLine(Name.ToLower());
        }
    }
}
