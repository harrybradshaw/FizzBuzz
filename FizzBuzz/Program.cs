using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stack = new List<string>();
            int firstB = -1;
            
            Console.WriteLine("How much FizzBuzzing do you want?");
            string input = Console.ReadLine();
            int intMaxIndex = 0;
            Int32.TryParse(input, out intMaxIndex);

            static int RegisterFirst(int firstB, int n)
            {
                if (firstB == -1)
                {
                    firstB = n;
                }

                return firstB;
            }

            static int ModifyStack(List<string> oldStack, int i, int n, int firstB = -1)
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
                            firstB = RegisterFirst(firstB,oldStack.Count);
                            break;
                        case 7:
                            oldStack.Add("Bang");
                            firstB = RegisterFirst(firstB,oldStack.Count);
                            break;
                        case 11:
                            oldStack.Clear();
                            oldStack.Add("Bong");
                            firstB = RegisterFirst(firstB,oldStack.Count);
                            break;
                        case 13:
                            if (firstB != -1)
                            {
                                oldStack.Insert(firstB-1,"Fezz");
                            }
                            else
                            {
                                oldStack.Add("Fezz");
                            }
                            break;
                        case 17:
                            oldStack.Reverse();
                            break;
                    }
                }
                return firstB;
            }

            for(int i = 1; i < intMaxIndex; i++)
            {
                stack.Clear();
                firstB = ModifyStack(stack, i, 3);
                firstB = ModifyStack(stack, i, 5, firstB);
                firstB = ModifyStack(stack, i, 7, firstB);
                firstB = ModifyStack(stack, i, 11, firstB);
                firstB = ModifyStack(stack, i, 13, firstB);
                firstB = ModifyStack(stack, i, 17);
                
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