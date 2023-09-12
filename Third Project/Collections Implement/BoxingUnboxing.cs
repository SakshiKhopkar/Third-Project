using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Collections_Implement
{
    internal class BoxingUnboxing
    {
        static void Main(string[] args)
        {
            ArrayList array= new ArrayList();
            array.Add(1);
            array.Add(2.5);  //Boxing is implicite
            array.Add("sanjana");
            //unboxing 
            // unboxing is Explicite
            double d = Convert.ToDouble(array[1]);
            Console.WriteLine(d);
            string s = Convert.ToString(array[2]);
            Console.WriteLine(s);
            

        }
    }
}
