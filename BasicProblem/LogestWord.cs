using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class LogestWord
    {
        public void Word()
        {
            Console.WriteLine("Enter A One Sentences");
            string Str = Console.ReadLine();    
            string[] words = Str.Split(' ');
            string LongestWord = "";
            foreach(string s in words)
            {
                if(s.Length > LongestWord.Length)
                {
                    LongestWord = s;
                }
            }
            Console.WriteLine(LongestWord);
        }
    }
}
