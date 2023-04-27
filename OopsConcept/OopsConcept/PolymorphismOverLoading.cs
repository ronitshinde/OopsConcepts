using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    //Polymorphism means many form and there are two types of polymorphism
    //1.Run time Polymorphism --> Method OverRiding
    //2.Compile Type PolyMorphism --> Method OverLoading
    public class PolymorphismOverLoading
    {
        //Compile Time => It Contains many functions or methods with different parameters
        public void MethodOne()
        {
            Console.WriteLine("without parameter");
        }
        public void MethodOne(int num)
        {
            Console.WriteLine($"With one parameter : Num = {num} ");
        }
        public void MethodOne(int num, string str)
        {
            Console.WriteLine($"With two parameter : Num = {num} , String = {str} ");
        }
        public void MethodOne(string str, int num)
        {
            Console.WriteLine($"With two parameter : String = {str} , Num = {num} ");
        }
        public void MethodOne(string str, string name)
        {
            Console.WriteLine($"With two parameter : String = {str} , String = {name}");
        }
    }
}



