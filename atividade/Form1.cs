namespace atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //class Circulo
            Circulo circulo = new Circulo();
            //valor ja definido "3"
            circulo.Raio = 3;

            MessageBox.Show("A �rea do c�rculo �: " + circulo.CalcularArea);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Retangulo retangulo = new Retangulo();

            retangulo.Lado = 3;

            MessageBox.Show("A �rea do ret�ngulo �: " + retangulo.CalcularArea);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo();

            triangulo.Lado = 3;

            MessageBox.Show("A �rea do tri�ngulo �: " + triangulo.CalcularArea);

        }
    }
}