using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            short centuries = sbyte.Parse(Console.ReadLine());
            int years = 100 * centuries;
            double days = years * 365.2422;
            long hours = (long)days * 24;
            ulong minutes = (ulong)hours * 60;
            ulong seconds = (ulong)minutes * 60;
            decimal milliseconds = (decimal)seconds * 1000;

            decimal microseconds = (decimal)milliseconds * 1000;
            decimal nanoseconds = (decimal)microseconds * 1000;

            Console.Write($"{centuries} centuries = ");
            Console.Write($"{years} years = ");
            Console.Write($"{Math.Floor(days)} days = ");
            Console.Write($"{hours} hours = ");
            Console.Write($"{minutes} minutes = ");
            Console.Write($"{seconds} seconds = ");
            Console.Write($"{milliseconds} milliseconds = ");
            Console.Write($"{microseconds} microseconds = ");
            Console.Write($"{nanoseconds} nanoseconds");

        }
    }
}
