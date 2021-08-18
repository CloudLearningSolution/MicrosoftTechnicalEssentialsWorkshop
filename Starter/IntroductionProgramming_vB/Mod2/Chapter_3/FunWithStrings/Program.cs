using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Strings *****\n");
            //BasicStringFunctionality();
            //StringConcatenation();
            //EscapeChars();
            //StringsAreImmutable();
            //FunWithStringBuilder();
            //StringInterpolation();
            Console.ReadLine();
        }

        #region String basics
        /*//TODO :Delete this line and wait for further instruction.
        static void BasicStringFunctionality()
        {

        }
        *///TODO :Delete this line and wait for further instruction.
        #endregion

        #region Concatenation
        /*//TODO :Delete this line and wait for further instruction.
        static void StringConcatenation()
        {

        }
        *///TODO :Delete this line and wait for further instruction.
        #endregion

        #region Escape Chars
        /*//TODO :Delete this line and wait for further instruction.
        static void EscapeChars()
        {


            // Adds a total of 4 blank lines (then beep again!).


            // The following string is printed verbatim
            // thus, all escape characters are displayed.

            // White space is preserved with verbatim strings.

        }
        *///TODO :Delete this line and wait for further instruction.
        #endregion

        #region Immutable test
        /*//TODO :Delete this line and wait for further instruction.
        static void StringsAreImmutable()
        {
            //// Set initial string value.
            //string s1 = "This is my string.";
            //Console.WriteLine("s1 = {0}", s1);

            //// Uppercase s1?
            //string upperString = s1.ToUpper();
            //Console.WriteLine("upperString = {0}", upperString);

            //// Nope! s1 is in the same format!
            //Console.WriteLine("s1 = {0}", s1);


        }
        *///TODO :Delete this line and wait for further instruction.
        #endregion

        #region StringBuilder
        /*//TODO :Delete this line and wait for further instruction.
        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");

            // Make a StringBuilder with an initial size of 256.

        }
        *///TODO :Delete this line and wait for further instruction.
        #endregion

        #region String interpolation
        /*//TODO :Delete this line and wait for further instruction.
        static void StringInterpolation()
        {
            // Some local variables we will plug into our larger string
            int age = 4;
            string name = "Soren";

            // Using curly bracket syntax.
            string greeting = string.Format("\tHello {0} you are {1} years old.", name.ToUpper(), age);
            Console.WriteLine(greeting);

            // Using string interpolation
            string greeting2 = $"\tHello {name.ToUpper()} you are {age} years old.";
            Console.WriteLine(greeting2);
        }
        *///TODO :Delete this line and wait for further instruction.
        #endregion
    }
}
