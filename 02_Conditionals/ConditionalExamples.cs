using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isTrue = 17 > 5;
            bool isFalse = 17 == 4;

        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool isTrue = true;
            if (isTrue)
            {

            }

            int age = 12;

            if(age > 17)
            {
                Console.WriteLine("You are an adult");
            }
            else if (age > 6)
            {
                Console.WriteLine("You are still a kid");
            }
            else if (age > 0)
            {
                Console.WriteLine("You are too young to be on a computer");
            }
            else
            {
                Console.WriteLine("You aren't even born yet");
            }

            if (age > 65 && age < 18)
            {

            }

            if (age <= 65 || age >= 18)
            {

            }

            if (age == 17)
            {

            }

            if (age != 19)
            {

            }


        }

        [TestMethod]
        public void SwitchCases()
        {
            int age = 42;

            switch (age)
            {
                case 18:
                    //code
                    break;
                case 19:
                    //code
                    break;
                case 20:
                case 22:
                case 23:
                    //code for all 3
                    break;
                default:
                    //catch all code
                    Console.WriteLine("You are not 18-23");
                    break;

            }
        }

        [TestMethod]
        public void Ternaries()
        {
            int age = 37;

            // bool someVariable = (boolean statement) ? trueValue : falseValue;

            bool isAge = (age == 24) ? true : false;

        }
    }
}
