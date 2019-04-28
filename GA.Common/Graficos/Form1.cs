using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            //int popMax = 200;
            //double taxaMut = 0.1;
            //double taxaCross = 0.8;
            //int maxGeracoes = 20;

            int popMax = Convert.ToInt32(textBox1.Text);
            double taxaMut = Convert.ToDouble(textBox2.Text);
            double taxaCross = Convert.ToDouble(textBox3.Text);
            int maxGeracoes = Convert.ToInt32(textBox4.Text);

            var ob = new GA.Common.GA(popMax, taxaMut, taxaCross, maxGeracoes);
            ob.executaGA();

            double[] arrayBestFit = new double[popMax];
            double[] arrayAverage = new double[popMax];


            arrayBestFit = ob.bestArrayFit();
            arrayAverage = ob.averageArrayFit();


            chart1.Series["Best"].Points.DataBindY(arrayBestFit);
            chart1.Series["Average"].Points.DataBindY(arrayAverage);

            arrayBestFit = null;
            arrayAverage = null;

        }
    }
}
