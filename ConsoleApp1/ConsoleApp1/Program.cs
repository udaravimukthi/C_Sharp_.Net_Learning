using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print(); 
            int returnResult= Add(5, 6);
            Console.WriteLine(returnResult);
            Console.ReadLine();
            
        }

        static void Print()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
}
