using System;
using System.Collections.Generic;
using System.Text;
using Daniel_Roberts_Unit4_IT481;

namespace Daniel_Roberts_Unit4_IT481
{
    public class ExampleMethods
    {
        //Module 1
        public static int Example1(int[] arrayOfInts, int n)
        {
            int currMin = 100;
            for (int i = 0; i < n; i++)
            {
                if (arrayOfInts[i] < currMin)
                {
                    currMin = arrayOfInts[i];
                }
            }
            return currMin;
        }

        //Module 2
        public static void Example2(int[] arrayOfInts)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(arrayOfInts[i].ToString());
            }
        }

        //Module 3
        public static void Example3(int[] arrayOfInts)
        {
            int a = 10;
            int b = 5;
            bool found = false;

            for (int i = 0; i < arrayOfInts.Length; i++)
            {
                if (arrayOfInts[i] == a)
                {
                    Console.WriteLine("The value of a was found in int array.");
                    found = true;
                }
                else if (arrayOfInts[i] == b)
                {
                    Console.WriteLine("The value of a was found in int array.");
                    found = true;
                }
            }
            if (found == false)
            {
                Console.WriteLine("None of the search values were found.");
            }
        }
    }
}
