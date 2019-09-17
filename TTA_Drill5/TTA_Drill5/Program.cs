using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int Weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int Height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package width:");
            int Width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int Length = Convert.ToInt32(Console.ReadLine());

            string weightCheck = Weight <= 50 ? "Good your package is less than 50 lbs." : "sorry that package is too heavy";
            Console.WriteLine(weightCheck);
            Console.ReadLine();

            if(Weight <= 50)
            {
                int total = Height + Width + Length;
                
                string Result = total <= 50 ? "Great your dimensions are acceptable" : "Sorry we cant work with those dimensions";
                Console.WriteLine(Result);
                Console.ReadLine();

                if (total <= 50)
                {
                    int cost = total * Weight;
                    double cost2 = Convert.ToDouble(cost);

                    double sumTotal = cost2 / 100.00;
                    
                    Console.WriteLine("Your total is: $" + sumTotal);
                    Console.ReadLine();
                }
            }
            

            
        }
    }
}
