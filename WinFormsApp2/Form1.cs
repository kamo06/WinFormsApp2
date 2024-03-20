using Npgsql;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            string connectionString = "Host=127.0.0.1;Username=User1;Password=password;Database=database1";// PostgreSQL接続文字列を指定します

            string idToSearch = textBox1.Text; // 検索するID

            string passToSearch = textBox2.Text; // 検索するname

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open(); // 接続を開きます

                string sql = "SELECT COUNT(*) FROM users WHERE id = @id AND password = @password";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", idToSearch);
                    command.Parameters.AddWithValue("@password", passToSearch);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("IDとPASSWORDの組み合わせが見つかりました。");

                        Form2 form2 = new Form2();

                        form2.Show();

                        // this.Hide();



                    }
                    else
                    {
                        MessageBox.Show("IDとPASSWORDの組み合わせは見つかりませんでした。");
                    }
                }
            }
        



        





        }
    }
}
