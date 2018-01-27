using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!this.textBox1.Text.Equals("") && !this.textBox2.Text.Equals(""))
            {
                int x = Convert.ToInt32(this.textBox1.Text);
                int y = Convert.ToInt32(this.textBox2.Text);
                int sum = x + y;
                MessageBox.Show("The sum is: " + sum.ToString());
            }
            else
            {
                MessageBox.Show("One or both input is empty");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!this.textBox1.Text.Equals("") && !this.textBox2.Text.Equals(""))
            {
                int x = Convert.ToInt32(this.textBox1.Text);
                int y = Convert.ToInt32(this.textBox2.Text);
                int sum = x - y;
                MessageBox.Show("The substraction is: " + sum.ToString());
            }
            else
            {
                MessageBox.Show("One or both input is empty");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!this.textBox1.Text.Equals("") && !this.textBox2.Text.Equals(""))
            {
                int x = Convert.ToInt32(this.textBox1.Text);
                int y = Convert.ToInt32(this.textBox2.Text);
                int sum = x * y;
                MessageBox.Show("The multiplication is: " + sum.ToString());
            }
            else
            {
                MessageBox.Show("One or both input is empty");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!this.textBox1.Text.Equals("") && !this.textBox2.Text.Equals(""))
            {
                if (!this.textBox2.Text.Equals("0"))
                {
                    double x = Convert.ToDouble(this.textBox1.Text);
                    double y = Convert.ToDouble(this.textBox2.Text);
                    double sum = x / y;
                    MessageBox.Show("The divide is: " + sum.ToString());
                }
                else
                    MessageBox.Show( "Input2 is zero.");
            }
            else
            {
                MessageBox.Show("One or both input is empty");
            }
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {

        }
    }
}
