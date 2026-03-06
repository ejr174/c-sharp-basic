namespace OrdenamientoArrays
{
    public partial class Form1 : Form
    {
        private int[] numero = { 4, 6, 9, 1, 7, 2, 8, 3 };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (int num in numero)
            {
                liDesordenada.Items.Add(num);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Array.Sort(numero);

            foreach (int numer in numero) { 
                liOrdenada.Items.Add(numer);
            }
        }
    }
}
