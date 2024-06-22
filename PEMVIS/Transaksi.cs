using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PEMVIS
{
    internal class Transaksi
    {
        string no_transaksi;
        string no_hp;
        string nama_pelanggan;
        string kategori;
        string jumlah;
        string harga;
        string total;
        string jam;
        string tanggal_terima;
        string tanggal_ambil;
        string kasir;
        protected const String conString = "server=localhost;database=laundry;uid=root;pwd=;";

        public Transaksi(string no_transaksi, string no_hp, string nama_pelanggan, string kategori, string jumlah, string harga, string total, string jam, string tanggal_terima, string tanggal_ambil, string kasir)
        {
            this.no_transaksi = no_transaksi;
            this.no_hp = no_hp;
            this.nama_pelanggan = nama_pelanggan;
            this.kategori = kategori;
            this.jumlah = jumlah;
            this.harga = harga;
            this.total = total;
            this.jam = jam;
            this.tanggal_terima = tanggal_terima;
            this.tanggal_ambil = tanggal_ambil;
            this.kasir = kasir;
        }

        public int insert()
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO transaksi (no_transaksi, no_hp, nama_pelanggan, kategori, jumlah, harga, total, jam, tanggal_terima, tanggal_ambil, kasir) VALUES(@no_transaksi, @no_hp, @nama_pelanggan, @kategori, @jumlah, @harga, @total, @jam, @tanggal_terima, @tanggal_ambil, @kasir)");
            cmd.Parameters.AddWithValue("@no_transaksi", no_transaksi);
            cmd.Parameters.AddWithValue("@no_hp", no_hp);
            cmd.Parameters.AddWithValue("@nama_pelanggan", nama_pelanggan);
            cmd.Parameters.AddWithValue("@kategori", kategori);
            cmd.Parameters.AddWithValue("@jumlah", jumlah);
            cmd.Parameters.AddWithValue("@harga", harga);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@jam", jam);
            cmd.Parameters.AddWithValue("@tanggal_terima", tanggal_terima);
            cmd.Parameters.AddWithValue("@tanggal_ambil", tanggal_ambil);
            cmd.Parameters.AddWithValue("@kasir", kasir);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;

            try
            {
                connect.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return result;
        }

        public static DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            //cara 1
            MySqlConnection connect = new MySqlConnection(conString);
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM transaksi", connect))
            {
                try
                {
                    connect.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);

                }
                catch (Exception e)
                {
                    String error = e.Message;
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
            return dt;
        }

        public int delete(string no_transaksi)
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("DELETE FROM transaksi WHERE no_transaksi=@no_transaksi", connect);
            cmd.Parameters.AddWithValue("@no_transaksi", no_transaksi);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;

            try
            {
                connect.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return result;
        }
        public int update()
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("UPDATE transaksi SET no_hp=@no_hp, nama_pelanggan=@nama_pelanggan, kategori=@kategori, jumlah=@jumlah, harga=@harga, total=@total, jam=@jam, tanggal_terima=@tanggal_terima, tanggal_ambil=@tanggal_ambil, kasir=@kasir  WHERE no_transaksi=@no_transaksi", connect);
            cmd.Parameters.AddWithValue("@no_transaksi", no_transaksi);
            cmd.Parameters.AddWithValue("@no_hp", no_hp);
            cmd.Parameters.AddWithValue("@nama_pelanggan", nama_pelanggan);
            cmd.Parameters.AddWithValue("@kategori", kategori);
            cmd.Parameters.AddWithValue("@jumlah", jumlah);
            cmd.Parameters.AddWithValue("@harga", harga);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@jam", jam);
            cmd.Parameters.AddWithValue("@tanggal_terima", tanggal_terima);
            cmd.Parameters.AddWithValue("@tanggal_ambil", tanggal_ambil);
            cmd.Parameters.AddWithValue("@kasir", kasir);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;

            try
            {
                connect.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return result;
        }

    }
}
