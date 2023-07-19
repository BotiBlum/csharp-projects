using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationLecture
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yoda said \"Do or do not, there is no try\"");
            Console.WriteLine("the file is located in the C:\\Users\\ directory");
            Console.WriteLine("Typing backlash n in a string\nwill cause a line break");

            string myString;
            myString = "abc";
            Console.WriteLine(myString.Length); // outputs "3"

            myString = "I'm Learning C#";
            Console.WriteLine(myString.ToLower()); // outputs "True"
            Console.WriteLine(myString.ToUpper()); // outputs "False"

            myString = "This is fun!";
            Console.WriteLine(myString.Contains("fun")); // outputs "True"
            Console.WriteLine(myString.Contains("boring")); // outputs "False"

            myString = "This is fun!";
            Console.WriteLine(myString.IndexOf('i')); // outputs "2"
            Console.WriteLine(myString.IndexOf('j')); // outputs "-1"


            myString = "This is fun!";
            Console.WriteLine(myString.Substrings(5));  // outputs "is fun!"
            Console.WriteLine(myString.Substrings(5, 2)); // outputs "is"

            myString = "This is fun!";
            Console.WriteLine(myString.Remove(5)); // outputs "This "
            Console.WriteLine(myString.Remove(5, 2)); // outputs "This fun!"

            myString = "This is fun!";
            Console.WriteLine(myString.Replace("fun", "awesome")); // outputs "This is awesome!"
            
            int myint = 5;
            double myDouble = 5.44735453;
            bool myBool = false;

            myString = myint.ToString();
            myString = myDouble.ToString("F"); // 5.43 will be stored in mystring
            myString = myBool.ToString();

        }
    }
}

namespace StringManipulationLecture2
{
    public class Program
    {
        static void Main_(string[] args)
        {
            int numBananas = 7;
            int numApples = 5;

            Console.WriteLine("There are "+ numBananas + " bananas and "+ numApples+ " apples"); // string concatenation
            Console.WriteLine("There are {0} bananas and {1} apples", numBananas, numApples); // string formating
            Console.WriteLine($"There are {numBananas} bananas and {numApples} apples"); // string interpolation
            Console.WriteLine($"There are {numBananas + numApples} pieces of fruit."); // string interpolation
        }
        
    }
    
}