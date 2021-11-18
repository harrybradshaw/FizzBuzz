using System;
using System.Collections;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzed : IEnumerable
    {
        private static string ComputeTerm(int i)
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
                tempString = String.Join("",stack);
            }
            else
            {
                tempString = i.ToString();
            }
            return tempString;
        }
        
        public IEnumerator GetEnumerator()
        {
            for (int index = 1; index < 101; index++)
            {
                yield return ComputeTerm(index);
            }
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("How much FizzBuzzing do you want?");
            string input = Console.ReadLine();
            Int32.TryParse(input, out int intMaxIndex);
            
            Console.WriteLine("Select the rules to use as a comma seperated list! (eg. 3,5,7)");
            Console.WriteLine("3: Fizz");
            Console.WriteLine("5: Buzz");
            Console.WriteLine("7: Bang");
            Console.WriteLine("11: Bong");
            Console.WriteLine("13: Fezz");
            Console.WriteLine("17: Reverse");
            
            //string rulesInput = Console.ReadLine();
            //string[] rulesStrings = rulesInput.Split(',');
            //int[] nums = Array.ConvertAll(rulesStrings, int.Parse);
            */
            
            var fizzbuzzer = new FizzBuzzed();
            foreach (var value in fizzbuzzer)
            {
                Console.WriteLine(value);
            }
            
        }
    }
}