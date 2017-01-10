using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] board =
            {
                "_","_","_","_","_","_","_","_","_"
            };

            int counter = 0;
            foreach (string place in board)
            {
                Console.Write(" " + place);
                if (counter == 2)
                {
                    Console.WriteLine("");
                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }

            var myString = "Austin";
            var cleanedString = myString.Replace('i', '1');

            int classSize = int.Parse(Console.ReadLine());
            int[] ages = new int[classSize];

            for (int i = 0; i < classSize; i++)
            {
                Console.WriteLine($"Age of {i} student?");
                ages[i] = int.Parse(Console.ReadLine());
            }

            foreach (var age in ages)
            {
                /*bool isLegalToDrink = age >= 21;
                if (isLegalToDrink)
                {
                    readableDrinkAge = "Yes";
                }
                else
                {
                    readableDrinkAge = "No";
                }*/
                string readableDrinkAge = age >= 21 ? "Yes" : "No";
                Console.WriteLine($"{age} is legal to drink? {readableDrinkAge}");
            }
            Console.WriteLine("-----");
            Console.WriteLine(ages.Max());
            Console.WriteLine(ages.Min());
            Console.WriteLine(ages.Average());

            string[] myArray = new string[9];
            myArray[0] = "X";

            Console.WriteLine(myArray);
        }
    }
}
