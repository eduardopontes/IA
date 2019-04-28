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

        

        private void botaoExec(object sender, EventArgs e)
        {
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
            }           
        }
    }

