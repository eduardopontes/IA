using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA.Common
{
    public partial class GraficosEP : Form
    {
        public GraficosEP()
        {
            InitializeComponent();
        }

        public void GraficosEP_Load(object sender, EventArgs e)
        {

            InitializeComponent();

            //chart1.Series[""].Points.AddXY("","");
        }

        public void BotaoChart_Click(object sender, EventArgs e)
        {
            //this.chart1.Series["Fitness"].Points.AddXY("generation","fit");
        }
    }
}
