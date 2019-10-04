using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math aMethod = new Math();
            Console.WriteLine("Type in an integer and it will be divided by 2");
            int t = Convert.ToInt32(Console.ReadLine());
            
            Math.MathMethod(t, out int x);
            Console.WriteLine("Your number divided by 2: " + x);
            Console.ReadLine();
            
            Console.WriteLine("Now add two more integers");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Math.MathMethod(t,b,c, out int sum);
            Console.WriteLine("The sum of all numbers is "+ sum);
            Console.ReadLine();

            Math.Addition(out int i);
            Console.ReadLine();
        }
       
    }
}
