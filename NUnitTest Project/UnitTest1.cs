using NUnit.Framework;
using DroneFactory;
using System;
using System.Data;
using System.Data.Common;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NUnitTest_Project

{
    [TestFixture]
    public class Tests
    {

        /*[SetUp]
        public void Setup()
        {
            //Optionally, set some local variable value required for testing
        }*/

        [Test]
        [Repeat(2)]//Repeats a method N number of times, if any fails, remaining will not run.
        //[TestCase(10, 20, 30)] //TestCase attribute used for declaring different test cases
        public static void Test1()
        {
            string[] droneTypes = { "Action Drone", "Advanced Aircraft", "Aero Systems", "AgEagle" };
            foreach (var c in droneTypes)
                Console.WriteLine(c);
            //This attribute indicates the method to be tested
                Assert.Pass();
        }

        /*[TearDown]
        public void TearDown()//Inidicate methods will be executed after every test case.
        {
            //reset values
        }*/
    }
}