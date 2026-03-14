namespace POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AireAcondicionado aireHyu = new AireAcondicionado("Hyundai-Ejemplo", "HAC-1CR7-Ejemplo", "Verde", 200, 1000, 20);
            MessageBox.Show("Marca inicial del aire: " + aireHyu.getMarca() + "Modelo modelo del Aire Acondicionado Hyundai: " + aireHyu.getModelo());

            aireHyu.setMarca("Hyundai");
            aireHyu.setModelo("HAC-12CR");
            aireHyu.setColor("Blanco");
            aireHyu.setVoltaje(220);
            aireHyu.setBtu(12000);
            aireHyu.setTemperatura(24);

            AireAcondicionado aireSams = new AireAcondicionado("Sam-Ejemplo", "AR1111-Ejemplo", "Naranja", 120, 900, 21);
            MessageBox.Show("Marca inicial del aire: " + aireSams.getMarca() + "Modelo modelo del Aire Acondicionado Hyundai: " + aireSams.getModelo());

            aireSams.setMarca("Samsung");
            aireSams.setModelo("AR12TXHZAWKNSL"); 
            aireSams.setColor("Negro");
            aireSams.setVoltaje(220);
            aireSams.setBtu(12000);
            aireSams.setTemperatura(22);

            MessageBox.Show("Modelo del Aire Acondicionado Hyundai: " + aireHyu.getModelo());
            MessageBox.Show("Modelo del Aire Acondicionado Hyundai: " + aireSams.getModelo());

        }
    }
}
