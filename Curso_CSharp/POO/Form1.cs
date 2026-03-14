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
            AireAcondicionado aireHyu = new AireAcondicionado();
            aireHyu.marca = "Hyundai";
            aireHyu.modelo = "HAC-12CR";
            aireHyu.color = "Blanco";
            aireHyu.voltaje = 220;
            aireHyu.btu = 12000;
            aireHyu.temperatura = 24;

            AireAcondicionado aireSams = new AireAcondicionado();
            aireSams.marca = "Samsung";
            aireSams.modelo = "AR12TXHZAWKNSL"; 
            aireSams.color = "Negro";
            aireSams.voltaje = 220;
            aireSams.btu = 12000;
            aireSams.temperatura = 22;

            MessageBox.Show($"Marca: {aireHyu.marca}\nModelo: {aireHyu.modelo}\nColor: {aireHyu.color}\nVoltaje: {aireHyu.voltaje}V\nBTU: {aireHyu.btu}\nTemperatura: {aireHyu.temperatura}°C");
            MessageBox.Show($"Marca: {aireSams.marca}\nModelo: {aireSams.modelo}\nColor: {aireSams.color}\nVoltaje: {aireSams.voltaje}V\nBTU: {aireSams.btu}\nTemperatura: {aireSams.temperatura}°C"); 
        }
    }
}
