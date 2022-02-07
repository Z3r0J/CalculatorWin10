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
        OperationClass op = new OperationClass();
        bool func = false;
        bool delete = false;
        public FrmCalculator()
        {
            InitializeComponent();
            TextBox[] texts = { textBox1 };
            foreach (TextBox item in texts)
                item.GotFocus += delegate { HideCaret(item.Handle); };
            charact = new CharacterLogic();
        }
        private void General_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.BorderColor = Color.FromArgb(159, 159, 159);
        }
        private void General_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.FlatAppearance.BorderSize = 1;
        }
        private void General_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            b.FlatAppearance.BorderColor = Color.FromArgb(142, 142, 142);
        }
        private void General1_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.FlatAppearance.BorderSize = 2;
            b.FlatAppearance.BorderColor = Color.FromArgb(157, 157, 157);
        }

        private void General1_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.FlatAppearance.BorderSize = 0;
        }
        private void General2_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.FlatAppearance.BorderSize = 2;
            b.FlatAppearance.BorderColor = Color.FromArgb(190, 190, 190);
        }

        private void General2_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.FlatAppearance.BorderSize = 0;
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
            if (SingletonChar.singleton.fue1sobrex)
            {
                textBox1.Clear();
                textBox1.Text = charact.AddCharacter('7', textBox1.Text).ToString("n0");
                SingletonChar.singleton.fue1sobrex = false;
            }
            else if (charact.PointExist('.', textBox1.Text))
            {
                textBox1.Text = charact.AddCharacter('7', textBox1.Text).ToString();
            }
            else if (SingletonChar.singleton.Btnresultado)
            {
                SingletonChar.singleton.Btnresultado = false;
                SingletonChar.singleton.SaveNumber = 0;
                SingletonChar.singleton.LastNumber = 0;
                SingletonChar.singleton.text = "";
                SingletonChar.singleton.signo = "";
                SingletonChar.singleton.func = "";
                lblResultado.Text = "";
                textBox1.Text = charact.AddCharacter('7', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
            else
            {
                textBox1.Text = charact.AddCharacter('7', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (SingletonChar.singleton.fue1sobrex)
            {
                textBox1.Clear();
                textBox1.Text = charact.AddCharacter('8', textBox1.Text).ToString("n0");
                SingletonChar.singleton.fue1sobrex = false;
            }
            else if (charact.PointExist('.', textBox1.Text))
            {
                textBox1.Text = charact.AddCharacter('8', textBox1.Text).ToString();
            }
            else if (SingletonChar.singleton.Btnresultado)
            {
                SingletonChar.singleton.Btnresultado = false;
                SingletonChar.singleton.SaveNumber = 0;
                SingletonChar.singleton.LastNumber = 0;
                SingletonChar.singleton.text = "";
                SingletonChar.singleton.signo = "";
                SingletonChar.singleton.func = "";
                lblResultado.Text = "";
                textBox1.Text = charact.AddCharacter('8', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
            else
            {
                textBox1.Text = charact.AddCharacter('8', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (SingletonChar.singleton.fue1sobrex)
            {
                textBox1.Clear();
                textBox1.Text = charact.AddCharacter('9', textBox1.Text).ToString("n0");
                SingletonChar.singleton.fue1sobrex = false;
            }
            else if (charact.PointExist('.', textBox1.Text))
            {
                textBox1.Text = charact.AddCharacter('9', textBox1.Text).ToString();
            }
            else if (SingletonChar.singleton.Btnresultado)
            {
                SingletonChar.singleton.Btnresultado = false;
                SingletonChar.singleton.SaveNumber = 0;
                SingletonChar.singleton.LastNumber = 0;
                SingletonChar.singleton.text = "";
                SingletonChar.singleton.signo = "";
                SingletonChar.singleton.func = "";
                lblResultado.Text = "";
                textBox1.Text = charact.AddCharacter('9', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
            else
            {
                textBox1.Text = charact.AddCharacter('9', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (SingletonChar.singleton.fue1sobrex)
            {
                textBox1.Clear();
                textBox1.Text = charact.AddCharacter('4', textBox1.Text).ToString("n0");
                SingletonChar.singleton.fue1sobrex = false;
            }
            else if (charact.PointExist('.', textBox1.Text))
            {
                textBox1.Text = charact.AddCharacter('4', textBox1.Text).ToString();
            }
            else if (SingletonChar.singleton.Btnresultado)
            {
                SingletonChar.singleton.Btnresultado = false;
                SingletonChar.singleton.SaveNumber = 0;
                SingletonChar.singleton.LastNumber = 0;
                SingletonChar.singleton.text = "";
                SingletonChar.singleton.func = "";
                SingletonChar.singleton.signo = "";
                lblResultado.Text = "";
                textBox1.Text = charact.AddCharacter('4', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
            else
            {
                textBox1.Text = charact.AddCharacter('4', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (SingletonChar.singleton.fue1sobrex)
            {
                textBox1.Clear();
                textBox1.Text = charact.AddCharacter('5', textBox1.Text).ToString("n0");
                SingletonChar.singleton.fue1sobrex = false;
            }
            else if (charact.PointExist('.', textBox1.Text))
            {
                textBox1.Text = charact.AddCharacter('5', textBox1.Text).ToString();
            }
            else if (SingletonChar.singleton.Btnresultado)
            {
                SingletonChar.singleton.Btnresultado = false;
                SingletonChar.singleton.SaveNumber = 0;
                SingletonChar.singleton.LastNumber = 0;
                SingletonChar.singleton.text = "";
                SingletonChar.singleton.signo = "";
                SingletonChar.singleton.func = "";
                lblResultado.Text = "";
                textBox1.Text = charact.AddCharacter('5', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
            else
            {
                textBox1.Text = charact.AddCharacter('5', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (SingletonChar.singleton.fue1sobrex)
            {
                textBox1.Clear();
                textBox1.Text = charact.AddCharacter('6', textBox1.Text).ToString("n0");
                SingletonChar.singleton.fue1sobrex = false;
            }
            else if (charact.PointExist('.', textBox1.Text))
            {
                textBox1.Text = charact.AddCharacter('6', textBox1.Text).ToString();
            }
            else if (SingletonChar.singleton.Btnresultado)
            {
                SingletonChar.singleton.Btnresultado = false;
                SingletonChar.singleton.SaveNumber = 0;
                SingletonChar.singleton.LastNumber = 0;
                SingletonChar.singleton.text = "";
                SingletonChar.singleton.func = "";
                SingletonChar.singleton.signo = "";
                lblResultado.Text = "";
                textBox1.Text = charact.AddCharacter('6', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
            else
            {
                textBox1.Text = charact.AddCharacter('6', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (SingletonChar.singleton.fue1sobrex)
            {
                textBox1.Clear();
                textBox1.Text = charact.AddCharacter('1', textBox1.Text).ToString("n0");
                SingletonChar.singleton.fue1sobrex = false;
            }
            else if (charact.PointExist('.', textBox1.Text))
            {
                textBox1.Text = charact.AddCharacter('1', textBox1.Text).ToString();
            }
            else if (SingletonChar.singleton.Btnresultado)
            {
                SingletonChar.singleton.Btnresultado = false;
                SingletonChar.singleton.SaveNumber = 0;
                SingletonChar.singleton.LastNumber = 0;
                SingletonChar.singleton.text = "";
                SingletonChar.singleton.signo = "";
                SingletonChar.singleton.func = "";
                lblResultado.Text = "";
                textBox1.Text = charact.AddCharacter('1', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
            else
            {
                textBox1.Text = charact.AddCharacter('1', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (SingletonChar.singleton.fue1sobrex)
            {
                textBox1.Clear();
                SingletonChar.singleton.text = "";
                textBox1.Text = charact.AddCharacter('2', textBox1.Text).ToString("n0");
                SingletonChar.singleton.fue1sobrex = false;
            }
            else if (charact.PointExist('.', textBox1.Text))
            {
                textBox1.Text = charact.AddCharacter('2', textBox1.Text).ToString();
            }
            else if (SingletonChar.singleton.Btnresultado)
            {
                SingletonChar.singleton.Btnresultado = false;
                SingletonChar.singleton.SaveNumber = 0;
                SingletonChar.singleton.LastNumber = 0;
                SingletonChar.singleton.text = "";
                SingletonChar.singleton.signo = "";
                SingletonChar.singleton.func = "";
                lblResultado.Text = "";
                textBox1.Text = charact.AddCharacter('2', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
            else
            {
                textBox1.Text = charact.AddCharacter('2', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (SingletonChar.singleton.fue1sobrex)
            {
                textBox1.Clear();
                textBox1.Text = charact.AddCharacter('3', textBox1.Text).ToString("n0");
                SingletonChar.singleton.fue1sobrex = false;
            }
            else if (charact.PointExist('.', textBox1.Text))
            {
                textBox1.Text = charact.AddCharacter('3', textBox1.Text).ToString();
            }
            else if (SingletonChar.singleton.Btnresultado)
            {
                SingletonChar.singleton.Btnresultado = false;
                SingletonChar.singleton.SaveNumber = 0;
                SingletonChar.singleton.LastNumber = 0;
                SingletonChar.singleton.text = "";
                SingletonChar.singleton.func = "";
                SingletonChar.singleton.signo = "";
                lblResultado.Text = "";
                textBox1.Text = charact.AddCharacter('3', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
            else
            {
                textBox1.Text = charact.AddCharacter('3', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (SingletonChar.singleton.fue1sobrex)
            {
                textBox1.Clear();
                SingletonChar.singleton.text = "";
                textBox1.Text = charact.AddCharacter('0', textBox1.Text).ToString("n0");
                SingletonChar.singleton.fue1sobrex = false;
            }
            else if (charact.PointExist('.', textBox1.Text))
            {
                textBox1.Text = charact.AddCharacter('0', textBox1.Text).ToString();
            }
            else if (SingletonChar.singleton.Btnresultado)
            {
                SingletonChar.singleton.Btnresultado = false;
                SingletonChar.singleton.SaveNumber = 0;
                SingletonChar.singleton.LastNumber = 0;
                SingletonChar.singleton.text = "";
                SingletonChar.singleton.signo = "";
                SingletonChar.singleton.func = "";
                lblResultado.Text = "";
                textBox1.Text = charact.AddCharacter('0', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
            else
            {
                textBox1.Text = charact.AddCharacter('0', textBox1.Text).ToString("n0");
                button38.Text = charact.CE(textBox1.Text);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (charact.PointExist('.', textBox1.Text))
            {

            }
            else
            {
                textBox1.Text = charact.AddPoint('.', textBox1.Text);
                button38.Text = charact.CE(textBox1.Text);
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (button38.Text == "CE" || delete)
            {
                SingletonChar.singleton.text = "";
                SingletonChar.singleton.signo = "";
                lblResultado.Text = "";
                textBox1.Clear();
                button38.Text = "C";

            }
        }

        private void Signo_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            func = false;
            if (SingletonChar.singleton.Btnresultado)
            {
                SingletonChar.singleton.LastNumber = 0;
                SingletonChar.singleton.SaveNumber = Convert.ToDecimal(textBox1.Text);
                SingletonChar.singleton.Btnresultado = false;
                SingletonChar.singleton.signo = Convert.ToString(b.Text);
                if (lblResultado.Text.Contains('('))
                {
                    lblResultado.Text = $"({SingletonChar.singleton.SaveNumber} {SingletonChar.singleton.signo}";
                }
                else
                {
                    lblResultado.Text = $"{SingletonChar.singleton.SaveNumber} {SingletonChar.singleton.signo}";
                }
            }
            else
            {
                if (SingletonChar.singleton.signo.Length != 0)
                {
                    MessageBox.Show("No se puede cambiar de signo hasta terminar la operacion actual.", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (String.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("No se puede realizar la operacion falta el segundo numero.", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SingletonChar.singleton.signo = Convert.ToString(b.Text);
                    SingletonChar.singleton.SaveNumber = Convert.ToDecimal(textBox1.Text);
                    if (lblResultado.Text.Contains('('))
                    {
                        lblResultado.Text += $" {SingletonChar.singleton.signo}";
                    }
                    else
                    {
                        lblResultado.Text = $"{SingletonChar.singleton.SaveNumber} {SingletonChar.singleton.signo}";
                    }
                    lblResultado.Visible = true;
                    SingletonChar.singleton.text = "";
                    textBox1.Clear();
                }
            }

        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (func)
            {
                bool response = true;
                Resultado(response);
            }
            else
            {
                bool response = false;
                Resultado(response);
            }
        }

        private void Resultado(bool response)
        {
            if (response == true)
            {
                if (String.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Escribe un numero para la operacion", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (SingletonChar.singleton.SaveNumber != 0)
                {
                    if (SingletonChar.singleton.Btnresultado == true)
                    {
                        SingletonChar.singleton.SaveNumber = Convert.ToDecimal(textBox1.Text);
                        SingletonChar.singleton.Btnresultado = true;
                        lblResultado.Text = $"{SingletonChar.singleton.SaveNumber}{SingletonChar.singleton.signo}";
                        lblResultado.Visible = true;
                        SingletonChar.singleton.text = "";
                        if (lblResultado.Text.Contains('('))
                        {
                            lblResultado.Text = $"({textBox1.Text} {SingletonChar.singleton.signo} {SingletonChar.singleton.LastNumber}) =";
                        }
                        else
                        {
                            lblResultado.Text = $"{textBox1.Text} {SingletonChar.singleton.signo} {SingletonChar.singleton.LastNumber} =";
                        }
                        if (Convert.ToString(op.AdvancedOperation(Convert.ToDecimal(textBox1.Text))).Contains('.'))
                        {
                            textBox1.Text = op.AdvancedOperation(Convert.ToDecimal(SingletonChar.singleton.LastNumber)).ToString();
                        }
                        else
                        {
                            textBox1.Text = $"{op.AdvancedOperation(Convert.ToDecimal(SingletonChar.singleton.LastNumber))}";
                        }
                        SingletonChar.singleton.text = "";
                    }
                    else
                    {
                        if (SingletonChar.singleton.LastNumber == 0)
                        {
                            SingletonChar.singleton.LastNumber = Convert.ToDecimal(textBox1.Text);
                        }
                        SingletonChar.singleton.Btnresultado = true;
                        lblResultado.Text = $"{SingletonChar.singleton.SaveNumber} {SingletonChar.singleton.signo}";
                        lblResultado.Visible = true;
                        SingletonChar.singleton.text = "";
                        if (lblResultado.Text.Contains('('))
                        {
                            lblResultado.Text = $"({SingletonChar.singleton.SaveNumber} {SingletonChar.singleton.signo} {SingletonChar.singleton.LastNumber}) =";
                        }
                        else
                        {
                            lblResultado.Text = $"{SingletonChar.singleton.SaveNumber} {SingletonChar.singleton.signo} {SingletonChar.singleton.LastNumber} =";
                        }
                        if (Convert.ToString(op.AdvancedOperation(Convert.ToDecimal(textBox1.Text))).Contains('.'))
                        {
                            SingletonChar.singleton.resultado = Convert.ToDecimal(op.AdvancedOperation(Convert.ToDecimal(textBox1.Text)));
                            textBox1.Text = SingletonChar.singleton.resultado.ToString();
                        }
                        else
                        {
                            SingletonChar.singleton.resultado = Convert.ToDecimal(op.AdvancedOperation(Convert.ToDecimal(textBox1.Text)));
                            textBox1.Text = SingletonChar.singleton.resultado.ToString("n0");
                        }
                        SingletonChar.singleton.text = "";
                    }
                }
                else if (SingletonChar.singleton.signo == "")
                {
                    lblResultado.Text = textBox1.Text + " = ";
                    textBox1.Text = textBox1.Text;
                }
            }
            else
            {
                if (String.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Escribe un numero para la operacion", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (SingletonChar.singleton.signo == "÷" && textBox1.Text == "0")
                {
                    textBox1.Text = "No se puede dividir entre cero";
                    button38.Text = charact.CE(textBox1.Text);
                }
                else if (SingletonChar.singleton.SaveNumber != 0)
                {
                    if (SingletonChar.singleton.Btnresultado == true)
                    {
                        SingletonChar.singleton.SaveNumber = Convert.ToDecimal(textBox1.Text);
                        SingletonChar.singleton.Btnresultado = true;
                        lblResultado.Text = $"{SingletonChar.singleton.SaveNumber}{SingletonChar.singleton.signo}";
                        lblResultado.Visible = true;
                        SingletonChar.singleton.text = "";
                        lblResultado.Text = $"{textBox1.Text} {SingletonChar.singleton.signo} {SingletonChar.singleton.LastNumber} =";
                        if (Convert.ToString(op.BasicOperation(Convert.ToDecimal(textBox1.Text))).Contains('.'))
                        {
                            textBox1.Text = op.BasicOperation(Convert.ToDecimal(SingletonChar.singleton.LastNumber)).ToString();
                        }
                        else
                        {
                            textBox1.Text = op.BasicOperation(Convert.ToDecimal(SingletonChar.singleton.LastNumber)).ToString("n0");
                        }
                        SingletonChar.singleton.text = "";
                    }
                    else
                    {
                        if (SingletonChar.singleton.LastNumber == 0)
                        {
                            SingletonChar.singleton.LastNumber = Convert.ToDecimal(textBox1.Text);
                        }
                        SingletonChar.singleton.Btnresultado = true;
                        if (lblResultado.Text.Contains('('))
                        {
                            lblResultado.Text = $"({SingletonChar.singleton.SaveNumber} {SingletonChar.singleton.signo}";
                        }
                        else
                        {
                            lblResultado.Text = $"{SingletonChar.singleton.SaveNumber} {SingletonChar.singleton.signo}";
                        }
                        lblResultado.Visible = true;
                        SingletonChar.singleton.text = "";
                        if (lblResultado.Text.Contains('('))
                        {
                            lblResultado.Text = $"({SingletonChar.singleton.SaveNumber} {SingletonChar.singleton.signo} {SingletonChar.singleton.LastNumber}) =";
                        }
                        else
                        {
                            lblResultado.Text = $"{SingletonChar.singleton.SaveNumber} {SingletonChar.singleton.signo} {SingletonChar.singleton.LastNumber} =";
                        }
                        if (Convert.ToString(op.BasicOperation(Convert.ToDecimal(textBox1.Text))).Contains('.'))
                        {
                            SingletonChar.singleton.resultado = op.BasicOperation(Convert.ToDecimal(textBox1.Text));
                            textBox1.Text = SingletonChar.singleton.resultado.ToString();
                        }
                        else
                        {
                            SingletonChar.singleton.resultado = op.BasicOperation(Convert.ToDecimal(textBox1.Text));
                            textBox1.Text = SingletonChar.singleton.resultado.ToString("n0");
                        }
                        SingletonChar.singleton.text = "";
                    }
                }
                else if (SingletonChar.singleton.func == "")
                {
                    lblResultado.Text = textBox1.Text + " = ";
                    textBox1.Text = textBox1.Text;
                }
            }
        }

        private void Advanced_Click(object sender, EventArgs e)
        {
            func = true;
            Button b = (Button)sender;
            SingletonChar.singleton.func = b.Text;
            if (SingletonChar.singleton.Btnresultado)
            {
                SingletonChar.singleton.LastNumber = 0;
                SingletonChar.singleton.SaveNumber = Convert.ToDecimal(textBox1.Text);
                SingletonChar.singleton.Btnresultado = false;
                SingletonChar.singleton.signo = Convert.ToString(b.Text);
                lblResultado.Text = $"{SingletonChar.singleton.SaveNumber} {SingletonChar.singleton.signo}";
            }
            else
            {
                SingletonChar.singleton.signo = Convert.ToString(b.Text);
                SingletonChar.singleton.SaveNumber = Convert.ToDecimal(textBox1.Text);
                lblResultado.Text = $"{SingletonChar.singleton.SaveNumber} {SingletonChar.singleton.signo}";
                lblResultado.Visible = true;
                SingletonChar.singleton.text = "";
                textBox1.Clear();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button ap = (Button)sender;
            SingletonChar.singleton.func = ap.Text;

            textBox1.Text = op.AdvancedOperation(Convert.ToDecimal(textBox1.Text));
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Button ap = (Button)sender;
            SingletonChar.singleton.func = ap.Text;
            if (Convert.ToDecimal(textBox1.Text) < 0)
            {
                lblResultado.Text = $"fact({textBox1.Text})";
                Console.WriteLine("Entrada no válida");
            }
            else
            {
                lblResultado.Text = $"fact({textBox1.Text})";
                if (op.ComplexCalc(SingletonChar.singleton.func, Convert.ToDecimal(textBox1.Text)).ToString().Length > 30)
                {
                    textBox1.Text = op.ComplexCalc(SingletonChar.singleton.func, Convert.ToDecimal(textBox1.Text)).ToString("e23");
                }
                else
                {
                    textBox1.Text = op.ComplexCalc(SingletonChar.singleton.func, Convert.ToDecimal(textBox1.Text)).ToString();
                }
                SingletonChar.singleton.text = "";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(textBox1.Text) != 0 || String.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (lblResultado.Text.Contains('('))
                {

                }
                else
                {
                    if (lblResultado.Text.Length > 0)
                    {
                        lblResultado.Text = $"({lblResultado.Text}";
                    }
                    else
                    {
                        lblResultado.Text = $"({textBox1.Text}";
                    }
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Contains('('))
            {
                if (lblResultado.Text.Contains(')'))
                {

                }
                else
                {

                    lblResultado.Text = $"{lblResultado.Text} {textBox1.Text})";
                }
            }
            else
            {
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {
            Button ap = (Button)sender;
            SingletonChar.singleton.func = ap.Text;
            lblResultado.Text = $"abs({textBox1.Text})";
            textBox1.Text = op.AdvancedOperation(Convert.ToDecimal(textBox1.Text));
            button38.Text = charact.CE(textBox1.Text);
            SingletonChar.singleton.text = "";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Button ap = (Button)sender;
            SingletonChar.singleton.func = ap.Text;
            SingletonChar.singleton.text = op.AdvancedOperation(Convert.ToDecimal(0)); ;
            textBox1.Text = SingletonChar.singleton.text;
            button38.Text = charact.CE(textBox1.Text);
            SingletonChar.singleton.fue1sobrex = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(textBox1.Text) == 0 || String.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "No se puede dividir entre cero";
                button38.Text = charact.CE(textBox1.Text);
            }
            else
            {
                Button ap = (Button)sender;
                SingletonChar.singleton.func = ap.Text;
                lblResultado.Text = $"1/{textBox1.Text}";
                SingletonChar.singleton.text = op.AdvancedOperation(Convert.ToDecimal(textBox1.Text)); ;
                textBox1.Text = SingletonChar.singleton.text;
                button38.Text = charact.CE(textBox1.Text);
                SingletonChar.singleton.fue1sobrex = true;
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length - 1 >= 0 || SingletonChar.singleton.text.Length - 1 >= 0)
            {
                if (SingletonChar.singleton.text.Length - 1 >= 0)
                {
                    SingletonChar.singleton.text = SingletonChar.singleton.text.Remove(SingletonChar.singleton.text.Length - 1, 1);
                }
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                button38.Text = charact.CE(textBox1.Text);
            }

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button ap = (Button)sender;
            SingletonChar.singleton.func = ap.Text;
            SingletonChar.singleton.text = op.AdvancedOperation(Convert.ToDecimal(0)); ;
            textBox1.Text = SingletonChar.singleton.text;
            button38.Text = charact.CE(textBox1.Text);
            SingletonChar.singleton.fue1sobrex = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button ap = (Button)sender;

            if (this.button12.Image.FrameDimensionsList[0] == Properties.Resources.x_2.FrameDimensionsList[0])
            {
                SingletonChar.singleton.func = "x^2";
                lblResultado.Text = $"sqr({textBox1.Text})";
                if (op.ComplexCalc(SingletonChar.singleton.func, Convert.ToDecimal(textBox1.Text)).ToString().Length > 30)
                {
                    textBox1.Text = op.ComplexCalc(SingletonChar.singleton.func, Convert.ToDecimal(textBox1.Text)).ToString("e23");
                }
                else
                {
                    textBox1.Text = op.ComplexCalc(SingletonChar.singleton.func, Convert.ToDecimal(textBox1.Text)).ToString("n0");
                }
                SingletonChar.singleton.text = "";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (this.button13.Image.FrameDimensionsList[0] == Properties.Resources.sqrt_x_.FrameDimensionsList[0])
            {
                if (Convert.ToDecimal(textBox1.Text) < 0)
                {
                    textBox1.Text = "Entrada no válida";
                    button38.Text = charact.CE(textBox1.Text);
                }
                else
                {
                    SingletonChar.singleton.func = "sqrt";
                    lblResultado.Text = $"sqrt({textBox1.Text})";
                    if (op.AdvancedOperation(Convert.ToDecimal(textBox1.Text)).ToString().Length > 30)
                    {
                        textBox1.Text = op.AdvancedOperation(Convert.ToDecimal(textBox1.Text));
                    }
                    else
                    {
                        textBox1.Text = op.AdvancedOperation(Convert.ToDecimal(textBox1.Text));
                    }
                    SingletonChar.singleton.text = "";
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            func = true;
            Button b = (Button)sender;
            SingletonChar.singleton.func = b.Text;
            if (SingletonChar.singleton.Btnresultado)
            {
                SingletonChar.singleton.LastNumber = 0;
                SingletonChar.singleton.SaveNumber = Convert.ToDecimal(textBox1.Text);
                SingletonChar.singleton.Btnresultado = false;
                SingletonChar.singleton.func = "^";
                SingletonChar.singleton.signo = "^";
                lblResultado.Text = $"{SingletonChar.singleton.SaveNumber} {SingletonChar.singleton.func}";
            }
            else
            {
                SingletonChar.singleton.func = "^";
                SingletonChar.singleton.signo = "^";
                SingletonChar.singleton.SaveNumber = Convert.ToDecimal(textBox1.Text);
                lblResultado.Text = $"{SingletonChar.singleton.SaveNumber} {SingletonChar.singleton.func}";
                lblResultado.Visible = true;
                SingletonChar.singleton.text = "";
                textBox1.Clear();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SingletonChar.singleton.func = "10^x";
            lblResultado.Text = $"10^({textBox1.Text})";

            textBox1.Text = $"{op.AdvancedOperation(Convert.ToDecimal(textBox1.Text))}";
            SingletonChar.singleton.text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(textBox1.Text) < 0)
            {
                textBox1.Text = "Entrada no válida";
                button38.Text = charact.CE(textBox1.Text);
            }
            else
            {
                SingletonChar.singleton.func = "log10";
                lblResultado.Text = $"log({textBox1.Text})";
                if (op.AdvancedOperation(Convert.ToDecimal(textBox1.Text)).ToString().Length > 30)
                {
                    textBox1.Text = op.AdvancedOperation(Convert.ToDecimal(textBox1.Text));
                }
                else
                {
                    textBox1.Text = op.AdvancedOperation(Convert.ToDecimal(textBox1.Text));
                }
                SingletonChar.singleton.text = "";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(textBox1.Text) < 0)
            {
                textBox1.Text = "Entrada no válida";
                button38.Text = charact.CE(textBox1.Text);
            }
            else
            {
                SingletonChar.singleton.func = "ln";
                lblResultado.Text = $"ln({textBox1.Text})";
                if (op.AdvancedOperation(Convert.ToDecimal(textBox1.Text)).ToString().Length > 30)
                {
                    textBox1.Text = op.AdvancedOperation(Convert.ToDecimal(textBox1.Text));
                }
                else
                {
                    textBox1.Text = op.AdvancedOperation(Convert.ToDecimal(textBox1.Text));
                }
                SingletonChar.singleton.text = "";
            }
        }
        private void Atajos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Multiply)
                    button42.PerformClick();
                else if (e.KeyCode == Keys.Delete)
                {
                    delete = true;
                    button38.PerformClick();
                }
                else if (e.KeyCode == Keys.Clear || e.KeyCode == Keys.C)
                {
                    delete = true;
                    button38.PerformClick();
                }
                else if (e.KeyCode == Keys.Back)
                    button45.PerformClick();
                else if (e.KeyCode == Keys.Add)
                    button40.PerformClick();
                else if (e.KeyCode == Keys.Subtract)
                    button41.PerformClick();
                else if (e.KeyCode == Keys.Divide)
                    button43.PerformClick();
                else if (e.KeyCode == Keys.Enter)
                    button39.PerformClick();
                else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
                    button25.PerformClick();
                else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                    button19.PerformClick();
                else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                    button26.PerformClick();
                else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                    button33.PerformClick();
                else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                    button20.PerformClick();
                else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                    button27.PerformClick();
                else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                    button34.PerformClick();
                else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                    button21.PerformClick();
                else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
                    button28.PerformClick();
                else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                    button35.PerformClick();
                else if (e.KeyCode == Keys.Decimal)
                    button32.PerformClick();
            }
            catch (Exception ex)
            {
            }

        }

        // Design By Jean Carlos Reyes
    }
}