using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("Bitm");
            myQueue.Enqueue("Basis");
            myQueue.Enqueue("NERD");
            myQueue.Enqueue("BD");

            foreach (string data in myQueue)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine(myQueue.Count);
            myQueue.Dequeue();
            Console.WriteLine(myQueue.Count);
            foreach (string data in myQueue)
            {
                Console.WriteLine(data);
            }

            Console.ReadKey();
        }
    }
}
