using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project
{
    internal class PrimeFromArray
    {
        static void Main(string[] args)
        {
            {
                int[] array = new int[5];
                Console.WriteLine("enter element in array");
                for (int i=0; i<array.Length; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("prime number are");
                for (int i = 0; i < array.Length; i++)
                {
                    bool isprime = true;
                    for (int j = 2; j < array[i]-1; j++)
                    {
                        if (array[i] % j == 0)
                        {
                            isprime = false;
                            break;
                        }
                    }
                    if (isprime == true)
                    {
                       Console.WriteLine(array[i]);
                    }
                    
                    
                }
                
            }
        }
    }
}
