using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.
            Console.Write("please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("please enter your locaiton: ");
            string location = Console.ReadLine();
            //3.
            Console.WriteLine("your name is: "+name);
            Console.WriteLine("your location is: "+location);
            //4.
            var today = DateTime.Today;
            Console.WriteLine("today is " + today.ToShortDateString());
            //5.
            var christmas = new DateTime(today.Year, 12 ,25);
            var dayC = (christmas - today);
            Console.WriteLine(dayC.Days+" days till christams");
            //6. 
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write("please enter the width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("please enter the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
            //7.
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
