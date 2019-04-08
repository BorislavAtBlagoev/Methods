﻿using System;

namespace MethodMoreExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            CheckCloserPointToZero(x1, y1, x2, y2);
            Console.ReadLine();

        }

        static void CheckCloserPointToZero(double x1, double y1, double x2, double y2)
        {
            double pythagoreanTheorem1 = (Math.Abs(x1) * Math.Abs(x1)) + (Math.Abs(y1) * Math.Abs(y1));
            double pythagoreanTheorem2 = (Math.Abs(x2) * Math.Abs(x2)) + (Math.Abs(y2) * Math.Abs(y2));

            if (Math.Sqrt(pythagoreanTheorem1) < Math.Sqrt(pythagoreanTheorem2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (Math.Sqrt(pythagoreanTheorem1) > Math.Sqrt(pythagoreanTheorem2))
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else if (Math.Sqrt(pythagoreanTheorem1) == Math.Sqrt(pythagoreanTheorem2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}
