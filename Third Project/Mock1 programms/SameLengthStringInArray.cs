using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Mock1_programms
{
    internal class SameLengthStringInArray
    {
        static void Main(string[] args)
        {
            string[] str = { "I" , "am" ,"very","smart"};
            for (int i=0; i<str.Length; i++)
            {
                while (str[i].Length<3)
                {
                    str[i] = str[i] + str[i];
                }
            }
        }
    }
}
