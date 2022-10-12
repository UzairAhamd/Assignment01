using System;

namespace UzairAhmadA1Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            //print * pattern using by multiple prints
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("*****");
            //print * pattern using for loop
            for (int i =1; i<=5; i++)
            {
                for (int j =1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
