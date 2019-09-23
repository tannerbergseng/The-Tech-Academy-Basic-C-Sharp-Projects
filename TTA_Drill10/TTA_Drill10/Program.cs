using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTA_Drill10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myNums = new List<int>();
            myNums.Add(4);
            myNums.Add(90);
            myNums.Add(57);
            myNums.Add(2);
            myNums.Add(600);
            
            try
            {
                Console.WriteLine("Enter a number and I will divide it by my list of numbers.");
                int yourNum = Convert.ToInt32(Console.ReadLine());
                int answer1 = myNums[0] / yourNum;
                Console.WriteLine(answer1);
                int answer2 = myNums[1] / yourNum;
                Console.WriteLine(answer2);
                int answer3 = myNums[2] / yourNum;
                Console.WriteLine(answer3);
                int answer4 = myNums[3] / yourNum;
                Console.WriteLine(answer4);
                int answer5 = myNums[4] / yourNum;
                Console.WriteLine(answer5);
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number");
                return;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("please don't divide by zero.");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
