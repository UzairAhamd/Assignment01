using System;
using System.Collections.Generic;
namespace UzairAhmadA1Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            //input the list length
            Console.WriteLine("Enter List Lenght: ");
            int len = Convert.ToInt32(Console.ReadLine());
            // get the list elements one by one via loop
            Console.WriteLine("Enter " + len + " Numbers one by one: ");
            int i = 1;
            List<int> enteredList = new List<int>();
            while (i <= len)
            {
                enteredList.Add(Convert.ToInt32(Console.ReadLine()));
                i++;
            }
            //Call the funciton and output the result
            Console.WriteLine("Odd position numbers are: ");
            OddPos(enteredList);
        }
        //make funciton to get list elements on odd positions
        public static void OddPos(List<int> getList)
        {
            for (int a = 0; a< getList.Count; a = a + 1)
            {
                //check if index is even or odd
                if (a % 2 != 0) { Console.WriteLine(getList[a]); }
            }
        }
    }
}
