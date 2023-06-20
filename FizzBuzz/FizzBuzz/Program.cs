using System;

namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.FizzBuzz(100);
        }

        public void FizzBuzz(int range)
        {
            var numbers = new List<string>();
            for (int i = 1; i < range + 1; i++) 
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    numbers.Add("FizzBuzz");
                }
                else if(i %3 == 0)
                {
                    numbers.Add("Fizz");
                }
                else if(i % 5 == 0)
                {
                    numbers.Add("Buzz");
                }
                else
                {
                    numbers.Add(i.ToString());
                }
            }
            numbers.ForEach(i => Console.Write(i + " "));
        }
    }
}
