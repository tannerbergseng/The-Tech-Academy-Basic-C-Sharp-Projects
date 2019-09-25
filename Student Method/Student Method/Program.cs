using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("See if you made the honor roll, enter your First name, your major, and your GPA");
            string name = Console.ReadLine();
            string major = Console.ReadLine();
            double GPA = Convert.ToDouble(Console.ReadLine());
            Student student1 = new Student(name, major, GPA);
            

            Console.WriteLine(student1.hasHonors());
            

            Console.ReadLine();
        }
    }
}
