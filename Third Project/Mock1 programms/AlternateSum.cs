using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Mock1_programms
{
    internal class AlternateSum
    {
        static void Main(string[] args)
        {
            int[] array = { 4,10,2,7,6,5};
             for(int i=0; i<array.Length-2; i++)
             {
                array[i] = array[i] + array[i+2];
                Console.WriteLine(array[i]);
             }

        }
    }
}
