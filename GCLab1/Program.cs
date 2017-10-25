using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab1
{
    class Program
    {
        double l, w, h;
        bool repeat = true;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter in the length of the rectangle: ");
                
                string inputOne = Console.ReadLine();

                double l;
                bool successl = double.TryParse(inputOne, out l);
                
                if (l < 0)
                {
                     Console.WriteLine("Please enter a positive number! ");
                     return;
                }
                
                Console.Write("Please enter in the width of the rectangle: ");
                string inputTwo = Console.ReadLine();

                double w;
                bool successw = double.TryParse(inputTwo, out w);

                if (w < 0 )
                {
                    Console.WriteLine("Please enter a positive number! ");
                    return;
                }

                Console.Write("Please enter in the height of the rectangle: ");
                string inputThree = Console.ReadLine();

                double h;
                bool successh = double.TryParse(inputThree, out h);

                if (h)
                {
                    Console.WriteLine("Please enter a positive number! ");
                    return;
                }

                double area = (l * w);
                Console.WriteLine("The area of the rectangle is: {0}", area);
                double perimeter = 2 * (l + w);
                Console.WriteLine("The perimeter of the rectangle is: {0}", perimeter);
                double volume = (l * w * h);
                Console.WriteLine("The volume of the rectangle is: {0}", volume);

                Console.WriteLine("Would you like to continue? (Y/N): ");
                string answer = Console.ReadLine();

                while (true)
                {
                    if (answer == "yes" || answer = "y")
                    {
                        repeat = true
                    }

                }
            }
            
        }
    }
}
