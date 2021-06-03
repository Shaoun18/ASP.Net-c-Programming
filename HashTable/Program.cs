using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hash salaryinfo = new Hash();
            salaryinfo.Add("Shaoun", 450000);
            salaryinfo.Add("Shaoun", 450000);
            salaryinfo.Add("Shaoun", 450000);

            Console.WriteLine("Employee ID Salary Amount");
            foreach (DictionaryEntry adictionaryEntry in salaryinfo) 
            {
                Console.WriteLine(adictionaryEntry.key + " " + adictionaryEntry.Entry);
            
            
            }
            foreach(string akey in salaryinfo.keys)
            {
                Console.WriteLine(akey);
            }
            Console.ReadKey();
            
        }
    }
}
