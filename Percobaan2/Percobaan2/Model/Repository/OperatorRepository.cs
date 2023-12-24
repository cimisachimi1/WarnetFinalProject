using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Percobaan2.Model.Entity;
using Percobaan2.Model.Context;

namespace Percobaan2.Model.Repository
{
    public class OperatorRepository
    {
        private MySqlConnection _conn;

        public OperatorRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public List<Operator> ReadAll()
        {
            List<Operator> list = new List<Operator>();

            try
            {
                string sql = @"SELECT ID_Operator, Nama, Alamat, Umur, Mulai_Shift, Akhir_Shift 
                               FROM operator 
                               ORDER BY Nama";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Operator akunOp = new Operator();
                            akunOp.ID_Operator = Convert.ToInt32(dtr["ID_Operator"]);
                            akunOp.Nama = dtr["Nama"].ToString();
                            akunOp.Alamat = dtr["Alamat"].ToString();

                            // Handle Umur as an integer
                            int umur;
                            if (int.TryParse(dtr["Umur"].ToString(), out umur))
                            {
                                akunOp.Umur = umur;
                            }
                            else
                            {
                                // Handle the case where Umur is not a valid integer
                                // You might want to log an error or handle it accordingly
                                akunOp.Umur = 0; // or any default value
                            }

                            // Handle Mulai_Shift and Akhir_Shift as DateTime
                            if (DateTime.TryParse(dtr["Mulai_Shift"].ToString(), out DateTime mulaiShift))
                            {
                                akunOp.Mulai_Shift = mulaiShift;
                            }
                            else
                            {
                                akunOp.Mulai_Shift = DateTime.MinValue; // or any default value
                            }

                            if (DateTime.TryParse(dtr["Akhir_Shift"].ToString(), out DateTime akhirShift))
                            {
                                akunOp.Akhir_Shift = akhirShift;
                            }
                            else
                            {
                                akunOp.Akhir_Shift = DateTime.MinValue; // or any default value
                            }

                            list.Add(akunOp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ReadAll error: {0}", ex.Message);
            }

            return list;
        }
    }
}
