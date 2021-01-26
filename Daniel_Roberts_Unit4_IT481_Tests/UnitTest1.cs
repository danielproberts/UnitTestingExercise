using System;
using System.IO;
using Daniel_Roberts_Unit4_IT481;
using NUnit.Framework;

namespace Daniel_Roberts_Unit4_IT481_Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ShouldExample1Test1()
        {
            //Declare Input Array
            int[] arrayOfInts = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Run Method
            int actualResult = ExampleMethods.Example1(arrayOfInts, 10);
            //Check if expected and actual results match
            Assert.That(actualResult, Is.EqualTo(1));
        }

        [Test]
        public void ShouldExample1Test2()
        {
            //Declare Input Array
            int[] arrayOfInts = new int[1] { 101 };
            //Run Method
            int actualResult = ExampleMethods.Example1(arrayOfInts, 1);
            //Check if expected and actual results match
            Assert.That(actualResult, Is.EqualTo(101));
        }

        [Test]
        public void ShouldExample2Test1()
        {
            //Declare Input Array
            int[] arrayOfInts = new int[5] { 1, 2, 3, 4, 5 };
            //Run Method
            ExampleMethods.Example2(arrayOfInts);
        }

        [Test]
        public void ShouldExample2Test2()
        {
            //Declare Input Array
            int[] arrayOfInts = new int[200];
            //Declare StringWriter to catch Console output for comparison
            var sw = new StringWriter();
            Console.SetOut(sw);
            //Run Method
            ExampleMethods.Example2(arrayOfInts);
            string actualResult = sw.ToString();
            //Each Line will be "0\n" for a total of 3 characters per line
            //200 values should result in a total result length of 600 characters
            Assert.AreEqual(actualResult.Length, 600);
        }

        [Test]
        public void ShouldExample3Test1()
        {
            //Declare Input Array
            int[] arrayOfInts = new int[5] { 1, 2, 3, 4, 5 };
            //Declare StringWriter to catch Console output for comparison
            var sw = new StringWriter();
            Console.SetOut(sw);
            //Run Method
            ExampleMethods.Example3(arrayOfInts);
            string actualResult = sw.ToString();
            //Check if expected and actual results match
            Assert.AreEqual(actualResult, "The value of b was found in int array.\r\n");
        }

        [Test]
        public void ShouldExample3Test2()
        {
            //Declare Input Array
            int[] arrayOfInts = new int[2] { 5, 10 };
            //Declare StringWriter to catch Console output for comparison
            var sw = new StringWriter();
            Console.SetOut(sw);
            //Run Method
            ExampleMethods.Example3(arrayOfInts);
            string actualResult = sw.ToString();
            //Check if expected and actual results match
            Assert.AreEqual(actualResult, "The value of a was found in int array.\r\nThe value of b was found in int array.\r\n");
        }
    }
}