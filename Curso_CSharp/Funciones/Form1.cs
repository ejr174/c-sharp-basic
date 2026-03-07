namespace Funciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnButtonSaludar_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtValor1.Text.Trim());
            int valor2 = int.Parse(txtValor2.Text.Trim());

            sumar(valor1, valor2);
        }

        public void sumar(int valor1, int valor2)
        { 
            MessageBox.Show($"El resultado de la suma es: {valor1 + valor2}");
        }

    }
}
