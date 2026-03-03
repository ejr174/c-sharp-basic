namespace BuclesWhileYDoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtIngreseValor.Text);

            //while (numero > 0)
            //{
            //    liMensajes.Items.Add($"En While: El número es: {numero}");
            //    numero--;
            //}

            do
            {
                liMensajes.Items.Add($"En Do-While: El número es: {numero}");
                numero--;
            } while (numero > 0);
        }
    }
}
