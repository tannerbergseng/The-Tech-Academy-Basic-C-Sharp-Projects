using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your pay rate and your hours worked and I will determine how much you can expect to make in a week.");
            double payRate = Convert.ToDouble(Console.ReadLine());
            double hoursWorked = Convert.ToDouble(Console.ReadLine());
            
            Employee employee = new Employee();

            employee.employeeMethod(payRate, hoursWorked);

            employee.employeeMethod(payRate: payRate, hoursWorked:hoursWorked);
            
            Console.ReadLine();
        }
    }
}
