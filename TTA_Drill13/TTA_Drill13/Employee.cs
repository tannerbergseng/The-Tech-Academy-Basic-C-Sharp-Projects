using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill12
{
    public class Employee
    {
        public void employeeMethod(double payRate, double hoursWorked)
        {
            double weeklyEarning = payRate * hoursWorked;
            Console.WriteLine("You worked: " + hoursWorked + " hours, and you made: $" + weeklyEarning + " this week");
        }
    }
}
