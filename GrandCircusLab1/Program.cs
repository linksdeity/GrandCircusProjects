using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double area;
                double length;
                double width;
                double perimeter;
                double height;
                double volume;
                string widthInput;
                string lengthInput;
                string heightInput;
                char check;

                Console.Write("Welcome to Grand Circus' Room Detail Generator!\n\n");

                Console.Write("\nEnter width in feet: ");
                widthInput = Console.ReadLine();

                Console.Write("\nEnter length in feet: ");
                lengthInput = Console.ReadLine();

                Console.Write("\nplease enter the height in feet: ");
                heightInput = Console.ReadLine();

                width = double.Parse(widthInput);
                length = double.Parse(lengthInput);
                height = double.Parse(heightInput);

                area = (width * length);
                perimeter = ((width * 2) + (length * 2));
                volume = (width * length * height);


                Console.Write("\nArea is: {0} feet", area);
                Console.Write("\nPerimeter is: {0} feet", perimeter);
                Console.Write("\nVolume is: {0} feet cubed", volume);

                Console.WriteLine("\n\n\nWould you like to measure again?");
                Console.WriteLine(" 'n' to quit, anything else to continue...");


                check = Console.ReadKey(true).KeyChar;

                if (check == 'n' || check == 'N')
                {
                    Console.Clear();
                    Console.Write("\n\n\nbye bye!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }


            
            


        }
    }
}
