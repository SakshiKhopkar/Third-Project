using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Mock1_programms
{
    internal class ReverseNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int no = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            while(no > 0)
            {
                int rem = no % 10;
                rev = rev * 10 + rem;
                no = no / 10;
            }
            Console.WriteLine("reverse no ="+rev);
        }
    }
}
