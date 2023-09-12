using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.string2
{
    internal class SwapingWithoutTemp
    {
        static void Main(string[] args)
        {//19.	How do you swap two string variables without using third or temp variable in C#
            string msg1 = "hello";
            string msg2 = "all";
            Console.WriteLine("before swap ");
            Console.WriteLine(msg1);
            Console.WriteLine(msg2);
            msg1=msg1 + msg2;
            msg2=msg1.Substring(0, msg1.Length-msg2.Length);
            msg1 = msg1.Substring(msg2.Length);
            Console.WriteLine("after swaping");
            Console.WriteLine(msg1);
            Console.WriteLine(msg2);
        }
    }
}
