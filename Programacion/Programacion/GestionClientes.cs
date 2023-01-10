namespace Programacion
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
      
            string nombre = txtNombre.Text;
            listClientes.Items.Add(nombre);
            MessageBox.Show("El nombre del cliente es: " + listClientes.Items[0]);
          
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
