using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.string2
{
    internal class DuplicateWord
    { //15.	Write a C# program to find the duplicate words and their number of occurrences in a string
        static void Main(string[] args)
        {
            string msg = "hello all";
            char[] chars = msg.ToCharArray();
            for (int i=0; i<chars.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int k=i-1; k>=0; k--)
                {
                    if (chars[k] == chars[i])
                    {
                      isvisited = true;
                        break;
                    }

                }
                if (isvisited==false)
                {
                    for (int j = i + 1; j < chars.Length; j++)
                    {
                        if (chars[j] == chars[i])
                        {
                             count++;
                        }
                    }
                    if (count > 1)
                    {
                        Console.WriteLine(count + "times" + chars[i]);
                    }
                }

            }
        }
    }
}
