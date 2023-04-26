using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Program
    {
        const int value = 10;
        static void Main(string[] args)
        {
            ClassName name = new ClassName();
            //This is interface method
            name.WithoutImplementionMethod();
            Constructor parameter = new Constructor();
            parameter.WithoutImplementionMethod();
            //This is inherited class
            ParentClass parent = new ParentClass();
            Console.WriteLine(parent.name = "Ronit");
            parent.TestName();
            parent.Class();
            //This is Enum
            Console.WriteLine(Project.Surya);
            int count = (int)Project.Surya;
            Console.WriteLine(count);
            //This is parameterised and non parameterised method.
            name.PrintName();
            name.PrintType("Csharp");
            Constructor nonParameterised = new Constructor(name, 25, "David");
            Constructor parameterised = new Constructor("Phoenix", 07, 'R');
            Constructor withParameters = new Constructor(7, 4);
            Constructor withPara = new Constructor("Seven", "Eight", "Nine");
            Constructor withBoolValue = new Constructor(true, 77);
            //It will hold the screen until the key is pressed.
            Console.ReadKey();
        }
    }
}











