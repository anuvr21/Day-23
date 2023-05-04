using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word:");
            string s =Console.ReadLine();
            Console.WriteLine("Enter second word:");
            string snew = Console.ReadLine();
            string result=s.Concatenate(snew);
            Console.WriteLine(result);
        }
    }
}
