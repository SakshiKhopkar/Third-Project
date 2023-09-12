using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Third_Project.string2;

namespace Third_Project.Generic_Assignments
{
    internal class RemoveDuplicate
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5,2,4};
            List<int> list = new List<int>();
            list.AddRange(array);
            for(int i=0; i<list.Count; i++)
            {
                int count = 1;
                bool isvisited=false;
                for(int k=i-1; k>=0; k--)
                {
                    if (list[k] == list[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited==false)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        if (list[i] == list[j])
                        {
                            count++;
                        }
                       
                    }
                   if (count > 1)
                    {        
                        list.Remove(list[i]);
                    }

                }
                
              
            }
            Console.WriteLine("element after removing");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }




        }
    }
}
