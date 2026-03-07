namespace Funciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string saludar(string nombre)
        {
            string saludo = "Bienvenido " + nombre;
            return saludo;
        }

        private void btnButtonSaludar_Click(object sender, EventArgs e)
        {
            string saludo = saludar("Emmanuel");
            MessageBox.Show(saludo);
        }

        public void sumar(int valor1, int valor2)
        {
            MessageBox.Show($"El resultado de la suma es: {valor1 + valor2}");
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtValor1.Text.Trim());
            int valor2 = int.Parse(txtValor2.Text.Trim());

            sumar(valor1, valor2);
        }
    }
}
