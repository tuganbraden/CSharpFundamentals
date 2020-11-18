using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 15;

            //1 Start
            //2 Condition
            //3 After
            //4 Body

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void ForeachLoops()
        {
            string name = "Eleven Fifty Academy";

            //1 collection
            //2 current iteration name
            //3 current iteration type
            //4 in keyword
            //5 body

            // foreach //3 //2  //4 //1
            foreach (char letter in name)
            {
                Console.WriteLine(letter); //5
            }

        }

        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while (total != 30)
            {
                Console.WriteLine(total);
                total++;
            }
        }
    }
}
