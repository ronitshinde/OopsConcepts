using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class ReferenceType
    {
        public void AddReferenceType(ref int num)
        {
            num = num * num;
            Console.WriteLine("Num : " + num);
        }
    }
}

