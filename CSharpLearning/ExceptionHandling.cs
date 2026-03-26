using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    internal class ExceptionHandling
    {
        public static void Run() 
        {
            Console.WriteLine("\nException Handling : Example - 1");
            try
            {
                Console.Write("Type first number : ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Type second number : ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                int dividedNumber = firstNumber / secondNumber;
                Console.WriteLine($"Divided number is: {dividedNumber}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error : Please type a number!");
            }
            catch (DivideByZeroException)   
            {
                Console.WriteLine("Error: Please enter a valid number.");
            }


            Console.WriteLine("\nException Handling : Example - 2");
            Console.Write("Type a number : ");
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
                Console.WriteLine("Valid number.");
            }
            catch(FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The number is too large");
            }
        }
    }
}
