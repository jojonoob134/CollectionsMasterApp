using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] myArray = new int[50];
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            for (int i = 1; i <= myArray.Length; i++)
            {
                myArray[i - 1] = i;
            }

            //TODO: Print the first number of the array
            int first = myArray[0];
            //TODO: Print the last number of the array            
            int last = myArray[myArray.Length - 1];
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine($"First number is {first} and last number is {last}");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(myArray);
            experiment();
            Array.Reverse(myArray);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            for (int i = 1; i <= myArray.Length; i+= 3)
            {
                myArray[i - 1] = 0;
            }


            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(myArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> myList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(myList.Count);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            for (int i = 0; i < 50; i++)
            {
                myList.Add(i);
            }

            //TODO: Print the new capacity
            Console.WriteLine(myList.Count);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            NumberChecker();

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            
            Console.WriteLine("-------------------");

            foreach (int num in myList)
            {
                Console.WriteLine(num);
            }

            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            myList.RemoveAll(myList => myList % 2 != 0);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            myList.Sort();
            foreach (int num in myList)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] listArray = new int[30];
            for (int i = 0; i < myList.Count; i++)
            {
                int change = myList[i];
                listArray[i] = change;
            }
            //TODO: Clear the list
            myList.Clear();

            #endregion
        }
        public static void experiment()
        {
            int[] myArray = new int[50];
            for (int i = 1; i <= myArray.Length; i++)
            {
                myArray[i - 1] = i;
            }
            Array.Reverse(myArray);
            for (int i = 1;i <= myArray.Length; i++)
            {
                Console.WriteLine(myArray[i - 1]);
            }
        }

        public static void ThreeKiller(int[] numbers)
        {
            
        }

        private static void OddKiller(List<int> numberList)
        {
            
        }

        public static void NumberChecker()
        {
            int inList = (int.Parse(Console.ReadLine()));
            List<int> myList = new List<int>();
            bool myBool = false;
            for (int i = 0; i < 50; i++)
            {
                myList.Add(i);
            }
            foreach (int num in myList)
            {
                if (inList == num)
                {
                    Console.WriteLine($"yes {num} is here");
                    myBool = true;
                }
            }
            if (myBool == false)
            {
                Console.WriteLine("no your number is not here");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

        }

        private static void ReverseArray(int[] array)
        {
            
        }
        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
