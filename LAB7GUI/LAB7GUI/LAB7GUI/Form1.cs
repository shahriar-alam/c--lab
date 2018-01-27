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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SetTextBox(string s)
        {
            this.textBox1.Text = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                DialogResult result = MessageBox.Show("Hello", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
                if (result.Equals(DialogResult.Yes))
                    MessageBox.Show("Yes");
                else if ( result.Equals(DialogResult.No))
                    MessageBox.Show("No");
                else if ( result.Equals(DialogResult.Cancel))
                    MessageBox.Show("Cancel");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.SetTextBox(this.textBox1.Text);
            f2.Show();
            this.Hide();
        }
    }
}
