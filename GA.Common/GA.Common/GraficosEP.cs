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

        private void GraficosEP_Load(object sender, EventArgs e)
        {
            
            
           

            

            FitGen.Series[""].Points.AddXY("","");
        }
    }
}
