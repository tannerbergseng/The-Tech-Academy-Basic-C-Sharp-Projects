using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your email adress to sign in");
            string Email = Convert.ToString(Console.ReadLine());
            bool correctEmail = Email == "instructor@learncodinganywhere.com";

            do
            {
                switch (Email)
                {
                    case "instructor@learncodinganywhere.com":
                        Console.WriteLine("great signing in now..");
                        correctEmail = true;
                        break;

                    case "tannermbergseng@gmail.com":
                        Console.WriteLine("no that's my email you can't use my email");
                        Console.WriteLine("Please enter your email adress to sign in");
                        Email = Convert.ToString(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("sorry that email isnt on our record please try another");
                        Console.WriteLine("Please enter your email adress to sign in");
                        Email = Convert.ToString(Console.ReadLine());
                        break;

                }
                
            }
            while (!correctEmail);

            Console.ReadLine();

            if (correctEmail == true)
            {
                Console.WriteLine("Great, now that thats out of the way..");
                Console.ReadLine();
                Console.WriteLine("lets have a race, first to count to 100 wins(press enter to begin)");
                Console.ReadLine();

                int x = 0;
                while(x < 101)
                {
                    Console.WriteLine(x);
                    x++;
                   
                }
                Console.WriteLine("Im just gonna assume I won");
                Console.ReadLine();
                

            }

        }
    }
}
