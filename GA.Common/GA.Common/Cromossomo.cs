using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.Common
{
    public class Cromossomo
    {
        //public double Fitness {
        //    get { return 20 + Math.Pow(x, 2) + Math.Pow(y, 2) - (10 * (Math.Cos(2 * Math.PI * x) + Math.Cos(2 * Math.PI * y))); }
        //    set { }
        //}

        public string Genes { get; set; }

        public string geraStringNumBinAleatorio()
        {
            //nesse rand.Next(0, 2).ToString() é dado o sinal. Vamos considerar 0 para negativo e 1 para positivo
            //PRECISA FAZER SEMPRE DAR STRING DO TAMANHO CERTO. PARA 3 DEVERIA RETORNAR 1000000011 E NÃO 111 (PRIMEIRO 1 É SINAL)
            var rand = new Random();
            return rand.Next(0, 2).ToString() + Convert.ToString(rand.Next(0, 501), 2);
        }

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
                x += (Genes[i] - '0') * valorDaCasa;
                y += (Genes[j] -'0') * valorDaCasa;
            }
            if (xNegativo) x *= -1;
            if (yNegativo) y *= -1;
            double[] genesDecodificados = new double[] { x/100, y/100 };
            return genesDecodificados;
        }

        /// <summary>
        /// Inicia os genes do cromossomo com valores aleatórios
        /// </summary>
        public void iniciaGenes()
        {
            this.Genes = geraStringNumBinAleatorio() + geraStringNumBinAleatorio();
        }
    }
}
