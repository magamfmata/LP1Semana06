using System;
using System.Diagnostics.CodeAnalysis;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
         int numbers = int.Parse(args[0]);
         int seed = int.Parse(args[1]);

         int total = 0;

         Random random = new Random(seed);
            for (int i = 0; i < numbers; i++);
            total += random.Next(1, 6);
            Console.WriteLine(total);

        }
    }
}
