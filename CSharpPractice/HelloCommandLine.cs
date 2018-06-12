using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class HelloCommandLine
    {
        static void Main(String []args)
        {
            Console.WriteLine("Your name");
            string name = Console.ReadLine();
            Console.WriteLine("How many hours did you sleep");
            int hoursOfSleep = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello: " + name);
            if(hoursOfSleep >8)
            {
                Console.WriteLine("You are all rested");
            }
            else
            {
                Console.WriteLine("You need more sleep");
            }

        }
    }
}
