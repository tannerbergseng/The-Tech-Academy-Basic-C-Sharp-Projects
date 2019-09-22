using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill9
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1//////
            Console.WriteLine("I decided it was time for a new career path so I decided I'am going to be..");
            Console.ReadLine();
            Console.WriteLine("A Psychic!");
            Console.ReadLine();
            Console.WriteLine("Right, here we go I am going to read your mind, just think of anything at all" + "\n" + "Then type it(press enter one more time first). ");
            Console.ReadLine();

            string[] stringArray = new string[] { Console.ReadLine(), Console.ReadLine(), Console.ReadLine() };


            foreach (string i in stringArray)
            {
                Console.WriteLine("Okay here we go, the first thing you are thinking of is...");
                Console.ReadLine();
                Console.WriteLine("Now don't forget I cant read your screen this is all pure raw energy stuff going on.");
                Console.ReadLine();
                Console.WriteLine("You were thinking of.. " + stringArray[0]);
                Console.ReadLine();


                Console.WriteLine("Pretty good huh?");
                Console.ReadLine();
                Console.WriteLine("Here we go again the second thing you were thinking of was... ");
                Console.ReadLine();
                Console.WriteLine("Jar-Jar Binks? Why?");
                Console.ReadLine();
                Console.WriteLine("Sorry there must've been some spectral interference you were thinking of: " + stringArray[1]);
                Console.ReadLine();

                Console.WriteLine("And natually the last thing you were thinking of was: " + stringArray[2]);
                Console.ReadLine();


            }
                ///2///// infinite loop
                //Console.WriteLine("That was pretty good huh? (no refunds)");
                //Console.ReadLine();

                //do
                //{
                //    Console.WriteLine("Better than getting stuck in a loop anyway.");
                //    Console.ReadLine();

                //}
                //while (true);

                ///3/////
                Console.WriteLine("That was pretty good huh? (no refunds)");
                Console.ReadLine();
                int[] clicks = new int[] { 1, 2, 3, 4, 5 };



                foreach (int j in clicks)
                {
                    Console.WriteLine("Better than getting stuck in a loop anyway.");
                    Console.ReadLine();

                }

                ///4/////
                Console.WriteLine("Now again to show off my new abilities I will determine if you are thinking of a number greater than 100 " + "\n" + "(press enter 1 more time before typing)");
                Console.ReadLine();
                int yourNum = Convert.ToInt32(Console.ReadLine());

                if (yourNum < 100)
                {
                    Console.WriteLine("you were thinking of just a little baby number");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Using my spectral powers I can determine the number you were thining of was equal to or more than 100");
                    Console.ReadLine();

                }

                /////5/////
                Console.WriteLine("Okay not impressed? you try it.");
                Console.WriteLine("Just try to guess a number less than or equal to the one im thinking of");
                int myNum = 0;
                int userNum = Convert.ToInt32(Console.ReadLine());

                if (userNum <= myNum)
                {
                    Console.WriteLine("see the funny thing about 0 and negatives is they are numbers but lack any value");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("see not as easy as it looks");
                    Console.ReadLine();
                }

                /////6 && 7 && 8/////
                Console.WriteLine("Hmm you know all of this feels like a hollow victory");
                Console.WriteLine("I know! I'll be a history teacher instead!");
                Console.ReadLine();
                Console.WriteLine("Okay your job here is easy just type in any of the following and I will give you more info on what you typed!");
                Console.ReadLine();

                List<string> History = new List<string>();
                History.Add("Alcibiades");
                History.Add("Epidaurus");
                History.Add("Crete");

                Console.WriteLine("Alright take your pick:");
                Console.WriteLine("(1)" + History[0]);
                Console.WriteLine("(2)" + History[1]);
                Console.WriteLine("(3)" + History[2]);


                string Choice = Console.ReadLine();
                bool goodChoice = Choice == "Alcibiades";
                do
                {
                    switch (Choice)
                    {
                        case "Alcibiades":
                            Console.WriteLine("Good choice, Alcibiades was a famous Athenian statesman who was born in 424 BCE");
                            Console.WriteLine("He is known to have started an actual political crisis");
                            Console.WriteLine("Where he drunkenly snapped the penis off of multiple statues of the god Hermes");
                            Console.WriteLine("This lead to his untimley assassination in 404 BCE");
                            Console.WriteLine("Only the good die young.");
                            goodChoice = true;
                            break;

                        case "Epidaurus":
                            Console.WriteLine("This is a good one, Epidaurus or more specifically the theatre of Epidaurus.");
                            Console.WriteLine("This famous theatre which is completly made from stone seated about 14,000 people.");
                            Console.WriteLine("What started as a simple theatre soon became the stage for major Athenian debates in the 4th century");
                            Console.WriteLine("The reason the theatre was so great for debates was because it could fit so many people especially compared to the Pynx in Athens");
                            Console.WriteLine("But more importantly beacuse the acoustics are perfect, even if you were all the way at the top");
                            Console.WriteLine("You could hear the stage perfectly without any form of amplification");
                            goodChoice = true;
                            break;

                        case "Crete":
                            Console.WriteLine("I say Crete but I am actually referring to the ancient civilisation that used to live there");
                            Console.WriteLine("The Minoans. The Minoan civilization was an absolute power house from 2700 - 1450 BCE");
                            Console.WriteLine("They were very advanced for their time, especially in trade.");
                            Console.WriteLine("Before Crete was what it is now, a mostly desert island. It was a forrested island");
                            Console.WriteLine("And the Minoans loved it, they were the biggest suppliers of wood to ancient greece which was huge at the time");
                            Console.WriteLine("So why is it a desert island now? Good question. No one really has the answer.");
                            Console.WriteLine("There are theories that say they simply deforrested themselves into near extinction");
                            Console.WriteLine("There are also theories that a nearby volcano erupted and the ash killed most of the trees and crops");
                            Console.WriteLine("The truth is no one really knows because they kept so little records of everything that happened");
                            Console.WriteLine("We may never know what actually happened to the once rich and powerful Minoan people ");
                            goodChoice = true;
                            break;

                        default:
                            Console.WriteLine("Please check your spelling and capitalizations");
                            break;

                    }
                }
                while (!goodChoice);
                Console.ReadLine();

             /// 9 && 10/////
            Console.WriteLine("ugh that was a lot of reading lets do something more simple.");
                Console.WriteLine("im going to make a list of animals, and you type in any animal you want and we'll see if we come up with the same one.");

                List<string> animals = new List<string>();
                animals.Add("zebra");
                animals.Add("lion");
                animals.Add("bear");
                animals.Add("ferret");
                animals.Add("ferret");

                string userInput = Console.ReadLine();
                bool animalFound = false;
                for (int i = 0; i < animals.Count; i++)
                {

                    if (userInput == animals[i])
                    {
                        animalFound = true;
                        Console.WriteLine("The index of the animal you typed in was " + i);
                    }
                }
                if (animalFound == false)
                {
                    Console.WriteLine("The animal you chose wasn't on the list");

                }
                Console.ReadLine();




                ///11/////
                List<string> NewString = new List<string>();
            NewString.Add("Apple");
            NewString.Add("Potato");
            NewString.Add("Broccoli");
            NewString.Add("Orange");
            NewString.Add("Lettuce");
            NewString.Add("Broccoli");
            NewString.Add("Orange");
            NewString.Add("Lettuce");
            NewString.Add("Broccoli");
            NewString.Add("Potato");
            NewString.Add("Potato");
            NewString.Add("Potato");

            List<string> uniqueList = new List<string>();

            List<int> count = new List<int>();

            foreach (string match in NewString)
            {
                
                if (uniqueList.Contains(match))
                {
                    count[uniqueList.IndexOf(match)] += 1;
                }
                else
                {
                    uniqueList.Add(match);
                    count.Add(1);

                }

                Console.WriteLine(match + " has appeared " + count[uniqueList.IndexOf(match)] + " time(s)");
            }
           
            Console.ReadLine();




        








        }
    }
}
