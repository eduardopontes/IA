using System;

namespace GA.Common
{
    public class Gene
    {
        private string value;
        public static readonly int length = 10;

        public bool IsNegative
        {
            get => GetNucleotideoEspecial == '0';
        }

        public Gene(string value)
        {
            if (value.Length != Gene.length)
                throw new ArgumentOutOfRangeException("Gene.length", "Gene length should be " + Gene.length);

            this.value = value;
        }

        public static Gene GenerateGene()
        {
            var value = Tools.RandomBinary(Gene.length);
            return new Gene(value);
        }

        // pega o sinal
        public char GetNucleotideoEspecial
        {
            // pega o ultimo nucleotideo
            get => this.value[0];
        }

        public double Decodificar()
        {
            var nucleotideoDecodificado = Convert.ToInt32(this.value, 2) / 100.0;

            if (this.IsNegative)
                return nucleotideoDecodificado * -1;

            return nucleotideoDecodificado;
        }
    }
}
