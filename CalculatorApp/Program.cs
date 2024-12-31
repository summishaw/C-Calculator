// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator App!");
            
            while (true)
            {
                Console.WriteLine("\nSelect an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("Thank you for using the Calculator App. Goodbye!");
                    break;
                }

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                        break;

                    case "2":
                        Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                        break;

                    case "3":
                        Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                        break;

                    case "4":
                        if (num2 != 0)
                        {
                            Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid operation.");
                        break;
                }
            }
        }
    }
}

// All are good working code and it is well defined so looking good All is Well Thanks.
