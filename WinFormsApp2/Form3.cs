using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            // コンボボックスにアイテムを追加する
            comboBox1.Items.Add("Enable");
            comboBox1.Items.Add("Disable");

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // 前のフォームをインスタンス化して表示させます
            Form2 form2 = new Form2();
            form2.Show();


            // 現在のフォームを閉じます
            Form3 form3 = new Form3();
            form3.Hide();


        }




        private void button1_Click(object sender, EventArgs e)
        {


            string code = textBox1.Text;
            string name = textBox2.Text;
            string color = textBox3.Text;   
            string size = textBox4.Text;
            string state = comboBox1.Text;



            string connectionString = "Host=127.0.0.1;Username=User1;Password=password;Database=database1"; // PostgreSQL接続文字列を指定します

            // PostgreSQLに接続します
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open(); // 接続を開きます

                // データを挿入するSQLクエリを準備します
                string sql = "INSERT INTO items (code, name, color, size, state) VALUES (@code, @name, @color, @size, @state)";

                // SQLクエリを実行するNpgsqlCommandオブジェクトを作成します
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    // パラメータを設定します
                    command.Parameters.AddWithValue("@code", code);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@color", color);
                    command.Parameters.AddWithValue("@size", Convert.ToDouble(size));
                    command.Parameters.AddWithValue("@state", state);

                    // SQLクエリを実行します
                    command.ExecuteNonQuery();

                    MessageBox.Show("Completed Add Record");
                    this.Close();
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
