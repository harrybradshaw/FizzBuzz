using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 101; i++)
            {
                string s = "";
                if (i % 3 == 0)
                {
                    s += "Fizz";
                }

                if (i % 5 == 0)
                {
                    s += "Buzz";
                }

                if (i % 7 == 0)
                {
                    s += "Bang";
                }

                if (i % 11 == 0)
                {
                    s = "Bong";
                }
                
                if (s.Length != 0)
                {
                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}