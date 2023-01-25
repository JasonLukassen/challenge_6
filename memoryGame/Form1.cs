using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace memoryGame
{
    public partial class Form1 : Form
    {


        string[] imageList = {@"C:\Users\jason\Source\Repos\JasonLukassen\challenge_6\memoryGame\images\imagePair1.png",
                              @"C:\Users\jason\Source\Repos\JasonLukassen\challenge_6\memoryGame\images\imagePair2.png",
                              @"C:\Users\jason\Source\Repos\JasonLukassen\challenge_6\memoryGame\images\imagePair3.png",
                              @"C:\Users\jason\Source\Repos\JasonLukassen\challenge_6\memoryGame\images\imagePair4.png",
                              @"C:\Users\jason\Source\Repos\JasonLukassen\challenge_6\memoryGame\images\imagePair5.png",
                              @"C:\Users\jason\Source\Repos\JasonLukassen\challenge_6\memoryGame\images\imagePair6.png",
                              @"C:\Users\jason\Source\Repos\JasonLukassen\challenge_6\memoryGame\images\imagePair7.png",
                              @"C:\Users\jason\Source\Repos\JasonLukassen\challenge_6\memoryGame\images\imagePair8.png",
                              @"C:\Users\jason\Source\Repos\JasonLukassen\challenge_6\memoryGame\images\imagePair9.png",
                              @"C:\Users\jason\Source\Repos\JasonLukassen\challenge_6\memoryGame\images\imagePair10.png",
                              @"C:\Users\jason\Source\Repos\JasonLukassen\challenge_6\memoryGame\images\imagePair11.png",
                              @"C:\Users\jason\Source\Repos\JasonLukassen\challenge_6\memoryGame\images\imagePair12.png",
                              };

        bool result;

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

        private void label2_Click(object sender, EventArgs e)
        {
            int scoreP1 = 0;
            label2.Text = $"PLayer1 : {scoreP1}";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            int scoreP2 = 0;
            scoreP2++;
            label3.Text = $"Player2 : {scoreP2}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = Image.FromFile(imageList[7]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackgroundImage = Image.FromFile(imageList[3]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackgroundImage = Image.FromFile(imageList[0]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackgroundImage = Image.FromFile(imageList[6]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackgroundImage = Image.FromFile(imageList[11]);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackgroundImage = Image.FromFile(imageList[9]);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackgroundImage = Image.FromFile(imageList[10]);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackgroundImage = Image.FromFile(imageList[5]);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackgroundImage = Image.FromFile(imageList[7]);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackgroundImage = Image.FromFile(imageList[9]);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackgroundImage = Image.FromFile(imageList[6]);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackgroundImage = Image.FromFile(imageList[2]);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackgroundImage = Image.FromFile(imageList[1]);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackgroundImage = Image.FromFile(imageList[10]);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackgroundImage = Image.FromFile(imageList[11]);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackgroundImage = Image.FromFile(imageList[2]);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackgroundImage = Image.FromFile(imageList[1]);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackgroundImage = Image.FromFile(imageList[4]);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackgroundImage = Image.FromFile(imageList[4]);

        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackgroundImage = Image.FromFile(imageList[5]);

        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackgroundImage = Image.FromFile(imageList[3]);

        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackgroundImage = Image.FromFile(imageList[8]);

        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackgroundImage = Image.FromFile(imageList[0]);

        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.BackgroundImage = Image.FromFile(imageList[8]);
        }
        
    }
}