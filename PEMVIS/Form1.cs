using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
namespace PEMVIS
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // textBox1 adalah TextBox untuk username
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // textBox2 adalah TextBox untuk password
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1; user=root; database=laundry; password=";
            string username = textBox1.Text;
            string password = textBox2.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM admin WHERE username=@username AND password=@password";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        // Mendapatkan nama pengguna dari hasil query
                        string namaPengguna = dataTable.Rows[0]["nama"]?.ToString() ?? "Nama tidak ditemukan";

                        // Membuat instance dari MenuUtama dan mengirimkan nama pengguna
                        MenuUtama menuUtama = new MenuUtama(namaPengguna);
                        // Menampilkan MenuUtama
                        menuUtama.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username atau password salah!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan pada database: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Menghentikan aplikasi
            Application.Exit();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
