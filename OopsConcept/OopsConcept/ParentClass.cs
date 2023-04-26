using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    //Inheritance is totally dependent on derived class and base class /child or parent class.
    //We are using colon : 
    public class ParentClass : BaseClass
    {
        public ParentClass()
        {
            Console.WriteLine("This is my Parent class");

        }
        public void Class()
        {
            Console.WriteLine("This is my method for parent class");
        }
    }
    public class BaseClass
    {
        public string name;
        public void TestName()
        {
            Console.WriteLine("This is a base class");
        }
    }
}


