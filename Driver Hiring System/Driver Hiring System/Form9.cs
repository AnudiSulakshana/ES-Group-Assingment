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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 f2 = new Form10();
            f2.Show();
            this.Hide();

            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-E2QCO8FG\\SQLEXPRESS;Initial Catalog=\"Overtime Handle\";Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into testfirst(Driver Id) values('" + textBox1.Text + "') (Driver name) values('"+textBox2.Text+"') (Rhours) values('"+textBox3.Text+"') (Rhourspay) values('"+textBox4.Text+"') (OT Hours Pay) values('"+textBox5.Text+"') (OT Hours) values('"+textBox6.Text+"') (Date) values('"+textBox6.Text+"')");

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
