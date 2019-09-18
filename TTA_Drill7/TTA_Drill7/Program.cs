using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill7
{
    class Program
    {
        static void Main(string[] args)
        {
            string Indy4 = "Indiana jones 4 was not as bad as people think. ";
            string Reason = "Indiana Jones 4 is just as outlandish as the rest of the series. ";
            string Reason2 = "All of the Inidana Jones movies are B-movies with A-movie budgets. ";

            Indy4 = Indy4.ToUpper();
            string Argument = Indy4 + Reason + Reason2;
            Console.WriteLine(Argument);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("So I've been rewatching all of the Indiana Jones movies and I've came to the conclusion that kingdom of the crystal skull is a fine movie. ");
            sb.Append("I've looked into why people hate the movie so much and almost all of the reasons could translate into the other movies. ");
            sb.Append("Like people saying the fridge scene is so horribly stupid but it's just as believable as him jumping out of a plane with a woman and a child on an inflatable raft and smoothly sled down a mountain and off of a [redacted] waterfall.");

            
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
