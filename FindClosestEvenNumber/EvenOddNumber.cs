using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindClosestEvenNumber
{
    public class EvenOddNumber
    {
        int[] arr;
        public EvenOddNumber(int[] arr)
        {
            this.arr = arr;
        }
        public void FindEven()
        {
            Console.WriteLine("Enter the number that you want find Closest Even");
            int Murli = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (Murli <= arr[i])
                {
                    if (arr[i] % 2 == 0)
                    {
                        Console.WriteLine(arr[i]);
                    }
                    else
                    {
                        Console.WriteLine(arr[i] + 1);
                    }
                    break;
                }
            }
        }
    }
}
