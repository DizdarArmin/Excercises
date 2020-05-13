using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Library
    {
        string filePath = "Files/Library/books.txt";
        List<string> listOfBooks = new List<string>();

        public void GetBooks() {
            listOfBooks = File.ReadAllLines(filePath).ToList();
        }

        public void AddBook(string tittle, string author) {
            GetBooks();

            listOfBooks.Add(tittle + " by " + author);
            File.WriteAllLines(filePath, listOfBooks);
        
        }

        public void DisplayBooks() {
            GetBooks();
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("      ****        BOOKS        ****      ");
            int i = 0;
            foreach (string book in listOfBooks) {
                i++;
                Console.WriteLine( "        " + i + ") " + book);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }


        public void FindBook() 
        {
            GetBooks();

            Console.WriteLine(" ");
            Console.WriteLine("Write name of the book or author ");
            string search = Console.ReadLine();
            search = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(search.ToLower());

            foreach (string book in listOfBooks) 
            {
                if (book.Contains(search)) 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("      - " + book);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            
        }

        public void DeleteBookByName()
        {
            GetBooks();

            Console.WriteLine(" ");
            Console.WriteLine("Delete book by writing name or author ");
            string search = Console.ReadLine();
            search = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(search.ToLower());
            int booksFound = 0;

            if (search.Count() < 3) {
                DeleteBookByName();
            }

            foreach (string book in listOfBooks.ToList())
            {
                if (book.Contains(search))
                {
                    
                    listOfBooks.Remove(book);
                    File.WriteAllLines(filePath, listOfBooks);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("      - DELETED " + book);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    booksFound++;
                }
                
               
            }

            if (booksFound == 0) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Couldn't find that book");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

        }

        public void DeleteBookAtPosition() {
            GetBooks();
            DisplayBooks();
            Console.WriteLine(" ");
            Console.WriteLine("Delete book at position");
            Console.WriteLine(" ");

            string input = Console.ReadLine();
            try
            {
                int position = Convert.ToInt32(input);

                if (position == 0|| position > listOfBooks.Count())
                {
                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Doesn't exist. Try again");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    DeleteBookAtPosition();
                    
                }
                else
                {
                   
                   

                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DELETED " + listOfBooks[position - 1] + " from position " + position);
                    Console.ForegroundColor = ConsoleColor.Gray;

                    listOfBooks.RemoveAt(position - 1);
                    File.WriteAllLines(filePath, listOfBooks);

                }

              
            }
            catch (FormatException)
            
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Can't convert string to integer. Try again");
                Console.ForegroundColor = ConsoleColor.Gray;
                DeleteBookAtPosition();
                
            }

            










        }


    }
}
