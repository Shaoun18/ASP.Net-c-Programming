using System;

namespace Input_collect.App
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your first Num : ");
            int n1 = Convert.ToInt32(Console.ReadLine()); // intput  collect the user

            Console.Write("Enter your Second Num : ");
            int n2 = Convert.ToInt32(Console.ReadLine()); // intput  collect the user

            int result = n1 + n2;
            Console.WriteLine("The result is : " + result);

            Console.ReadKey();


        }
    }
}
