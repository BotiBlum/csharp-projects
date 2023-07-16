using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicLecture
{
    public class Program
    {
        static void Main_(string[] args)
        {
            bool answer;
            answer = false;
            Console.WriteLine("Is it raining today? " + (answer == true));
            Console.WriteLine(answer);

            // BOOLEAN OPERATORS
            // == equality
            // != inequality
            // ! NOT
            // > Greater than
            // < Less than
            // >= Greater than or equal to
            // <= Less than or equal to
            // && logical AND
            // || logical OR

            answer = (1 == 1); // evaluates to true
            answer = (1 != 2); // evaluates to true
            answer = !(false); // evaluates to true

            answer = (2 > 1); // evaluates to true
            answer = (1 < 2); // evaluates to true
            answer = (2 >= 1); // evaluates to true
            answer = (2 >= 2); // evaluates to true
            answer = (1 <= 2); // evaluates to true
            answer = (2 <= 2); // evaluates to true

            answer = (true && true); //  evaluates to true
            answer = (true && false); // evaluates to false
            answer = (false && false); // evaluates to false

            answer = (true || true); // evaluates to true
            answer = (true || false); // evaluates to true
            answer = (false || false); // evaluates to false

            Console.ReadKey();

            // HIGER PRECEDENCE
            // !
            // < > <= >=
            // == !=
            // &&
            // ||
            // LOWER PRECEDENCE

            bool expression;
            expression = 2 > 5 || 4 == 4 && 6 <= 7;

            // 2 > 5 || 4 == 4 && 6 <= 7
            // false || 4 == 4 && 6 <= 7
            // false || 4 == 4 && true
            // false || true && true
            // false || true
            // true

            Console.WriteLine(expression); // outputs "True"
            Console.ReadKey();
        }
    }
}