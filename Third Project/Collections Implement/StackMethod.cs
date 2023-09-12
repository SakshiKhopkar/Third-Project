using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Collections_Implement
{
    internal class StackMethod
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Top element " + stack.Peek());//Peek() -- returns the top element in the stack
        }

    }
}
