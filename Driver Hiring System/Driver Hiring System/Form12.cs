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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 f2 = new Form13();
            f2.Show();
            this.Hide();

            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-E2QCO8FG\\SQLEXPRESS;Initial Catalog=\"Driver Hiring system\";Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into testfirst(name) values('\"+textBox1.Text+\"') (id) values('"+textBox2.Text+"') (Rattendance) values('"+textBox3.Text+"') (Qualification) values('"+textBox4.Text+"') (Marks) values('"+textBox5.Text+"')");

        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
