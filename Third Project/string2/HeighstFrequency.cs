using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.string2
{
    internal class HeighstFrequency
    {
        static void Main(string[] args)
        {
            //12.Write a C# program to find highest frequency character in a string
            string str = "hello all of you";
            int[] charcount = new int[256];
            int length=str.Length;
            for(int i = 0; i < length; i++)
            {
                 charcount[str[i]]++;
               // Console.WriteLine("charcount[str[i]]" + str[i]+" " + charcount[str[i]]);
            }
            int maxcount = -1;
            char character =' ';
            for(int i = 0; i < length; i++)
            {
                if (charcount[str[i]] > maxcount)
                {
                    maxcount = charcount[str[i]];
                    character = str[i];
                }
            }
            Console.WriteLine(" original string "+str);
            Console.WriteLine("Heighst numbered character "+character);
            Console.WriteLine("count of charcter is " + maxcount);

        }
    }
}
