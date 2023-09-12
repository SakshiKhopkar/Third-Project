using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.string2
{
    internal class TogleString
    {
        static void Main(string[] args)
        {
            string msg = "Hello world";
            char[] chars = msg.ToCharArray();
            string str = "";
            for(int i=0; i<chars.Length; i++)
            {
                if (chars[i] >= 'a'&& chars[i]<='z' )
                {
                    int a = (int)(chars[i] - 32);
                    chars[i] = (char)a;
              
                }
              else if (chars[i] >= 'A' && chars[i] <= 'Z')
               {
                    int A = (int)(chars[i] + 32);
                    chars[i] = (char)A;
               }
                
             
            }
            str= new string(chars);
            Console.WriteLine(str);

        }
    }
}
