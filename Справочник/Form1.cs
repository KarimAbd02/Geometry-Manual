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
using System.Diagnostics;

namespace Справочник
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void войтиКакАдминистраторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            Hide();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 newForm = new AboutBox1();
            newForm.Show();
            Hide();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Project.chm");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "абдурахманов_БДDataSet.Задание". При необходимости она может быть перемещена или удалена.
            this.заданиеTableAdapter.Fill(this.абдурахманов_БДDataSet.Задание);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "абдурахманов_БДDataSet.Темы". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "абдурахманов_БДDataSet.Глава". При необходимости она может быть перемещена или удалена.
            this.главаTableAdapter.Fill(this.абдурахманов_БДDataSet.Глава);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "абдурахманов_БДDataSet.Глава". При необходимости она может быть перемещена или удалена.
            this.главаTableAdapter.Fill(this.абдурахманов_БДDataSet.Глава);
            for (int i = 0; i < абдурахманов_БДDataSet.Глава.Rows.Count; i++)
            {
                comboBox1.Items.Add(абдурахманов_БДDataSet.Глава.Rows[i].ItemArray.ElementAt(1).ToString());
            }

            for (int i = 0; i < абдурахманов_БДDataSet.Задание.Rows.Count; i++)
            {
                comboBox3.Items.Add(абдурахманов_БДDataSet.Задание.Rows[i].ItemArray.ElementAt(0).ToString());
            }

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql2 = "SELECT [Название темы] FROM Темы INNER JOIN Глава ON Темы.[ID Главы]=Глава.[ID Главы]  Where Глава.[Название главы] = " + "'" + comboBox1.Text + "'";
            string connectionString2;
            connectionString2 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\абдурахманов БД.mdb;";
            OleDbConnection connection2 = new OleDbConnection(connectionString2);
            connection2.Open();
            OleDbCommand command2 = new OleDbCommand(sql2, connection2);
            // организуем выборку данных из базы и помещаем ее в dataRead
            OleDbDataReader dataReader2 = command2.ExecuteReader();
            comboBox2.Items.Clear();
            // пока не достигли "конца" dataRead
            while (dataReader2.Read())
            {
                // добавляем очередное значение в listBox
                comboBox2.Items.Add(dataReader2.GetString(0));
            }
            dataReader2.Dispose();// освобождаем ресурсы, занятые OleDbDataReader
            dataReader2.Close();
            connection2.Close();
        }
        public string tema;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tema = "";
                if (comboBox2.Text != "Название темы" || comboBox2.Text != "")
                {
                    string sql1 = "SELECT * FROM Темы  WHERE  [Название темы] =" + "'" + comboBox2.Text + "'";
                    string connectionString1;
                    connectionString1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\абдурахманов БД.mdb;";

                    OleDbConnection connection1 = new OleDbConnection(connectionString1);
                    connection1.Open();
                    OleDbCommand command1 = new OleDbCommand(sql1, connection1);
                    OleDbDataReader dataReader1 = command1.ExecuteReader();

                    tema = "";
                    while (dataReader1.Read())
                    {
                        tema += dataReader1["Тема"];
                    }
                    dataReader1.Close();
                    connection1.Close();
                }
                richTextBox1.LoadFile(@"" + tema);
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Проверте правильность введённых данных");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            tema = "";
            {
                string sql1 = "SELECT * FROM Задание  WHERE  [ID Задания] =" + comboBox3.Text;
                string connectionString2;
                connectionString2 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\абдурахманов БД.mdb;";

                OleDbConnection connection2 = new OleDbConnection(connectionString2);
                connection2.Open();
                OleDbCommand command1 = new OleDbCommand(sql1, connection2);
                OleDbDataReader dataReader2 = command1.ExecuteReader();

                tema = "";
                while (dataReader2.Read())
                {
                    tema += dataReader2["Название задания"];
                }
                dataReader2.Close();
                connection2.Close();
            }
            richTextBox1.Text = tema;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
        }
    }
}
            

    
    

