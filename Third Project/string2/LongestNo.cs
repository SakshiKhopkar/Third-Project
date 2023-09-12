using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.string2
{
    internal class LongestNo
    {//18.	WAP to find longest word in the given sentence
        static void Main(string[] args)
        {
            string str1 = "Indians is the best";
            string[] str2 = str1.Split(' ');
            char[] ch1 = str2[0].ToCharArray();
            char[] ch2 = str2[1].ToCharArray();
            char[] ch3 = str2[2].ToCharArray();
            int maxlength=ch1.Length;
            string longesrword = "";
            foreach(string word in str2)
            {
                if( word.Length >= maxlength)
                {
                    longesrword = word;
                }
            }
            Console.WriteLine("longest word in string is "+longesrword);
/*            for (int i = 0; i < str2.Length; i++)
            {
                if (str2[i].Length > maxlength)
                {
                    maxlength = str2[i].Length;
                    
                }
            }
            Console.WriteLine("max length of word is "+maxlength);*/
        }
    }
}
