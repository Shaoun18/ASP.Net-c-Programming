using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();

            myList.Add("BITM");
            myList.Add("Tech");
            myList.Add("Basis");
            myList.Add("Nero");

            Console.WriteLine("Last Size Previous : " + myList.Count);


            List<string> newList = new List<string>();

            myList.Add("A");
            myList.Add("B");
            myList.Add("C");
            myList.Add("D");
            myList.AddRange(newList);

            Console.WriteLine("New Size : " + myList.Count);
            myList[0] = "BD";

            foreach (string data in myList)
            {
                Console.WriteLine(data);
            }
            
        }
    }
}
