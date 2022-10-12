using System;

namespace UzairAhmadA1Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            //input the number
            Console.WriteLine("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            //call funciton and output the result
            Console.WriteLine("Is "+number+" Prime: "+ IsPrime(number));
        }
        //IsPrime would check if a number is a prime number or not
        public static bool IsPrime(int checkNumber)
        {
            bool check = true;
            for(int i=2;i<=checkNumber/2;i++)
            {
                //check whether the number is divisible by any other number than itself and number 1
                if(checkNumber%i==0)
                {
                    check = false;
                    return check;
                }
            }
            return check;
        }
    }
}
