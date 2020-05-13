using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Sorting
    {
        readonly string fileOnePath = "Files/Sorting/fileOne.txt";
        readonly string fileTwoPath = "Files/Sorting/fileTwo.txt";

        List<string> linesOne = new List<string>();
        List<string> linesTwo = new List<string>();

        public string GetFileOne() {
            return fileOnePath;
        }
        public string GetFileTwo()
        {
            return fileTwoPath;
        }


        public void ReadFile(string pathOne, string pathTwo)
        {
            Console.WriteLine("");
            linesOne = File.ReadAllLines(pathOne).ToList();
            linesTwo = File.ReadAllLines(pathTwo).ToList();

            linesOne.AddRange(linesTwo);
            Console.WriteLine("Not sorted: ");
            Console.WriteLine("");

            foreach (string line in linesOne)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("");


            linesOne.Sort();

            Console.WriteLine("Sorted: ");
            Console.WriteLine("");
            foreach (string line in linesOne)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("");



        }







    }
}
