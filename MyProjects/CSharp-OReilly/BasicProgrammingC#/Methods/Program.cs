using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceParametersLecture
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 5;
            int z; // have to be created when used with "ref" -- if it used bu "out" the variable can be null.
            ChangeNumber(x);
            ChangeNumber(out z);
            Console.WriteLine("Value for X: "+x); // outputs 5
            Console.WriteLine("Value for Z: "+z); // outputs 0
            Console.ReadKey();

            Console.WriteLine("Enter a name:");
            SayHello(Console.ReadLine());
            Console.WriteLine("Enter a second name:");
            SayHello(Console.ReadLine());
            Console.WriteLine("Enter a third name:");
            SayHello(Console.ReadLine(), true);

             // ----------------------------
             // Methods Exercise 2

             int number;
             do
             {
                Console.Write("Enter an integer (1 to exit): ");
                number = Convert.ToInt32(Console.ReadLine());
                
                if (number != 1)
                {
                    if (IsPrimeNumber(number))
                        Console.WriteLine(number + " is a prime number");
                    else
                        Console.WriteLine(number + " is not a prime number");
                }

             } while (number != 1);

            */
             // -------------------------------------------------------
             // Method Overloading and Ref/Out Parameters

             int a, b, c, sum;

             Console.WriteLine("Enter an integer: ");
             a=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter a second integer");
             b=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter a third integer: ");
             c=Convert.ToInt32(Console.ReadLine());

            sum = AddThreeIntegers(a,b,c);
            Console.WriteLine("the sum of the three integers is "+sum);

            Console.WriteLine("Enter an integer: ");
             a=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter a second integer");
             b=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter a third integer: ");
             c=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("the sum of the three integers is "+AddThreeIntegers(a,b,c,ref sum));


             


        }
        static void ChangeNumber(int y)
        {
            y = 0;
        }
        static void ChangeNumber(out int y) // ref is useful for returning multi values
        {
            y = 0;
        }
        // ----------------------------

        static void SayHello(string _name, bool AskHowAreYou = false)
        {
            Console.Write("Hello! "+_name+" ");
            if (AskHowAreYou)
            {
                Console.WriteLine("How are you? ");
            }
            else 
            {
                Console.WriteLine();
            }
            Console.ReadKey();
        }

         // ----------------------------

         static bool IsPrimeNumber(int number)
         {
            bool isPrime = true;
            for (int i = 2; i < number; i++)
            {
                if (number % 2 == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
         }

         static int AddThreeIntegers(int a, int b, int c)
         {
            return a + b + c;
         }
         static int AddThreeIntegers(int a, int b, int c, ref int sum)
         {
            return sum = a + b + c ;
         }


    }
}