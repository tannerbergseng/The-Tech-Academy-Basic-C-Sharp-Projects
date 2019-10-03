using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill15
{
    static class Program
    {
        static void Main(string[] args)
        {
            Math aMethod = new Math();
            Console.WriteLine("Type in an integer and it will be divided by 2");
            int a = Convert.ToInt32(Console.ReadLine());
            
            aMethod.mathMethod(a);
            Console.ReadLine();

            
            int i;
            Addition(out i);

            Console.WriteLine("Now add two more integers");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            aMethod.mathMethod(a);
            Console.ReadLine();

        }
        public static void Addition(out int i)
        {
            i = 30;
            i += i;
            Console.WriteLine("Here is the output method: " + i);
            Console.ReadLine();
        }
    }
}
