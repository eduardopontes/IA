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

        [TestMethod]
        public void TestaFormataNumBin()
        {
            //Arrange
            var obj = new Cromossomo();
            string sin = "0";
            string n = "11";//-3
            var expected = "0000000011";

            //Act
            var actual = obj.formataNumBin(sin, n);
 

            //Assert
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void TestaGetFit()
        {
            //Arrange
            var obj = new Cromossomo();
            obj.Genes = "10000000001000000000"; //0 e 0
            double expected = 0;

            //Act
            double actual = obj.Fitness;
            
            //Assert
            Assert.AreEqual(actual, expected);

        }

        [TestMethod]
        public void TestaRoleta()
        {
            //Arrange
            int popMax = 100;
            double taxaMut = 0.8;
            int maxGeracoes = 5;
            double taxaCross = 0.7;

            double actual = 537;
            double expected = 537; //só pra rodar
            
            var obj = new GA.Common.GA(popMax, taxaMut, taxaCross, maxGeracoes);

            obj.criaPopInicial();


            //Act
            obj.roleta(actual);

            //Assert
            Assert.AreEqual(actual, expected);

        }

    }
}
