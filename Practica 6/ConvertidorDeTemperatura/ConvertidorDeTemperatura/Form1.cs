using System.Drawing;

namespace ConvertidorDeTemperatura
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

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, fahr1;
            v1 = double.Parse(valor1.Text);
            fahr1 = v1 * (9.0 / 5.0) + 32;
            Resultado.Text = fahr1.ToString();
            label2.Text = " Fahrenheit";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double v1, cent1;
            v1 = double.Parse(valor1.Text);
            cent1 = (v1 - 32) * (5.0 / 9.0);
            Resultado.Text = cent1.ToString();
            label2.Text = " Centigrados ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor1.Text = "  ";
            Resultado.Text = "  ";
        }
    }
}
