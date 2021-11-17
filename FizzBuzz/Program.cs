using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stack = new List<string>();
            int FirstB = -1;
            
            for(int i = 1; i < 101; i++)
            {
                stack.Clear();
                if (i % 3 == 0)
                {
                    stack.Add("Fizz");
                }

                if (i % 5 == 0)
                {
                    stack.Add("Buzz");
                }

                if (i % 7 == 0)
                {
                    stack.Add("Bang");
                }

                if (i % 11 == 0)
                {
                    stack.Clear();
                    stack.Add("Bong");
                }
                
                if (stack.Count != 0)
                {
                    string tempString = "";
                    foreach (string item in stack)
                    {
                        tempString += item;
                    }
                    Console.WriteLine(tempString);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}