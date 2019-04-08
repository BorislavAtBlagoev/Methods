using System;

namespace MethodExercises8
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstFactorialDigit = int.Parse(Console.ReadLine());
            int secondFactorialDigit = int.Parse(Console.ReadLine());

            double devideFactorials = (double)FirstFactorial(firstFactorialDigit) / SecondFactorial(secondFactorialDigit);
            Console.WriteLine($"{devideFactorials:F2}");
            Console.WriteLine(FactorialWithForLoop(firstFactorialDigit) / FactorialWithForLoop2(secondFactorialDigit));
            Console.WriteLine(FactorialWithForLoop(firstFactorialDigit) + " " + FactorialWithForLoop2(secondFactorialDigit));
            Console.ReadLine();
        }

        static int FactorialWithForLoop(int firstFactorialDigit)
        {
            for (int i = firstFactorialDigit - 1; i >= 1; i--)
            {
                firstFactorialDigit = firstFactorialDigit * i;
            }
            return firstFactorialDigit;
        }

        static int FactorialWithForLoop2(int secondFactorialDigit)
        {
            int count = secondFactorialDigit;
            for (int i = 2; i < secondFactorialDigit; i++)
            {
                count = count * i;
            }
            return count;
        }

        private static int FirstFactorial(int firstFactorialDigit)
        {
            int count = firstFactorialDigit - 1;
            while (count >= 1)
            {
                firstFactorialDigit = firstFactorialDigit * count;
                count--;
            }
            return firstFactorialDigit;
        }

        private static int SecondFactorial(int secondFactorialDigit)
        {
            int count = secondFactorialDigit - 1;
            while (count >= 1)
            {
                secondFactorialDigit = secondFactorialDigit * count;
                count--;
            }
            return secondFactorialDigit;
        }
    }
}
