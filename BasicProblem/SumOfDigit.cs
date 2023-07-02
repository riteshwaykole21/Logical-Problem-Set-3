using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class SumOfDigit
    {
        public void Numbers()
        {
            Console.WriteLine("Enter A Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Sum = 0;
            int rem = 0;
            int Div = 0;
            rem = Number % 10;
            Div = Number / 10;
            Sum = rem + Div;
            Console.WriteLine($"The Sum Of Digits Is = {Sum}");
        }
    }
}
