using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Calculator
    {
        public void Calculate()
        {
            Console.WriteLine("\nEnter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chose operation: ( + , - , / , * )");
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                Console.WriteLine(firstNumber + " + " + secondNumber + " = " + (firstNumber + secondNumber));
            }
            else if (operation == "-")
            {
                Console.WriteLine(firstNumber + " - " + secondNumber + " = " + (firstNumber - secondNumber));
            }
            else if (operation == "/")

            {
                if (firstNumber % secondNumber == 0)
                {
                    Console.WriteLine(firstNumber + " / " + secondNumber + " = " + (firstNumber / secondNumber));
                }
                else
                {
                    Console.WriteLine(firstNumber + " is not divisible by " + secondNumber);
                }
            }

            else if (operation == "*")
            {
                Console.WriteLine(firstNumber + " * " + secondNumber + " = " + (firstNumber * secondNumber));
            }
            else
            {
                Console.WriteLine("Operation doesnt exist");
            }

        }
    }
}
