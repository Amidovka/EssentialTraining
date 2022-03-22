using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestClass]
    public class SimpleArrayTest
    {
        [TestMethod]
        public void TestInstantiation()
        {
            var testInstance = new SimpleArray();
            Assert.AreEqual(testInstance.GroceryList.Length, 4, "I expect length to be 4");
            Assert.AreEqual(testInstance.GroceryList[1], "Milk");
        }

        [TestMethod]
        public void TestToString()
        {
            var testInstance = new SimpleArray();
            Assert.IsTrue(testInstance.ToString().StartsWith("There are"));
        }
    }
}
