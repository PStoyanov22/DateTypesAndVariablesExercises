using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            long picturesTaken = long.Parse(Console.ReadLine());
            long secondsForFiltering = long.Parse(Console.ReadLine());
            long filterFactorPercentage = long.Parse(Console.ReadLine());
            long uploadTimePerPicture = long.Parse(Console.ReadLine());

            double goodPictures = Math.Ceiling(picturesTaken * filterFactorPercentage / 100.0);

            long totalFilteredPictureTimeInSec = picturesTaken * secondsForFiltering;
            double TotalUploadTime = goodPictures * uploadTimePerPicture;
            long totalSeconds = totalFilteredPictureTimeInSec + (long)TotalUploadTime;

           

            TimeSpan span = TimeSpan.FromSeconds(totalSeconds);
            string totalTime = span.ToString(@"d\:hh\:mm\:ss");


            Console.WriteLine(totalTime);


        }
    }
}
