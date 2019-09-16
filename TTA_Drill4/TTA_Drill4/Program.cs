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
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int userAge = Convert.ToInt32(age);
            bool checkAge = Convert.ToBoolean(userAge);

            Console.WriteLine("Have you ever had a DUI, please type 'true' or 'false'");
            string DUICheck = Console.ReadLine();
            bool DUIReq = Convert.ToBoolean(DUICheck);

            Console.WriteLine("How many speeding tickets do you have?");
            string Speeding = Console.ReadLine();
            int speedRacer = Convert.ToInt32(Speeding);
            bool speedRacerCheck = Convert.ToBoolean(speedRacer);

            bool qualified = true && true && true;

            if (qualified)
            {
                bool = checkAge && DUIReq && speedRacerCheck;
            }

        }
    }
}
