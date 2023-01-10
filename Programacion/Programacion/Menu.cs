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

        private void btnAdult_Click(object sender, EventArgs e)
        {
            Form edad = new Edad();
            edad.Show();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Form listNumber = new ListNumber();
            listNumber.Show();
        }
    }
}
