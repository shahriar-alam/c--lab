using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        double first, second;
        bool buttonClicked = false;
        string op = " ";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text == "0")
                this.textBox1.Text = "7";
            else
                this.textBox1.Text += "7";
            buttonClicked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
                this.textBox1.Text = "8";
            else
                this.textBox1.Text += "8";
            buttonClicked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
                this.textBox1.Text = "9";
            else
                this.textBox1.Text += "9";
            buttonClicked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
                this.textBox1.Text = "4";
            else
                this.textBox1.Text += "4";
            buttonClicked = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
                this.textBox1.Text = "5";
            else
                this.textBox1.Text += "5";
            buttonClicked = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
                this.textBox1.Text = "6";
            else
                this.textBox1.Text += "6";
            buttonClicked = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
                this.textBox1.Text = "1";
            else
                this.textBox1.Text += "1";
            buttonClicked = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
                this.textBox1.Text = "2";
            else
                this.textBox1.Text += "2";
            buttonClicked = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
                this.textBox1.Text = "3";
            else
                this.textBox1.Text += "3";
            buttonClicked = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
                this.textBox1.Text = "0";
            else
                this.textBox1.Text += "0";
            buttonClicked = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "0")
                this.textBox1.Text = "0.";
            else
            {
                if (!(this.textBox1.Text.Contains(".")))
                {
                    this.textBox1.Text += ".";
                }
            }
            buttonClicked = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (op.Equals(" "))
            {
                if(buttonClicked == true)
                    first = Convert.ToDouble(this.textBox1.Text);
                op = "/";
                this.label2.Text = "/";
                this.textBox1.Text = "0";
                this.label1.Text = first.ToString();
            }
            else if (op.Equals("/"))
            {
                if (first != 0 && !(this.textBox1.Text.Equals("0")))
                {
                    second = Convert.ToDouble(this.textBox1.Text);
                    first /= second;
                    op = "/";
                    this.label2.Text = "/";
                    second = Convert.ToDouble(this.textBox1.Text);
                    this.textBox1.Text = "0";
                    this.label1.Text = first.ToString();
                }
                else
                {
                    MessageBox.Show("Cant divide by 0");
                    this.textBox1.Text = "0";
                    this.label1.Text = "0";
                    op = " ";
                    first = second = 0;

                }
            }
            else
            {
                if (op.Equals("*"))
                {
                    second = Convert.ToDouble(this.textBox1.Text);
                    first *= second;
                    op = "/";
                    this.label2.Text = "/";
                    second = Convert.ToDouble(this.textBox1.Text);
                    this.textBox1.Text = "0";
                    this.label1.Text = first.ToString();
                }
                else if (op.Equals("+"))
                {
                    second = Convert.ToDouble(this.textBox1.Text);
                    first += second;
                    op = "/";
                    this.label2.Text = "/";
                    second = Convert.ToDouble(this.textBox1.Text);
                    this.textBox1.Text = "0";
                    this.label1.Text = first.ToString();
                }
                else if (op.Equals("-"))
                {
                    second = Convert.ToDouble(this.textBox1.Text);
                    first -= second;
                    op = "/";
                    this.label2.Text = "/";
                    second = Convert.ToDouble(this.textBox1.Text);
                    this.textBox1.Text = "0";
                    this.label1.Text = first.ToString();
                }
                
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (op.Equals(" "))
            {
                if (buttonClicked == true)
                    first = Convert.ToDouble(this.textBox1.Text);
                op = "*";
                this.label2.Text = "*";
                this.textBox1.Text = "0";
                this.label1.Text = first.ToString();
            }
            else if(op.Equals("*"))
            {
                second = Convert.ToDouble(this.textBox1.Text);
                first *= second;
                this.label2.Text = "*";
                second = Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "0";
                this.label1.Text = first.ToString();
               
            }
            else
            {
                if (op.Equals("/"))
                {
                    if (first != 0 && !(this.textBox1.Text.Equals("0")))
                    {
                        second = Convert.ToDouble(this.textBox1.Text);
                        first /= second;
                        op = "*";
                        this.label2.Text = "*";
                        second = Convert.ToDouble(this.textBox1.Text);
                        this.textBox1.Text = "0";
                        this.label1.Text = first.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cant divide by 0");
                        this.textBox1.Text = "0";
                        this.label1.Text = "0";
                        this.label2.Text = "";
                        op = " ";
                        first = second = 0;

                    }
                }
                else if (op.Equals("+"))
                {
                    second = Convert.ToDouble(this.textBox1.Text);
                    first += second;
                    op = "*";
                    this.label2.Text = "*";
                    second = Convert.ToDouble(this.textBox1.Text);
                    this.textBox1.Text = "0";
                    this.label1.Text = first.ToString();
                }
                else if (op.Equals("-"))
                {
                    second = Convert.ToDouble(this.textBox1.Text);
                    first -= second;
                    op = "/";
                    this.label2.Text = "*";
                    second = Convert.ToDouble(this.textBox1.Text);
                    this.textBox1.Text = "0";
                    this.label1.Text = first.ToString();
                }

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (op.Equals(" "))
            {
                if (buttonClicked == true)
                    first = Convert.ToDouble(this.textBox1.Text);
                op = "-";
                this.label2.Text = "-";
                this.textBox1.Text = "0";
                this.label1.Text = first.ToString();
            }
            else if (op.Equals("-"))
            {
                second = Convert.ToDouble(this.textBox1.Text);
                first -= second;
                this.label2.Text = "-";
                second = Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "0";
                this.label1.Text = first.ToString();

            }
            else
            {
                if (op.Equals("/"))
                {
                    if (first != 0 && !(this.textBox1.Text.Equals("0")))
                    {
                        second = Convert.ToDouble(this.textBox1.Text);
                        first /= second;
                        op = "-";
                        this.label2.Text = "-";
                        second = Convert.ToDouble(this.textBox1.Text);
                        this.textBox1.Text = "0";
                        this.label1.Text = first.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cant divide by 0");
                        this.textBox1.Text = "0";
                        this.label1.Text = "0";
                        this.label2.Text = "";
                        op = " ";
                        first = second = 0;

                    }
                }
                else if (op.Equals("+"))
                {
                    second = Convert.ToDouble(this.textBox1.Text);
                    first += second;
                    op = "-";
                    this.label2.Text = "-";
                    second = Convert.ToDouble(this.textBox1.Text);
                    this.textBox1.Text = "0";
                    this.label1.Text = first.ToString();
                }
                else if (op.Equals("*"))
                {
                    second = Convert.ToDouble(this.textBox1.Text);
                    first *= second;
                    op = "-";
                    this.label2.Text = "-";
                    second = Convert.ToDouble(this.textBox1.Text);
                    this.textBox1.Text = "0";
                    this.label1.Text = first.ToString();

                }

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (op.Equals(" "))
            {
                if (buttonClicked == true)
                    first = Convert.ToDouble(this.textBox1.Text);
                op = "+";
                this.label2.Text = "+";
                this.textBox1.Text = "0";
                this.label1.Text = first.ToString();
            }
            else if (op.Equals("+"))
            {
                second = Convert.ToDouble(this.textBox1.Text);
                first += second;
                this.label2.Text = "+";
                second = Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "0";
                this.label1.Text = first.ToString();

            }
            else
            {
                if (op.Equals("/"))
                {
                    if (first != 0 && !(this.textBox1.Text.Equals("0")))
                    {
                        second = Convert.ToDouble(this.textBox1.Text);
                        first /= second;
                        op = "+";
                        this.label2.Text = "+";
                        second = Convert.ToDouble(this.textBox1.Text);
                        this.textBox1.Text = "0";
                        this.label1.Text = first.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cant divide by 0");
                        this.textBox1.Text = "0";
                        this.label1.Text = "0";
                        this.label2.Text = "";
                        op = " ";
                        first = second = 0;

                    }
                }
                else if (op.Equals("-"))
                {
                    second = Convert.ToDouble(this.textBox1.Text);
                    first -= second;
                    op = "+";
                    this.label2.Text = "+";
                    second = Convert.ToDouble(this.textBox1.Text);
                    this.textBox1.Text = "0";
                    this.label1.Text = first.ToString();
                }
                else if (op.Equals("*"))
                {
                    second = Convert.ToDouble(this.textBox1.Text);
                    first *= second;
                    op = "+";
                    this.label2.Text = "+";
                    second = Convert.ToDouble(this.textBox1.Text);
                    this.textBox1.Text = "0";
                    this.label1.Text = first.ToString();

                }

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (op.Equals(" "))
            {
                first = Convert.ToDouble(this.textBox1.Text);
                this.label1.Text = first.ToString();
                op = " ";
                this.label2.Text = "";
                this.textBox1.Text = "0";
                buttonClicked = false;
            }
            else if (op.Equals("+"))
            {
                second = Convert.ToDouble(this.textBox1.Text);
                first += second;
                this.label1.Text = first.ToString();
                this.label2.Text = "";
                this.textBox1.Text = "0";
                op = " ";
                buttonClicked = false;
            }
            else if (op.Equals("-"))
            {
                second = Convert.ToDouble(this.textBox1.Text);
                first -= second;
                this.label1.Text = first.ToString();
                this.label2.Text = "";
                this.textBox1.Text = "0";
                op = " ";
                buttonClicked = false;
            }
            else if (op.Equals("*"))
            {
                second = Convert.ToDouble(this.textBox1.Text);
                first *= second;
                this.label1.Text = first.ToString();
                this.label2.Text = "";
                this.textBox1.Text = "0";
                op = " ";
                buttonClicked = false;
            }
            else if (op.Equals("/"))
            {
                if (first != 0 && !(this.textBox1.Text.Equals("0")))
                {
                    second = Convert.ToDouble(this.textBox1.Text);
                    first /= second;
                    op = " ";
                    this.label2.Text = "";
                    second = Convert.ToDouble(this.textBox1.Text);
                    this.textBox1.Text = "0";
                    this.label1.Text = first.ToString();
                    buttonClicked = false;
                }
                else
                {
                    MessageBox.Show("Cant divide by 0");
                    this.textBox1.Text = "0";
                    this.label1.Text = "";
                    op = " ";
                    this.label2.Text = "";
                    first = second = 0;
                    buttonClicked = false;
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length > 1)
            {
                string s = this.textBox1.Text;
                s = s.Remove(s.Length - 1, 1);
                this.textBox1.Text = s;
            }
            else
            {
                this.textBox1.Text = "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.StartsWith("-"))
            {
                int len = this.textBox1.Text.Length;
                string str = this.textBox1.Text;
                this.textBox1.Text = str.Substring(1);
            }
            else
                this.textBox1.Text = "-" + this.textBox1.Text;
        }        
    }
}
