using System.Diagnostics.Metrics;

namespace WinFormsAppKihivasMegoldás3.nap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        string isPrimeNumOrNot;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static bool isPrime(int numToBeChecked, int counterNum)
        {

            for (int i = 1; i <= numToBeChecked; i++)
            {
                if (numToBeChecked % i == 0)
                {
                    counterNum++;
                }
            }
            if (counterNum == 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text != string.Empty)
            {
                isPrimeNumOrNot = textBox1.Text;
                textBox2.Text = $"You are about to test: {isPrimeNumOrNot}. Please press checked! For reset, please click the red Prime Checker Program";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = isPrime(Convert.ToInt32(isPrimeNumOrNot), counter);

                if (result && textBox1.Text != "")
                {
                    textBox2.Text = ($"{isPrimeNumOrNot} is not a prime number. For reset, please click the red Prime Checker Program");
                    textBox1.Text = isPrimeNumOrNot;
                }
                
                if (!result && textBox1.Text != "")
                {
                    textBox2.Text = ($"{isPrimeNumOrNot} is a prime number. For reset, please click the red Prime Checker Program");
                    textBox1.Text = isPrimeNumOrNot;
                }
                
            }
            catch (Exception ex)
            {
                textBox2.Text = "You typed input in a wrong format: " + ex.Message;
            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            
        }
    }
}
