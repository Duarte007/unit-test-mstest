using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using classes;

namespace test2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestScaleneTriangle()
        {
            Triangle t1 = new Triangle(5, 10, 9);
            string type = t1.getType();
            Assert.AreEqual(type, "escaleno");
        }

        [TestMethod]
        public void TestIsoscelesTriangle()
        {
            Triangle t1 = new Triangle(10, 10, 12);
            string type = t1.getType();
            Assert.AreEqual(type, "isosceles");
        }

        [TestMethod]
        public void TestEquilateralTriangle()
        {
            Triangle t1 = new Triangle(5, 5, 5);
            string type = t1.getType();
            Assert.AreEqual(type, "equilatero");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Invalid values for triangle")]
        public void InvalidValuesTriangle()
        {
            Triangle t1 = new Triangle(20, 15, 5);
        }
    }
}
