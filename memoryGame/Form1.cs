using System.Globalization;
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

        string backOffImage = @"C:\Users\jason\source\repos\JasonLukassen\challenge_6\memoryGame\images.png";
        int scoreP1 = 0;
        int scoreP2 = 0;


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



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }


        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                checkBox1.BackgroundImage = Image.FromFile(imageList[7]);
            }
            else
            {
                checkBox1.BackgroundImage= Image.FromFile(backOffImage);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.BackgroundImage = Image.FromFile(imageList[3]);
            }
            else
            {
                checkBox2.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.BackgroundImage = Image.FromFile(imageList[0]);
            }
            else
            {
                checkBox3.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox4.BackgroundImage = Image.FromFile(imageList[6]);
            }
            else
            {
                checkBox4.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox5.BackgroundImage = Image.FromFile(imageList[11]);
            }
            else
            {
                checkBox5.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox6.BackgroundImage = Image.FromFile(imageList[9]);
            }
            else
            {
                checkBox6.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox7.BackgroundImage = Image.FromFile(imageList[10]);
            }
            else
            {
                checkBox7.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                checkBox8.BackgroundImage = Image.FromFile(imageList[5]);
            }
            else
            {
                checkBox8.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                checkBox9.BackgroundImage = Image.FromFile(imageList[7]);
            }
            else
            {
                checkBox9.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                checkBox10.BackgroundImage = Image.FromFile(imageList[9]);
            }
            else
            {
                checkBox10.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                checkBox11.BackgroundImage = Image.FromFile(imageList[6]);
            }
            else
            {
                checkBox11.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                checkBox12.BackgroundImage = Image.FromFile(imageList[2]);
            }
            else
            {
                checkBox12.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                checkBox13.BackgroundImage = Image.FromFile(imageList[1]);
            }
            else
            {
                checkBox13.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                checkBox14.BackgroundImage = Image.FromFile(imageList[10]);
            }
            else
            {
                checkBox14.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                checkBox15.BackgroundImage = Image.FromFile(imageList[11]);
            }
            else
            {
                checkBox15.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                checkBox16.BackgroundImage = Image.FromFile(imageList[2]);
            }
            else
            {
                checkBox16.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
            {
                checkBox17.BackgroundImage = Image.FromFile(imageList[1]);
            }
            else
            {
                checkBox17.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
            {
                checkBox18.BackgroundImage = Image.FromFile(imageList[4]);
            }
            else
            {
                checkBox18.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                checkBox19.BackgroundImage = Image.FromFile(imageList[4]);
            }
            else
            {
                checkBox19.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
            {
                checkBox20.BackgroundImage = Image.FromFile(imageList[5]);
            }
            else
            {
                checkBox20.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked)
            {
                checkBox21.BackgroundImage = Image.FromFile(imageList[3]);
            }
            else
            {
                checkBox21.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked)
            {
                checkBox22.BackgroundImage = Image.FromFile(imageList[8]);
            }
            else
            {
                checkBox22.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked)
            {
                checkBox23.BackgroundImage = Image.FromFile(imageList[0]);
            }
            else
            {
                checkBox23.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked)
            {
                checkBox24.BackgroundImage = Image.FromFile(imageList[8]);
            }
            else
            {
                checkBox24.BackgroundImage = Image.FromFile(backOffImage);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scoreP1++;
            label4.Text = $"{scoreP1}";

            if (scoreP1 + scoreP2 == 12)
            {
                panel1.Visible= true;
                label7.Visible= true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            scoreP1--;
            if (scoreP1 <= 0)
            {
                scoreP1 = 0;
            }

            label4.Text = $"{scoreP1}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            scoreP2++;
            label5.Text = $"{scoreP2}";

            if (scoreP1 + scoreP2 == 12)
            {
                panel1.Visible = true;
                label7.Visible = true;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            scoreP2--;
            if (scoreP2 <= 0)
            {
                scoreP2 = 0;
            }

            label5.Text = $"{scoreP2}";
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (scoreP1 == scoreP2)
            {
                label7.Text = "It's a draw";
                label7.Left = 850;
            }
            else if (scoreP1 > scoreP2)
            {
                label7.Text = "player 1 \nis the winner";
                label7.Left = 850;
            }
            else
            {
                label7.Text = "player 2 \nis the winner";
                label7.Left = 850;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if(scoreP1 + scoreP2 == 12) 
            {
                Visible= true;
            }
        }
    }
}