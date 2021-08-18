using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Methods *****\n");

            #region Pass by value
            /* //TODO :Delete this line and wait for further instruction.
            // Pass two variables in by value.


            */ //TODO :Delete this line and wait for further instruction.
            #endregion

            #region Output params
            /*//TODO :Delete this line and wait for further instruction.
            // No need to assign initial value to local variables
            // used as output parameters.

            *///TODO :Delete this line and wait for further instruction.
            #endregion

            #region Ref params
            /*//TODO :Delete this line and wait for further instruction.

            *///TODO :Delete this line and wait for further instruction.
            #endregion

            #region Param array
            /*//TODO :Delete this line and wait for further instruction.
            // Pass in a comma-delimited list of doubles...


            // ...or pass an array of doubles.

           
            // Average of 0 is 0!

            *///TODO :Delete this line and wait for further instruction.
            #endregion

            #region Optional arguments / Named arguments
            /*//TODO :Delete this line and wait for further instruction.






            // This is OK, as positional args are listed before named args.


            // These work only if all args are optional.

            *///TODO :Delete this line and wait for further instruction.
            #endregion

            //Console.ReadLine();
        }

        #region Input paramerters
        /*//TODO :Delete this line and wait for further instruction.
        // Arguments are passed by value by default.

        {

            // Caller will not see these changes
            // as you are modifying a copy of the
            // original data.

        }
        *///TODO :Delete this line and wait for further instruction.
        #endregion

        #region Output parameters
        /*//TODO :Delete this line and wait for further instruction.
        // Output parameters must be assigned by the called method.
        {

        }

        // Returning multiple output parameters.
        static void FillTheseValues(out int a, out string b, out bool c)
        {

        }
        *///TODO :Delete this line and wait for further instruction.
        #endregion

        #region Ref parameters
        /*//TODO :Delete this line and wait for further instruction.
        // Reference parameters.
        public static void SwapStrings(ref string s1, ref string s2)
        {

        }
        *///TODO :Delete this line and wait for further instruction.
        #endregion

        #region Params array
        /*//TODO :Delete this line and wait for further instruction.
        // Return average of "some number" of doubles.
        static double CalculateAverage(params double[] values)
        {

        }
        *///TODO :Delete this line and wait for further instruction.
        #endregion

        #region Optional arguments
        /*//TODO :Delete this line and wait for further instruction.
        static void EnterLogData(string message, string owner = "Programmer")
        {

        }

        static void DisplayFancyMessage(ConsoleColor textColor = ConsoleColor.Blue,
            ConsoleColor backgroundColor = ConsoleColor.White, string message = "Test Message")
        {

        }
        *///TODO :Delete this line and wait for further instruction.
        #endregion
    }
}
