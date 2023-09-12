using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.stringbuilder
{
    internal class StringbuilderFun
    {
        static void Main(string[] args)
        {
            StringBuilder stringbuilder = new StringBuilder("Hello to all");
            Console.WriteLine(stringbuilder);
            stringbuilder.Append("good morning");
            Console.WriteLine(stringbuilder);
            stringbuilder.Remove(4, 5);
            Console.WriteLine(stringbuilder);
            stringbuilder.Replace('l', 'L');
            Console.WriteLine(stringbuilder);
            stringbuilder.Replace("all", "everyone");
            Console.WriteLine(stringbuilder);
            Console.WriteLine("capacity ="+stringbuilder.Capacity);
            stringbuilder.Clear();
            Console.WriteLine(stringbuilder);
        }
    }
}
