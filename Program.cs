using System;

namespace MethodExersises9
{
    class Program
    {
        static void Main(string[] args)
        {

            string enterNumberOrEND = Console.ReadLine();

            EnterString(enterNumberOrEND);

        }
        static void EnterString(string enteredString)
        {
            while (enteredString != "END")
            {

                if (CheckForPalindromeStrings(enteredString) == true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                enteredString = Console.ReadLine();
            }
        }

        static bool CheckForPalindromeStrings(string isPalindromeSring)
        {

            bool isPalindrome = true;

            for (int i = 0; i < isPalindromeSring.Length / 2; i++)
            {
                for (int j = (isPalindromeSring.Length - 1) - i; j >= (isPalindromeSring.Length - 1) - i; j--)
                {
                    if (isPalindromeSring[i] != isPalindromeSring[j])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
            }

            return isPalindrome;
        }

    }
}
