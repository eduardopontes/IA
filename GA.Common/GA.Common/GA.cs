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

        public GA(int popMax, double taxaMut, double taxaCross, int maxGeracoes)
        {
            this.Populacao = new Cromossomo[popMax];
            this.taxaMut = taxaMut;
            this.taxaCross = taxaCross;
            this.maxGen = maxGeracoes;
        }

        public static Random rand = new Random();

        //CHECK
        public void criaPop()
        {
            for (int i = 0; i < Populacao.Length; i++)
            {
                Populacao[i] = new Cromossomo();
            }
        }                    
    }
}
