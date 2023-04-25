using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class ClassName : InterfaceType
    {
        int Id = 10;
        int name = 15;
        //This is non-parameterised method.
        public void PrintName()
        {
            Console.WriteLine("Bridgelabz");
            Console.WriteLine(Id);
            Console.WriteLine(name);
        }
        //This is parameterised method.
        public void PrintType(string name)
        {
            Console.WriteLine(name);
        }
        public void WithoutImplementionMethod()
        {
            Console.WriteLine("This is classname.cs");
        }
    }
}
