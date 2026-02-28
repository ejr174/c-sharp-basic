namespace CalcularNotaFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularNota_Click(object sender, EventArgs e)
        {
            int nota1 = int.Parse(txtNota1.Text);
            int nota2 = int.Parse(txtNota1.Text);
            int nota3 = int.Parse(txtNota3.Text);

            double sumaNotas = nota1 + nota2 + nota3;

            double notaFinal = sumaNotas / 3;

            MessageBox.Show("La nota final es: " + notaFinal);
        }
    }
}
