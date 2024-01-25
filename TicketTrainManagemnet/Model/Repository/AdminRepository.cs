using System;

using System.Data.SQLite;
using TicketTrainManagemnet.Model.Context;

namespace TicketTrainManagemnet.Model.Repository

{
    public class AdminRepository
    {
        // deklarsi objek connection
        private SQLiteConnection _conn;

        // constructor
        public AdminRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }

        // Validasi Admnin Login
        public bool IsValidUser(string adminName, string password)
        {
            bool result = false;

            string sql = @"select count(*) as row_count
                           from Admin
                           where namaAdmin = @adminName and Password = @password";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@adminName", adminName);
                cmd.Parameters.AddWithValue("@password", password);

                // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                using (SQLiteDataReader dtr = cmd.ExecuteReader())
                {
                    // panggil method Read untuk mendapatkan baris dari result set
                    if (dtr.Read())
                    {
                        result = Convert.ToInt32(dtr["row_count"]) > 0;
                    }
                }
            }

            return result;
        }
    }
}
