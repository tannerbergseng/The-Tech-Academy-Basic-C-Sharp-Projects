using System;


namespace TTA_Drill13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in an integer and I will do a math");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Math math = new Math(num1, num2);
            int methodResults = math.MathMethod(num1, num2);
            Console.WriteLine(methodResults);
            Console.ReadLine();

            Console.WriteLine("Now put in some numbers with decimals.");
            decimal num3 = Convert.ToDecimal(Console.ReadLine());
            decimal num4 = Convert.ToDecimal(Console.ReadLine());
            Math math1 = new Math(num3, num4);
            int methodResults1 = math1.MathMethod(num3, num4);
            Console.WriteLine(methodResults1);
            Console.ReadLine();

            Console.WriteLine("Now add a couple more integers");
            string num5 = Console.ReadLine();
            string num6 = Console.ReadLine();
            Math math2 = new Math(num5, num6);
            int methodResults2 = math2.MathMethod(num5, num6);
            Console.WriteLine(methodResults2);
            Console.ReadLine();

        }
        
    }
}
