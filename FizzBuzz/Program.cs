using System;

namespace Exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SharpBuzz!");

            for (int a = 1; a < 101; a = a + 1) {
                SharpBuzz(a);
             }
        }

        public static void SharpBuzz(int args) 
        {
            if (args % 15 == 0)
            {
                Console.WriteLine("SharpBuzz");
            }
            else if (args % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (args % 3 == 0)
            {
                Console.WriteLine("Sharp");
            }
            else
            {
                Console.WriteLine($"{args}");
            }
        }

    }
}
