using System;
namespace Prog120_S24_L9_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // !! Code for the Lecture.
            // You will need to deconstruct this.

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
                else if (choice == "2")
                {
                    Console.WriteLine("Choose an equation to solve:");
                    Console.WriteLine("1. y = 2x + 3");
                    Console.WriteLine("2. y = ax^2 + bx + c");
                    Console.WriteLine("3. y = a(x - b)(x + c)");
                    Console.Write("Choose an equation (1-3): ");
                    string equationChoice = Console.ReadLine();

                    if (equationChoice == "1")
                    {
                        Console.Write("Enter the value for x: ");
                        double x = double.Parse(Console.ReadLine());
                        double y = 2 * x + 3;
                        Console.WriteLine($"The result of 2 * {x} + 3 is {y}");
                    }
                    else if (equationChoice == "2")
                    {
                        Console.Write("Enter the value for a: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Enter the value for b: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Enter the value for x: ");
                        double x = double.Parse(Console.ReadLine());
                        double y = a * x * x + b * x;
                        Console.WriteLine($"The result of {a} * {x}^2 + {b} * {x} is {y}");
                    }
                    else if (equationChoice == "3")
                    {
                        Console.Write("Enter the value for a: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Enter the value for b: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Enter the value for c: ");
                        double c = double.Parse(Console.ReadLine());
                        Console.Write("Enter the value for x: ");
                        double x = double.Parse(Console.ReadLine());
                        double y = a * (x - b) * (x + c);
                        Console.WriteLine($"The result of {a} * ({x} - {b}) * ({x} + {c}) is {y}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Returning to main menu.");
                    }
                }
                else if (choice == "3")
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
        } // Main


        // 1. What is a method

        // 2. What is a method signature

        // 3. What is a call stack

        // 4. What is the scope of variables inside of the method

        // 5. Where can you declare a method

        // 6. Why do we use methods?

        // 7. What is a return type?

        // 8. What does void mean?


    } // class

} // namespace
