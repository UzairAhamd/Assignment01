using System;
using System.Collections.Generic;
namespace UzairAhmadA1Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the list elements one by one:");
            bool totalVal = true;
            List<int> enteredList = new List<int>();
            while (totalVal == true)
            {
                enteredList.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("you want to add more numbers? (y/n)");
                string intent = Console.ReadLine();
                if (intent == "n")
                {
                    totalVal = false;
                }
                else
                {
                    Console.WriteLine("Enter next number: ");
                }
            }
            Console.WriteLine("Enter Element you want to find: ");
            int elem = Convert.ToInt32(Console.ReadLine());
//            CheckElement(enteredList,elem);
            Console.ReadLine();
        }
        //public static void CheckElement(List<int> getList, int getElem)
        //{
        //    int check = 0;
        //    for (int i = 1; i < getList.Count; i++)
        //    {
        //        if (getElem == getList[i])
        //        {
        //            Console.WriteLine(getElem + " is present in the list!");
        //            check = check + 1;
        //            break;
        //        }
        //    }
        //    if (check == 0)
        //    {
        //        Console.WriteLine(getElem + " is not present in the list!");
        //    }
        //}
    }
}
