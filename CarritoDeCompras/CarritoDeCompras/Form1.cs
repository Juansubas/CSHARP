using System.Linq.Expressions;

namespace CarritoDeCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboProducts.Items.Add("Pantalon");
            cboProducts.Items.Add("Camisa");
            cboProducts.Items.Add("Zapatos");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String productoSeleccionado = cboProducts.SelectedItem.ToString();
            listShoppingCart.Items.Add(productoSeleccionado);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Pantalon 20
            // Camisa 35
            // Zapatos 24
            double precioFinal = 0;

            int totalProductosCargados = listShoppingCart.Items.Count;

            for (int i = 0; i < totalProductosCargados; i++ )
            {
                string productoElegido = listShoppingCart.Items[i].ToString();
                switch (productoElegido)
                {
                    case "Pantalon":
                        precioFinal += 20;
                        break;
                    case "Camisa":
                        precioFinal += 35;
                        break;
                    case "Zapatos":
                        precioFinal += 24;
                        break;
                    default:
                        break;
                }
            }

            if (txtDiscount.Text == "NAVIDAD")
            {
                precioFinal *= 0.9;
            }

            MessageBox.Show("Su valor a pagar es: $" + precioFinal);
        }
    }
}