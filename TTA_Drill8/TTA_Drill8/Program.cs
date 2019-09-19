using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill8
{
    class Program
    {
        static void Main()
        {
            List<string> Greeting = new List<string>();
            Greeting.Add("Shalom (Hebrew)");
            Greeting.Add("Guten tag (German)");
            Greeting.Add("Zdravstvuyte (Russian)");
            Greeting.Add("Bonjour (French)");
            Greeting.Add("Salve (Italian)");
            Greeting.Add("Asalaam alaikum (Arabic)");

            Console.WriteLine("Select an index (0-5) and I will say \"Hello\" in a differnt language. ");
            int Index = Convert.ToInt32(Console.ReadLine());
           
            // index checker
            if (Index > 5)
            {
                Console.WriteLine("please select 0 - 5 next time ");
                Console.ReadLine();
            }
            Console.WriteLine(Greeting[Index]);
            Console.ReadLine();
            
            //new array
            int[] numArray = new int[] { 42, 69, 420, 666, 13, 7 };

            Console.WriteLine("Now lets do the same thing with numbers, just select 0-5 again");
            int Index2 = Convert.ToInt32(Console.ReadLine());
            
            // index checker
            if (Index2 > 5)
            {
                Console.WriteLine("please select 0 - 5 next time ");
                Console.ReadLine();
            }

            Console.WriteLine(numArray[Index2]);
            Console.WriteLine("It's funny how some numbers can carry more than their numeric value.");
            Console.ReadLine();
           
            //new array
            string[] stringArray = new string[] { "L'hitraot", "Auf Wiedersehen", "Do svidaniya", "Au Revoir", "Arrivederci", "Ma'a as-salaama" };

            Console.WriteLine("we've reached the end of this journey select one last index (0-5) and I will say \"Goodbye\" using the same languages.");
            int Index3 = Convert.ToInt32(Console.ReadLine());
            
            // index checker
            if (Index3 > 5)
            {
                Console.WriteLine("please select 0 - 5 next time ");
                Console.ReadLine();
            }

            Console.WriteLine(stringArray[Index3]);
            Console.ReadLine();

            
        }
    }
}
