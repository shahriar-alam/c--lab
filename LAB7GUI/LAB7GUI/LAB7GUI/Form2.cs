using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB7GUI
{
    public partial class Form2 : Form
    {
        private Form1 ob = null;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 ob1)
        {
            this.ob = ob1;
            InitializeComponent();
        }
        public void SetTextBox(string s)
        {
            this.textBox1.Text = s;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ob.SetTextBox(this.textBox1.Text);
            ob.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();


        }
    }
}
