using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userContinue = true;

            Console.WriteLine("Hi! Let's analyze some numbers. What's your name?");
            string user = Console.ReadLine();

            while (userContinue)
            {
                Console.WriteLine($"\nAlright, {user}. Enter a number between 1 and 100: ");

                int userInput = int.Parse(Console.ReadLine().Trim());
                bool IsEven = Even(userInput);

                if (userInput <= 0)
                {
                    Console.WriteLine("Number cannot be negative or 0");
                }                    
                else if (userInput <= 25 && IsEven)
                {
                    Console.WriteLine($"{userInput}, Even and less than 25");
                }
                else if (userInput <= 100 && Even(userInput))
                {
                    Console.WriteLine($"{userInput}, Even");
                }
                else if (userInput <= 100)
                {
                    Console.WriteLine($"{userInput}, Odd");
                }
                else
                {
                    Console.WriteLine("\nInvalid input.");
                }


                while (userContinue)
                {
                    Console.WriteLine($"\nWant to analyze another number, {user}? Y/N?");

                    string playAgain = Console.ReadLine().ToLower().Trim();

                    if (playAgain == "n")
                    {
                        userContinue = false;
                    }
                    else if (playAgain == "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }
            Console.WriteLine($"\nBye, {user}!");
        }
        public static bool Even(int num)
        {
            if (num % 2 == 0)
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
