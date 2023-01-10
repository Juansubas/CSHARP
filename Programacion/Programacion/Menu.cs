namespace Programacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form gestionClientes = new GestionClientes();
            gestionClientes.Show();
        }
    }
}
