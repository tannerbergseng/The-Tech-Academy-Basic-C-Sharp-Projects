using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill17
{
   class Employee : Person
    {
        public override void sayName()
        {
            Console.WriteLine(fName);
            Console.WriteLine(lName);
        }
    }
}
