using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string employeeFirstName = Console.ReadLine();
            string employeeLastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalId = long.Parse(Console.ReadLine());
            ulong uniqueEmployeeNumber = ulong.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}", employeeFirstName);
            Console.WriteLine("Last name: {0}", employeeLastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", personalId);
            Console.WriteLine("Unique Employee number: {0}", uniqueEmployeeNumber);
        }
    }
}
