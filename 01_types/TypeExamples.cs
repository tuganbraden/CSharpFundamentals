using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            // Whole numbers
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumber = 16;
            Int16 anotherSmallNumber = 16;
            int wholeNumber = 32;
            long largeWholeNumber = 64;

            int newNumber = oneBytesWorth;

            float floatExample = 1.234567f;
            double doubleExample = 1.237909;
            decimal decimalExample = 1.7000000m;

            char letter = 'j';


            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");
        }

        [TestMethod]
        public void ReferenceTypes()
        {
            string stringExample = "This is a string.";
            string name = "Braden";

            string declared;
            declared = "Now it's initialized.";

            string concatenate = stringExample + " " + name;
            string interpolate = $"{name}. Here is the string: {stringExample}";
            Console.WriteLine(interpolate);


            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2019, 6, 29);

            TimeSpan waitTime = randomDate - now;
            Console.WriteLine(waitTime.TotalSeconds);


            string anotherExampleString = "Hello World";
            string[] stringArray = { anotherExampleString, "Hello", "World", "!" };
            string[] students = new string[15];

            Console.WriteLine(stringArray);



            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence");

            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Luke");

            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Josh");

            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();

        }
    }
}
