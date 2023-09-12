using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Mock1_programms
{
    //3.	Find first non-repeating letter in the  given string.  

    internal class NonRepeatingLetterInString
    {
        static void Main(string[] args)
        {
            string str = "My name is eshani ";
            str.ToLower();
            char[] ch= str.ToCharArray();
            for(int i=0; i < ch.Length; i++)
            {
                bool same = false;
                for(int j=i+1; j<str.Length; j++)
                {
                    if (ch[i] ==str[j])
                    {
                        same = true;
                        break;
                    }
                }
                if (same == false)
                {
                    Console.WriteLine(ch[i]);
                    break;
                }
            }
        }
    }
}
