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
    public partial class Edad : Form
    {
        public Edad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string textAge = txtAge.Text;

            int age = Int32.Parse(textAge);

            bool isAdult = age >= 18;

            if (isAdult)
            {
                lblAge.Text = "Usted es mayor de edad";
            } else
            {
                lblAge.Text = "Usted es menor de edad";
            }
        }
    }
}
