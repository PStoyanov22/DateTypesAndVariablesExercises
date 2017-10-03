using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            float eps = 0.000001f;

            bool areEqual = true;

            if (Math.Abs(numberOne - numberTwo) < eps)
            {
                
                Console.WriteLine(areEqual);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
