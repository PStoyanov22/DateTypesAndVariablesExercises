using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            sbyte hours = sbyte.Parse(Console.ReadLine());
            sbyte minutes = sbyte.Parse(Console.ReadLine());
            sbyte seconds = sbyte.Parse(Console.ReadLine());

            float totalSeconds = (hours * 3600) + (minutes * 60) + seconds;
            float totalHours = hours + (minutes / 60.0f) + (seconds / 3600.0f);
            float kilometers = distanceInMeters / 1000.0f;
            float miles = kilometers / 1.609f;


            Console.WriteLine(distanceInMeters / totalSeconds);
            Console.WriteLine(kilometers / totalHours);
            Console.WriteLine(miles / totalHours);

        }
    }
}
