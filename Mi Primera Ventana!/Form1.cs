namespace Mi_Primera_Ventana_
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer miReproductor;

        int nivelDeCulpa = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            miReproductor = new System.Media.SoundPlayer(Properties.Resources.party);
            miReproductor.PlayLooping();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miReproductor.Stop();

            miReproductor = new System.Media.SoundPlayer(Properties.Resources.cumpleaños);

            miReproductor.Play();

            MessageBox.Show("Felicidades");

            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nivelDeCulpa = nivelDeCulpa + 1;

            if (nivelDeCulpa == 1)
            {
                MessageBox.Show("¿En serio vas a decir que no? Se ve buenísimo...", "Duda");
            }
            else if (nivelDeCulpa == 2)
            {
                MessageBox.Show("¿Estás completamente seguro? Me tomó horas hornear este código...", "Tristeza");
            }
            else if (nivelDeCulpa == 3)
            {
                MessageBox.Show("Ándale, no seas así. ¡Solo dale al botón de Sí!", "Ruego");
            }
            else if (nivelDeCulpa == 4)
            {
                MessageBox.Show("Me estás rompiendo el corazón, pruebalo!", "Dolor");
            }
            else
            {
                MessageBox.Show("No me voy a rendir. La única salida es decir que Sí. ACEPTA. EL. PASTEL.", "Determinación");
            }
        }
    }
}
