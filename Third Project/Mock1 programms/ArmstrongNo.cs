using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Mock1_programms
{
    internal class ArmstrongNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no");
            int no=Convert.ToInt32(Console.ReadLine());
            int temp = no;
            int count = 0;
            int original = temp;
            int sum = 0;
            int power = 1;
            while (no > 0)
            {
                count++;
               no= no / 10;
            }
            while (temp > 0)
            {
                int rem= temp % 10;
                for(int i = 1; i <= count; i++)
                {
                    power =power*rem;
                }
                sum= sum + power;
                power = 1;
                temp= temp / 10;
            }
            if (sum == original)
            {
                Console.WriteLine("armstrong");
            }
            else
            {
                Console.WriteLine("not Armstrong");
            }
        }
    }
}
