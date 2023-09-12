using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.string2
{
    internal class Toggleto_string
    {
        static void Main(string[] args)
        {
            string msg = "Hello all";
            char[] chars = msg.ToCharArray();
            string str = "";
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >=65 && chars[i]<= 90)
                {
                   int a = (int)chars[i]+32;
                    chars[i]= (char)a;
                     
                }
                else
                {
                    int A = (int)chars[i]-32;
                    chars[i]= (char)A;
                }
                 str=new string(chars);
               
            }
            Console.WriteLine(str);
        }
    }
}
