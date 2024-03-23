namespace WinBetuCiklus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10000; i++)
            {
                listBox1.Items.Add((char)i);
            }
        }
    }
}