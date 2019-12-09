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
    public partial class d_w : UserControl
    {
        public d_w()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" ||
               textBox2.Text.Trim() == "" ||
               textBox3.Text.Trim() == "" ||
               dateTimePicker1.Text.Trim() == "" ||
               comboBox1.Text.Trim() == "" ||
               comboBox2.Text.Trim() == "" ||
               textBox4.Text.Trim() == "" ||
               textBox5.Text.Trim() == "" ||
               dateTimePicker2.Text.Trim() == "" ||
               textBox6.Text.Trim() == "" ||
               textBox7.Text.Trim() == "" ||
               textBox8.Text.Trim() == "" ||
               textBox9.Text.Trim() == "" ||
               comboBox3.Text.Trim() == "" ||
               textBox10.Text.Trim() == "" ||
               textBox11.Text.Trim() == "" ||
               textBox12.Text.Trim() == "" ||
               maskedTextBox1.Text.Trim() == "" ||
               maskedTextBox2.Text.Trim() == "" ||
               textBox13.Text.Trim() == "" ||
               textBox14.Text.Trim() == "" ||
               textBox15.Text.Trim() == "" ||
               dateTimePicker3.Text.Trim() == "" ||
               comboBox4.Text.Trim() == "" ||
               pictureBox1.Name.Trim() == "")
            {
                MessageBox.Show("Не все поля заполнены!!!");
            }
            else
            {
                SqlConnection conn = new SqlConnection(Program.st_connect);
                conn.Open();
                string s = "insert into workers (Фамилия, Имя, Отчество, Дата_рождения, Пол, Гражданство, Должность," +
                    " Стаж_работы, Фото, Статус, Дата_приема, Паспорт, Кем_выдан, Дата_выдачи, Подразделение," +
                    " Место_рождения, Адрес_прописки, Адрес_проживания, ИНН, СНИЛС, Мед_полис, Образование," +
                    " Дом_телефон, Раб_телефон, Оклад)" +
                    " values('" + textBox1.Text.Trim() + "'," +
                           " '" + textBox2.Text.Trim() + "'," +
                           " '" + textBox3.Text.Trim() + "'," +
                           " '" + dateTimePicker1.Text.Trim() + "'," +
                           " '" + comboBox1.Text.Trim() + "'," +
                           " '" + comboBox2.Text.Trim() + "'," +
                           " '" + textBox13.Text.Trim() + "'," +
                           " '" + textBox14.Text.Trim() + "'," +
                           " '" + pictureBox1.Name.Trim() + "'," +
                           " '" + comboBox4.Text.Trim() + "'," +
                           " '" + dateTimePicker3.Text.Trim() + "'," +
                           " '" + textBox4.Text.Trim() + "'," +
                           " '" + textBox5.Text.Trim() + "'," +
                           " '" + dateTimePicker2.Text.Trim() + "'," +
                           " '" + textBox6.Text.Trim() + "'," +
                           " '" + textBox7.Text.Trim() + "'," +
                           " '" + textBox8.Text.Trim() + "'," +
                           " '" + textBox9.Text.Trim() + "'," +
                           " '" + textBox10.Text.Trim() + "'," +
                           " '" + textBox11.Text.Trim() + "'," +
                           " '" + textBox12.Text.Trim() + "'," +
                           " '" + comboBox3.Text.Trim() + "'," +
                           " '" + maskedTextBox1.Text.Trim() + "'," +
                           " '" + maskedTextBox2.Text.Trim() + "'," +
                           " '" + textBox15.Text.Trim() + "')";
                SqlCommand comm = new SqlCommand(s, conn);
                comm.ExecuteScalar();
                conn.Close();
            }
        }
    }
}
