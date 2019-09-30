using System;


namespace TTA_Drill14
{
    class ExampleClass
    {
        
        public void ExampleMethod(int required,  int optionalInt = 10)
        {
            int result = required + optionalInt;
            Console.WriteLine(result);
        }
    }
}
