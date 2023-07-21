using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindClosestEvenNumber
{
    public class EvenOddNumber
    {
        public void FindEven()
        {
            Console.WriteLine("Enter the number that you want find Closest Even");
            int Murli=int.Parse(Console.ReadLine());
            if(Murli%2==0 )
            {
                Console.WriteLine(Murli);
            }
            else
            {
                Console.WriteLine(Murli+1);
            }
        }
    }
}
