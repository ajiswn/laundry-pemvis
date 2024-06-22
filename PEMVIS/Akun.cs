using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace PEMVIS
{
    internal class Admin
    {
        string ID;
        string nama;
        string username;
        string password;
        protected const String conString = "server=localhost;database=laundry;uid=root;pwd=;";

        public Admin(string ID, string nama, string username, string password)
        {
            this.ID = ID;
            this.nama = nama;
            this.username = username;
            this.password = password;
        }

        public int insert()
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO admin (ID,nama,username,password) VALUES(@ID,@nama,@username,@password)");
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
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
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM admin", connect))
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
        public int delete(string ID)
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("DELETE FROM admin WHERE ID=@ID", connect);
            cmd.Parameters.AddWithValue("@ID", ID);
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
            MySqlCommand cmd = new MySqlCommand("UPDATE admin SET nama=@nama, username=@username, password=@password  WHERE ID=@ID", connect);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
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
