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
            Console.WriteLine("1:Find Closest Even \n2: Describe type Infomartion");
            Console.WriteLine("Enter the choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        EvenOddNumber evenOdd = new EvenOddNumber();
                        int[] arr = { 8, 10, 12, 16, 18, 22, 24, 26, 28, };
                        evenOdd.FindEven(arr);
                        break;
                    }
                case 2:
                    {
                        ReflectionClass reflection = new ReflectionClass();
                        reflection.FetchDataOfEvenClass();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please insert valid input");
                        break;
                    }
            }


        }
    }
}
