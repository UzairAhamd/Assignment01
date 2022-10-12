using System;

namespace UzairAhmad_A1Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            //create for loop to iterate through rows
            for (int i = 1; i <= 5; i++)
            { 
                //itrate through columns
                for (int j =1; j <=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
