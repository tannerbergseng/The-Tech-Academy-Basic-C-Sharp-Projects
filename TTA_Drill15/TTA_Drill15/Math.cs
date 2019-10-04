using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill15
{
     static class Math
    {
        public static void MathMethod(int a, out int result)
        {
            result = a / 2;
        }
        public static void MathMethod(int a, int b, int c, out int sum)
        {
            sum = a + b + c;
        }

        public static void Addition(out int i)
        {
            i = 30;
            i += i;
            Console.WriteLine("Here is the output method: " + i);

        }
    }
}
