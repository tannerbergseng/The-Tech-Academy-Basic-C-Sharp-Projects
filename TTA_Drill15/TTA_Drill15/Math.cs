using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill15
{
    class Math
    {
        public void mathMethod(int a, int b = 2)
        {
            int result = a / b;
            Console.WriteLine(result);
        }
        public void mathMethod(int a , int b, int c)
        {
            int sum = a + b + c;
            Console.WriteLine(sum);
        }
    }
}
