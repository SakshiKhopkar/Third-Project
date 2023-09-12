using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Mock1_programms
{
    internal class SortArray
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 2, 7, 1, 4, 8, 3 };
            for(int i=0;i<array.Length;i++)
            {
                for(int j = i+1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                         int temp = array[i];
                         array[i] = array[j];
                         array[j] = temp;
                    }
                }
            }
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
