using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week");
            string userInput = Console.ReadLine();
           
            try
            {
                daysOfTheWeek day = (daysOfTheWeek) Enum.Parse(typeof(daysOfTheWeek), userInput, true);
                Console.WriteLine("you entered: " + day);
                Console.ReadLine();
            }
            catch (Exception )
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
        }
        public enum daysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
