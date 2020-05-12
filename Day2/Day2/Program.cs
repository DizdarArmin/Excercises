using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.choseProgram();       
                   
        }



        class Calculator {
            public void calculate()
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
                else {
                    Console.WriteLine("Operation doesnt exist");
                }

            }
        }

        class GradingSystem
        {
            public void gradeWithIfStatement()
            {
                Console.WriteLine("\nWrite your grade from 1 to 10");
                int grade = Convert.ToInt32(Console.ReadLine());

                if (grade > 0 && grade <= 4)
                {
                    Console.WriteLine("Fail");
                }
                else if (grade == 5)
                {
                    Console.WriteLine("Pass");
                }

                else if (grade == 6)
                {
                    Console.WriteLine("Good");
                }
                else if (grade == 7 || grade == 8)
                {
                    Console.WriteLine("Notable");
                }
                else if (grade == 9 || grade == 10)
                {
                    Console.WriteLine("Excellent");
                }
                else
                {
                    Console.WriteLine("That grade doesnt exist");
                }

            }
            public void gradeWithSwitch()
            {
                Console.WriteLine("\nWrite your grade from 1 to 10");
                int grade = Convert.ToInt32(Console.ReadLine());

                switch (grade)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine("Fail");
                        break;

                    case 5:
                        Console.WriteLine("Pass");
                        break;

                    case 6:
                        Console.WriteLine("Good");
                        break;

                    case 7:
                    case 8:
                        Console.WriteLine("Notable");
                        break;

                    case 9:
                    case 10:
                        Console.WriteLine("Excellent");
                        break;
                }


            }
        }

        class Reverse
        {
            public void displayArrayInReverseOrder()
            {
                Console.WriteLine("\nWrite 5 numbers, use empty space as divider");
                
                string numbers = Console.ReadLine();
                string[] arrayOfNumbers = numbers.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                Array.Reverse(arrayOfNumbers);

                for (int i = 0; i < arrayOfNumbers.Length; i++) 
                {
                    Console.Write(" {0}" , arrayOfNumbers[i]);   
                }
                Console.WriteLine(" ");
            }
        }       

        class EvenNumbers
        {
            public void giveEvenNumbers() 
            {
                Console.WriteLine("\nWrite 10 numbers, use empty space as divider");

                string numbers = Console.ReadLine();
                string[] arrayOfNumbers = numbers.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                int[] allNumbers = Array.ConvertAll(arrayOfNumbers, s => int.Parse(s));

                Console.WriteLine("Even numbers are: ");
                foreach (int number in allNumbers)
                {
                    if (number % 2 == 0) 
                    {
                        Console.Write(" {0}", number);
                    }
                }
                Console.WriteLine(" ");

                
            }

        }

        class Menu {
        

           public void choseProgram() 
            {

                Console.WriteLine("\nFor Basic Calculator press 1");
                Console.WriteLine("For Grading System with IF Statement press 2");
                Console.WriteLine("For Grading System with Switch press 3");
                Console.WriteLine("For Reverse Array press 4");
                Console.WriteLine("For Even Number press 5");
                Console.WriteLine("For exit press Q");




                ConsoleKeyInfo userInput = Console.ReadKey();
                if (userInput.KeyChar == '1')
                {
                    Calculator calculator = new Calculator();
                    calculator.calculate();
                }
                else if (userInput.KeyChar == '2')
                {
                    GradingSystem grading = new GradingSystem();
                    grading.gradeWithIfStatement();
                }
                else if (userInput.KeyChar == '3')
                {
                    GradingSystem grading = new GradingSystem();
                    grading.gradeWithSwitch();
                }
                else if (userInput.KeyChar == '4')
                {
                    Reverse reverse = new Reverse();
                    reverse.displayArrayInReverseOrder();
                }
                else if (userInput.KeyChar == '5')
                {
                    EvenNumbers even = new EvenNumbers();
                    even.giveEvenNumbers();
                }

                else if (userInput.KeyChar == 'q') 
                {
                    Environment.Exit(0);
                }

                else
                {
                    Console.WriteLine("\nThat program is not avaliable");

                    choseProgram();
                }
                    choseProgram();
                






            }
        
        }

    }
}
