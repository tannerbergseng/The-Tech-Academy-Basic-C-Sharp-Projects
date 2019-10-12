using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            DateTime CurrentTime = DateTime.Now;
            Console.WriteLine("type in a number");
            int number = Convert.ToInt32(Console.ReadLine());
            DateTime ChangedHour = CurrentTime.AddHours(number);
            Console.WriteLine("It will be {0} in {1} hour(s) ", ChangedHour, number);
            Console.ReadLine();
        }

    }
}
