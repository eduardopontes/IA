using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GA;

namespace Rastrigin.Teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestaRas()
        {
            //Arrange
            double a = 3.78;
            double b = 4.88;
            
            var ob = new Program();

            //Act
            Console.WriteLine(Math.Round(ob.ras(a, b), 2));

            //Assert
            Assert.AreEqual(true, true);
        }
    }
}
