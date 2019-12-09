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
using Microsoft.Office.Interop.Excel;

namespace mysoft
{
    public partial class report : UserControl
    {
        public report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application myExcel = new Microsoft.Office.Interop.Excel.Application();//создаем виртуальный объект Excel
                                                                                                                  //создать книгу в объекте Excel
            myExcel.Application.Workbooks.Add(Type.Missing);
            //Настраиваем ячейки
            myExcel.Columns.ColumnWidth = 15;
            //Пишем заголовки ячеек
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                myExcel.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;// заголовки программно
            }

            /*myExcel.Cells[1, 2] = "Заголовок 2"; //заголовки прописаны
            myExcel.Cells[1, 3] = "Заголовок 3";
            myExcel.Cells[1, 4] = "Заголовок 4";*/

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    myExcel.Cells[j + 2, i + 1] = dataGridView1[i, j].Value.ToString();
                }
            }

            myExcel.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
