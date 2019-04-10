using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.Common
{
    public class Cromossomo
    {
        public Cromossomo(Func<double, double, double> funcFit)
        {
            this.funcFit = funcFit;
        }
        public Func<double, double, double> funcFit { get; set; }
        public float Fitness { get; set; }

        public string Genes { get; set; }

        /// <summary>
        /// Inicia os genes do cromossomo com valores aleatórios
        /// </summary>
        public void iniciaGenes(int tamGenes)
        {
            var rand = new Random();
            Genes = Convert.ToString(rand.Next(0, 501));

        }
    }
}
