using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5
{
    
    public partial class Form1 : Form
    {
        int i;
        public Form1()
        {
            InitializeComponent();
        }




        public void EmptyChecker(Button butt1, Button butt2)
        {
            if (butt2.Text == "")
            {
                butt2.Text = butt1.Text;
                butt1.Text = "";
            }
        }


        public void SolChecker()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" &&
            button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button7.Text == "7" && button8.Text == "8"
            && button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" &&
            button13.Text == "13" && button14.Text == "14" && button15.Text == "15")
            {
                MessageBox.Show("Well done you are a winner", "Puzzle Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            i = i + 1;
            textBox1.Text = "Number of Clicks" + i;
            textBox2.Text = i.ToString();

        }




        public void Puzzle()
        {
            int[] buttnum = new int[16];
            int j, k, rowcheck;
            Boolean flag = false;


            j = 1;

            do
            {
                Random rnd = new Random();
                rowcheck = Convert.ToInt32((rnd.Next(0, 15)) + 1);

                for (k = 1; k <= j; k++)
                {
                    if (buttnum[k] == rowcheck)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    buttnum[j] = rowcheck;
                    j++;
                }
            } while (j <= 15);

            button1.Text = Convert.ToString(buttnum[1]);
            button2.Text = Convert.ToString(buttnum[2]);
            button3.Text = Convert.ToString(buttnum[3]);
            button4.Text = Convert.ToString(buttnum[4]);
            button5.Text = Convert.ToString(buttnum[5]);
            button6.Text = Convert.ToString(buttnum[6]);
            button7.Text = Convert.ToString(buttnum[7]);
            button8.Text = Convert.ToString(buttnum[8]);
            button9.Text = Convert.ToString(buttnum[9]);
            button10.Text = Convert.ToString(buttnum[10]);
            button11.Text = Convert.ToString(buttnum[11]);
            button12.Text = Convert.ToString(buttnum[12]);
            button13.Text = Convert.ToString(buttnum[13]);
            button14.Text = Convert.ToString(buttnum[14]);
            button15.Text = Convert.ToString(buttnum[15]);
            button16.Text = "";


        }




        private void Form1_Load(object sender, EventArgs e)
        {
            Puzzle();
        }

      

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirm if you want to exit","Puzzle game",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirm if you want to exit", "Puzzle game",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmptyChecker(button1, button2);
            EmptyChecker(button1, button5);
            SolChecker();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button1.Text = Convert.ToString(1);
            button2.Text = Convert.ToString(2);
            button3.Text = Convert.ToString(3);
            button4.Text = Convert.ToString(4);
            button5.Text = Convert.ToString(5);
            button6.Text = Convert.ToString(6);
            button7.Text = Convert.ToString(7);
            button8.Text = Convert.ToString(8);
            button9.Text = Convert.ToString(9);
            button10.Text = Convert.ToString(10);
            button11.Text = Convert.ToString(11);
            button12.Text = Convert.ToString(12);
            button13.Text = Convert.ToString(13);
            button14.Text = Convert.ToString(14);
            button15.Text = Convert.ToString(15);
            button16.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Puzzle();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Puzzle();
            textBox1.Clear();
            textBox2.Clear();

            this.Refresh();
            this.Hide();
            Form1 NewGame = new Form1();
            NewGame.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmptyChecker(button2, button1);
            EmptyChecker(button2, button3);
            EmptyChecker(button2, button6);
            SolChecker();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmptyChecker(button3, button2);
            EmptyChecker(button3, button4);
            EmptyChecker(button3, button7);
            SolChecker();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmptyChecker(button4, button3);
            EmptyChecker(button4, button8);
            SolChecker();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmptyChecker(button5, button1);
            EmptyChecker(button5, button6);
            EmptyChecker(button5, button9);
            SolChecker();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EmptyChecker(button6, button2);
            EmptyChecker(button6, button5);
            EmptyChecker(button6, button7);
            EmptyChecker(button6, button10);
            SolChecker();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EmptyChecker(button7, button3);
            EmptyChecker(button7, button6);
            EmptyChecker(button7, button8);
            EmptyChecker(button7, button11);
            SolChecker();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EmptyChecker(button8, button4);
            EmptyChecker(button8, button7);
            EmptyChecker(button8, button12);
            SolChecker();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EmptyChecker(button9, button5);
            EmptyChecker(button9, button10);
            EmptyChecker(button9, button13);
            SolChecker();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EmptyChecker(button10, button6);
            EmptyChecker(button10, button9);
            EmptyChecker(button10, button11);
            EmptyChecker(button10, button14);
            SolChecker();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            EmptyChecker(button11, button7);
            EmptyChecker(button11, button10);
            EmptyChecker(button11, button12);
            EmptyChecker(button11, button15);
            SolChecker();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            EmptyChecker(button12, button8);
            EmptyChecker(button12, button11);
            EmptyChecker(button12, button16);
            SolChecker();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            EmptyChecker(button13, button9);
            EmptyChecker(button13, button14);
            SolChecker();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            EmptyChecker(button14, button10);
            EmptyChecker(button14, button13);
            EmptyChecker(button14, button15);
            SolChecker();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            EmptyChecker(button15, button11);
            EmptyChecker(button15, button14);
            EmptyChecker(button15, button16);
            SolChecker();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            EmptyChecker(button16, button12);
            EmptyChecker(button16, button15);
            SolChecker();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        int timerleft = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerleft > 0)
            {
             
                timerleft = timerleft - 1;
                LbMyTime.Text = timerleft + "second" ;
                BtnRefresh.Visible = false;
            }
            else
            {
                
                BtnRefresh.Visible = true;
                LbMessage.Text = "Sorry, you run out of time !!";
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }
    }
}
