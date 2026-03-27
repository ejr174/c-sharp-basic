namespace Delegado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            delegadoSuma ds = sumar;
            int resultado = ds(5, 10);

            MessageBox.Show("El resultado de la suma es: " + resultado);
        }

        delegate int delegadoSuma(int a, int b);

        private int sumar(int a, int b)
        {
            return a + b;
        }
    }
}
