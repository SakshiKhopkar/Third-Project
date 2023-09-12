using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project
{
    internal class HashtableFun
    {
        static void Main(string[] args)
        {
            //Implement country code & country name using Hashtable
            Hashtable ht = new Hashtable();
            ht.Add(91 ,"India");
            ht.Add(1, "US");
            ht.Add(52, "Mexico");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}
