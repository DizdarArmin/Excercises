using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class StringManipulation
    {


        public void  Manipulate() {

            Console.WriteLine(" ");
            Console.WriteLine("Write sentence");
            string userInput = Console.ReadLine();
            string spacesToUnderScore = userInput.Replace(" ", "_");
            string lowerCaseToUpperCaseA = userInput.Replace("a", "A");
            string withoutLeadingSpaces = userInput.TrimEnd(' ');
            string withoutTrailingSpaces = userInput.TrimStart(' ');


            Console.WriteLine(" ");
            Console.WriteLine("Original sentence: " + userInput);

            Console.WriteLine("Underscore instead of spaces: " + spacesToUnderScore);

            Console.WriteLine("a to A: " + lowerCaseToUpperCaseA);

            Console.WriteLine("Without leading spaces:" + withoutLeadingSpaces);
            Console.WriteLine("Without trailing spaces:" + withoutTrailingSpaces);


            Console.ReadLine();

        }

    }
}
