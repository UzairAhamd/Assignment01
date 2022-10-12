using System;

namespace UzairAhmadA1Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            //enter the number
            Console.WriteLine("Enter the Number: ");
            int numb = Convert.ToInt32(Console.ReadLine());
            // call the funciton and print the result
            checkEvenOdd(numb);
        }
        //make the funciton to check if the number is even or odd
        public static void checkEvenOdd(int getNumb)
        {
            //check the evenness of the number 
            if (getNumb % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}
