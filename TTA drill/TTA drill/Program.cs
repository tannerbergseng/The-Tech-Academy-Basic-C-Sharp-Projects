using System;


namespace TTA_drill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("Great, you are on " + courseName);

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("You sumbmitted page number " + pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'");
            string needHelp = Console.ReadLine();
            bool Help = Convert.ToBoolean(needHelp);

            if (Help)
            {
                Console.WriteLine("You typed true, an instructor will help you shortly! ");
            }
            else
            {
                Console.WriteLine("You typed false, good work!");
            }

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics");
            string Experience = Console.ReadLine();
            Console.WriteLine("Good job, glad to see everything going well!");
            
            

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific");
            string Feedback = Console.ReadLine();
            Console.WriteLine("Thank you for your feedback");


            Console.WriteLine("How many hours did you study today?");
            string Hours = Console.ReadLine();
            int TotalHours = Convert.ToInt32(Hours);
            Console.WriteLine("Good job on studying " + Hours); Console.WriteLine("hours today");
            
      

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
