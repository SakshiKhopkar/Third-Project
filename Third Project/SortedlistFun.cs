using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project
{
    internal class SortedlistFun
    {
        //Implement dept id , dept name using SortedList
        static void Main(string[] args)
        {
            SortedList list = new SortedList();
            list.Add(5, "Science");
            list.Add(3, "sales");
            list.Add(2, "Employee");
            list.Add(1, "Manager");

            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}
