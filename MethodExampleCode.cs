using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog120_S24_L9_Methods
{
    internal static class MethodExampleCode
    {
        static void Menu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Print from one number to another using loops");
                Console.WriteLine("2. Perform an algebra level equation");
                Console.WriteLine("3. Work with an array of names");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    PrintNumbers();
                }
                else if (choice == "2")
                {
                    PerformAlgebra();
                }
                else if (choice == "3")
                {
                    WorkWithNames();
                }
                else if (choice == "4")
                {
                    exit = true;
                    Console.WriteLine("Exiting the program.");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please choose again.");
                }

                Console.WriteLine(); // Blank line for readability
            }
        }

        static void PrintNumbers()
        {
            Console.Write("Enter the starting number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter the ending number: ");
            int end = int.Parse(Console.ReadLine());

            if (start <= end)
            {
                for (int i = start; i <= end; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = start; i >= end; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void PerformAlgebra()
        {
            Console.WriteLine("Choose an equation to solve:");
            Console.WriteLine("1. y = 2x + 3");
            Console.WriteLine("2. y = ax^2 + bx");
            Console.WriteLine("3. y = a(x - b)(x + c)");
            Console.Write("Choose an equation (1-3): ");
            string equationChoice = Console.ReadLine();

            if (equationChoice == "1")
            {
                SolveEquation1();
            }
            else if (equationChoice == "2")
            {
                SolveEquation2();
            }
            else if (equationChoice == "3")
            {
                SolveEquation3();
            }
            else
            {
                Console.WriteLine("Invalid option. Returning to main menu.");
            }
        }

        static void SolveEquation1()
        {
            Console.Write("Enter the value for x: ");
            double x = double.Parse(Console.ReadLine());
            double y = Add(Multiply(2, x), 3);
            Console.WriteLine($"The result of 2 * {x} + 3 is {y}");
        }

        static void SolveEquation2()
        {
            Console.Write("Enter the value for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for x: ");
            double x = double.Parse(Console.ReadLine());
            double y = Add(Multiply(a, Multiply(x, x)), Multiply(b, x));
            Console.WriteLine($"The result of {a} * {x}^2 + {b} * {x} is {y}");
        }

        static void SolveEquation3()
        {
            Console.Write("Enter the value for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for x: ");
            double x = double.Parse(Console.ReadLine());
            double y = Multiply(a, Multiply(Subtract(x, b), Add(x, c)));
            Console.WriteLine($"The result of {a} * ({x} - {b}) * ({x} + {c}) is {y}");
        }

        static void WorkWithNames()
        {
            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter name {i + 1}: ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("You entered the following names:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }


    }
}
