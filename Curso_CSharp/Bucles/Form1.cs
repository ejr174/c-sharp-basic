namespace Bucles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int valorIngresado = Convert.ToInt16(txtValorIngresado.Text);

            for (int i = 0; i <= 10; i++)
            {
                liTablas.Items.Add(valorIngresado + "X" + i + " = " + (valorIngresado*i));
            }
        }
    }
}
