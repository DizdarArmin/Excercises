using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class GradingSystem
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
}
