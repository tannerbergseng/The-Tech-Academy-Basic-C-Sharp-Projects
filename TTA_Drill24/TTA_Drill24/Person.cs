using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill24
{
    abstract class Person
    {
        public int YourAge = Convert.ToInt32(Console.ReadLine());
             
        
        public abstract void sayAge();

    }
}
