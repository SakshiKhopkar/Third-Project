using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Mock1_programms
{
    internal class unqueFromArray
    {
        //2.There are 2 arrays of numbers. Find java program to find number in first array which is not in second array.
        static void Main(string[] args)
        {
            int[] array = { 5, 77, 6, 7, 8, 55 };
            int[] array2 = { 6, 5, 4, 7, 8};
           
            for(int i=0;i<array.Length;i++)
            {
                bool same = false;
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array[i] == array2[j])
                    {
                        same = true;
                        break;
                    }
                }
                if (same == false)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
