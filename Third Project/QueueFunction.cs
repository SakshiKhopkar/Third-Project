﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project
{
    internal class QueueFunction
    {
        static void Main(string[] args)
        {
           Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Dequeue();
            Console.WriteLine("First element "+queue.Peek());
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
