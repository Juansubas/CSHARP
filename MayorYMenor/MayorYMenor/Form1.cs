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
            int numeroIntermedio = a;

            if (b > numeroIntermedio)
            {
                numeroIntermedio = b;
            }

            if (c > numeroIntermedio)
            {
                numeroIntermedio = c;
            }

            return numeroIntermedio;
        }

        private int calcularMenor(int a, int b, int c)
        {
            int numeroIntermedio = a;

            if (b < numeroIntermedio)
            {
                numeroIntermedio = b;
            }

            if (c < numeroIntermedio)
            {
                numeroIntermedio = c;
            }

            return numeroIntermedio;
        }
    }
}