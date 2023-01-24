using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace memoryGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = Image.FromFile(@"image.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int scoreP1 = 0;
            label2.Text = $"PLayer1 : {scoreP1}";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            int scoreP2 = 0;
            label3.Text = $"Player2 : {scoreP2}";
        }
    }
}