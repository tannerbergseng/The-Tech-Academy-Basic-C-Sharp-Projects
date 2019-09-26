using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill12
{
    class Employee
    {
        public double payRate;
        public double hoursWorked;

        static void Employee1(double payRate, double hoursWorked)
        {
            double weeklyEarning = payRate * hoursWorked;
        }
    }
}
