using System;

namespace Exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz!");

            for (int a = 1; a < 101; a = a + 1) {
                FizzBuzz(a);
             }
        }

        public static void FizzBuzz(int args) 
        {
            if (args % 15 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (args % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (args % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine($"{args}");
            }
        }

    }
}
