using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace GA.Common
{
    public class GA
    {
        public Cromossomo[] Populacao { get; set; }

        public double taxaMut { get; set; }

        public double taxaCross { get; set; }

        public int maxGen { get; set; }

        Func<double, double, double> funcFit;

        public GA(int popMax, double taxaMut, double taxaCross, int maxGeracoes, Func<double, double, double> funcFit)
        {
            this.Populacao = new Cromossomo[popMax];
            this.taxaMut = taxaMut;
            this.taxaCross = taxaCross;
            this.maxGen = maxGeracoes;
            this.funcFit = funcFit;
        }

        public void criaPop()
        {
            foreach (var cromo in Populacao)
            {

            }
        }

       
    }
}
