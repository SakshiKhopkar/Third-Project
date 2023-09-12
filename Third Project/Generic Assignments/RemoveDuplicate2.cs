using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Generic_Assignments
{
    internal class RemoveDuplicate2
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 2, 4 };
            List<int> list = new List<int>();
            for(int i=0;i<list.Count;i++)
            {
                for(int j = i + 1; j < list.Count; j++)
                {
                    if (array[i] == list[j])
                    {
                        list.Remove(list[j]);
                        j--;
                    }
                }
            }
            Console.WriteLine("element after removing");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

        }
    }
}
