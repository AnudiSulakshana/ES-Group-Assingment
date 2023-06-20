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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 f2 = new Form9();
            f2.Show();

            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-E2QCO8FG\\SQLEXPRESS;Initial Catalog=\"Overtime Request Form\";Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into testfirst(Date) values ('"+textBox1.Text+"') (Name) values ('"+textBox2.Text+"') (Id) values ('"+textBox3.Text+"') (Email) values ('"+textBox4.Text+"') (Manager's name) values ('"+textBox5.Text+"') (date of OT) values ('"+textBox6.Text+"') (Requested OT hours) values ('"+textBox7.Text+"') (description) values ('"+textBox8.Text+"') ");
            cmd.Connection = conn;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
