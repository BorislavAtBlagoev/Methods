using System;

namespace MethodExercises7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nxmMatrix = int.Parse(Console.ReadLine());
            PrintMatrix(nxmMatrix);
            Console.ReadLine();
        }

        static void PrintMatrix(int nxmMatrix)
        {
            for (int i = 0; i < nxmMatrix; i++)
            {
                for (int j = 0; j < nxmMatrix; j++)
                {
                    Console.Write(nxmMatrix + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
