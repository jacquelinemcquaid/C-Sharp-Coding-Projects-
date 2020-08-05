using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");

            Console.Write("What is your hourly wage?");
            int a = int.Parse(Console.ReadLine());

            Console.Write("How many hours do you work per week?");
            int b = int.Parse(Console.ReadLine());


            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine($"{ a * b * 52 }");
            Console.WriteLine("Enter 'okay' to continue");
            Console.ReadLine();

            Console.WriteLine("Person 2");

            Console.Write("What is your hourly wage?");
            int c = int.Parse(Console.ReadLine());

            Console.Write("How many hours do you work per week?");
            int d = int.Parse(Console.ReadLine());


            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine($"{ c * d * 52 }");
            Console.WriteLine("Enter 'okay' to continue");
            Console.ReadLine();

            Console.WriteLine("True or false: Person 1 makes more money than Person 2");

            bool trueOrFalse = a * b * 52 > c * d * 52;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

        }
    }
}
