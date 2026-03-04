namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarPersonajes_Click(object sender, EventArgs e)
        {
            string[] personajes = new string[5];

            personajes[0] = "Tanjiro Kamado";
            personajes[1] = "Itachi Uchija";
            personajes[2] = "Gon";
            personajes[3] = "Killua";
            personajes[4] = "Saitama";

            for (int i = 0; i <= personajes.Length - 1; i++)
            {
                liPersonajes.Items.Add(personajes[i]);
            }

        }

        private void btnListarEquipos_Click(object sender, EventArgs e)
        {
            string[] equipos = { "Atl. Nacional", "Real Madrd", "Man Utd" };

            for (int i = 0; i <= equipos.Length - 1; i++)
            {
                liEquipos.Items.Add(equipos[i]);
            }

        }
    }
}
