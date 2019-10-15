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
            
            const string Greeting = "Hello,";
            Console.WriteLine("Type in your name");
            var name = Console.ReadLine();
            Console.WriteLine("{0} {1}", Greeting,name);
            Console.WriteLine("How old are you?");
            PersonAge personAge = new PersonAge();

            try
                {
                personAge.sayAge();
                Console.ReadLine();
                }
                catch (AgeException)
                {
                    Console.WriteLine("Plese enter a whole number greater than 0");
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Something here went wrong..");
                    Console.ReadLine();
                }
        }
    }
}
