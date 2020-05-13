using System;
using System.Diagnostics;
using System.Globalization;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.choseProgram();

        }

        class Menu
        {
            public void Library()
            {
                Library library = new Library();
                Console.WriteLine(" ");
                Console.WriteLine(" - See all books in library - press S");
                Console.WriteLine(" - Add book to library - press A");
                Console.WriteLine(" - Find book - press F");
                Console.WriteLine(" - Delete by book or author name - press D");
                Console.WriteLine(" - Delete book at position - press P");

                Console.WriteLine(" ");
                Console.WriteLine(" - Back to main menu - press M");

                ConsoleKeyInfo libraryInput = Console.ReadKey();
                if (libraryInput.KeyChar == 's')
                {
                    library.DisplayBooks();
                    Library();
                }
                else if (libraryInput.KeyChar == 'a')
                {
                    Console.WriteLine("\nWrite Name of the book, Author");
                    string book = Console.ReadLine();
                    string[] info = book.Split(new char[] { ',', '\t' }, System.StringSplitOptions.RemoveEmptyEntries);
                    string tittle = info[0];
                    string author = info[1];


                    tittle = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tittle.ToLower());
                    author = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(author.ToLower());

                    library.AddBook(tittle, author);
                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(tittle + " by " + author + " succesfully added to library");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(" ");
                    Library();
                }
                else if (libraryInput.KeyChar == 'f')
                {
                    //library = new Library();
                    library.FindBook();
                    Library();
                }
                else if (libraryInput.KeyChar == 'd')
                {
                    library.DeleteBookByName();
                    Library();
                }
                else if (libraryInput.KeyChar == 'p')
                {
                    library.DeleteBookAtPosition();
                    Library();
                }
                else if (libraryInput.KeyChar == 'm') 
                {
                    choseProgram();
                }



                    Console.ReadLine();



                


            }



            public void choseProgram()
            {
                Console.WriteLine("\n * **** Welcome *****");
                Console.WriteLine(" ");

                Console.WriteLine("\n - For Basic Calculator press 1");
                Console.WriteLine(" - For Grading System with IF Statement press 2");
                Console.WriteLine(" - For Grading System with Switch press 3");
                Console.WriteLine(" - For Reverse Array press 4");
                Console.WriteLine(" - For Even Number press 5");
                Console.WriteLine(" - For Sorting from 2 files press 6");
                

                Console.WriteLine(" - For Library press 7");
                Console.WriteLine(" - For String Manipulation press 8");

                Console.WriteLine(" ");
                Console.WriteLine(" - For exit press Q");

                ConsoleKeyInfo userInput = Console.ReadKey();
                if (userInput.KeyChar == '1')
                {
                    Calculator calculator = new Calculator();
                    calculator.Calculate();
                    choseProgram();
                }

                else if (userInput.KeyChar == '2')
                {
                    GradingSystem grading = new GradingSystem();
                    grading.gradeWithIfStatement();
                    choseProgram();
                }
                else if (userInput.KeyChar == '3')
                {
                    GradingSystem grading = new GradingSystem();
                    grading.gradeWithSwitch();
                    choseProgram();
                }
                else if (userInput.KeyChar == '4')
                {
                    Reverse reverse = new Reverse();
                    reverse.displayArrayInReverseOrder();
                    choseProgram();
                }
                else if (userInput.KeyChar == '5')
                {
                    EvenNumbers even = new EvenNumbers();
                    even.giveEvenNumbers();
                    choseProgram();
                }
                else if (userInput.KeyChar == '6')
                {
                    Sorting sorting = new Sorting();
                    sorting.ReadFile(sorting.GetFileOne(), sorting.GetFileTwo());
                    choseProgram();
                }
                else if (userInput.KeyChar == '7')
                {
                    Library();
                   
                }
                else if (userInput.KeyChar == '8')
                {
                    StringManipulation manipulator = new StringManipulation();
                    manipulator.Manipulate();

                }


                else if (userInput.KeyChar == 'q')
                {
                    Environment.Exit(0);
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nThat program is not avaliable");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    choseProgram();
                }
               







            }

            

            }

        }

    }



