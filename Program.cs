using System;

namespace MethodMoreExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            int digits1 = 0;
            double digits2 = 0;

            if (inputType == "int")
            {
                MultiplyDigitsAndPrint(digits1);
            }
            else if (inputType == "real")
            {
                MultiplyDigitsAndPrint(digits2);
            }
            else if (inputType == "string")
            {
                SurroundStringWhitSymbol(inputType);
            }

            Console.ReadLine();
        }

        static void MultiplyDigitsAndPrint(int digits)
        {
            digits = int.Parse(Console.ReadLine());
            digits *= 2;
            Console.WriteLine(digits);
        }

        static void MultiplyDigitsAndPrint(double digits)
        {
            digits = double.Parse(Console.ReadLine());
            digits *= 1.5;
            Console.WriteLine("{0:F2}", digits);
        }

        static void SurroundStringWhitSymbol(string inputString)
        {
            inputString = Console.ReadLine();
            Console.WriteLine($"${inputString}$");
        }
    }
}
