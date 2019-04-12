using System;
using System.Linq;
using GA.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ToolsTests
    {
        [TestMethod]
        public void Should_GenerateRandomBinary()
        {
            var length = 10;
            var randomBinary = Tools.RandomBinary(length);

            for (int i = 0; i < length; i++)
            {
                var bit = randomBinary[i];
                Assert.IsTrue(bit == '1' || bit == '0');
            }

            Assert.AreEqual(length, randomBinary.Length);
        }
    }
}
