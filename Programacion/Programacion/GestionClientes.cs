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
            /*
            string nombre = txtNombre.Text;
            listClientes.Items.Add(nombre);
            MessageBox.Show("" + listClientes.Items[0
            */

            //Array Estático
            int[] listaDeItems = new int[] {0, 4, 2, 5 };

            //Array Dinámico
            List<int> lista = new List<int>();

            lista.Add(2);
            lista.Add(20);
            lista.Add(15);
            lista.Add(100);

            for (int i = 0; i < lista.Count; i++)
            {
                int numero = lista[i];
                MessageBox.Show(numero.ToString());
            }



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
