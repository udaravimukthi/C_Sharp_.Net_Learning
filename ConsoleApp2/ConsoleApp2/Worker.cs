﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Worker
    {
        public void Print()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
}
