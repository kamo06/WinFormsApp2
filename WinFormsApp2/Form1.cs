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



            string connectionString = "Host=127.0.0.1;Username=User1;Password=password;Database=database1";// PostgreSQL�ڑ���������w�肵�܂�

            string idToSearch = textBox1.Text; // ��������ID

            string passToSearch = textBox2.Text; // ��������name

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open(); // �ڑ����J���܂�

                string sql = "SELECT COUNT(*) FROM users WHERE id = @id AND password = @password";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", idToSearch);
                    command.Parameters.AddWithValue("@password", passToSearch);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("ID��PASSWORD�̑g�ݍ��킹��������܂����B");

                        Form2 form2 = new Form2();

                        form2.Show();

                        // this.Hide();



                    }
                    else
                    {
                        MessageBox.Show("ID��PASSWORD�̑g�ݍ��킹�͌�����܂���ł����B");
                    }
                }
            }
        



        





        }
    }
}
