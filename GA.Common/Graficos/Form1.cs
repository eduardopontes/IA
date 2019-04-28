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
            label5.Visible = false;
        }



        private void botaoExec(object sender, EventArgs e)
        {
            label5.Visible = true;

            chart1.ChartAreas[0].AxisX.Title = "Gerações";
            chart1.ChartAreas[0].AxisY.Title = "Fitness";

            int popMax = Convert.ToInt32(textBox1.Text);
            double taxaCross = Convert.ToDouble(textBox2.Text);
            double taxaMut = Convert.ToDouble(textBox3.Text);
            int maxGeracoes = Convert.ToInt32(textBox4.Text);

            var ob = new GA.Common.GA(popMax, taxaMut, taxaCross, maxGeracoes);
            ob.executaGA();

            double[] arrayBestFit = new double[popMax];
            double[] arrayAverage = new double[popMax];


            arrayBestFit = ob.bestArrayFit();
            arrayAverage = ob.averageArrayFit();


            chart1.Series["Best"].Points.DataBindY(arrayBestFit);
            chart1.Series["Average"].Points.DataBindY(arrayAverage);

            label5.Text = ob.printaDados();
        }
    }
}

