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

            StringBuilder sb = new StringBuilder();
            sb.Append("My favorite color is blue.");
            Console.WriteLine(sb);
            Console.ReadLine();






        }
    }
}
