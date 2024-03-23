namespace WinFormsAppKihivas3.nap
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

        }
        int num = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            num++;
            progressBar1.Value = num;
            labelIncreaseable.Text = $"Counter: {num.ToString()}";
        }

        private void buttonDecrease_Click(object sender, EventArgs e)
        {
            num--;
            progressBar1.Value = num;
            labelIncreaseable.Text = $"Counter: {num.ToString()}";
        }
    }
}
