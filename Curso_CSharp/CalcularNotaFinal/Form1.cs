namespace CalcularNotaFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtNota1.Visible = false;
            txtNota2.Visible = false;
            txtNota3.Visible = false;

            lblNota1.Visible = false;
            lblNota2.Visible = false;
            lblNota3.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularNota_Click(object sender, EventArgs e)
        {
            txtNota1.Visible = true;
            txtNota2.Visible = true;
            txtNota3.Visible = true;

            lblNota1.Visible = true;
            lblNota2.Visible = true;
            lblNota3.Visible = true;

            int nota1 = int.Parse(txtNota1.Text);
            int nota2 = int.Parse(txtNota1.Text);
            int nota3 = int.Parse(txtNota3.Text);

            double sumaNotas = nota1 + nota2 + nota3;

            double notaFinal = sumaNotas / 3;

            MessageBox.Show("La nota final es: " + notaFinal);
        }

        private void btnParOImpar_Click(object sender, EventArgs e)
        {
            txtNota1.Visible = true;
            lblNota1.Visible = true;

            if (!int.TryParse(txtNota1.Text, out int num))
            {
                MessageBox.Show("Introduce un número entero en Nota #1.");
                txtNota1.Focus();
                return;
            }

            if (num % 2 == 0)
                MessageBox.Show("El número es par");
            else
                MessageBox.Show("El número es impar");
        }
    }
}
