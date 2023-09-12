using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Generic_Assignments
{
    internal class HashsetFun
    {
        static void Main(string[] args)
        {
            HashSet<string> hashset = new HashSet<string>();
            hashset.Add("pune");
            hashset.Add("mumbai");
            hashset.Add("latue");
            hashset.Add("delhi");
            hashset.Add("sangli");
            hashset.Remove("sangli");
            hashset.Add("pune");
            
            foreach(string item in hashset) 
            {
                Console.WriteLine(item);
            } 
            HashSet<string> list1= new HashSet<string>();
            HashSet<string> list2 = new HashSet<string>();
            list1.Add("c");
            list1.Add("c++");
            list1.Add("c#");
            list1.Add("java");
            list2.Add("c");
            list2.Add("c++");
            list2.Add("c#");
            list2.Add("python");
            list1.UnionWith(list2);
            //list1.IntersectWith(list1);
            //list1.ExceptWith(list2);
            foreach(string item in list1)
            {
                Console.WriteLine(item);
            }
            foreach(string item in list2)
            {
                Console.WriteLine(item);
            }

        }
    }
}
