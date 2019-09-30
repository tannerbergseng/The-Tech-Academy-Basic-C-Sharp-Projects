using System;


namespace TTA_Drill14
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleClass anExample = new ExampleClass();
            Console.WriteLine("Type in an integer");
            int required = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now type in another or leave it blank");
            string optionalInt = Console.ReadLine();
            if (optionalInt == "")
            {
                anExample.ExampleMethod(required);
            }
            else
            {
                int int2 = Convert.ToInt32(optionalInt);
                anExample.ExampleMethod(required, int2);
            }
            Console.ReadLine();
        }
    }
}
