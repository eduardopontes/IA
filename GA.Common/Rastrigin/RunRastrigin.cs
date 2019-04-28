﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GA.Common;

namespace GA
{
    public class RunRastrigin
    {
        public double ras(double x, double y)
        {
            return 20 + Math.Pow(x, 2) + Math.Pow(y, 2) - (10 * (Math.Cos(2 * Math.PI * x) + Math.Cos(2 * Math.PI * y)));
        }


        
        static void Main(string[] args)
        {
            var ob = new GA.Common.GA(200, 0.1, 0.8, 5000);
            ob.executaGA();
            ob.printaDados();

            
            

            Console.ReadLine();
        }
    }
}
