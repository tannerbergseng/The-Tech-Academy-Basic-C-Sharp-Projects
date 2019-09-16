using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("what is your age?");
            string Age = Console.ReadLine();
            int userAge = Convert.ToInt32(Age);
            bool checkAge = Convert.ToBoolean(userAge);

            Console.WriteLine("have you ever had a dui, please type 'true' or 'false'");
            string DUICheck = Console.ReadLine();
            bool DUIReq = Convert.ToBoolean(DUICheck);

            Console.WriteLine("How many speeding tickets do you have?(Please use numerical value 1,2,ect..)");
            string Speeding = Console.ReadLine();
            int speedRacer = Convert.ToInt32(Speeding);
            bool SpeedCheck = Convert.ToBoolean(speedRacer);

            if (speedRacer <= 3 && userAge >= 15 && DUIReq == false)
            {
                    Console.WriteLine("Congrats you qualify!");
                    Console.ReadLine();
            }
            else
            {
                Console.WriteLine("sorry you dont meet our requirements..");
                Console.ReadLine();
            }

            
   




    }
    }
}
