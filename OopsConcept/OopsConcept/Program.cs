using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClassName name = new ClassName();
            name.PrintName();
            name.PrintType("Csharp");
            Constructor nonParameterised = new Constructor();
            Constructor parameterised = new Constructor("Phoenix", 07, 'R');
            Constructor withParameters = new Constructor(7,4);
            Constructor withPara = new Constructor("Seven","Eight","Nine");
            Constructor withBoolValue = new Constructor(true,77);
            //It will hold the screen until the key is pressed.
            Console.ReadKey();
        }
    }
}
