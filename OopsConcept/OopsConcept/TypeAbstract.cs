using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    //It will show the essential features and hide the complex data from user.
    //It will achieve with the help of abstract class and abstract method.
    //Abstract class.
    public abstract class TypeAbstract
    {
        //Firstly use abstract keyword to create the abstract class.
        //We cannot create the object for the abstract class.
        //Abstract and Non-Abstract methods are present in the abstract class. 
        public abstract void AbstractMethod(); //This is abstract method and does not contain any body.
        public void NonAbstractMethod() //This is the regular method/non-abstract method.
        {
            Console.WriteLine("This is non abstract method");
        }

    }
}
