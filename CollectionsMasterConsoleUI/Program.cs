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

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(1, 50);
            int[] myArray = Populater(1, 50);
            //TODO: Print the first number of the array
            int first = myArray[0];
            //TODO: Print the last number of the array            
            int last = myArray[myArray.Length - 1];
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myArray);
            Console.WriteLine($"First number is {first} and last number is {last}");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            

            Console.WriteLine("All Numbers Reversed:");
            myArray = ReverseArray(myArray);
            NumberPrinter(myArray);


            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            //experiment(myArray);
            ThreeKiller(myArray);
            Console.WriteLine();
            NumberPrinter(myArray);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(myArray);
            NumberPrinter(myArray);

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
            

            myList = Populater(myList);

            //TODO: Print the new capacity
            Console.WriteLine(myList.Count);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            NumberChecker(myList);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            
            Console.WriteLine("-------------------");

            NumberPrinter(myList);

            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(myList);
            NumberPrinter(myList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            myList.Sort();
            NumberPrinter(myList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] listArray = new int[50];
            for (int i = 0; i < myList.Count; i++)
            {
                int change = myList[i];
                listArray[i] = change;
            }
            //TODO: Clear the list
            myList.Clear();
            NumberPrinter(listArray);

            #endregion

        }
        public static void experiment(int[] myArray)
        {
            
            for (int i = 1; i <= myArray.Length; i++)
            {
                Console.WriteLine(myArray[i - 1]);
            }
        }

        public static int[] ThreeKiller(int[] myArray)
        {
            int l = 0;
            foreach (int i in myArray)
            {
                int three = i % 3;
                if (three == 0)
                {
                    myArray[l] = 0;
                }
                l++;
            }
            return myArray;
        }

        private static List<int> OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(myList => myList % 2 != 0);
            return numberList;
        }

        public static void NumberChecker(List<int> myList)
        {
            bool myBool = false;
            bool sameNum = false;
            int checkNum;
            while (!myBool)            {
                string isNumThere = Console.ReadLine();
                if (int.TryParse(isNumThere, out checkNum))
                {
                    foreach (int num in myList)
                    {
                        if (checkNum == num)
                        {
                            Console.WriteLine($"Yes we do have {num} in the list");
                            sameNum = true;
                        }
                    }
                    myBool = true;
                }
                else
                {
                    Console.WriteLine("sorry but you did not type a number please type again a number you want");
                }
            }
            if (!sameNum)
            {
                Console.WriteLine("this list dose not have the same number in");
            }
        }

        public static List<int> Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            { 
                int ranNum = rng.Next(1, 50);
                numberList.Add(ranNum);
            }
            return numberList;
        }
        

        public static int[] Populater(int min, int max)
        {
            int[] myArray = new int[50];
            Random rng = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rng.Next(min,max + 1);
            }
            return myArray;
        }

        public static int[] ReverseArray(int[] array)
        {
            Array.Reverse(array);
            return array;
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
