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

            static int RegisterFirst(int oldFirst,int n)
            {
                if (oldFirst == -1)
                {
                    return n;
                }
                else
                {
                    return oldFirst;
                }
            }

            static List<string> ModifyStack(List<string> oldStack, int i, int n, int firstB)
            {
                if (i % n == 0)
                {
                    switch (n)
                    {
                        case 3:
                            oldStack.Add("Fizz");
                            break;
                        case 5:
                            firstB = RegisterFirst(firstB,n);
                            oldStack.Add("Buzz");
                            break;
                        case 7:
                            firstB = RegisterFirst(firstB,n);
                            oldStack.Add("Bang");
                            break;
                        case 11:
                            firstB = RegisterFirst(firstB,n);
                            oldStack.Clear();
                            oldStack.Add("Bong");
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
                    }
                }
                return oldStack;
            }

            for(int i = 1; i < 201; i++)
            {
                stack.Clear();
                ModifyStack(stack, i, 3, firstB);
                ModifyStack(stack, i, 5, firstB);
                ModifyStack(stack, i, 7, firstB);
                ModifyStack(stack, i, 11, firstB);
                ModifyStack(stack, i, 13, firstB);
                
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