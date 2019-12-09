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

namespace mysoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string log = textBox1.Text.Trim();
            string pass = textBox2.Text.Trim();
            if (log == "" || pass == "")
            {
                MessageBox.Show("Вы не ввели данные для входа!");
            }
            else
            {
                SqlConnection connect = new SqlConnection(Program.st_connect);
                connect.Open();
                string s = "select * from porol where admin='" + log + "' and pass='" + pass + "'";
                SqlCommand command = new SqlCommand(s, connect);
                SqlDataReader reader = command.ExecuteReader();
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
        }
    }
}
