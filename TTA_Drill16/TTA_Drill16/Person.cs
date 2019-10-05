using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill16
{
    public class Person
    {
        public List<string> Employee { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }

        public void sayName()
        {
            Console.WriteLine("Name: {0} {1}", fName, lName);
        }
    }
}
