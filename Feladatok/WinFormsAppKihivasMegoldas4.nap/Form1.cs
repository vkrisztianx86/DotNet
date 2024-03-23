using System.Drawing;

namespace WinFormsAppKihivasMegoldas4.nap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = Properties.Settings.Default.A;
            trackBar2.Value = Properties.Settings.Default.B;
            Calculate();
        }
        void panel1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int width = trackBar1.Value;
            int height = trackBar2.Value;
            if (height < width)
            {
                height = (int)((double)250 / width * height);
                width = 250;
            }
            else if (height > width)
            {
                width = (int)((double)250 / height * width);
                height = 250;
            }
            else
            {
                height = 250;
                width = 250;
            }
            int x = panel1.Width / 2 - width / 2;
            int y = panel1.Height / 2 - height / 2;
            Rectangle rectangle = new Rectangle(x, y, width, height);
            Pen pen = new Pen(Color.DarkBlue, 3); // Initialize the Pen
            //g.DrawRectangle(pen, rectangle);

            if (comboBox1.Text == "Rectangle")
            {
                g.DrawRectangle(pen, rectangle);
            }
            if (comboBox1.Text == "Ellipse")
            {
                g.DrawEllipse(pen, rectangle);
            }
        }
        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Value = trackBar2.Value;
            panel1.Invalidate();
            Calculate();
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
            panel1.Invalidate();
            Calculate();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            trackBar2.Value = (int)numericUpDown2.Value;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)numericUpDown1.Value;
        }
        void Calculate()
        {
            label1.Text = $"Outline: {(trackBar1.Value + trackBar2.Value) * 2}";
            label3.Text = $"Outline: {(trackBar1.Value * trackBar2.Value)}";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.A = trackBar1.Value;
            Properties.Settings.Default.B = trackBar2.Value;
            Properties.Settings.Default.Save();

        }
        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
