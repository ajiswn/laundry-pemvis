using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PEMVIS
{
    public partial class FormPegawai : Form
    {
        private string namaPengguna;
        private enum Status { Insert, Update }
        private Status currentStatus;

        private void resetTombol()
        {
            textBox4.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            textBox4.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
        private void loadAkun()
        {
            DataTable dt = new DataTable();
            dt = Admin.SelectAll();
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = dt;
            dataGridView2.Show();
        }
        private void FormPegawai_Load(object sender, EventArgs e)
        {
            loadAkun();
        }

        public FormPegawai(string namaPengguna)
        {
            this.namaPengguna = namaPengguna;
            InitializeComponent();
            resetTombol();
            loadAkun();
        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            resetTombol();
            if (dataGridView2.Rows[e.RowIndex].Cells[0].Value != null)
            {
                textBox4.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            button3.Enabled = true;
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (currentStatus == Status.Insert)
            {
                Admin akunInsert = new Admin(textBox4.Text, textBox1.Text, textBox2.Text, textBox3.Text);
                if (akunInsert.insert() == 1)
                {
                    MessageBox.Show("Akun berhasil dibuat");
                }
                else
                {
                    MessageBox.Show("Insert gagal dibuat");
                }
            }
            else if (currentStatus == Status.Update)
            {
                Admin akunUpdate = new Admin(textBox4.Text, textBox1.Text, textBox2.Text, textBox3.Text);
                if (akunUpdate.update() == 1)
                {
                    MessageBox.Show("Update data akun berhasil");
                }
                else
                {
                    MessageBox.Show("Update data akun gagal ");
                }
            }
            loadAkun();
            resetTombol();
        }




        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {
            resetTombol();
            textBox4.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;


            button1.Enabled = true;
            currentStatus = Status.Insert;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Membuat instance dari MenuUtama dan mengirimkan nama pengguna
            MenuUtama menuUtama = new MenuUtama(namaPengguna);
            menuUtama.Show();
            this.Hide();
        }



       


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            button1.Enabled = true;
            currentStatus = Status.Update;
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin menghapus akun " + textBox1.Text + "?", "Konfirmasi Hapus", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Admin akun = new Admin(textBox4.Text, "", "", "");
                if (akun.delete(textBox4.Text) == 1)
                {
                    MessageBox.Show("Hapus akun " + textBox1.Text + " berhasil");
                }
                else
                {
                    MessageBox.Show("Hapus akun " + textBox1.Text + " gagal");
                }
                loadAkun();
                resetTombol();
            }
        }
    }
}