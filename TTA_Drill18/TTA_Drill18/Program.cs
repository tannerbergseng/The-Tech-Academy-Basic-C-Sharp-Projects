using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill17
{
    class Program : Employee
    {
        static void Main(string[] args)
        {
           
            IQuittable Quit = new Employee();
            Quit.Quit();
            Employee employee = new Employee();

            employee.fName = "Sample";
            employee.lName = "Student";
            employee.ID = 1;

            employee.fName1 = "Sample";
            employee.lName1 = "Student";
            employee.ID1 = 2;
            employee.sayName();
            Console.ReadLine();

            if (employee.ID == employee.ID1)
            {
                Console.WriteLine(true);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(false);
                Console.ReadLine();
            }

            
            
        }
    }
}
