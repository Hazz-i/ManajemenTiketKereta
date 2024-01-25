using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using TicketTrainManagemnet.Model.Context;
using TicketTrainManagemnet.Model.Entity;

namespace TicketTrainManagemnet.Model.Repository
{
    public class TiketRepository
    {
        // deklarsi objek connection
        private SQLiteConnection _conn;

        // constructor
        public TiketRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }

        //Query validasi kursi apakah masi tersedia atau tidak
        public bool validasiNomorKursi(int nomorKursi, int idRute, int idKereta)
        {
            bool validasi = false;

            string sql = @"SELECT tiket.id_tiket, tiket.nomorKursi, rute.stasiunAsal, rute.stasiunTujuan, rute.waktuBerangkat, rute.waktuTiba, kereta.NamaKereta, kereta.kelasKereta 
                   FROM tiket 
                   JOIN rute ON tiket.id_rute = rute.id_rute 
                   JOIN kereta ON tiket.Id_kereta = kereta.Id_kereta 
                   WHERE tiket.nomorKursi = @nomorKursi AND tiket.Id_kereta = @idKereta AND tiket.id_rute = @idRute";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@nomorKursi", nomorKursi);
                cmd.Parameters.AddWithValue("@idKereta", idKereta);
                cmd.Parameters.AddWithValue("@idRute", idRute);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        validasi = true;
                    }
                }
            }
            return validasi;
        }

        //Query menampilkan data tiket berdasarkan nama yang dicari
        public List<Tiket> readByName(string nama) 
        {
            List<Tiket> list = new List<Tiket> ();

            string sql = "SELECT tiket.Id_tiket, tiket.namaPenumpang, tiket.tgl_pesan, tiket.nomorKursi, tiket.totalHarga, rute.stasiunAsal, rute.stasiunTujuan, rute.waktuBerangkat, rute.waktuTiba, kereta.NamaKereta, kereta.kelasKereta FROM tiket JOIN rute ON tiket.id_rute = rute.id_rute JOIN kereta ON tiket.Id_kereta = kereta.Id_kereta WHERE namaPenumpang COLLATE Latin1_General_CS_AS LIKE @namaPenumpang COLLATE Latin1_General_CS_AS";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@namaPenumpang", nama);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Tiket tiket = new Tiket();
                        tiket.Id_tiket = int.Parse(reader["Id_tiket"].ToString());
                        tiket.tanggal = reader["tgl_pesan"].ToString();
                        tiket.namaPenumpang = reader["namaPenumpang"].ToString();
                        tiket.stasiunBerangkat = reader["stasiunAsal"].ToString();
                        tiket.stasiunTujuan = reader["stasiunTujuan"].ToString();
                        tiket.waktuBerangkat = reader["waktuBerangkat"].ToString();
                        tiket.waktuTiba = reader["waktuTiba"].ToString();
                        tiket.namaKereta = reader["namaKereta"].ToString();
                        tiket.kelasKereta = reader["kelasKereta"].ToString();
                        tiket.nomorKursi = int.Parse(reader["nomorKursi"].ToString());
                        tiket.totalHarga = int.Parse(reader["totalHarga"].ToString());

                        list.Add(tiket);
                    }
                }
            }

            return list;
        }

        //Query menambah tiket
        public int InsertTiket(Tiket tiket)
        {
            int result = 0;
            string sql = "insert into Tiket (tgl_pesan, namaPenumpang, NomorKursi, TotalHarga, Id_Kereta, Id_Rute) values (@tgl_pesan, @namaPenumpang,@NomorKursi, @TotalHarga, @Id_Kereta, @Id_Rute)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@namaPenumpang", tiket.namaPenumpang);
                cmd.Parameters.AddWithValue("@tgl_pesan", tiket.tanggal);
                cmd.Parameters.AddWithValue("@NomorKursi", tiket.nomorKursi);
                cmd.Parameters.AddWithValue("@TotalHarga", tiket.totalHarga);
                cmd.Parameters.AddWithValue("@Id_Kereta", tiket.Id_kereta);
                cmd.Parameters.AddWithValue("@Id_Rute", tiket.Id_rute);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }

        //Query membaca tiket
        public List<Tiket> ReadTiket()
        {
            List<Tiket> list = new List<Tiket>();
            try
            {
                string sql = @"SELECT tiket.Id_tiket, tiket.namaPenumpang, tiket.tgl_pesan, tiket.nomorKursi, tiket.totalHarga, rute.stasiunAsal, rute.stasiunTujuan, rute.waktuBerangkat,  rute.waktuTiba, kereta.NamaKereta, kereta.kelasKereta FROM
                               tiket JOIN rute ON tiket.id_rute = rute.id_rute JOIN kereta ON tiket.Id_kereta = kereta.Id_kereta";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Tiket tiket = new Tiket();
                            tiket.Id_tiket = int.Parse(reader["Id_tiket"].ToString());
                            tiket.tanggal = reader["tgl_pesan"].ToString();    
                            tiket.namaPenumpang = reader["namaPenumpang"].ToString();
                            tiket.stasiunBerangkat = reader["stasiunAsal"].ToString();
                            tiket.stasiunTujuan = reader["stasiunTujuan"].ToString();
                            tiket.waktuBerangkat = reader["waktuBerangkat"].ToString();
                            tiket.waktuTiba = reader["waktuTiba"].ToString();
                            tiket.namaKereta = reader["namaKereta"].ToString();
                            tiket.kelasKereta = reader["kelasKereta"].ToString();
                            tiket.nomorKursi = int.Parse(reader["nomorKursi"].ToString());
                            tiket.totalHarga = int.Parse(reader["totalHarga"].ToString());

                            list.Add(tiket);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll Eror : {0}", ex.Message);
            }
            return list;
        }

        //Query membaca tiket dari Id Tiket
        public List<Tiket> ReadTiketById(int id_tiket)
        {
            List<Tiket> list = new List<Tiket>();
            try
            {
                string sql = @"SELECT tiket.Id_tiket, tiket.namaPenumpang, tiket.tgl_pesan, tiket.nomorKursi, tiket.totalHarga, rute.stasiunAsal, rute.stasiunTujuan, rute.waktuBerangkat,  rute.waktuTiba, kereta.NamaKereta, kereta.kelasKereta FROM
                               tiket JOIN rute ON tiket.id_rute = rute.id_rute JOIN kereta ON tiket.Id_kereta = kereta.Id_kereta where id_tiket = @id_tiket";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@id_tiket", id_tiket);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Tiket tiket = new Tiket();
                            tiket.tanggal = reader["tgl_pesan"].ToString();
                            tiket.namaPenumpang = reader["namaPenumpang"].ToString();
                            tiket.stasiunBerangkat = reader["stasiunAsal"].ToString();
                            tiket.stasiunTujuan = reader["stasiunTujuan"].ToString();
                            tiket.waktuBerangkat = reader["waktuBerangkat"].ToString();
                            tiket.waktuTiba = reader["waktuTiba"].ToString();
                            tiket.namaKereta = reader["namaKereta"].ToString();
                            tiket.kelasKereta = reader["kelasKereta"].ToString();
                            tiket.nomorKursi = int.Parse(reader["nomorKursi"].ToString());
                            tiket.totalHarga = int.Parse(reader["totalHarga"].ToString());

                            list.Add(tiket);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll Eror : {0}", ex.Message);
            }
            return list;
        }

        //Query Menghapus kereta
        public int DeleteTiket(Tiket tiket)
        {
            int result = 0;
            string sql = @"delete from tiket where Id_tiket = @Id_tiket";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Id_tiket", tiket.Id_tiket);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }
            return result;
        }

        // Query Update Kereta
        public int Update(Tiket tiket, int id_tiket)
        {
            int result = 0;
            string sql = @"update tiket set  namaPenumpang = @namaPenumpang, tgl_pesan = @tgl_pesan,  NomorKursi = @NomorKursi,  TotalHarga = @TotalHarga, Id_Kereta = @Id_Kereta, Id_rute = @Id_rute  WHERE id_tiket = @id_tiket";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id_tiket", id_tiket);
                cmd.Parameters.AddWithValue("@namaPenumpang", tiket.namaPenumpang);
                cmd.Parameters.AddWithValue("@tgl_pesan", tiket.tanggal);
                cmd.Parameters.AddWithValue("@NomorKursi", tiket.nomorKursi);
                cmd.Parameters.AddWithValue("@TotalHarga", tiket.totalHarga);
                cmd.Parameters.AddWithValue("@Id_Kereta", tiket.Id_kereta);
                cmd.Parameters.AddWithValue("@Id_rute", tiket.Id_rute);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }
            return result;
        }

        //Query membaca jumlah penjumlahan
        public int JumlahTIketBulan(string tanggal)
        {
            int result = 0;
            string sql = "SELECT strftime('%m', tgl_pesan) as Bulan, SUM(totalHarga) as TotalHargaPerBulan FROM tiket WHERE strftime('%m', tgl_pesan) = strftime('%m', @tgl_pesan) GROUP BY strftime('%m', tgl_pesan)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@tgl_pesan", tanggal);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = Convert.ToInt32(reader["TotalHargaPerBulan"]);
                    }
                }
            }
            return result;
        }

        //Query membaca laporanPerbulan
        public List<Tiket> readTiektByMonth(string tanggal)
        {
            List<Tiket> list = new List<Tiket>();
            try
            {
                string sql = @"SELECT tiket.Id_tiket, tiket.namaPenumpang, tiket.tgl_pesan, tiket.nomorKursi, tiket.totalHarga, rute.stasiunAsal, rute.stasiunTujuan, rute.waktuBerangkat, rute.waktuTiba, kereta.NamaKereta, kereta.kelasKereta 
                                FROM tiket JOIN rute ON tiket.id_rute = rute.id_rute JOIN kereta ON tiket.Id_kereta = kereta.Id_kereta 
                                WHERE strftime('%m', tiket.tgl_pesan) = strftime('%m', @tgl_pesan)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@tgl_pesan", tanggal);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Tiket tiket = new Tiket();
                            tiket.tanggal = reader["tgl_pesan"].ToString();
                            tiket.namaPenumpang = reader["namaPenumpang"].ToString();
                            tiket.stasiunBerangkat = reader["stasiunAsal"].ToString();
                            tiket.stasiunTujuan = reader["stasiunTujuan"].ToString();
                            tiket.waktuBerangkat = reader["waktuBerangkat"].ToString();
                            tiket.waktuTiba = reader["waktuTiba"].ToString();
                            tiket.namaKereta = reader["namaKereta"].ToString();
                            tiket.kelasKereta = reader["kelasKereta"].ToString();
                            tiket.nomorKursi = int.Parse(reader["nomorKursi"].ToString());
                            tiket.totalHarga = int.Parse(reader["totalHarga"].ToString());

                            list.Add(tiket);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll Eror : {0}", ex.Message);
            }
            return list;
        }

        //Query mecari data tiket menggunakan nama dan bulan 
        public List<Tiket> readTiketByNamMonth(string nama, string tanggal)
        {
            List<Tiket> list = new List<Tiket>();
            try
            {
                string sql = @"SELECT tiket.Id_tiket, tiket.namaPenumpang, tiket.tgl_pesan, tiket.nomorKursi, tiket.totalHarga, rute.stasiunAsal, rute.stasiunTujuan, rute.waktuBerangkat, rute.waktuTiba, kereta.NamaKereta, kereta.kelasKereta 
                                FROM tiket JOIN rute ON tiket.id_rute = rute.id_rute JOIN kereta ON tiket.Id_kereta = kereta.Id_kereta 
                                WHERE namaPenumpang COLLATE Latin1_General_CS_AS LIKE @namaPenumpang COLLATE Latin1_General_CS_AS AND strftime('%m', tiket.tgl_pesan) = strftime('%m', @tgl_pesan) ";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@tgl_pesan", tanggal);
                    cmd.Parameters.AddWithValue("@namaPenumpang", nama);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Tiket tiket = new Tiket();
                            tiket.tanggal = reader["tgl_pesan"].ToString();
                            tiket.namaPenumpang = reader["namaPenumpang"].ToString();
                            tiket.stasiunBerangkat = reader["stasiunAsal"].ToString();
                            tiket.stasiunTujuan = reader["stasiunTujuan"].ToString();
                            tiket.waktuBerangkat = reader["waktuBerangkat"].ToString();
                            tiket.waktuTiba = reader["waktuTiba"].ToString();
                            tiket.namaKereta = reader["namaKereta"].ToString();
                            tiket.kelasKereta = reader["kelasKereta"].ToString();
                            tiket.nomorKursi = int.Parse(reader["nomorKursi"].ToString());
                            tiket.totalHarga = int.Parse(reader["totalHarga"].ToString());

                            list.Add(tiket);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll Eror : {0}", ex.Message);
            }
            return list;
        }

    }
}
