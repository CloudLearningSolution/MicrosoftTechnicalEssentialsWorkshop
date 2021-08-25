using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyMathClass
    {
        public static readonly double PI = 3.14;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Const *****\n");
            //Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);
            // Error! Can't change a constant!
            // MyMathClass.PI = 3.1444;

            Console.ReadLine();
        }

        /* //TODO :Delete this line and wait for further instruction.
        static void LocalConstStringVariable()
        {
            // A local constant data point can be directly accessed.


            // Error!Can’t change a constant after initial value assignment. 
            // fixedStr = "This will not work!";
        }
        */ //TODO :Delete this line and wait for further instruction.
    }
}

