using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Collections_Implement
{
    internal class StrArraylist
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("sanjana");
            list.Add("Esha");
            list.Add("Angha");
            Console.WriteLine("capacity  "+list.Capacity);
            Console.WriteLine("count  " + list.Count);
            Console.WriteLine("******************************");

            StringBuilder stringbuilder = new StringBuilder("Hii all");
            stringbuilder.Append("morning");
            stringbuilder.EnsureCapacity(50);
           // stringbuilder.Remove(1,2);
           // Console.WriteLine(stringbuilder);
            Console.WriteLine("Capacity =" + stringbuilder.Capacity);
        }
    }
}
