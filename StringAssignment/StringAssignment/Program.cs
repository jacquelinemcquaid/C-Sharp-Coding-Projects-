using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = "Jacqueline";
            string lastname = "McQuaid";

            Console.WriteLine(firstname + lastname);
            Console.WriteLine("Type 'okay' to continue.");
            Console.ReadLine();

            int number1 = 3;
            int number2 = 8;

            Console.WriteLine(number1 + number2);
            Console.WriteLine("Type 'okay' to continue.");
            Console.ReadLine();

            string favWord1 = "delicious";
            string favWord2 = " food";

            Console.WriteLine(favWord1 + favWord2);
            Console.WriteLine("Type 'okay' to continue.");
            Console.ReadLine();

            firstname = firstname.ToUpper();
            Console.WriteLine(firstname);
            Console.WriteLine("Type 'okay' to continue");
            Console.ReadLine();

            string quote = "To the world you may be one person; \nbut to one person you may be the world. \n \n \t Be confident. \n \t Be you.";
            Console.WriteLine(quote);
            Console.WriteLine("Type 'okay' to continue.");
            Console.ReadLine();

            StringBuilder p0 = new StringBuilder();
            p0.Append("I am going to tell you about a few of my favorite things.");
            Console.WriteLine(p0);

            StringBuilder p1 = new StringBuilder();
            p1.Append("My favorite color is blue.");
            Console.WriteLine(p1);
            StringBuilder p2 = new StringBuilder();
            p2.Append("My favourite fruit is watermelon.");
            Console.WriteLine(p2);
            StringBuilder p3 = new StringBuilder();
            p3.Append("My favourite sport is swimming.");
            Console.WriteLine(p3);

            StringBuilder p4 = new StringBuilder();
            p4.Append("What are your favorite things?");
            Console.WriteLine(p4);
            Console.ReadLine();




            Console.ReadLine();






        }
    }
}
