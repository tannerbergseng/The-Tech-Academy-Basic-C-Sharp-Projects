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
            Employee employee = new Employee();
            employee.fName = "Sample";
            employee.lName = "Student";
            employee.sayName();
            Console.ReadLine();
        }
    }
}
