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
            
            Console.WriteLine("Now add two more integers");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            aMethod.mathMethod(a,b,c);
            Console.ReadLine();

            aMethod.Addition(out int i);
            Console.ReadLine();
        }
       
    }
}
