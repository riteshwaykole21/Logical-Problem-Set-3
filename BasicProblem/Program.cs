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
            Console.WriteLine("4 : The Sum Last Two Lowest Positive Number");
            Console.WriteLine("5 : Odd Number From 1 To 99");
            Console.WriteLine("6 : Prime Number Program");
            Console.WriteLine("7 : Sum Of Digit Number");
            Console.WriteLine("8 : Class Demo Problem");
            Console.WriteLine("Enter A Option Number");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
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
                case 4:
                    SumOfLowestNo sum = new SumOfLowestNo();
                    int[] Arr = { 19, 5, 42, 2, 77 };
                    int[] Arr1 = { 10, 343445353, 3453445, 34535453 };
                    int[] Arr2 = {2, 9, 6, -1 };
                    sum.Number(Arr);
                    sum.Number(Arr1);
                    sum.Number(Arr2);
                    break;
                case 5:
                    OddNumber odd = new OddNumber();
                    odd.Numbers();
                    break;
                case 6:
                    PrimeNumber prime = new PrimeNumber();
                    prime.Numbers();
                    break;
                case 7:
                    SumOfDigit sumOfDigit = new SumOfDigit();
                    sumOfDigit.Numbers();
                    break;
                case 8:
                    ClassDemo demo = new ClassDemo(12, "Ritesh", ".Net", 2000,1000);
                    demo.Display();
                    break;
            }
            Console.ReadLine();
        }
    }
}
