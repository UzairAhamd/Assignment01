using System;
using System.Collections.Generic;
namespace UzairAhmadA1Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the list elements one by one
            Console.WriteLine("Enter the list elements one by one:");
            bool totalVal = true;
            List<int> enteredList = new List<int>();
            //run the loop to get the maximum number a user want in the list
            while (totalVal == true)
            {
                enteredList.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("you want to add more numbers? (y/n)");
                string intent = Console.ReadLine();
                //check if the user want to enter more numbers in the list
                if (intent == "n")
                {
                    totalVal = false;
                }
                else
                {
                    Console.WriteLine("Enter next number: ");
                }
            }
            //get the number you want to find in the list
            Console.WriteLine("Enter Element you want to find: ");
            int elem = Convert.ToInt32(Console.ReadLine());
            // call the function to get the output
            CheckElement(enteredList,elem);

        }
        //make funciton to check if the entered number is in the list or not
        public static void CheckElement(List<int> getList, int getElem)
        {
            int check = 0;
            for (int i = 0; i < getList.Count; i++)
            {
                //check the number is presemt int the list by comparing
                if (getElem == getList[i])
                {
                    Console.WriteLine(getElem + " is present in the list!");
                    check = check + 1;
                    break;
                }
            }
            if (check == 0)
            {
                Console.WriteLine(getElem + " is not present in the list!");
            }
        }
    }
}
