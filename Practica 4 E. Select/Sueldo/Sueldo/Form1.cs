namespace Sueldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sueldo, aum, nsue;
            sueldo = double.Parse(textBox1.Text);
            if (sueldo < 400000.00)
            {
                aum = sueldo * 0.15;
                nsue = sueldo + aum;
                textBox2.Text = nsue.ToString();
            }
            else nsue = sueldo * 1.08;
            textBox2.Text = nsue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
