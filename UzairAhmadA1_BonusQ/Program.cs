using System;

namespace UzairAhmadA1_BonusQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //get a string from user
            Console.WriteLine("Enter string:");
            string word = Console.ReadLine();
            //call functino and output the result
            CheckPlanidrome(word);
        }
        //write funtion to check if the given word is a palindrome
        public static void CheckPlanidrome(string getWord)
        {
            bool check = false;
            // run loop till the half of the length of the string
            for (int i = 0; i < getWord.Length / 2; i++)
            {
                //check alphabets moving from outer to inner of the string
                if (getWord[i] != getWord[getWord.Length - 1 - i])
                {
                    check = false;
                    break;
                }
                else
                {
                    check = true;
                }
            }
            //after having the check convey the appropriate result
            if (check ==false)
            {
                Console.WriteLine("Given Word " + getWord + " isn't a palindrome");
            }
            else
            {
                Console.WriteLine("Given Word " + getWord + " is a palindrome");
            }
        }

    }
}
