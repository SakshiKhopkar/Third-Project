using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project
{
    internal class GenericClasses
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Remove(1);
            list1.Insert(1, 66);
            list1.AddRange(list1);
            list1.Sort();
            list1.RemoveAt(0);
            list1.RemoveRange(1, 3);
            Console.WriteLine("Total count"+list1.Count);
            Stack<int> stack1 = new Stack<int>();    
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            Queue<string> strQue= new Queue<string>();
            strQue.Enqueue("hello");
            strQue.Enqueue("Hii");
            strQue.Dequeue();
            foreach (int i in list1)
            {
                Console.WriteLine("list is "+i);
            }
            foreach (int i in stack1)
            {
                Console.WriteLine("stack is "+i);
            }
            foreach(string i in strQue)
            {
                Console.WriteLine("Queue is "+i);
            }

            Dictionary<string,string> dictionary = new Dictionary<string,string>();
            dictionary.Add(".doc", "document file");
            dictionary.Add(".xls", "Exel flie");
            dictionary.Add(".cs", "C# file");
            dictionary.Remove(".xls");
            foreach (KeyValuePair<string,string> item in dictionary)
            {
                Console.WriteLine($"key{item.Key}-{item.Value}");
            }
            Dictionary<int,string> dictionary2 = new Dictionary<int,string>();
            dictionary2.Add(102, "sales");
            dictionary2.Add(103, "manager");
            dictionary2.Add(104, "senior manager");
            foreach(KeyValuePair<int,string> item in dictionary2)
            {
                Console.WriteLine($"{item.Key}-{item.Value}");
            }
            Dictionary<int,string> dic = new Dictionary<int,string>();
            dic.Add(01, "us");
            dic.Add(91, "India");
            foreach(KeyValuePair<int,string> item in dic)
            {
                Console.WriteLine($"{item.Key}-{item.Value}");
            }

        }
    }
}
