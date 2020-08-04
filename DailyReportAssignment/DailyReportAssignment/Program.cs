using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College");
         
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you in?");
            string currentCourse = Console.ReadLine();
      

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
            bool helpNeeded = true;
            string needsHelp = Convert.ToString(helpNeeded);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you would like to share? Please give specifics.");
            string feedback = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you would like to provide? Please be specific.");
            string moreFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();






        }
    }
}
