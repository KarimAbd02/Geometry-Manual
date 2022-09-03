using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Справочник
{
    public partial class Form3 : Form
    {
      
        public Form3()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\абдурахманов БД.mdb;");
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select Логин From Администратор where Логин ='" + textBox1.Text + "' and Пароль ='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            // Проверяем, что количество строк из БД больше нуля
            if (dt.Rows.Count > 0)
            {
                // Нужный Вам ID
                string ID = dt.Rows[0][0].ToString();
                this.Hide();
                Form2 ss = new Form2();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Неправильно введённые имя или пароль");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Логин и Пароль в базе данных \nРаздел Таблица 'Администратор'! ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 N = new Form1();
            N.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
