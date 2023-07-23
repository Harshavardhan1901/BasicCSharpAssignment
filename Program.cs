using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignment
{
    internal class Program
    {
        private static int CalculateFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * CalculateFactorial(num - 1);
            }
        }
        static void Main(string[] args)
        {
            //Task 1:Hello World
            Console.WriteLine("Task 1:");
            Console.WriteLine("Hello, World!");
            Console.ReadKey();

            //Task-2:Variables and User Input
            Console.WriteLine("\nTask 2:");
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}!");
            Console.ReadKey();

            //Task-3:
            Console.WriteLine("\nTask 3:");
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int addition = num1 + num2;
            int subtraction = num1 - num2;
            int multiplication = num1 * num2;

            Console.WriteLine($"Addition: {addition}");
            Console.WriteLine($"Subtraction: {subtraction}");
            Console.WriteLine($"Multiplication: {multiplication}");

            // Handle division by zero
            if (num2 != 0)
            {
                int division = num1 / num2;
                int modulus = num1 % num2;
                Console.WriteLine($"Division: {division}");
                Console.WriteLine($"Modulus: {modulus}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            Console.ReadKey();

            //Task-4:
            Console.WriteLine("\nTask 4:");
            Console.WriteLine("Enter a number to check if it is even or odd: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else
            { 
                Console.WriteLine($"{number} is an odd number."); 
            }
            Console.ReadKey();

            //Task 5:
            Console.WriteLine("\nTask 5:");
            Console.WriteLine("Numbers from 1 to 10:");
            for (int i = 1; i<= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            //Task 6:Arrays
            Console.WriteLine("\nTask 6:");
            int[] numbers = { 1, 2, 3, 4, 5 };

            int sum = 0;
            foreach (int num  in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.ReadKey();

            //Task 7:Methods
            Console.WriteLine("\nTask 7:");
            Console.WriteLine("Enter a positive integer: ");
            int userinput = int.Parse(Console.ReadLine());

            if (userinput >= 0)
            {
                int factorial = CalculateFactorial(userinput);
                Console.WriteLine($"Factorial of {userinput} is: {factorial}");
            }
            else
            {
                Console.WriteLine("Invalid Input!!! Please enter a non-negative integer.");
            }
            Console.ReadKey();

            //Task 8:Exception Handling
            Console.WriteLine("\nTask 8:");
            int age;

            do
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    if (age < 0)
                    {
                        Console.WriteLine("Age must be a non-negative integer.");
                    }
                    else if (age < 18)
                    {
                        Console.WriteLine("You are a minor.");
                    }
                    else if (age >= 18 && age < 65)
                    {
                        Console.WriteLine("You are an adult.");
                    }
                    else
                    {
                        Console.WriteLine("You are a senior.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age.");
                }
            } while (age < 0);


            Console.ReadKey();
        }
    }
}
