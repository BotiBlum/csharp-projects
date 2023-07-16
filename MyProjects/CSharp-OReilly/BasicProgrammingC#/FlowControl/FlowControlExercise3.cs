using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControlExercise3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string likesPizza;
            bool validResponse;

            do
            {
                Console.WriteLine("\nDo you like pizza?: ");
                likesPizza = Console.ReadLine();

                if (likesPizza == "yes")
                {
                    Console.Write("You like pizza!");
                    validResponse = false;
                }
                else if (likesPizza == "no")
                {
                    Console.Write("You do not like pizza?: ");
                    validResponse = false;
                }
                else 
                {
                    Console.Write("You did not enter a valid response, please try again.");
                    validResponse = true;
                }

            //    Console.Write(likesPizza);
                
            } while (validResponse);
        }        
    }
}

