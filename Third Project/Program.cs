using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringbuilder=new StringBuilder("hello to all");
            Console.WriteLine(stringbuilder);
            Console.WriteLine(stringbuilder.GetHashCode());
            Console.WriteLine(stringbuilder.Append("Good Morning"));
            Console.WriteLine(stringbuilder.GetHashCode());

        }
    }
}
