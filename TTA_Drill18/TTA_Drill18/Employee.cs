using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill17
{
   class Employee<T> : Person, IQuittable
    {
        public List<T> Things;
        
        //public int ID;
        //public int ID1;

        //public static bool operator==(Employee ID, Employee ID1)
        //{
        //    bool isEqual = ID == ID1;
        //    return true;
        //}
        //public static bool operator!=(Employee ID, Employee ID1)
        //{
        //    bool notEqual = ID != ID1;
        //    return false;
        //}
        public override void sayName()
        {
            Console.WriteLine(fName);
            Console.WriteLine(lName);

        }
        public void Quit()
        {

        }
    }
}
