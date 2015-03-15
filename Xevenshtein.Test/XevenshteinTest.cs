using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xevenshtein.Core;

namespace Xevenshtein.Test
{
    [TestClass]
    public class XevenshteinTest
    {
        [TestMethod]
        public void TestDistance_Succeed()
        {
            string a = "a";
            string b = "b";
            int expectedResult = 1;

            var result = Levenshtein.Compute(a, b);

            Assert.AreEqual(expectedResult, result);
        }


        [TestMethod]
        public void TestDistance_Fail()
        {
            string a = "b";
            string b = "b";
            int expectedResult = 1;

            var result = Levenshtein.Compute(a, b);

            Assert.AreEqual(expectedResult, result);
        }

 
    }
}
