using GA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using GA.Common;

namespace GA
{
    public class RunRastrigin
    {
        static void Main(string[] args)
        {
            var gene = Gene.GenerateGene();
           
            // nao faço ideia do que acontece aqui kkkkkkk

            Console.WriteLine("aleatorio " + rand.Next(0, 2));
            string teste;
            teste = "abcde";
            teste = teste.Insert(0, "0");
            
            Console.WriteLine(teste);
            //var rand = new Random();
            //Console.WriteLine("500 binario é " + Convert.ToString(500, 2));
            //Console.WriteLine("0 binario é " + Convert.ToString(0, 2));
            //Console.WriteLine("1 binario é " + Convert.ToString(1, 2));
            //Console.WriteLine("250 binario é " + Convert.ToString(250, 2));
            //Console.WriteLine("-1 binario é " + Convert.ToString(-1, 2));
            //Console.WriteLine("-0 binario é " + Convert.ToString(-0, 2));
            Console.ReadLine();
            //var ob = new GA.Common.GA(100, 0.2, 0.8, 500, ras);
        }
    }
}
