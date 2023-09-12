using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Third_Project.string2;

namespace Third_Project.Mock1_programms
{
    internal class NotesAmount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the amount");
            int amt = Convert.ToInt32(Console.ReadLine());
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;
            int count7 = 0;
            while (amt > 0)
            {
                if (amt >= 1000)
                {
                    amt = amt - 1000;
                    count1++;
                }
                if(amt < 1000 && amt>=500)
                {
                    amt = amt - 500;
                    count2++;  
                }
                if(amt<500 && amt >= 200)
                {
                    amt = amt - 200;
                    count3++;
                }
                if(amt<200 && amt >= 100)
                {
                    amt = amt -100;
                    count4++;
                }
                if(amt<100 && amt >= 50)
                {
                    amt = amt - 50;
                    count5++;
                }
                if (amt<50 && amt >= 20)
                {
                    amt = amt - 20;
                    count6++;
                }
                if((amt<20 && amt >= 10))
                {
                    amt = amt - 10;
                    count7++;
                }
            }
            Console.WriteLine($"1000 is {count1}\n 500 is {count2}\n 200 is {count3}\n100 is{count4}\n50 is {count5}\n20 is {count6} \n10 is {count7}");

        }
    }
}
