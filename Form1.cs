namespace _11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 10; x++)
            {
                listBox1.Items.Add(x);

                double fx = x / (1.0 + x * x);
                listBox2.Items.Add(fx);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 0;
            while (x < 10)
            {
                listBox1.Items.Add(x);

                double fx = x / (1.0 + x * x);
                listBox2.Items.Add(fx);

                x++; // Incrementa x en cada iteración para evitar un bucle infinito.
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = 0;
            do
            {
                listBox1.Items.Add(x);

                double fx = x / (1.0 + x * x);
                listBox2.Items.Add(fx);

                x++; // Incrementa x en cada iteración para evitar un bucle infinito.
            } while (x < 10);

        }
    }
}