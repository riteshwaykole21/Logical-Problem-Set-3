using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : Return True");
            Console.WriteLine("2 : To Convert Sentences Into Lower Case");
            Console.WriteLine("3 : Longest Word In The Sentences");
            Console.WriteLine("Enter A Option Number");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    ReturnTrue returnTrue = new ReturnTrue();
                    returnTrue.Numbers();
                    break;
                case 2:
                    LowerCase low = new LowerCase();
                    low.Result();
                    break;
                case 3:
                    LogestWord word = new LogestWord();
                    word.Word();
                    break;
            }
            Console.ReadLine();
        }
    }
}
