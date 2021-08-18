using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImplicitlyTypedLocalVars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Implicit Typing *****");
            //DeclareImplicitVars();
            //QueryOverInts();
            //Console.WriteLine();
            //Console.ReadKey();
        }

        #region Implicit data typing
        /*//TODO :Delete this line and wait for further instruction.
        static void DeclareImplicitVars()
        {
            // Implicitly typed local variables.


            // Print out the underlying type.

        }

        static int GetAnInt()
        {

        }

        static void ImplicitTypingIsStrongTyping()
        {
            // The compiler knows "s" is a System.String.


            // Can invoke any member of the underlying type.

            // Error! Can't assign numerical data to a a string!
            // s = 44;
        }
        *///TODO :Delete this line and wait for further instruction.
        #endregion

        #region LINQ example
        /*//TODO :Delete this line and wait for further instruction.
        static void QueryOverInts()
        {




            // Hmm...what type is subset?

        } 
        *///TODO :Delete this line and wait for further instruction.
        #endregion

    }

    #region Bad use of var!
    // Uncomment to see compile errors.
    //class ThisWillNeverCompile
    //{
    //    // Error! var cannot be used as field data!
    //    private var myInt = 10;

    //    // Error! var cannot be used as a return value
    //    // or parameter type!
    //    public var MyMethod(var x, var y) { }
    //}
    #endregion
}
