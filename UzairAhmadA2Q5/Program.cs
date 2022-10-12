using System;
using System.Collections.Generic;
using System.Drawing;

namespace UzairAhmadA2Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter List: ");
            List<int> enterList = new List<int>();
            bool checkList = false;
            int k = 1;
            while (checkList == false)
            {
                Console.Write("Enter Element " + k + " :");
                enterList.Add(Convert.ToInt32(Console.ReadLine()));
                k++;
                Console.Write("Do you want to enter more elements? (y/n): ");
                string checkResponse = Console.ReadLine();
                if (checkResponse == "n")
                {
                    checkList = true;
                }
            }
            for (int i = enterList.Count - 1; i >= 0; i--)
            {
                int counter = 0;
                if (i == 0)
                {
                    if (enterList[i] != enterList[i + 1])
                    {
                        counter++;
                    }
                }
                else if (enterList[i] != enterList[i - 1])
                {
                    for (int j = enterList.Count - 1; j >= 0; j--)
                    {

                        if (enterList[i] == enterList[j])
                        {
                            counter++;
                        }
                    }
                }
                else
                {
                    continue;
                }
                Console.WriteLine(enterList[i] + " : " + counter);
            }
        }
    }
}