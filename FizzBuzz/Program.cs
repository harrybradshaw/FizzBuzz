using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static string ComputeOutput(int i)
        {
            string tempString = "";
            List<string> stack = new List<string>();
            int firstB = -1;
            int[] nums = {3, 5, 7, 11, 13, 17};
            
            void UpdateFirst()
            {
                if (firstB == -1)
                {
                    firstB = stack.Count;
                }
            }
            
            void ModifyStack(int n)
            {
                if (i % n == 0)
                {
                    switch (n)
                    {
                        case 3:
                            stack.Add("Fizz");
                            break;
                        case 5:
                            stack.Add("Buzz");
                            UpdateFirst();
                            break;
                        case 7:
                            stack.Add("Bang");
                            UpdateFirst();
                            break;
                        case 11:
                            stack.Clear();
                            stack.Add("Bong");
                            UpdateFirst();
                            break;
                        case 13:
                            if (firstB != -1)
                            {
                                stack.Insert(firstB-1,"Fezz");
                            }
                            else
                            {
                                stack.Add("Fezz");
                            }
                            break;
                        case 17:
                            stack.Reverse();
                            break;
                    }
                }
            }
            
            foreach (int n in nums)
            {
                ModifyStack(n);
            }

            if (stack.Count > 0)
            {
                foreach (var item in stack)
                {
                    tempString += item;
                }
            }
            else
            {
                tempString = i.ToString();
            }
            
            return tempString;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("How much FizzBuzzing do you want?");
            string input = Console.ReadLine();
            int intMaxIndex = 0;
            Int32.TryParse(input, out intMaxIndex);
            
            string output = "";
            for(int i = 1; i < intMaxIndex; i++)
            {
                output = ComputeOutput(i);
                Console.WriteLine(output);
            }
        }
    }
}