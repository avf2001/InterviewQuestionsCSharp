using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable
                .Range(1, 100)
                .Select(i =>     i % 15 == 0 ? "FizzBuzz"
                               : i % 3 == 0 ? "Fizz"
                               : i % 5 == 0 ? "Buzz"
                               : i.ToString()
                )
                .ToList()
                .ForEach(s => Console.WriteLine(s));
        }
    }
}
