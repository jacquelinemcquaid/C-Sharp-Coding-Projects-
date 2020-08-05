using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int a = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Have you ever had a DUI? (yes/no)");
            string b = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int c = int.Parse(Console.ReadLine());

           

            bool qualified = true || false;

            if (a > 15)
            {
                qualified = true;
            }
            
            else if (a <= 15)
                    {
                qualified = false;
            }

            if (b == "no")
            {
                qualified = true;
            }

            else if (b == "yes")
            {
                qualified = false;
            }

            if (c <= 3)
            {
                qualified = true;
            }

            else if (c > 3)
            {
                qualified = false;
            }

            Console.WriteLine("Are you qualified?");
            Console.WriteLine(qualified);
            Console.ReadLine();
            







            

            






        }
    }
}
