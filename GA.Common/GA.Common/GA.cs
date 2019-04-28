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
        public int maxGer { get; set; }
        public bool vaiCruzar
        {
            get
            {
                return rand.NextDouble() < taxaCross;
            }
            set { }
        }

        public int geracao = 0;

        public GA(int popMax, double taxaMut, double taxaCross, int maxGeracoes)
        {
            if (popMax % 2 != 0)
            {
                popMax += 1;
            }
            this.Populacao = new Cromossomo[popMax];
            this.taxaMut = taxaMut;
            this.taxaCross = taxaCross;
            this.maxGer = maxGeracoes;
        }

        public static Random rand = new Random();

        public string printaDados()
        {
            int bestCount = 0;
            double somafit = 0;
            Cromossomo melhorCromo = Populacao[0];
            foreach (var cromo in Populacao)
            {
                if (cromo.Fitness == 1)
                {
                    bestCount++;
                }
                somafit += cromo.Fitness;
                melhorCromo = (cromo.Fitness > melhorCromo.Fitness) ? cromo : melhorCromo;
            }
            double[] par = melhorCromo.decodificaGenes();
            string result = "Melhor cromossomo: " + melhorCromo.Fitness + "\nMelhor resposta x: " + par[0] + " y: " + par[1] + "\nMédia da população: " + somafit / Populacao.Length + "\nNumero de casos ótimos: " + bestCount;

            return result;
        }

        public void executaGA()
        {
            criaPopInicial();
            for (int i = 0; i < maxGer; i++)
            {
                novaGeracao();
            }
        }

        List<double> BestfitList = new List<double>();
        List<double> AveragefitList = new List<double>();

        public double[] bestArrayFit()
        {
            double[] arrayFitness = BestfitList.ToArray();
            return arrayFitness;
        }

        public double[] averageArrayFit()
        {
            double[] arrayFitness = AveragefitList.ToArray();
            return arrayFitness;
        }

        //CHECK
        public void criaPopInicial()
        {
            double somaFit = 0;//avaliar qual vai ser a logica pra isso, talvez não fique aqui

            double bestFit = 0;
            double averageFit = 0;

            for (int i = 0; i < Populacao.Length; i++)
            {
                Populacao[i] = new Cromossomo();
                somaFit += Populacao[i].Fitness;

                if (Populacao[i].Fitness >= bestFit)
                {
                    bestFit = Populacao[i].Fitness;
                }
            }
            averageFit = somaFit / Populacao.Length;

            AveragefitList.Add(averageFit);
            BestfitList.Add(bestFit);
            geracao++;
        }

        public void novaGeracao()
        {
            Populacao = crossover();
            avaliaMutacoes();
            geracao++;
        }

        public Cromossomo[] crossover()
        {
            Cromossomo[] novaPop = new Cromossomo[Populacao.Length];

            Cromossomo parceiroA;
            Cromossomo parceiroB;

            double somaFit = 0;
            double bestFit = 0;
            double averageFit = 0;

            foreach (var cromo in Populacao)
            {
                somaFit += cromo.Fitness;

                if (cromo.Fitness >= bestFit)
                {
                    bestFit = cromo.Fitness;
                }
            }
            averageFit = somaFit / Populacao.Length;

            AveragefitList.Add(averageFit);
            BestfitList.Add(bestFit);

            for (int i = 0; i < novaPop.Length; i += 2)
            {
                parceiroA = roleta(somaFit);
                parceiroB = roleta(somaFit);

                if (vaiCruzar)
                {
                    novaPop[i] = parceiroA.cruza(parceiroB);
                    novaPop[i + 1] = parceiroB.cruza(parceiroA);
                }
                else
                {
                    novaPop[i] = parceiroA;
                    novaPop[i + 1] = parceiroB;
                }
            }
            return novaPop;
        }


        public Cromossomo roleta(double somaTotalFit)
        {
            double giroRoleta = rand.NextDouble();

            foreach (var cromo in Populacao)
            {
                giroRoleta -= cromo.Fitness / somaTotalFit;
                if (giroRoleta < 0) return cromo;
            }
            return Populacao[Populacao.Length - 1];
        }

        public void avaliaMutacoes()
        {
            foreach (var cromo in Populacao)
            {
                if (rand.NextDouble() < taxaMut)
                {
                    cromo.mutar();
                }
            }
        }
    }
}
