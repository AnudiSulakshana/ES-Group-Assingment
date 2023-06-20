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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 f2 = new Form8();
            f2.Show();
            this.Hide();

            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-E2QCO8FG\\SQLEXPRESS;Initial Catalog=\"Driver Hiring system\";Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into testfirst(Name) values ('" + textBox1.Text + "') (Id) values ('"+textBox2.Text+"') (Licenece Id) values ('"+textBox3.Text+"') (Telephone no) values ('"+textBox4.Text+"') (Email) values ('"+textBox5.Text+"') (Time) values ('"+textBox6.Text+"') (location) values ('"+textBox7.Text+"') (description) values ('"+textBox8.Text+"')");
            cmd.Connection = conn;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
