using System.Collections.Generic;

namespace GA.Common
{
    public class Cromossomo
    {

        public Cromossomo(IList<Gene> genes)
        {
            this.Genes = genes;
        }

        public IList<Gene> Genes { get; set; }

        public double Fitness
        {
            get
            {
                var x = this.Genes[0].Decodificar();
                var y = this.Genes[1].Decodificar();
                return Tools.rastrigin(x, y);
            }
        }
    }
}
