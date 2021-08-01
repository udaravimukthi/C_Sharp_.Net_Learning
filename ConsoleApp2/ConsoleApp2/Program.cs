using System;

namespace ConsoleApp2
{
    class Program
    {
        static Worker wrkr = new Worker();
        static void Main(string[] args)
        {
            int returnResult= wrkr.Add(5, 6);
            Console.WriteLine(returnResult);
            Console.ReadLine();

            CheckIF();
            CheckSwitch();
            CheckWhile();
            CheckFor();
        }

        static void CheckIF()
        {

            int x = 12;
            string name = "Udara";

            if (x > 10)
            {
                Console.WriteLine("X is geater than 10");
                Console.ReadLine();
            }
            else if (name == "Udara")
            {
                Console.WriteLine("Hi Udara");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("less than 10");
                Console.ReadLine();
            }
        }

        static void CheckSwitch()
        {
            int x = 10;
            switch (x)
            {
                case 10:
                    Console.WriteLine("x is 10");
                    break;
                case 20:
                    Console.WriteLine("x is 20");
                    break;
                default:
                    Console.WriteLine(x);
                    break;
            }
        }

        static void CheckWhile()
        {
            string name = "my name is udara";
            int count = 0;

            while (count <= 10)
            {
                Console.WriteLine(name);
                count++;
            }
            Console.ReadLine();
        }

        static void CheckFor()
        {
            string nm = "uv";

            for(int i=0; i<10; i++)
            {
                Console.WriteLine(nm);
            }
            Console.ReadLine();


        }
    }
}
