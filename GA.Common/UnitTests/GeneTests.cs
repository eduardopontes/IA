using GA.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class GeneTests
    {
        [TestMethod]
        public void Should_BeNegative()
        {
            var gene = new Gene("1000000000");

            Assert.IsFalse(gene.IsNegative);
        }

        [TestMethod]
        public void Should_BePositive()
        {
            var gene = new Gene("0000000000");

            Assert.IsTrue(gene.IsNegative);
        }

        [TestMethod]
        public void Should_ThrowException_When_InvalidLengthIsProvided()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Gene(""));
        }
    }
}
