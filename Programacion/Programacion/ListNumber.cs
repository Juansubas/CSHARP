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
    public partial class ListNumber : Form
    {
        List<int> lista = new List<int>();
        public ListNumber()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(txtNumber.Text);
            lista.Add(number);
        }


        private void mostrarListado(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                int numero = lista[i];
                MessageBox.Show("El resultado es: " + numero);
                //MessageBox.Show(numero.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarListado(lista);
        }
    }
}
