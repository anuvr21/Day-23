﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            bool result = i.isGreaterThan(100);
            Console.WriteLine(result);
        }
    }
}
