using System;

namespace first_csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //loop that prints 1-255
            for (int num = 1; num < 256; num++)
            {
                Console.WriteLine(num);
            }
            // Print all values 1-100 divisable by 3 or 5 but not both
            for (int num = 1; num < 101; num ++)
            {
                if (!(num % 15 == 0))
                {
                    if (num % 3 == 0 || num % 5 == 0)
                    {
                        Console.WriteLine(num);
                    }
                    
                }
            }
            // fizzbuzz
            for (int num = 1; num < 101; num ++)
            {
                if(num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz");   
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
        }
    }
}
