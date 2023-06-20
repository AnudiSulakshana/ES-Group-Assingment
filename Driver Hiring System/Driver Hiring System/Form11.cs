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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 f2 = new Form12();
            f2.Show();
            this.Hide();

            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-E2QCO8FG\\SQLEXPRESS;Initial Catalog=\"Leave Handling\";Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into testfirst(id) values('\"+textBox1.Text+\"') (name) values('"+textBox2.Text+"') (data) values('"+textBox3.Text+"') (Ltype) values('"+textBox4.Text+"') (Reason) values('"+textBox5.Text+"') (Adriver) values('"+textBox6.Text+"') (Adriverid) values('"+textBox7.Text+"')");

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
