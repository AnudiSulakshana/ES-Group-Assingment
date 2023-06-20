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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4();
            f2.Show();
            this.Hide();

            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-E2QCO8FG\\SQLEXPRESS;Initial Catalog=\"Driver Hiring system\";Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into testfirst(Name) values('" + textBox1.Text + "') (Address) values ('"+textBox2.Text+"') (Age) values ('"+textBox3.Text+"') (Telephone no) values('"+textBox4.Text+"') (Grade) values('"+textBox5.Text+"')");

        }
    }
}
