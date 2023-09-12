using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.string2
{
    internal class StringFinding
    {
        static void Main(string[] args)
        {
            string msg = "Hii 5all";
            char[] ch = msg.ToCharArray();
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            for(int i=0; i<ch.Length; i++)
            {
                if ((ch[i]>='a'&& ch[i] <= 'z') || (ch[i] >= 'A' && ch[i] <= 'Z'))
                {
                    count1++;
                }
                else if (ch[i] >='0' && ch[i] <= '9')
                {
                    count2++;
                }
                else
                {
                    count3++;
                }
            }
            Console.WriteLine("count of charcter "+count1);           
            Console.WriteLine("count of digit " + count2);
            Console.WriteLine("count of symbols " + count3);
        }
    }
}
