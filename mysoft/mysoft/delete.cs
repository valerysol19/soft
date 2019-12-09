using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace mysoft
{
    public partial class delete : UserControl
    {
        public delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = dataGridView1.CurrentRow.Index;
            Program.id = Convert.ToInt32(dataGridView1[0, k].Value);
            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();

            string s = "delete from workers where id = " + Program.id.ToString();
            SqlCommand comm = new SqlCommand(s, conn);
            {
                MessageBox.Show("Пользователь успешно удален!");
            }
            comm.ExecuteScalar();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();
            string s = "select * from workers where Фамилия like '%" + textBox1.Text.Trim() + "%' ";
            SqlDataAdapter adap = new SqlDataAdapter(s, conn);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
    }
}
