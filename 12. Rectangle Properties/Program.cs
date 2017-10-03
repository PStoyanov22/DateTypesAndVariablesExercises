using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double rectangleWidth = double.Parse(Console.ReadLine());
            double rectangleHeight = double.Parse(Console.ReadLine());

            double rectangleDiagonal = Math.Sqrt((rectangleHeight * rectangleHeight) +
                                                 (rectangleWidth * rectangleWidth));

            Console.WriteLine(rectangleHeight * 2 + rectangleWidth * 2);
            Console.WriteLine(rectangleHeight * rectangleWidth);
            Console.WriteLine(rectangleDiagonal);
            
        }
    }
}
