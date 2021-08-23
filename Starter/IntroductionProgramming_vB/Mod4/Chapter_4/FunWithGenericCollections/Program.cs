using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithGenericCollections
{
    #region Person class for testing
    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, int age)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}, Age: {2}",
              FirstName, LastName, Age);
        }
    }
    #endregion

    #region SortPeopleByAge class
    class SortPeopleByAge : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            if (firstPerson.Age > secondPerson.Age)
                return 1;
            if (firstPerson.Age < secondPerson.Age)
                return -1;
            else
                return 0;
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Generic Collections *****\n");
            //UseGenericList();
            Console.WriteLine();

            //UseGenericQueue();
            Console.WriteLine();

            //UseGenericStack();
            Console.WriteLine();

           // UseSortedSet();
            Console.WriteLine();

            //UseDictionary();
            Console.WriteLine();

            Console.ReadLine();
        }

        #region Use List<T>
        /* //TODO :Delete this line and wait for further instruction.
        private static void UseGenericList()
        {
            // Make a List of Person objects, filled with 
            // collection / object init syntax.


            // Print out # of items in List.

            // Enumerate over list.


            // Insert a new person.


            // Copy data into a new array.

        }
        */ //TODO :Delete this line and wait for further instruction.
        #endregion

        #region Use Queue<T>
        /* //TODO :Delete this line and wait for further instruction.
        static void GetCoffee(Person p)
        {
            Console.WriteLine("{0} got coffee!", p.FirstName);
        }

        static void UseGenericQueue()
        {
            // Make a Q with three people.


            // Peek at first person in Q.

            // Remove each person from Q.


            // Try to de-Q again?

        }
        */ //TODO :Delete this line and wait for further instruction.
        #endregion

        #region Use Stack<T>
        /* //TODO :Delete this line and wait for further instruction.
        static void UseGenericStack()
        {


            // Now look at the top item, pop it, and look again.



        }
        */ //TODO :Delete this line and wait for further instruction.

        #endregion

        #region Use SortedSet<T>
        /* //TODO :Delete this line and wait for further instruction.
        private static void UseSortedSet()
        {
            // Make some people with different ages.


            // Note the items are sorted by age!


            // Add a few new people, with various ages. 


        }
        */ //TODO :Delete this line and wait for further instruction.
        #endregion

        #region Use Dictionary<K,V>
        /* //TODO :Delete this line and wait for further instruction.
        private static void UseDictionary()
        {
            // Populate using Add() method


            // Get Homer.


            // Populate with initialization syntax.


            // Get Lisa.


            // Populate with dictionary initialization syntax.


            // Get Marge.

        }
        */ //TODO :Delete this line and wait for further instruction.
        #endregion
    }
}
