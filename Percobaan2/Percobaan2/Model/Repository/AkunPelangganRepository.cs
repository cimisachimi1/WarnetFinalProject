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
    public class AkunPelangganRepository
    {
        // deklarsi objek connection
        private SQLiteConnection _conn;

        // constructor
        public AkunPelangganRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }


        public List<AkunPelanggan> ReadAll()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<AkunPelanggan> list = new List<AkunPelanggan>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select ID_Pelanggan, Username, Password 
                               from mahasiswa 
                               order by Username";

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
                            AkunPelanggan akunPlnggn = new AkunPelanggan();
                            akunPlnggn.Username = dtr["Username"].ToString();
                            akunPlnggn.Password = dtr["Password"].ToString();
                            akunPlnggn.ID_Pelanggan = dtr["ID_Pelanggan"].ToString();

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
