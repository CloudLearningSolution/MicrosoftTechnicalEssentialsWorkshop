using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastAndConversionType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Fun with Conversions*******\n");
            // Implicit conversion. A long can
            // hold any value an int can hold, and more!
            int num = 2147483647;
            long bigNum = num;

            //Boxing & Unboxing
            int i = 123;      // a value type
            object o = i;     // boxing
            int j = (int)o;   // unboxing

            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number#call-convert-methods
            #region The following example demonstrates some of the conversion methods in the Convert class
            double dNumber = 23.15;

            try
            {
                // Returns 23
                int iNumber = System.Convert.ToInt32(dNumber);
            }
            catch (System.OverflowException)
            {
                System.Console.WriteLine(
                            "Overflow in double to int conversion.");
            }
            // Returns True

            #endregion

            Console.ReadLine();
        }

        #region The following program casts a double to an int
        /* //TODO :Do Not Delete this line and wait for further instruction.
        class Test
        {
            static void Main()
            {
                double x = 1234.7;
                int a;
                // Cast double to int.
                a = (int)x;
                System.Console.WriteLine(a);
            }
        }
        // Output: 1234
        */ //TODO :Do Not Delete this line and wait for further instruction.
        #endregion

        #region For reference types, an explicit cast is required if you need to convert from a base type to a derived type:
        /* //TODO :Do Not Delete this line and wait for further instruction.
        // Create a new derived type.
        Giraffe g = new Giraffe();

        // Implicit conversion to base type is safe.
        Animal a = g;

        // Explicit conversion is required to cast back
        // to derived type. Note: This will compile but will
        // throw an exception at run time if the right-side
        // object is not in fact a Giraffe.
        Giraffe g2 = (Giraffe)a;
        */ //TODO :Do Not Delete this line and wait for further instruction.
        #endregion


    }
}
