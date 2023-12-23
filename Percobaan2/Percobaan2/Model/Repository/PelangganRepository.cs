using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SQLite;
using Percobaan2.Model.Entity;
using Percobaan2.Model.Context;

namespace Percobaan2.Model.Repository
{
    public class PelangganRepository
    {
        // deklarsi objek connection
        private SQLiteConnection _conn;

        // constructor
        public PelangganRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }


        public List<Pelanggan> ReadAll()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Pelanggan> list = new List<Pelanggan>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select ID_Pelanggan, Nama_Pelanggan, Alamat, Email, NomerHP 
                               from pelanggan 
                               order by Nama_Pelanggan";

                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Pelanggan akunPlnggn = new Pelanggan();
                            akunPlnggn.ID_Pelanggan = (int)dtr["ID_Pelanggan"];
                            akunPlnggn.NamaPelanggan = dtr["Nama_Pelanggan"].ToString();
                            akunPlnggn.Alamat = dtr["Alamat"].ToString();
                            akunPlnggn.Email = dtr["Email"].ToString();
                            akunPlnggn.NomerHp = dtr["NomerHP"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(akunPlnggn);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

    }
}