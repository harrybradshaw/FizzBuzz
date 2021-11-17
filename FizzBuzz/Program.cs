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

            static List<string> ModifyStack(List<string> oldStack, int i,int n)
            {
                if (i % n == 0)
                {
                    switch (n)
                    {
                        case 3:
                            oldStack.Add("Fizz");
                            break;
                        case 5:
                            oldStack.Add("Buzz");
                            break;
                        case 7:
                            oldStack.Add("Bang");
                            break;
                        case 11:
                            oldStack.Clear();
                            oldStack.Add("Bong");
                            break;
                    }
                }
                return oldStack;
            }

            for(int i = 1; i < 101; i++)
            {
                stack.Clear();
                ModifyStack(stack, i, 3);
                ModifyStack(stack, i, 5);
                ModifyStack(stack, i, 7);
                ModifyStack(stack, i, 11);
                
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