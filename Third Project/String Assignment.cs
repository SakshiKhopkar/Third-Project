using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project
{
    internal class String_Assignment
    {//Accept email_id from user and check valid or not(should contain @,.)
        static void Main(string[] args)
        {
            string email = "sakshi@123gmail.com";
            char[] ch=email.ToCharArray();
            bool isvalid = false;
            for(int i=0; i<ch.Length; i++)
            {
                if (ch[i] =='@' || ch[i] == '.')
                {
                    isvalid = true;
                }
            }
            if(isvalid)
            {
                Console.WriteLine("email is valid");
            }
        }
    }
}
