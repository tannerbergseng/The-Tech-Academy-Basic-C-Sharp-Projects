using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill24
{
    class Program
    {
        static void Main(string[] args)
        {

            const string Greeting = ("Hello,");
            Console.WriteLine("Type in your name");
            var name = Console.ReadLine();
            Console.WriteLine("{0} {1}", Greeting,name);
            Console.WriteLine("How old are you?");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered {0} as your age", age);
            Console.ReadLine();
        }
    }
}
