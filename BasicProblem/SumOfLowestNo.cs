using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class SumOfLowestNo
    {
        public void Number(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if(Arr[i] > Arr[j])
                    {
                        int temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }               
            }
            int num = 0;
            foreach(int i in Arr)
            {
                num++;
                if(i >= 0)
                {
                    break;
                }
            }
            int Sum = Arr[num] + Arr[num - 1];
            Console.WriteLine(Sum);
        }
    }
}
