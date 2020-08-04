using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} X 50 = { a * 50}");
            Console.WriteLine("Enter 'okay' to continue");
            Console.ReadLine();

            Console.Write("Enter a number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{b} + 25 = { b + 25}");
            Console.WriteLine("Enter 'okay' to continue");
            Console.ReadLine();

            Console.Write("Enter a number:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"{c} / 12.5 = { c / 12.5}");
            Console.WriteLine("Enter 'okay' to continue");
            Console.ReadLine();

            Console.Write("Enter a number:");
            int d = int.Parse(Console.ReadLine());
            bool trueOrFalse = d > 50;
            Console.WriteLine("True or false: is your number greater than 50?");
            Console.WriteLine(trueOrFalse.ToString());
            Console.WriteLine("Enter 'okay' to continue.");
            Console.ReadLine();

            Console.Write("Enter a number to find its remainer:");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine($"{ e % 7}");
            Console.ReadLine();






        }
    }
}
