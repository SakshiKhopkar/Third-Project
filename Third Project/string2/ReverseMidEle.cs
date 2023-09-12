using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.string2
{
    public class ReverseMidEle
    {
        static void Main(string[] args)
        {
            string st = "Hello Sakshi";
            string str = "";
            string[] s=st.Split(' ');
            string str2 = "";
            Console.WriteLine("original string  "+st);
            for (int i=s.Length-1; i>=0; i--)
            {
                   
               str2 = str2 + " " + s[i];
                
            }
            Console.WriteLine(" ");
            Console.WriteLine("string after reverse  "+str2);
        }

    }


}







