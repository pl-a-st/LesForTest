using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LesForTest;

namespace UnitTest {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void SumTest() {
            AbstractClass abstractClass = new AbstractClass();
            int sum = abstractClass.Sum(value1: 5, value2: 4);
            Assert.AreEqual(expected: 8, sum);
        }
        [TestMethod]
        public void SumTest2() {
            AbstractClass abstractClass = new AbstractClass();
            int sum = abstractClass.Sum(value1: 5, value2: 4);
            Assert.AreEqual(expected: 9, sum);
        }
    }
}
