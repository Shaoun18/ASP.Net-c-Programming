using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> mystack = new Stack<string>();
            mystack.Push("Bitm");
            mystack.Push("Basis");
            mystack.Push("NERD");
            mystack.Push("BD");

            foreach (string data in mystack)
            {
                Console.WriteLine(data);
            }

            Console.WriteLine(mystack.Count);
            mystack.Pop();
            Console.WriteLine(mystack.Count);
            foreach (string data in mystack)
            {
                Console.WriteLine(data);
            }

            Console.ReadKey();

        }
    }
}
