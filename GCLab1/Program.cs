using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double l, h, w;
            bool testNum = true;

            while (testNum)
            {
                Console.Write("Please enter the Length of the rectangle: ");
                l = DoubleVal();

                Console.Write("Please enter the Width of the rectangle: ");
                w = DoubleVal();

                Console.Write("Please enter the Height of the rectangle: ");
                h = DoubleVal();

                //Lists of formulas
                double area = w * l;
                double perimeter = 2 * w + 2 * l;
                double volume = l * w * h;

                //Results for the user on what was asked for.
                Console.WriteLine("The area of the room is: " + area);
                Console.WriteLine("The perimeter of the room is: " + perimeter);
                Console.WriteLine("The volume of the room is: " + volume);

                bool validation = true;

                Console.WriteLine("Would you like to continue? (y/n): ");

                //Makes sure the user would like to continue
                while (validation)
                {
                    string answer = Console.ReadLine();
                    if (answer == "yes" || answer == "Yes" || answer == "y" || answer == "Y" || answer == "ya" || answer == "Ya")
                    {
                        testNum = true;
                        validation = false;
                    }
                    else
                    {
                        Console.WriteLine("Goodbye!");
                        validation = false;
                        return;
                    }
                }
            }
        }
        //Checks to make sure the entered value is a correct measurment
        private static double DoubleVal()
        {
            while (true)
            {
                string measurments = Console.ReadLine();
                bool success = double.TryParse(measurments, out double doubleValue);

                //Checks for positive numbers
                if (doubleValue < 0)
                {
                    Console.WriteLine("That was not a positive number! ");
                    success = false;
                }

                if (success)
                {
                    return doubleValue;
                }
                else
                {
                    Console.Write("Make sure to enter a valid number! ");
                }
            }
        }
    }
}