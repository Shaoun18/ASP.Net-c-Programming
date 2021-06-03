using System;
using System.Collections;

namespace Array.App
{
    class Program
    {
        static void Main(string[] args)
        {

            //String name = "shaoun";

            //String[] names = new string[5];
            //names[0] = "Alif";
            //names[1] = "Rama";
            //names[2] = "Ratan";

            //String aname = names[2];
            //Console.WriteLine("Her name is : " +  aname);
            //Console.ReadKey();

            //int notables = 10;
            //int[] numberlist = new int[4];

            //numberlist[0] = 13;
            //numberlist[1] = 65;
            //numberlist[2] = 98;

            //int anumber = numberlist[1];
            //Console.WriteLine("Her number is : " + anumber);
            //Console.ReadKey();

            //double salary = 45000.000;
            //double[] salaries = new double[5];

            //salaries[0] = 13000.00;
            //salaries[1] = 65000.00;
            //salaries[2] = 9800.66;

            //double asalary = salaries[1];
            //Console.WriteLine("Her salary is : " + asalary);
            //Console.ReadKey();



            //int size = 10;

            //int[] numbers = new int[size];

            //for(int i = 1; i <= size; i++)
            //{
            //    numbers[i-1] = i;
            //    Console.WriteLine(numbers);
            //}
            //Console.ReadKey();


            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(123);
            myArrayList.Add("abc");
            myArrayList.Add(123.52);
            myArrayList.Add("A");

            Console.WriteLine(myArrayList.Count);
            Console.WriteLine(myArrayList.Contains(123.52));
            foreach(var data in myArrayList)
            {
                Console.WriteLine(data);

            }

            myArrayList.Remove(123);
            Console.WriteLine(myArrayList.Count);
            foreach (var data in myArrayList)
            {
                Console.WriteLine(data);

            }
            myArrayList.RemoveAt(0);
            Console.WriteLine(myArrayList.Count);

            Console.ReadKey();
        }
    }
}
