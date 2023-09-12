using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.string2
{
    internal class countVowel
    {
        //9.Write a C# program to count total number of vowels and consonants in a string.
        static void Main(string[] args)
        {
            string message = "Hey Good Morning";
            char[] chars = message.ToCharArray();
            int count= 0;
            int tally = 0;
            for(int i=0; i<chars.Length; i++)
            {
                if (chars[i] =='a'|| chars[i]=='e'|| chars[i]=='i'|| chars[i] =='o'|| chars[i] == 'u' || chars[i] == 'A' || chars[i] == 'E' || chars[i] == 'I' || chars[i]=='O'|| chars[i]=='U')
                {
                    count++;
                }
                else
                {
                  tally++;
                }
            }
            Console.WriteLine("Total number of vowels  "+count);
            Console.WriteLine("Total number of Consonant  " + tally);
        }
    }
}
