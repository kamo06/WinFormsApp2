using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            // ListBoxで選択された項目のテキストを取得します
            string selectedId = listBox1.SelectedItem.ToString();

            // 選択されたIDを使用してデータベースから情報を取得します
            string connectionString = "Host=127.0.0.1;Username=User1;Password=password;Database=database1";// PostgreSQL接続文字列を指定します

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open(); // 接続を開きます

                // 選択されたIDを使用してデータベースから情報を取得するSQLクエリを準備します
                string sql = "SELECT * FROM users WHERE id = @id";

                // SQLクエリを実行するNpgsqlCommandオブジェクトを作成します
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    // パラメータを設定します
                    command.Parameters.AddWithValue("@id", selectedId);

                    // SQLクエリを実行し、結果を取得します
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // データが取得された場合は、それをラベルに反映します
                        if (reader.Read())
                        {
                            // データベースから取得した値をラベルに反映します
                            string id = reader["id"].ToString();
                            string name = reader["name"].ToString();
                            string password = reader["password"].ToString();
                            string acesslevel = reader["acesslevel"].ToString();

                            // ラベルに値を設定します

                            textBox1.Text = id;
                            textBox2.Text = name;
                            textBox3.Text = password;
                            comboBox1.Text = acesslevel;
                        }
                    }
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string connectionString = "Host=127.0.0.1;Username=User1;Password=password;Database=database1"; // PostgreSQL接続文字列を指定します

            // PostgreSQLに接続します
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open(); // 接続を開きます

                // テーブルからIDを取得するSQLクエリを準備します
                string sql = "SELECT id FROM users";

                // SQLクエリを実行するNpgsqlCommandオブジェクトを作成します
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    // SQLクエリを実行し、結果をNpgsqlDataReaderに読み込みます
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // リストボックスにIDを追加します
                        while (reader.Read())
                        {
                            // データリーダーからIDを取得し、リストボックスに追加します
                            string id = reader.GetString(0);  // 0は取得する列のインデックス（ID列のインデックス）
                            listBox1.Items.Add(id.ToString()); // リストボックスにIDを追加します
                        }
                    }
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
