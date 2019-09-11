using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTAdrill2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type any number and it will be multiplied by 50");
            string userNum = Console.ReadLine();
            int myNum = 50;
            int userNum2 = Convert.ToInt32(userNum);
            int product = myNum * userNum2;
            Console.WriteLine(product);

            Console.WriteLine("Type any number and it will be added by 25");
            string userNumber = Console.ReadLine();
            int userNumber2 = Convert.ToInt32(userNumber);
            int myNumber = 25;
            int productNumber = userNumber2 + myNumber;
            Console.WriteLine(productNumber);
            Console.ReadLine();

            Console.WriteLine("Type any number and it will be divided by 12.5");
            string getNum = Console.ReadLine();
            int getNum2 = Convert.ToInt32(getNum);
            double staticNum = 12.5;
            double quotient = getNum2 / staticNum;
            Console.WriteLine(quotient);
            Console.ReadLine();

            Console.WriteLine("Type in a number and it will be determined if it is greater or less than or equal to 50");
            string getNumber = Console.ReadLine();
            int getNumber2 = Convert.ToInt32(getNumber);
            int staticNumber = 50;
            bool checkNum = staticNumber <= getNumber2;
            Console.WriteLine(checkNum);
            Console.ReadLine();

            Console.WriteLine("Type in a number and it will be divided by 7 and print the remainder");
            string shrek = Console.ReadLine();
            int shrek2 = Convert.ToInt32(shrek);
            int donkey = 7;
            int remainder = shrek2 % donkey;
            Console.WriteLine(remainder);
            Console.ReadLine();
        }
    }
}
