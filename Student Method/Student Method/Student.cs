using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill11
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }


        public bool hasHonors()
        {
            if(gpa >= 3.5)
            {
                Console.WriteLine("Congrats you made it on the honor roll!");
                return true;
            }
            Console.WriteLine("Sorry you didn't quite make the honor roll");
            return false;
        }
    }
}
