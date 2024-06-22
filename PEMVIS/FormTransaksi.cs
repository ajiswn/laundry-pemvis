using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PEMVIS
{
    public partial class FormTransaksi : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private string namaPengguna;

        private enum Status { Insert, Update }
        private Status currentStatus;

        private void resetTombol()
        {
            button4.Enabled = false;
            button5.Enabled = false;
            button2.Enabled = true;

            textBox8.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            comboBox1.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox11.Text = string.Empty;
            textBox12.Text = string.Empty;
            textBox13.Text = string.Empty;
        }

        // Dictionary untuk menyimpan data satuan dan harga berdasarkan kategori
        private Dictionary<string, (string Satuan, string Harga)> data = new Dictionary<string, (string Satuan, string Harga)>
        {
            { "Cuci Ex", ("Kg", "20000") },
            { "Setrika Ex", ("Kg", "15000") },
            { "Cuci + Setrika Ex", ("Kg", "30000") },
            { "Cuci Reg", ("Kg", "10000") },
            { "Setrika Reg", ("Kg", "8000") },
            { "Cuci + Setrika Reg", ("Kg", "18000") }
        };

        private void loadTran()
        {
            DataTable dt = new DataTable();
            dt = Transaksi.SelectAll();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
        }


        public FormTransaksi(string namaPengguna)
        {
            InitializeComponent();
            LoadComboBox();
            resetTombol();
            loadTran();
            InitializeTimer();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            this.namaPengguna = namaPengguna;
            // Mengatur teks pada textBox1 menjadi nama pengguna yang sedang login
            textBox1.Text = namaPengguna ?? "Nama tidak ditemukan";
            // Mengatur textBox1 menjadi read-only
            textBox1.ReadOnly = true;
            // Tambahkan event handler untuk textBox8, textBox9, textBox6, dan textBox13
            textBox8.TextChanged += new EventHandler(textBox8_TextChanged);
            textBox9.TextChanged += new EventHandler(textBox9_TextChanged);
            textBox6.TextChanged += new EventHandler(textBox6_TextChanged);
            textBox13.TextChanged += new EventHandler(textBox13_TextChanged_1);
        }


        // Mengisi ComboBox dengan data kategori
        private void LoadComboBox()
        {
            comboBox1.Items.Add("Cuci Ex");
            comboBox1.Items.Add("Setrika Ex");
            comboBox1.Items.Add("Cuci + Setrika Ex");
            comboBox1.Items.Add("Cuci Reg");
            comboBox1.Items.Add("Setrika Reg");
            comboBox1.Items.Add("Cuci + Setrika Reg");
        }


        // Event handler untuk ComboBox
        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string? selectedKategori = comboBox1.SelectedItem?.ToString();
            if (selectedKategori != null && data.ContainsKey(selectedKategori))
            {
                var (satuan, harga) = data[selectedKategori];
                textBox7.Text = satuan; // Mengisi textBox7 dengan satuan
                textBox8.Text = harga;  // Mengisi textBox8 dengan harga

                // Mengatur textBox menjadi ReadOnly setelah terisi
                textBox7.ReadOnly = true;
                textBox8.ReadOnly = true;
            }
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Setel interval ke 1 detik
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            UpdateDateTimeTextBoxes();
        }

        private void UpdateDateTimeTextBoxes()
        {
            textBox11.Text = DateTime.Now.ToString("HH:mm:ss"); // Format jam saat ini
            textBox12.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Format tanggal saat ini
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

            }
            button4.Enabled = true;
            button5.Enabled = true; 
            button2.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuUtama menuUtama = new MenuUtama(namaPengguna);
            menuUtama.Show();
            this.Hide();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormTransaksi_Load(object? sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object? sender, EventArgs e)
        {
            UpdateTextBox6();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox9_TextChanged(object? sender, EventArgs e)
        {
            UpdateTextBox6();
        }


        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateTextBox6()
        {
            if (double.TryParse(textBox8.Text, out double value1) && double.TryParse(textBox9.Text, out double value2))
            {
                double result = value1 * value2;
                textBox6.Text = result.ToString();
            }
            else
            {
                textBox6.Text = string.Empty;
            }
        }
        private void textBox6_TextChanged(object? sender, EventArgs e)
        {
            UpdateTextBox14();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged_1(object? sender, EventArgs e)
        {
            UpdateTextBox14();
        }

        private void UpdateTextBox14()
        {
            if (double.TryParse(textBox13.Text, out double value1) && double.TryParse(textBox6.Text, out double value2))
            {
                double result = value1 - value2;
                textBox14.Text = result.ToString();
            }
            else
            {
                textBox14.Text = string.Empty;
            }
        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object? sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object? sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentStatus == Status.Insert)
            {
                Transaksi tranInsert = new Transaksi(textBox2.Text, textBox3.Text, textBox4.Text, comboBox1.Text, textBox9.Text, textBox8.Text, textBox6.Text, textBox11.Text, textBox12.Text, dateTimePicker1.Text, textBox1.Text);
                if (tranInsert.insert() == 1)
                {
                    MessageBox.Show("Transaksi berhasi dibuat");
                    
                }
                else
                {
                    MessageBox.Show("Transaksi gagal dibuat");
                }
            }
            else if (currentStatus == Status.Update)
            {
                Transaksi tranUpdate = new Transaksi(textBox2.Text,textBox3.Text, textBox4.Text, comboBox1.Text, textBox9.Text, textBox8.Text, textBox6.Text, textBox11.Text, textBox12.Text, dateTimePicker1.Text, textBox1.Text);
                if (tranUpdate.update() == 1)
                {
                    MessageBox.Show("Update data transaksi berhasil");
                    currentStatus = Status.Insert;
                }
                else
                {
                    MessageBox.Show("Update data transaksi gagal ");
                }
            }
            loadTran();
            resetTombol();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin transaksi selesai " + textBox2.Text + "?", "Konfirmasi Selesai", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Transaksi tran = new Transaksi(textBox2.Text, "", "", "", "", "", "", "", "", "","");
                if (tran.delete(textBox2.Text) == 1)
                {
                    MessageBox.Show("Transaksi " + textBox2.Text + "Selesai");
                }
                else
                {
                    MessageBox.Show("Transaksi " + textBox2.Text + " gagal");
                }
                loadTran();
                resetTombol();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentStatus = Status.Update;
            button2.Enabled = true;
            button4.Enabled = true;
            button2.Enabled = true;
        }
    }
}
