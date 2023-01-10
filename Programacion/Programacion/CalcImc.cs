using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion
{
    public partial class CalcImc : Form
    {
        public CalcImc()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double weigth = Double.Parse(txtWeigth.Text);
            double height = Double.Parse(txtHeight.Text);

            double result = weigth / (height * height);

            MessageBox.Show("Su IMC es de: " + result);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
