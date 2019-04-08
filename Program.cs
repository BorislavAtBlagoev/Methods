using System;

namespace MethodExercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(VowelsCount(input));
        }

        static int VowelsCount(string input)
        {
            int vowelsCount = 0;
            string inputToLower = input.ToLower();


            for (int i = 0; i < inputToLower.Length; i++)
            {
                if (inputToLower[i] == 'a' ||
                    inputToLower[i] == 'o' ||
                    inputToLower[i] == 'u' ||
                    inputToLower[i] == 'e' ||
                    inputToLower[i] == 'i' ||
                    inputToLower[i] == 'y')
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }

    }
}
