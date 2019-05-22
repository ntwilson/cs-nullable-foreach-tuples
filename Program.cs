using System;

namespace cs_nullable_foreach_tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var xs = new[] { 
                (a: 1, b: 2),
                (a: 3, b: 4)
            };

            foreach (var (a, b) in xs) { }
            foreach (var tuple in xs) {
                var (a, b) = tuple;
            }

            Console.WriteLine("Hello World!");
        }
    }
}
