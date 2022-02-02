using BusinessLayer;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class FrmCalculator : Form
    {

        // Design By Jean Carlos Reyes
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        private CharacterLogic charact;
        public FrmCalculator()
        {
            InitializeComponent();
            TextBox[] texts = { textBox1 };
            foreach (TextBox item in texts)
                item.GotFocus += delegate { HideCaret(item.Handle); };
            charact = new CharacterLogic();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.BorderColor = Color.FromArgb(190, 190, 190);
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.FlatAppearance.BorderSize = 0;
        }
        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.BorderColor = Color.FromArgb(157, 157, 157);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.FlatAppearance.BorderSize = 0;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatAppearance.BorderColor = Color.FromArgb(190, 190, 190);
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.FlatAppearance.BorderSize = 0;
        }
        private void button8_MouseHover(object sender, EventArgs e)
        {
            button8.FlatAppearance.BorderSize = 2;
            button8.FlatAppearance.BorderColor = Color.FromArgb(190, 190, 190);
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.FlatAppearance.BorderSize = 0;
        }
        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.FlatAppearance.BorderSize = 2;
            button7.FlatAppearance.BorderColor = Color.FromArgb(190, 190, 190);
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.FlatAppearance.BorderSize = 0;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.BorderColor = Color.FromArgb(190, 190, 190);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.BorderColor = Color.FromArgb(190, 190, 190);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderSize = 0;
        }
        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatAppearance.BorderColor = Color.FromArgb(190, 190, 190);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.FlatAppearance.BorderSize = 0;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            button9.FlatAppearance.BorderSize = 2;
            button9.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180);
            pictureBox1.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            button9.FlatAppearance.BorderSize = 0;
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(172, 172, 172);
            button9.FlatAppearance.BorderColor = Color.FromArgb(143, 143, 143);
        }
        private void button10_MouseHover(object sender, EventArgs e)
        {
            button10.FlatAppearance.BorderSize = 2;
            button10.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180);
            pictureBox2.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
            button10.FlatAppearance.BorderSize = 0;
        }

        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(172, 172, 172);
            button10.FlatAppearance.BorderColor = Color.FromArgb(143, 143, 143);
        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
            button11.FlatAppearance.BorderSize = 1;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            button11.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button12_MouseHover(object sender, EventArgs e)
        {
            button12.FlatAppearance.BorderSize = 1;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            button12.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button13_MouseHover(object sender, EventArgs e)
        {
            button13.FlatAppearance.BorderSize = 1;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button13_MouseDown(object sender, MouseEventArgs e)
        {
            button13.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button14_MouseHover(object sender, EventArgs e)
        {
            button14.FlatAppearance.BorderSize = 1;
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button14_MouseDown(object sender, MouseEventArgs e)
        {
            button14.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button15_MouseHover(object sender, EventArgs e)
        {
            button15.FlatAppearance.BorderSize = 1;
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button15_MouseDown(object sender, MouseEventArgs e)
        {
            button16.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button16_MouseHover(object sender, EventArgs e)
        {
            button16.FlatAppearance.BorderSize = 1;
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button16_MouseDown(object sender, MouseEventArgs e)
        {
            button16.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button17_MouseHover(object sender, EventArgs e)
        {
            button17.FlatAppearance.BorderSize = 1;
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button17_MouseDown(object sender, MouseEventArgs e)
        {
            button17.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button24_MouseHover(object sender, EventArgs e)
        {
            button24.FlatAppearance.BorderSize = 1;
        }

        private void button24_MouseLeave(object sender, EventArgs e)
        {
            button24.FlatAppearance.BorderSize = 0;
            button24.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button24_MouseDown(object sender, MouseEventArgs e)
        {
            button24.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button23_MouseHover(object sender, EventArgs e)
        {
            button23.FlatAppearance.BorderSize = 1;
        }

        private void button23_MouseLeave(object sender, EventArgs e)
        {
            button23.FlatAppearance.BorderSize = 0;
            button23.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button23_MouseDown(object sender, MouseEventArgs e)
        {
            button23.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button22_MouseHover(object sender, EventArgs e)
        {
            button22.FlatAppearance.BorderSize = 1;
        }

        private void button22_MouseLeave(object sender, EventArgs e)
        {
            button22.FlatAppearance.BorderSize = 0;
            button22.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button22_MouseDown(object sender, MouseEventArgs e)
        {
            button22.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button31_MouseHover(object sender, EventArgs e)
        {
            button31.FlatAppearance.BorderSize = 1;
        }

        private void button31_MouseLeave(object sender, EventArgs e)
        {
            button31.FlatAppearance.BorderSize = 0;
            button31.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button31_MouseDown(object sender, MouseEventArgs e)
        {
            button31.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button30_MouseHover(object sender, EventArgs e)
        {
            button30.FlatAppearance.BorderSize = 1;
        }

        private void button30_MouseLeave(object sender, EventArgs e)
        {
            button30.FlatAppearance.BorderSize = 0;
            button30.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button30_MouseDown(object sender, MouseEventArgs e)
        {
            button30.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button29_MouseHover(object sender, EventArgs e)
        {
            button29.FlatAppearance.BorderSize = 1;
        }

        private void button29_MouseLeave(object sender, EventArgs e)
        {
            button29.FlatAppearance.BorderSize = 0;
            button29.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button29_MouseDown(object sender, MouseEventArgs e)
        {
            button29.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }

        private void button38_MouseHover(object sender, EventArgs e)
        {
            button38.FlatAppearance.BorderSize = 1;
        }

        private void button38_MouseLeave(object sender, EventArgs e)
        {
            button38.FlatAppearance.BorderSize = 0;
            button38.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button38_MouseDown(object sender, MouseEventArgs e)
        {
            button38.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button37_MouseHover(object sender, EventArgs e)
        {
            button37.FlatAppearance.BorderSize = 1;
        }

        private void button37_MouseLeave(object sender, EventArgs e)
        {
            button37.FlatAppearance.BorderSize = 0;
            button37.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button37_MouseDown(object sender, MouseEventArgs e)
        {
            button37.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button36_MouseHover(object sender, EventArgs e)
        {
            button36.FlatAppearance.BorderSize = 1;
        }

        private void button36_MouseLeave(object sender, EventArgs e)
        {
            button36.FlatAppearance.BorderSize = 0;
            button36.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button36_MouseDown(object sender, MouseEventArgs e)
        {
            button36.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button39_MouseHover(object sender, EventArgs e)
        {
            button39.FlatAppearance.BorderSize = 1;
        }

        private void button39_MouseLeave(object sender, EventArgs e)
        {
            button39.FlatAppearance.BorderSize = 0;
            button39.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button39_MouseDown(object sender, MouseEventArgs e)
        {
            button39.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button40_MouseHover(object sender, EventArgs e)
        {
            button40.FlatAppearance.BorderSize = 1;
        }

        private void button40_MouseLeave(object sender, EventArgs e)
        {
            button40.FlatAppearance.BorderSize = 0;
            button40.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button40_MouseDown(object sender, MouseEventArgs e)
        {
            button40.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button41_MouseHover(object sender, EventArgs e)
        {
            button41.FlatAppearance.BorderSize = 1;
        }

        private void button41_MouseLeave(object sender, EventArgs e)
        {
            button41.FlatAppearance.BorderSize = 0;
            button41.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button41_MouseDown(object sender, MouseEventArgs e)
        {
            button41.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button42_MouseHover(object sender, EventArgs e)
        {
            button42.FlatAppearance.BorderSize = 1;
        }

        private void button42_MouseLeave(object sender, EventArgs e)
        {
            button42.FlatAppearance.BorderSize = 0;
            button42.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button42_MouseDown(object sender, MouseEventArgs e)
        {
            button42.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button43_MouseHover(object sender, EventArgs e)
        {
            button43.FlatAppearance.BorderSize = 1;
        }

        private void button43_MouseLeave(object sender, EventArgs e)
        {
            button43.FlatAppearance.BorderSize = 0;
            button43.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button43_MouseDown(object sender, MouseEventArgs e)
        {
            button43.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button44_MouseHover(object sender, EventArgs e)
        {
            button44.FlatAppearance.BorderSize = 1;
        }

        private void button44_MouseLeave(object sender, EventArgs e)
        {
            button44.FlatAppearance.BorderSize = 0;
            button44.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button44_MouseDown(object sender, MouseEventArgs e)
        {
            button44.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void button45_MouseHover(object sender, EventArgs e)
        {
            button45.FlatAppearance.BorderSize = 1;
        }

        private void button45_MouseLeave(object sender, EventArgs e)
        {
            button45.FlatAppearance.BorderSize = 0;
            button45.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }

        private void button45_MouseDown(object sender, MouseEventArgs e)
        {
            button45.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button46_MouseHover(object sender, EventArgs e)
        {
            button46.FlatAppearance.MouseOverBackColor = Color.Red;
            button46.Image = Properties.Resources.cross_white;
        }

        private void button46_MouseLeave(object sender, EventArgs e)
        {
            button46.Image = Properties.Resources.cross;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = charact.AddCharacter('7', textBox1.Text);
            button38.Text = charact.CE(textBox1.Text);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = charact.AddCharacter('8', textBox1.Text);
            button38.Text = charact.CE(textBox1.Text);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox1.Text = charact.AddCharacter('9', textBox1.Text);
            button38.Text = charact.CE(textBox1.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = charact.AddCharacter('4', textBox1.Text);
            button38.Text = charact.CE(textBox1.Text);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = charact.AddCharacter('5', textBox1.Text);
            button38.Text = charact.CE(textBox1.Text);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text = charact.AddCharacter('6', textBox1.Text);
            button38.Text = charact.CE(textBox1.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = charact.AddCharacter('1', textBox1.Text);
            button38.Text = charact.CE(textBox1.Text);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = charact.AddCharacter('2', textBox1.Text);
            button38.Text = charact.CE(textBox1.Text);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Text = charact.AddCharacter('3', textBox1.Text);
            button38.Text = charact.CE(textBox1.Text);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = charact.AddCharacter('0', textBox1.Text);
            button38.Text = charact.CE(textBox1.Text);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (charact.PointExist('.',textBox1.Text))
            {

            }
            else
            {
                textBox1.Text = charact.AddCharacter('.', textBox1.Text);
                button38.Text=charact.CE(textBox1.Text);
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (button38.Text == "CE")
            {
                SingletonChar.singleton.text="";
                textBox1.Clear();
                button38.Text = "C";

            }
        }
        // Design By Jean Carlos Reyes
    }
}
