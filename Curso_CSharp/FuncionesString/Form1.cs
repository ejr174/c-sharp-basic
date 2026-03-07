namespace FuncionesString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMayuscula_Click(object sender, EventArgs e)
        {
            string cadenaPrincipal = txtCadenaPrincipal.Text.ToUpper();

            txtResult.Text = cadenaPrincipal;
        }

        private void btnSubCadena_Click(object sender, EventArgs e)
        {
            string cadenaPrincipal = txtCadenaPrincipal.Text.Substring(0,4);

            txtResult.Text = cadenaPrincipal;
        }

        private void btnMinuscula_Click(object sender, EventArgs e)
        {
            string cadenaPrincipal = txtCadenaPrincipal.Text.ToLower();

            txtResult.Text = cadenaPrincipal;
        }
    }
}
