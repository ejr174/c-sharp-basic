namespace UsoStatic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("El valor de pi es: " + Mateticas.pi);
            MessageBox.Show("El resultado de la potenciacion es: " + Mateticas.potenciacion(5, 3));
        }
    }
}
