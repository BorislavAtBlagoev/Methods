using System;

namespace MethodExercises10
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool asasd;
            bool isValid = false;

            PrintFinalResult(count, isValid);
            Console.ReadLine();
        }

        static void PrintFinalResult(int count, bool isValid)
        {
            while (count++ < 5 && isValid == false)
            {
                string password = Console.ReadLine();
                bool passwordLenght = CheckLenghtOfPassword(password);
                bool isConsistOnlyDigitsAndLatters = CheckConsistOnlyDigitsAndLatters(password);
                bool isConsistTwoOrMoreDigits = CheckConsistTwoOrMoreDigits(password);
                isValid = HowTrueOrFalse(passwordLenght, isConsistOnlyDigitsAndLatters, isConsistTwoOrMoreDigits);

            }
            if (isValid == true)
            {
                Console.WriteLine("Wellcome");
            }
            else
            {
                Console.WriteLine("invalid password");
            }
        }

        static bool HowTrueOrFalse(bool passwordLenght, bool isConsistOnlyDigitsAndLatters, bool isConsistTwoOrMoreDigits)
        {

            if (passwordLenght == true &&
                   isConsistOnlyDigitsAndLatters == true &&
                   isConsistTwoOrMoreDigits == true)
            {
                return true;
            }
            else
            {

                if (passwordLenght == false)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (isConsistOnlyDigitsAndLatters == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (isConsistTwoOrMoreDigits == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }

                Console.WriteLine();
                Console.WriteLine("Incorect password");
                return false;

            }
        }

        static bool CheckConsistTwoOrMoreDigits(string password)
        {
            int counter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    counter++;
                }
            }

            if (counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        static bool CheckConsistOnlyDigitsAndLatters(string password)
        {

            for (int i = 0; i < password.Length; i++)
            {

                if (!(char.IsLetterOrDigit(password[i])))
                {
                    return false;

                }

            }

            return true;
        }

        static bool CheckLenghtOfPassword(string password)
        {

            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
