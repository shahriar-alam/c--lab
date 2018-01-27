using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyUserDBDataContext mdc = new MyUserDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\student\Downloads\LabAssignment2\LabAssignment2\Registration\UserDB.mdf;Integrated Security=True;Connect Timeout=30");
            var list = from a in mdc.Users
                       select a;
            this.dataGridView1.DataSource = list;
        }
        public void UpdateTable()
        {
            MyUserDBDataContext mdc = new MyUserDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\student\Downloads\LabAssignment2\LabAssignment2\Registration\UserDB.mdf;Integrated Security=True;Connect Timeout=30");
            var list = from a in mdc.Users
                       select a;
            this.dataGridView1.DataSource = list;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MyUserDBDataContext mdc = new MyUserDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\student\Downloads\LabAssignment2\LabAssignment2\Registration\UserDB.mdf;Integrated Security=True;Connect Timeout=30");
            User u = new User();
            if (textBox3.Text == textBox4.Text)
            {
                u.Name = textBox1.Text;
                u.Email = textBox2.Text;
                u.Password = textBox3.Text;
                u.Phone = textBox5.Text;
                u.BloodGroup = comboBox1.Text;
                if (radioButton1.Checked)
                {
                    u.Gender = "Male";
                    mdc.Users.InsertOnSubmit(u);
                    mdc.SubmitChanges();
                    UpdateTable();
                }
                else if (radioButton2.Checked)
                {
                    u.Gender = "Female";
                    mdc.Users.InsertOnSubmit(u);
                    mdc.SubmitChanges();
                    UpdateTable();
                }
                else
                    MessageBox.Show("Select Gender");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyUserDBDataContext mdc = new MyUserDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\student\Downloads\LabAssignment2\LabAssignment2\Registration\UserDB.mdf;Integrated Security=True;Connect Timeout=30");
            var record = from a in mdc.Users
                         where a.Id == int.Parse(textBox6.Text)
                         select a;
            textBox1.Text = record.First().Name;
            textBox2.Text = record.First().Email;
            textBox3.Text = record.First().Password;
            textBox4.Text = record.First().Password;
            textBox5.Text = record.First().Phone;
            if (record.First().Gender == "Male")
                radioButton1.Checked = true;
            else
                radioButton2.PerformClick();
            comboBox1.Text = record.First().BloodGroup;
            dataGridView1.DataSource = record;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyUserDBDataContext mdc = new MyUserDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\student\Downloads\LabAssignment2\LabAssignment2\Registration\UserDB.mdf;Integrated Security=True;Connect Timeout=30");
            var record = from a in mdc.Users
                         where a.Id == int.Parse(textBox6.Text)
                         select a;
            textBox1.Text = record.First().Name;
            textBox2.Text = record.First().Email;
            textBox3.Text = record.First().Password;
            textBox4.Text = record.First().Password;
            textBox5.Text = record.First().Phone;
            if (record.First().Gender == "Male")
                radioButton1.Checked = true;
            else
                radioButton2.PerformClick();
            comboBox1.Text = record.First().BloodGroup;
            dataGridView1.DataSource = record;

            User u = record.First();
            if (textBox3.Text == textBox4.Text)
            {
                u.Name = textBox1.Text;
                u.Email = textBox2.Text;
                u.Password = textBox3.Text;
                u.Phone = textBox3.Text;
                u.BloodGroup = comboBox1.Text;
                if (radioButton1.Checked)
                {
                    u.Gender = "Male";
                    //mdc.Users.InsertOnSubmit(u);
                    mdc.SubmitChanges();
                    UpdateTable();
                }
                else if (radioButton2.Checked)
                {
                    u.Gender = "Female";
                    //mdc.Users.InsertOnSubmit(u);
                    mdc.SubmitChanges();
                    UpdateTable();
                }
                else
                    MessageBox.Show("Select Gender");
            }

        }
    }
}
