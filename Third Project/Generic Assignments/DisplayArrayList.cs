using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Generic_Assignments
{
    internal class DisplayArrayList
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            List<int> list = new List<int>();
            list.AddRange(array);
            list.Add(44);
            list.Add(54);
            for(int i=0; i<list.Count; i++)
            {
                Console.WriteLine(" element in list " + list[i]);
            }
        }
    }
}
