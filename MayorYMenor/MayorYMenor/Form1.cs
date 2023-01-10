namespace MayorYMenor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int numeroUno = Int32.Parse(txtNumberOne.Text);
            int numeroDos = Int32.Parse(txtNumberTwo.Text);
            int numeroTres = Int32.Parse(txtNumberThree.Text);

            int resultMenor = calcularMenor(numeroUno, numeroDos, numeroTres);
            int resultMayor = calcularMayor(numeroUno, numeroDos, numeroTres);

            MessageBox.Show("El numero mayor es: " + resultMayor + "\nEl numero menor es: " + resultMenor);

        }

        private int calcularMayor(int a, int b, int c)
        {
            int numeroMayor = a;

            if (b > numeroMayor)
            {
                numeroMayor  = b;
            }

            if (c > numeroMayor)
            {
                numeroMayor = c;
            }

            return numeroMayor;
        }

        private int calcularMenor(int a, int b, int c)
        {
            int numeroMenor = a;

            if (b < numeroMenor)
            {
                numeroMenor = b;
            }

            if (c < numeroMenor)
            {
                numeroMenor = c;
            }

            return numeroMenor;
        }
    }
}