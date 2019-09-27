using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill13
{
    class Math
    {
        public Math(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        public Math(double num3 , double num4)
        {
            double product = num3 * num4;
            int TotalProduct = Convert.ToInt32(product);
            Console.WriteLine(TotalProduct);
            Console.ReadLine();
        }

        public Math(string num5, string num6)
        {
            int num7 = Convert.ToInt32(num5);
            int num8 = Convert.ToInt32(num6);
            int Division = num7 / num8;
            Console.WriteLine(Division);
            Console.ReadLine();
            
        }
        
    }
}
