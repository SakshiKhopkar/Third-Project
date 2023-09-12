using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Assignment2Array
{
    internal class MaxArrayEle
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'c', 'r', 'm' };
            char m = ch[0];
            char n= ch[0];
            for(int i=0; i<ch.Length; i++)
            {
                if (ch[i] > m)
                {
                    m= ch[i];
                }
                if (ch[i] < n)
                {
                    n= ch[i];
                }
            }
            Console.WriteLine("maximum character "+m);
            Console.WriteLine("minimum character "+n);
        }
    }
}
