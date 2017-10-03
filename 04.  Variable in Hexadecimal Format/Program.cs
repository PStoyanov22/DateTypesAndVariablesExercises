using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = Console.ReadLine();

            int convertedOutput = Convert.ToInt32(output, 16);

            Console.WriteLine(convertedOutput);
        }
    }
}
