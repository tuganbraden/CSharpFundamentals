using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class InClassLoopExamples
    {
        [TestMethod]
        public void Loops()
        {
            int studentCount = 10;

            for (int i = 0; i <= studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] names = { "Michael", "Simon", "Peyton", "Casey" };
            //Console.WriteLine(names);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(names.Length); //give the number of items in array
            
            while(studentCount > 0)
            {
                Console.WriteLine(studentCount);
                studentCount -= 1;
            }
        }
    }
}
