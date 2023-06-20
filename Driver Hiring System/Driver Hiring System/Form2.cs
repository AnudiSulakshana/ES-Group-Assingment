using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Driver_Hiring_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form6 f2 = new Form6();
            f2.Show();

            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-E2QCO8FG\\SQLEXPRESS;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into testfirst(FName) values('" + textBox1.Text + "') (Id) values ('"+textBox2.Text+"') (age) values('"+textBox3.Text+"') (T no) values('"+textBox4.Text+"') (Address) values('"+textBox5.Text+"') (W experience) values('"+textBox6.Text+"') (Ltype) values('"+textBox7.Text+"') (E qualification) values('"+textBox8.Text+"')");

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
