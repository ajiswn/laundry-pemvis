using Microsoft.VisualBasic.Logging;
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
    public partial class MenuUtama : Form
    {
        private string namaPengguna;
        public MenuUtama(string namaPengguna)
        {
            InitializeComponent();
            this.namaPengguna = namaPengguna;
            // Contoh menampilkan nama pengguna di label


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void MenuUtama_Load(object sender, EventArgs e)
        {

        }

        private void aKUNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Membuat instance dari form LOGIN
            LOGIN loginForm = new LOGIN();

            // Menampilkan form LOGIN
            loginForm.Show();

            // Menutup form MenuUtama
            this.Close();

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tRANSAKSIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Membuat instance dari FormTransaksi dan mengirimkan nama pengguna
            FormTransaksi formTransaksi = new FormTransaksi(namaPengguna);
            formTransaksi.Show();

        }

        private void mASTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPegawai formPegawai = new FormPegawai(namaPengguna);
            formPegawai.Show();


        }

    }
}
