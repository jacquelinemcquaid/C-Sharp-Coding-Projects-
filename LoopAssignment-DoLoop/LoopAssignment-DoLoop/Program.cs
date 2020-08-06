using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignment_DoLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number between 1 and 100.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPicked = number == 27;

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You picked 1. Try again.");
                        Console.WriteLine("Pick a number between 1 and 100.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 27:
                        Console.WriteLine("You picked 27. You are correct!");

                        isPicked = true;
                        break;

                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Pick a number between 1 and 100.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }

            while (isPicked == false);
            Console.ReadLine();
        }


    }
}
