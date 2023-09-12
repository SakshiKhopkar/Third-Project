using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Collections_Implement
{
    internal class ArraylistMethod
    {
        static void Main(string[] args)
        {
            int[] arr=new int[] {67,45,12};
            ArrayList list = new ArrayList();
         
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.AddRange(arr);
            list.Insert(1, 5);
            list.Sort();
            list.Reverse();
            Console.WriteLine("Count (total element) " + list.Count);
            Console.WriteLine("Capacity " + list.Capacity);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
