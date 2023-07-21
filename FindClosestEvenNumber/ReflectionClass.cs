using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FindClosestEvenNumber
{
    public class ReflectionClass
    {
        public void FetchDataOfEvenClass()
        {      

            Type type = typeof(EvenOddNumber);
            Console.WriteLine("Class Name is : "+type.Name);
            Console.WriteLine("Full Name is : "+type.FullName);
            Console.WriteLine("NameSpace  is : "+type.Namespace);
            MethodInfo[] m= type.GetMethods();
            foreach(MethodInfo m2 in m)
            {
                Console.WriteLine("Return Type: "+m2.ReturnType+" Attributs: "+m2.Attributes);
            }
        }
    }
}
