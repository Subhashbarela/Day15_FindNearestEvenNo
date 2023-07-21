using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindClosestEvenNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            EvenOddNumber evenOdd=new EvenOddNumber();
            int[] arr = { 8,10, 12,16, 18, 22, 24, 26, 28, };
            evenOdd.FindEven(arr);
        }
    }
}
