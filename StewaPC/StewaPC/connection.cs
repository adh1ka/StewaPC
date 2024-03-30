using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data;

namespace StewaPC
{
    internal class connection
    {
        public static SqlConnection conn = new SqlConnection(@"Data source=DESKTOP-P4CRNIP\SQLEXPRESS;initial catalog=DB_TEST;integrated security=true");
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds = new DataSet();
        public static DataTable dt = new DataTable();

        public static void exit()
        {
            DialogResult result = MessageBox.Show("Apakah Anda Ingin Exit?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //public static string getResult(string pilihan)
        //{
        //    string result = "";
        //    switch(pilihan)
        //    {
        //        case "ADMIN":
        //            result = ;
        //            break;
        //        case "SELLER":
        //            result = "SELLER";
        //            break;
        //        default:
        //            result = "Pilih Role Terlebih Dahulu";
        //            break;
        //    }
        //    return result;
        //}

        public static bool validate(string namaTabel, string[] namaKolom, string[] value)
        {
            string query = "SELECT * FROM " + namaTabel + " WHERE ";
            for (int i = 0; i < namaKolom.Length; i++)
            {
                query += namaKolom[i] + " = ";
                if (namaKolom[i] == "pwd")
                {
                    query += "SHA2('" + value[i] + "', 256)";
                }
                else
                {
                    query += "'" + value[i] + "'";
                    if (i < namaKolom.Length - 1)
                    {
                        query += " AND ";
                    }
                }
            }
            conn.Open();
            cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                dr.Close();
                conn.Close();
                return true;
            }
            else
            {
                dr.Close();
                conn.Close();
                return false;
            }
        }

        public static int getId(string namaTabel, string[] namaKolom, string[] value)
        {
            string query = "SELECT ID FROM " + namaTabel + " WHERE ";
            for(int i = 0;i < namaKolom.Length;i++)
            {
                query += namaKolom[i] + "= '" + value[i] + "'";
                if (i < namaKolom.Length - 1)
                {
                    query += " AND ";
                }
            }
            conn.Open();
            cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            int id;
            if (dr.HasRows)
            {
                id = Convert.ToInt32(dr["id"]);
            }
            else
            {
                id = 0;
            }
            dr.Close();
            conn.Close();
            return id;
        }
        public static void tampil(string namaTabel, string[] namaKolom, DataGridView dgv)
        {
            string query = "SELECT ";
            for (int i = 0; i < namaKolom.Length; i++)
            {
                query += namaKolom[i];
                if (i < namaKolom.Length - 1)
                {
                    query += ",";
                }
            }
            query += " FROM " + namaTabel + "";
            conn.Open();
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv.DataSource = dt;
            conn.Close();
        }



        public static void insert(string namaTabel, string[] namaKolom, string[] value)
        {
            string query = "INSERT INTO " + namaTabel + " (";
            for(int i = 0; i < namaKolom.Length; i++) 
            {
                query += namaKolom[i];
                if(i < namaKolom.Length -1)
                {
                    query += ", ";
                }
            }
            query += ") VALUES (";
            for(int i = 0; i < namaKolom.Length; i++)
            {
                query += "'" + value[i] + "'";
                if(i < value.Length - 1)
                {
                    query += ", ";
                }
            }
            query += ")";

            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }   
        
        public static void update(string namaTabel, string[] namaKolom, string[] value, int id)
        {
            string query = "UPDATE " + namaTabel + " SET(";
            for(int i = 0; i < namaKolom.Length; i++) 
            {
                query += namaKolom[i] + " = " + value[i] +"";
                if(i < namaKolom.Length - 1)
                {
                    query += ", ";
                }
            }
            query += ") WHERE ID = " + id + "";
            conn.Open();
            cmd = new SqlCommand (query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void delete(string namaTabel, int  id)
        {
            string query = "DELETE FROM " + namaTabel + " WHERE ID = " + id + "";
            conn.Open();
            cmd = new SqlCommand (query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
       
    }
}
