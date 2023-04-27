using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    //Type casting is used to assign a value of one data type to other data type.
    //There are two types of type casting 1-Implicit and 2-Explicit.
    //Implicit : Automatically converting small type to large type.
    //char -> int -> long -> float -> double
    //Explicit : It should be manually.
    //Reverse of the implicit convert large to small.
    //double -> float -> long -> int -> char
    public class TypeCasting
    {
        public void Casting()
        {
            //This is implicit casting/Automatically converts small to large type.
            int value = 10;
            double doubleValue = value;
            Console.WriteLine(value);
            Console.WriteLine($"Implicit conversion of integer {value} to double : " +doubleValue);
            //This is explicit casting/Manually convert large to small type.
            double number = 10.05;
            int integer =(int) number;
            Console.WriteLine($"Explicit conversion of double {number} to integer : " +integer);
        }
    }
}
