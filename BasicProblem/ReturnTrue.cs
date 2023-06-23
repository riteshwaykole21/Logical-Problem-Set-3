using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class ReturnTrue
    {
        public void Numbers()
        {
            Console.WriteLine("Enter First Number");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Second Number");
            int Second = Convert.ToInt32(Console.ReadLine());   
            if(First == 20)
            {
                Console.WriteLine(true);
            }
            else if(Second == 20)
            {
                Console.WriteLine(true);
            }
            else if(First + Second == 20)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false );
            }
        }
    }
}
