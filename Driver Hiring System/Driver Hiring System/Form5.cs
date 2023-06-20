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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f2 = new Form7();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-E2QCO8FG\\SQLEXPRESS;Initial Catalog=\"Vehicle Details\";Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into testfirst(V Number) values ('" + textBox1.Text + "') (Dn Id) values ('"+textBox2.Text+"') (Yard in hour) values('"+textBox3.Text+"') (Yard leave hour) values('"+textBox4.Text+"')");

        }
    }
}
