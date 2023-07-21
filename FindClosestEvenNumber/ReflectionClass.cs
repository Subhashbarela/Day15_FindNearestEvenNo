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
        public ReflectionClass()
        {
            
        }
        Type type = typeof(EvenOddNumber);
        public void FetchDataOfEvenClass()
        {      

            Console.WriteLine("Class Name is : "+type.Name);
            Console.WriteLine("Full Name is : "+type.FullName);
            Console.WriteLine("NameSpace  is : "+type.Namespace);
            MethodInfo[] m= type.GetMethods();
            foreach(MethodInfo m2 in m)
            {
                Console.WriteLine("Return Type: "+m2.ReturnType+" Attributs: "+m2.Attributes);
            }
        }
        public void FetchConstructor()
        {
            ConstructorInfo[] c= type.GetConstructors();
            foreach(ConstructorInfo c2 in c)
            {
                Console.WriteLine("Declaration type: "+c2.DeclaringType+" Name: "+c2.Name);
            }
        }
    }
}
