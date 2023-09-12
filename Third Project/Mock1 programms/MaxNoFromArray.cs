using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Mock1_programms
{
    internal class MaxNoFromArray
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 7, 3, 2, 4 };
            int maxno = array[0];
            for(int i=0; i<array.Length; i++)
            {
                if (array[i] > maxno)
                {
                    maxno= array[i];
                }
            }
            Console.WriteLine("maximum from array"+maxno);
        }
    }
}
