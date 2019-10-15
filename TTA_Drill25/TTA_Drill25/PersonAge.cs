using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill25
{
    class PersonAge : Person
    {
        public override void sayAge()
        {
            if (YourAge <= 0)
            {
                throw new AgeException();
            }
            else
            {
                Console.WriteLine("You entered {0} as your age", YourAge);
                DateTime today = DateTime.Today;
                int birthyear = today.Year - YourAge;
                Console.WriteLine("you were born during {0}", birthyear);


            }
        }
    }
}
