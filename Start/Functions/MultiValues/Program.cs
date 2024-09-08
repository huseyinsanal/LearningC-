using System;

namespace MultiValues
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Tuples are grouped values added in C# 7
            (int a, int b) tup1 = (5, 10);
            var tup2 = ("Some Text", 10.5f, 25);

            // TODO: Tuple values are mutable
            tup1.b = 20;
            tup2.Item1 = "New String";
            tup2.Item3 = 55;
            Console.WriteLine($"{tup1.a}, {tup1.b}");
            Console.WriteLine($"{tup2.Item1}, {tup1.Item2}, {tup2.Item3}");

            // TODO: Functions can work with tuples
            (int, int) result = PlusTimes(6,12);
            Console.WriteLine($"Sum: {result.Item1}, Product: {result.Item2}");
        }

        // TODO: Functions can return multiple values using tuples
        static (int, int) PlusTimes(int a, int b) {
            return (a + b, a * b);
        }
    }
}
