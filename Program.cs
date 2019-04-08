﻿using System;

namespace MethodMoreExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            TribonacciSequence(input);
            Console.ReadLine();
        }

        static void TribonacciSequence(int lengthOfSequence)
        {
            int firstDigit = 0;
            int secondDigit = 0;
            int thirdDigit = 1;
            int nextDigit = 0;

            for (int i = 1; i <= lengthOfSequence; i++)
            {
                if (i==1)
                {
                    nextDigit = i;
                }
                else
                {
                    nextDigit = firstDigit + secondDigit + thirdDigit;
                    firstDigit = secondDigit;
                    secondDigit = thirdDigit;
                    thirdDigit = nextDigit;
                }

                Console.Write($"{nextDigit} ");
            } 
           
        }
    }
}
