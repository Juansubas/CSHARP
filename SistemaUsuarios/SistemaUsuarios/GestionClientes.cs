using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaUsuarios
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            listClientes.Items.Add(txtNombre.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string holis = listClientes.SelectedItem.ToString();
            listClientes.Items.Remove(holis);
            MessageBox.Show("Eliminado con éxito");
        }
    }
}
