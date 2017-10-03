using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            for (int sequentNumber = 2; sequentNumber <= number; sequentNumber++)
            {
                bool isPrime = true;
                for (int currentDivisor = 2; currentDivisor <= Math.Sqrt(sequentNumber); currentDivisor++)
                {
                    if (sequentNumber % currentDivisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{sequentNumber} -> {isPrime}");
            }
            
            
        }
    }
}
