using System;

namespace MethodExercises3
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintCharBetweenTwo(firstChar, secondChar);
            Console.ReadLine();

        }

        static void PrintCharBetweenTwo(char firstChar, char secondChar)
        {
            char temp = ' ';

            if (firstChar>secondChar)
            {
                temp = firstChar;
                firstChar = secondChar;
                secondChar = temp;
            }

            for (int i = firstChar+1; i < secondChar; i++)
            {
                Console.Write((char)i+" ");
            }

        }

    }
}
