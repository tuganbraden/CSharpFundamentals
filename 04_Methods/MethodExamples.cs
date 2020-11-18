using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class MethodExamples
    {
        //input
        //what we do
        //output

        //Access mod   Return type    Signature (name and list of parameters)
        public int addTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public int addTwoNumbers(int x)
        {
            return x;
        }

        private int subTwoNumbers(int a, int b)
        {
            return a - b;
        }

        private int multTwoNumbers(int x, int z)
        {
            return x * z;
        }

        private int divTwoNumbers(int n1, int n2)
        {
            return n1 / n2;
        }
        
        private int remainder(int a, int num2)
        {
            return a % num2;
        }


        [TestMethod]
        public void MethodTests()
        {
            int b = addTwoNumbers(7, 12);
            Assert.AreEqual(19, b);

            int subB = subTwoNumbers(10, 5);
            Assert.AreEqual(5, subB);

            int mB = multTwoNumbers(12, 5);
            Assert.AreEqual(60, mB);

            int dB = divTwoNumbers(10, 4);
            Assert.AreEqual(2, dB);

            int rem = remainder(10, 4);
            Assert.AreEqual(2, rem);

        }
    }
}
