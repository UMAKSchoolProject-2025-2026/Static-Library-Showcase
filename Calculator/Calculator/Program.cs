using System;
using MathUtil;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("---- Simple Calculator ----");
                Console.WriteLine();
                Console.WriteLine("Choose operator:");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.WriteLine("5 - Power");
                Console.WriteLine("6 - Factorial");
                Console.WriteLine("7 - Is Prime");
                Console.WriteLine();

                int choice;
                while (true)
                {
                    Console.Write("Enter your choice: ");
                    if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 7)
                        break;
                    Console.WriteLine("Not a valid operator. Please select again.");
                }

                int a, b;

                switch (choice)
                {
                    case 1:
                        a = GetInt("Enter First Integer: ");
                        b = GetInt("Enter Second Integer: ");
                        Console.WriteLine($"Result: {MathHelper.Add(a, b)}");
                        break;

                    case 2:
                        a = GetInt("Enter First Integer: ");
                        b = GetInt("Enter Second Integer: ");
                        Console.WriteLine($"Result: {MathHelper.Subtract(a, b)}");
                        break;

                    case 3:
                        a = GetInt("Enter First Integer: ");
                        b = GetInt("Enter Second Integer: ");
                        Console.WriteLine($"Result: {MathHelper.Multiply(a, b)}");
                        break;

                    case 4:
                        a = GetInt("Enter First Integer: ");
                        b = GetInt("Enter Second Integer: ");
                        double divResult = MathHelper.Divide(a, b);
                        if (double.IsNaN(divResult))
                            Console.WriteLine("Cannot be divided by zero.");
                        else
                            Console.WriteLine($"Result: {divResult}");
                        break;

                    case 5:
                        a = GetInt("Enter base: ");
                        b = GetInt("Enter power: ");
                        Console.WriteLine($"Result: {MathHelper.Power(a, b)}");
                        break;

                    case 6:
                        a = GetInt("Enter an Integer for Factorial: ");
                        int fact = MathHelper.Factorial(a);
                        if (fact == -1)
                            Console.WriteLine("Cannot compute factorial of a negative number.");
                        else
                            Console.WriteLine($"Result: {fact}");
                        break;

                    case 7:
                        a = GetInt("Enter an Integer for Is Prime: ");
                        bool isPrime = MathHelper.IsPrime(a);
                        Console.WriteLine(isPrime ? $"{a} is a prime number." : $"{a} is not a prime number.");
                        break;
                }

                string answer;
                while (true)
                {
                    Console.Write("Do you want to continue? (y/n): ");
                    answer = Console.ReadLine().Trim().ToLower();

                    if (answer == "y" || answer == "n")
                        break;

                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                }

                if (answer == "n")
                {
                    running = false;
                    Console.WriteLine("Calculator closed.");
                }

                Console.WriteLine();
            }
        }











        //Para fast
        static int GetInt(string message)
        {
            int num;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out num))
                    return num;

                Console.WriteLine("Invalid number. Please try again.");
            }
        }
    }
}
