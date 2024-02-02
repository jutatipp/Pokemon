namespace Pokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wigglytuff Wigglytuff = new Wigglytuff();
            label1.Text = Wigglytuff.Name();
            pictureBox1.Image = Pokemon.Properties.Resources.Wigglytuff;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pachirisu Pachirisu = new Pachirisu();
            label1.Text = Pachirisu.Name();
            pictureBox1.Image = Pokemon.Properties.Resources.Pachirisu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Snorlax Snorlaxu = new Snorlax();
            label1.Text = Snorlaxu.Name();
            pictureBox1.Image = Pokemon.Properties.Resources.Snorlax;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            eevee eevee = new eevee();
            label1.Text = eevee.Name();
            pictureBox1.Image = Pokemon.Properties.Resources.eevee;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pipi pipi = new pipi();
            label1.Text = pipi.Name();
            pictureBox1.Image = Pokemon.Properties.Resources.pipi;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Celebi Celebi = new Celebi();
            label1.Text = Celebi.Name();
            pictureBox1.Image = Pokemon.Properties.Resources.Celebi;
        }
    }
}
