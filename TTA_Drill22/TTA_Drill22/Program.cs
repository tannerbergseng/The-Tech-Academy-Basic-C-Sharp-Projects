using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TTA_Drill22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number any number");
            int number = Convert.ToInt32(Console.ReadLine());
            string number1 = Convert.ToString(number);

            File.WriteAllText(@".\Log.txt", number1);

            using (StreamWriter file = new StreamWriter(@".\Log.txt", true))
            {
                file.WriteLine(number1);
                Console.ReadLine();
            }
        }
    }
}
