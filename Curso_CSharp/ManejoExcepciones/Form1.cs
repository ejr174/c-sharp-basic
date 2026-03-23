namespace ManejoExcepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] personajes = { "Itachi", "Gon", "Cr7" };

                for (int i = 0; i < personajes.Length + 1; i++)
                {
                    MessageBox.Show(personajes[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message); 
            }
            finally
            {
                MessageBox.Show("El bloque finally se ejecuta siempre, haya o no una excepción.");
            }
        }
    }
}
