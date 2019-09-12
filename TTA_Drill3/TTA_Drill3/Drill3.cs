using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill3
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Hourly rate of person1:");
            Console.WriteLine(15);
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine(40);
            Console.ReadLine();
            Console.WriteLine("Person 2");
            Console.WriteLine("hourly rate?");
            Console.WriteLine(20);
            Console.WriteLine("hours worked per week?");
            Console.WriteLine(40);
            Console.ReadLine();
            Console.WriteLine("Weekly salary of person1:");
            int product = 15 * 40;
            Console.WriteLine(product);
            Console.ReadLine();
            Console.WriteLine("Weekly salary of person2:");
            int product2 = 20 * 40;
            Console.WriteLine(product2);
            Console.ReadLine();
            Console.WriteLine("does person 1 make more than person 2?");
            bool checkNum = 600 > 800;
            Console.WriteLine(checkNum);
            Console.ReadLine();
      
            
            

        }
    }
}
