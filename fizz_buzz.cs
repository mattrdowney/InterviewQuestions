using System;

namespace InterviewQuestions
{
    class FizzBuzz
    {
        static void Main(string[] arguments)
        {
            fizz_buzz(100);
        }
        
        private static void fizz_buzz(int count)
        {
            for (int number = 1; number < count; number += 1)
            {
                if ((number % (3*5)) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ((number % (3)) == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if ((number % (5)) == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
