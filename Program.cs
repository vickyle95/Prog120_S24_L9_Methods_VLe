using System;
namespace Prog120_S24_L9_Methods
{
    class Program
    {
        // The first thing we're going to do
        // Is move ALL the code from Main, into a seperate method


        static void Main(string[] args)
        {
            // !! Code for the Lecture.
            // You will need to deconstruct this.
            //Console.WriteLine("Start of code");


            //PerformAlgebra();
            Menu();

        } // Main

        // 1. What is a method
        // A method is a  block of code, given an identifying name that is used to call it



        // 3. What is a call stack

        // 4. What is the scope of variables inside of the method
        // INSIDE the enclosing method code block

        // 5. Where can you declare a method
        // You can declare a method INSIDE of a class block and OUTSIDE of a method block

        // 6. Why do we use methods?
        // To organize our code into specific funtionality
        // Reuseability

        // 7. What is a return type?
        // Tells the computer what TYPE is to be returned OUT OF THE METHOD

        // 8. What does void mean?
        // Void means that nothing is being returned from the method

        // 9. How do you CALL a method?
        // To CALL a method, you call it inside of another method.
        // You need to use the NAME of your method, followed by parenthese

        // Rule 1: You cannot declare a method INSIDE of another method

        //------------------
        // Method

        // Refactoring
        // Refactoring is improving our code effiency

        // 2. What is a method signature
        // A method signature defines the NAme, and Parameters to the running application
        // Method Signature: Naame and Parameters
        // Access Modifier - Static Keyword - Return Type - Name - Parameters
        // Method names should be in Upper Case in C#

        public static void Menu()
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
                    // Start of Algebra Menu
                    PerformAlgebra();
                }
                else if (choice == "3")
                {
                    // Loop Through Names
                    WorkWithNames();
                    //End of Looping Through Names
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
        } // Menu()

        // Create a new method called PrintNumbers()
        // How do I declare this method
        public static void PrintNumbers()
        {
            Console.Write("Enter the starting number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter the ending number: ");
            int end = int.Parse(Console.ReadLine());

            // When you pass in VALUES to a method, they are called arguments
            // They have to be the proper type, in the proper order
            // LoopThroughNumbers(int, int)

            LoopThroughNumbers(start,end);
            
        } // PrintNumbers()

        // New method name - Loop Through Numbers

        //Parameters
        // Parameters allow us to pass ARGUMENTS into a method
        // Parameters are declared inside of the parentheses after the name
        public static void LoopThroughNumbers(int start, int end)
        {
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
        } // LoopThroughNumbers()

        // -------- Write our Equation methods

        // For our return type, we are replacing void with the type we EXPECT to ocme out
        // We are adding 2 doubles, so we are changing void to double
        
        public static double Add(double number1, double number2)
        {
            double sum = number1 + number2;

            // In order to return something we use the keyword
            // return
            return sum;
        }

        // Subtract
        public static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }
        // Multiply
        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        // Divide
        public static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }


        // SolveEquation1()
        public static void SolveEquation1()
        {
            Console.Write("Enter the value for x: ");
            double x = double.Parse(Console.ReadLine());

            // PEMDAS
            // Parenthese - Exponents
            // Multiplacation - Division 
            // Addition - Subtraction

            // y = e * x + 3
            double step1 = Multiply(2, x);
            double y = Add(step1, 3);

            Console.WriteLine($"The result of 2 * {x} + 3 is {y}");
        }// SolveEquation1()

        // SolveEquation2()
        public static void SolveEquation2()
        {
            Console.Write("Enter the value for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for x: ");
            double x = double.Parse(Console.ReadLine());

            // (a * x * x) + (b * x)

            // Step 1 = a * x
            double step1 = Multiply(a, x);

            // Step 2 = Step1 * x = (a * x * x)
            double step2 = Multiply(step1, x);

            // Step 3 = b * x
            double step3 = Multiply(b, x);

            // y = Step2 + Step3
            double y = Add(step2, step3);
            Console.WriteLine($"The result of {a} * {x}^2 + {b} * {x} is {y}");
        }// SolveEquation2()

        // SolveEquation3()
        public static void SolveEquation3()
        {
            Console.Write("Enter the value for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for x: ");
            double x = double.Parse(Console.ReadLine());

            // a * (x - b) * (x + c)

            // Parenthese
            // Step1 x - b
            double step1 = Subtract(x, b);
            // Step2 x + c
            double step2 = Add(x, c);

            // a * step1 * step2
            //Multiplcation
            // Step3 a * step1
            double step3 = Multiply(a, step1);

            // y = step3 * step2 
            double y = Multiply(step3, step2);

            Console.WriteLine($"The result of {a} * ({x} - {b}) * ({x} + {c}) is {y}");
        }// SolveEquation3()

        // PerformAlgebra() Method
        public static void PerformAlgebra()
        {
            Console.WriteLine("Choose an equation to solve:");
            Console.WriteLine("1. y = 2x + 3");
            Console.WriteLine("2. y = ax^2 + bx + c");
            Console.WriteLine("3. y = a(x - b)(x + c)");
            Console.Write("Choose an equation (1-3): ");
            string equationChoice = Console.ReadLine();

            if (equationChoice == "1")
            {
                // Equation 1
                SolveEquation1();
                // End Quation 1
            }
            else if (equationChoice == "2")
            {
                // Equation 2
                SolveEquation2();
                // End Equation 2
            }
            else if (equationChoice == "3")
            {
                // Equation 3
                SolveEquation3();
                // End Equation 3
            }
            else
            {
                Console.WriteLine("Invalid option. Returning to main menu.");
            }
        } // PerformAlgebra()

        // Create a new method Work with Names
        public static void WorkWithNames()
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
        } // WorkWithNames()
    } // class

} // namespace
