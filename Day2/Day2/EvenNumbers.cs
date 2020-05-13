using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class EvenNumbers
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
}
