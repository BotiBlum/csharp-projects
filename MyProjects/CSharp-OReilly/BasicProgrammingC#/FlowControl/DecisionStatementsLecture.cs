using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionStatementsLecture
{
    public class Program
    {
        static void Main_(string[] aargs)
        {
            /*

            if (express)
                // do this
            */
            int age = 10;
            if (age >= 18)
                    Console.WriteLine("You are old enough to vote!"); // just for one line of code
            Console.WriteLine("Have a nice day!");

            age = 20;
            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote!"); // just for one line of code
                Console.WriteLine("Congratulations!");
            }

            for (int i = 1; i <= 3; i++)
            {
                if (i == 2)
                {
                    //break; 
                    continue; // skip all the remaining code but continue the for loop.
                }
                Console.WriteLine(i); // continue writes 1 and 3 number
            }
            Console.WriteLine("Out!");
                    

            Console.ReadKey();
        }
    }
    
}