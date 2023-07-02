using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class PrimeNumber
    {
        public void Numbers()
        {
            int count = 0;
            int Sum = 0;
            for (int num = 2;count < 500 ; num++)
            {
                int a = 0;
                for (int i = 2; i < num; i++)
                {
                    if(num % i == 0)
                    {
                        a++;
                        break;
                    }
                }
                if(a == 0)
                {
                    count++;
                    Sum += num;
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine($"\n The sum Of All Prime Number {Sum}");
        }
    }
}
