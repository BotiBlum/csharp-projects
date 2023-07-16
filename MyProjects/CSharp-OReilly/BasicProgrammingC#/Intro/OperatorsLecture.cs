using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsLecture
{   
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            // + - * /
            int x = 1;
            int y = 1;
            int sum;

            sum = x + y; // evaluates to 2
            Console.WriteLine("Sum: " + sum);

            //-------------------------------------

            double double1 = 5.0 / 2.0; // evaluates to 2.5
            double double2 = 5 / 2; // evaluates to 2
            Console.WriteLine("double1: "+double1.ToString());
            Console.WriteLine("double2: "+double2.ToString());

            //-------------------------------------

            int? remainder = null;;
            remainder = 7 % 3; // evaluates to 1
            Console.WriteLine(remainder);
            remainder = 6 % 3; // evaluates to 0
            Console.WriteLine(remainder);

            //-------------------------------------

            y = 1;
            x = ++y; // y is incremented to 2, x is set to 2
            Console.WriteLine(x);

            y = 2;
            x = --y; // y is decremented to 1, x is set to 1
            Console.WriteLine(x);
            
            y = 1;
            x = ++y; // x is set to 1, y is incremented to 2
            Console.WriteLine(x);
            
            y = 2;
            x = --y; // x is set to 2, y is decremented to 1
            Console.WriteLine(x);

             //-------------------------------------

             // these two statements do the same thing
             x += y;
             x = x + y;

             // these two statements do the same thing
            x -= y;
            x = x - y;

            // these two statements do the same thing
            x *= y;
            x = x * y;

            // these two statements do the same thing
            x /= y;
            x = x / y;

             //-------------------------------------

             sum = 1 + 2 * 5; // evaluates to 11

             // HIGHEST PRECEDENCE
             // ++, -- (prefix)
             // *, /, %
             // +, -
             // =, +=, -=, *=, /=
             // ++, -- (postfix)
             // LOWEST PRCEDENCE

             sum = (1 + 2) * 5; // evaluates to 15

              //-------------------------------------

            string string1 = "pro";
            string string2 = "gramming";
            Console.WriteLine(string1+string2);  // outputs "programming"


            //-------------------------------------

            int myInteger = 765;
            double myDouble = 7.2;

            myDouble = myInteger; // implicit conversion
            Console.WriteLine("Implicit: "+myDouble);

            myDouble = 7.2;
            myInteger = (int)myDouble; // explicit conversion
            Console.WriteLine("Explicit: "+myInteger);

            //-------------------------------------

            string myString = "5";
            myInteger = Convert.ToInt32(myString);
            Console.WriteLine(myInteger);

            

            char userInput;
            Console.WriteLine("Enter a character: ");
            userInput = Console.ReadKey().KeyChar;

            Console.WriteLine();
            Console.WriteLine("You entered: " + userInput);
            Console.ReadKey();

            string userInputString;

            Console.WriteLine("Enter some text: ");
            userInputString = Console.ReadLine();
            Console.WriteLine("You entered: " + userInputString);
            Console.ReadKey(); 

            */

            string usersName;
            int usersAge;
            string friendsName;
            int friendsAge;

            Console.Write("Enter your name: ");
            usersName = Console.ReadLine();
            Console.Write("Enter your age: ");
            usersAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is "+usersName+" and your are "+usersAge +" years old");
            Console.WriteLine();

            Console.Write("Enter your friend's name: ");
            friendsName = Console.ReadLine();
            Console.Write("Enter your friend's age: ");
            friendsAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your friend's name is "+friendsName+" and it is "+ friendsAge +" years old");
            Console.WriteLine();


        }
    }
}