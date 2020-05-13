using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Reverse
    {
        public void displayArrayInReverseOrder()
        {
            Console.WriteLine("\nWrite 5 numbers, use empty space as divider");

            string numbers = Console.ReadLine();
            string[] arrayOfNumbers = numbers.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(arrayOfNumbers);

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.Write(" {0}", arrayOfNumbers[i]);
            }
            Console.WriteLine(" ");
        }
    }
}
