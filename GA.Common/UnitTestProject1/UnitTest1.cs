using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GA;
using GA.Common;

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
            
            var ob = new RunRastrigin();

            //Act
            Console.WriteLine(Math.Round(ob.ras(a, b), 2));

            //Assert
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestaDecodificaGenes()
        {
            //Arrange
            var ob = new Cromossomo();
            ob.Genes = "01000000001000000111"; //-256 e 7
            double[] expected = {-2.56, 0.07};

            //Act
            double[] actual = ob.decodificaGenes();

            //Assert
            Assert.IsTrue(actual[0] == expected[0] && actual[1] == expected[1]);

        }
    }
}
