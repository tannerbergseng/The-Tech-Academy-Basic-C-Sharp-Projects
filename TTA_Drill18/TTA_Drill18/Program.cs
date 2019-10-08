using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill17
{
    class Program 
    {
        static void Main(string[] args)
        {

            Employee<string> ThingString = new Employee<string>();
            ThingString.Things = new List<string>();
            ThingString.Things.Add("A thing");
            ThingString.Things.Add("Another thing");
            ThingString.Things.Add("The last thing");

            Employee<int> IntThings = new Employee<int>();
            IntThings.Things = new List<int>();
            IntThings.Things.Add(1);
            IntThings.Things.Add(2);
            IntThings.Things.Add(3);

            foreach (string Items in ThingString.Things)
            {
                Console.WriteLine(Items);
                Console.ReadLine();
            }

            foreach (int Item in IntThings.Things)
            {
                Console.WriteLine(Item);
                Console.ReadLine();
            }
            //IQuittable Quit = new Employee();
            //Quit.Quit();
            //Employee employee = new Employee();

            //employee.fName = "Sample";
            //employee.lName = "Student";
            //employee.ID = 1;

            //employee.fName1 = "Sample";
            //employee.lName1 = "Student";
            //employee.ID1 = 2;
            //employee.sayName();
            //Console.ReadLine();

            //if (employee.ID == employee.ID1)
            //{
            //    Console.WriteLine(true);
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //    Console.ReadLine();
            //}

        }
    }
}
