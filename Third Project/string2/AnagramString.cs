using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.string2
{
    internal class AnagramString
    {
        static void Main(string[] args)
        {
            string msg1 = "listen";
            string msg2 = "sblent";
            bool issame = true;
            msg1.ToLower();
            msg2.ToLower();
            char[] ch1= msg1.ToCharArray();
            char[] ch2= msg2.ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string str1=new string(ch1);
            string str2=new string(ch2);

            for (int i=0,j=0; i<str1.Length||j<str2.Length; i++,j++)
            {
                if (msg1.Length != msg2.Length)
                {
                    issame = false;
                    break;
                }
                if (str1 != str2)
                {
                   issame= false;
                } 
            }
            if (issame)
            {
                Console.WriteLine("string is anagram");
            }
            else
            {
                Console.WriteLine("string is not anagram");
            }
            
        }
    }
}
