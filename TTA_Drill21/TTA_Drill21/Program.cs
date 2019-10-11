using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill21
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { FirstName = "Joe", LastName = "Shmo", ID = 1 });
            employees.Add(new Employee { FirstName = "Greg", LastName = "Egg", ID = 2 });
            employees.Add(new Employee { FirstName = "Joe", LastName = "Low", ID = 3 });
            employees.Add(new Employee { FirstName = "Kevin", LastName = "Seven", ID = 4 });
            employees.Add(new Employee { FirstName = "Kyle", LastName = "Bile", ID = 5 });
            employees.Add(new Employee { FirstName = "Bertude", LastName = "Gertrude", ID = 6 });
            employees.Add(new Employee { FirstName = "Don", LastName = "Bomb", ID = 7 });
            employees.Add(new Employee { FirstName = "Agitha", LastName = "Lag-itha(?)", ID = 8 });
            employees.Add(new Employee { FirstName = "Bartholomew", LastName = "Molecule", ID = 9 });
            employees.Add(new Employee { FirstName = "Susan", LastName = "Boozin'", ID = 10 });

            List<Employee> JoeList = new List<Employee>();
            foreach (Employee person in employees)
            {
                if (person.FirstName == "Joe")
                {
                    JoeList.Add( person );
                    Console.WriteLine("First name: " + person.FirstName + ", Last Name: " +person.LastName + ", ID: " + person.ID + " test");
                    Console.ReadLine();
                }
            }

            List<Employee> People = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee x in People)
            {
                Console.WriteLine("First name: " + x.FirstName + ", Last Name: " + x.LastName + ", ID: " + x.ID);
                Console.ReadLine();
            }

            List<Employee> Counting = employees.Where(x => x.ID > 5).ToList();
            foreach(Employee x in Counting)
            {
                Console.WriteLine("First name: " + x.FirstName + ", Last Name: " + x.LastName + ", ID: " + x.ID);
                Console.ReadLine();
            }
        }
    }
}
