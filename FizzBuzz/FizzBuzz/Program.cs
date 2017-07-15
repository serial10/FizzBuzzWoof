using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {           
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {                    
                    if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                    {
                        Console.WriteLine("{0} " + "Fizz " + "Buzz " + "Woof", i);
                        continue;
                    }
                    if (i % 3 == 0 && i % 7 == 0)
                    {
                        Console.WriteLine("{0} " + "Fizz " + "Woof", i);
                        continue;
                    }
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("{0} " + "Fizz " + "Buzz", i);
                        continue;
                    }
                        Console.WriteLine("{0} " + "Fizz", i);
                        continue;                 
                }
                if (i % 5 == 0)
                {
                    if (i % 5 == 0 && i % 7 == 0)
                    {
                        Console.WriteLine("{0} " + "Buzz " + "Woof", i);
                        continue;
                    }
                        Console.WriteLine("{0} " + "Buzz", i);
                        continue;                    
                }
                if (i % 7 == 0)
                {
                    Console.WriteLine("{0} " + "Woof", i);
                    continue;
                }
                    Console.WriteLine(i);                
            }
        }
    }
}
