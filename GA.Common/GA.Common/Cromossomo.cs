using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.Common
{
    public class Cromossomo
    {

        //CHECK
        public Cromossomo()
        {
            this.iniciaGenes(GA.rand);
        }


        //CHECK
        public double Fitness
        {
            get
            {
                double[] genesDecodificados = this.decodificaGenes();
                double x = genesDecodificados[0];
                double y = genesDecodificados[1];

                return 20 + Math.Pow(x, 2) + Math.Pow(y, 2) - (10 * (Math.Cos(2 * Math.PI * x) + Math.Cos(2 * Math.PI * y)));
            }
            set { }
        }

        public string Genes { get; set; }

        //CHECK
        public string geraNumBinAleatorio(int min, int max, Random rand)
        {
            return formataNumBin(rand.Next(0, 2).ToString(), Convert.ToString(rand.Next(min, max), 2));
        }

        //CHECK
        public string formataNumBin(string sinal, string num)
        {
            //nesse rand.Next(0, 2).ToString() é dado o sinal. Vamos considerar 0 para negativo e 1 para positivo
            string binNumber = sinal + num;
            if (binNumber.Length < 10)
            {
                while(binNumber.Length < 10)
                {
                    binNumber = binNumber.Insert(1, "0");
                }
            }
            return binNumber;
        }

        //CHECK
        /// <summary>
        /// Decodifica os genes para forma decimal. Retorna array de doubles com os genes x e y
        /// </summary>
        /// <returns>Array de doubles com os genes x e y</returns>
        public double[] decodificaGenes()
        {
            bool xNegativo, yNegativo;
            xNegativo = this.Genes[0] == '0';
            yNegativo = this.Genes[10] == '0';

            double x = 0;
            double y = 0;
            int valorDaCasa = 1;

            for(int i = 9, j = 19; i > 0; i--,j--,valorDaCasa*=2)
            {
                x += (this.Genes[i] - '0') * valorDaCasa;
                y += (this.Genes[j] -'0') * valorDaCasa;
            }
            if (xNegativo) x *= -1;
            if (yNegativo) y *= -1;
            double[] genesDecodificados = new double[] { x/100, y/100 };
            return genesDecodificados;
        }


        //CHECK
        /// <summary>
        /// Inicia os genes do cromossomo com valores aleatórios
        /// </summary>
        public void iniciaGenes(Random rand)
        {
            this.Genes = geraNumBinAleatorio(0, 501, rand) + geraNumBinAleatorio(0, 501, rand);
        }
    }
}
