using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Mock1_programms
{
    internal class CreateMaxNoUsingArray
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 8, 7, 4, 2, 3 };
            int num = 0;
            for(int i=0; i<array.Length; i++)
            {
                for(int j=0;j<array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach(int i in array)
            {
                 num =num*10+ i;
            }
            Console.WriteLine(num);
        }
    }
}
