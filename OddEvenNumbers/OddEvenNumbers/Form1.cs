namespace OddEvenNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(txtNumber.Text);

            if(number % 2 == 0 )
            {
                MessageBox.Show("Su numero es par: " + number);
            }
            else
            {
                MessageBox.Show("Su numero es impar: " + number);
            }
        }
    }
}