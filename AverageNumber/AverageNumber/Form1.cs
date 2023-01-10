namespace AverageNumber
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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double a = Int32.Parse(txtFirstNumber.Text);
            double b = Int32.Parse(txtSecondNumber.Text);
            double c = Int32.Parse(txtThirdNumber.Text);

            double result = (a + b + c) / 3;

            MessageBox.Show("El promedio de los tres numero es: " + result);


        }

        private void lblFirstNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}