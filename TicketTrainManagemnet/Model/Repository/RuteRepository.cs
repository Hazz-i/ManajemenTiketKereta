using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using TicketTrainManagemnet.Model.Context;
using TicketTrainManagemnet.Model.Entity;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace TicketTrainManagemnet.Model.Repository
{
    public class RuteRepository
    {
        // deklarsi objek connection
        private SQLiteConnection _conn;

        // constructor
        public RuteRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }

        //Query menambah Rute
        public int InsertRute(Rute rute)
        {
            int result = 0;
            string sql = "insert into Rute (stasiunAsal, stasiunTujuan, waktuBerangkat, waktuTiba, tanggal, harga) values (@stasiunAsal, @stasiunTujuan, @waktuBerangkat,  @waktuTiba, @tanggal, @harga)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@stasiunAsal", rute.stasiunBerangkat);
                cmd.Parameters.AddWithValue("@stasiunTujuan", rute.stasiunTujuan);
                cmd.Parameters.AddWithValue("@waktuBerangkat", rute.waktuBerangkat);
                cmd.Parameters.AddWithValue("@waktuTiba", rute.waktuTiba);
                cmd.Parameters.AddWithValue("@tanggal", rute.tanggal);
                cmd.Parameters.AddWithValue("@harga", rute.harga);

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

        //Query membaca Rute
        public List<Rute> ReadRuteAll()
        {
            List<Rute> list = new List<Rute>();
            try
            {
                string sql = @"select *from Rute ";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rute rute = new Rute();
                            rute.Id_rute = int.Parse(reader["Id_rute"].ToString());
                            rute.stasiunBerangkat = reader["stasiunAsal"].ToString();
                            rute.stasiunTujuan = reader["stasiunTujuan"].ToString();
                            rute.waktuBerangkat = reader["waktuBerangkat"].ToString();
                            rute.waktuTiba = reader["waktuTiba"].ToString();
                            rute.tanggal = reader["tanggal"].ToString();
                            rute.harga = int.Parse(reader["harga"].ToString());

                            list.Add(rute);

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

        //Query membaca kereta byId_Kereta
        public List<Rute> ReadRutebyId(int Id_rute)
        {
            List<Rute> list = new List<Rute>();
            try
            {
                string sql = @"select *from Rute where id_rute = @id_rute";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@id_rute", Id_rute);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rute rute = new Rute();
                            rute.stasiunBerangkat = reader["stasiunAsal"].ToString();
                            rute.stasiunTujuan = reader["stasiunTujuan"].ToString();
                            rute.waktuBerangkat = reader["waktuBerangkat"].ToString();
                            rute.waktuTiba = reader["waktuTiba"].ToString();
                            rute.tanggal = reader["tanggal"].ToString();
                            rute.harga = int.Parse(reader["harga"].ToString());
                            list.Add(rute);
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

        //Query membaca kereta byTanggal
        public List<Rute> readByTanggal(string tanggal)
        {
            List<Rute> list = new List<Rute>();
            try
            {
                string sql = @"SELECT* FROM Rute WHERE tanggal = @tanggal";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@tanggal", tanggal);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rute rute = new Rute();
                            rute.Id_rute = int.Parse(reader["Id_rute"].ToString());
                            rute.stasiunBerangkat = reader["stasiunAsal"].ToString();
                            rute.stasiunTujuan = reader["stasiunTujuan"].ToString();
                            rute.waktuBerangkat = reader["waktuBerangkat"].ToString();
                            rute.waktuTiba = reader["waktuTiba"].ToString();
                            rute.harga = int.Parse(reader["harga"].ToString());
                            rute.tanggal = reader["tanggal"].ToString();
                            list.Add(rute);
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

        //Query membaca kereta byNameStasiun
        public List<Rute> readByName(string namaStasiun)
        {
            List<Rute> list = new List<Rute>();
            try
            {
                string sql = @"SELECT *FROM Rute
                               WHERE stasiunAsal COLLATE Latin1_General_CS_AS LIKE @stasiunAsal COLLATE Latin1_General_CS_AS
                               OR stasiunTujuan COLLATE Latin1_General_CS_AS LIKE @stasiunAsal COLLATE Latin1_General_CS_AS";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@stasiunAsal", namaStasiun);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rute rute = new Rute();
                            rute.Id_rute = int.Parse(reader["Id_rute"].ToString());
                            rute.stasiunBerangkat = reader["stasiunAsal"].ToString();
                            rute.stasiunTujuan = reader["stasiunTujuan"].ToString();
                            rute.waktuBerangkat = reader["waktuBerangkat"].ToString();
                            rute.waktuTiba = reader["waktuTiba"].ToString();
                            rute.harga = int.Parse(reader["harga"].ToString());
                            rute.tanggal = reader["tanggal"].ToString();
                            list.Add(rute);
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

        //Query Menghapus Rute
        public int DeleteRute(Rute rute)
        {
            int result = 0;
            string sql = @"delete from rute where id_rute = @id_rute";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id_rute", rute.Id_rute);
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
        public int UpdateRute(Rute rute, int Id_rute)
        {
            int result = 0;
            string sql = @"update rute set  stasiunAsal = @stasiunAsal, stasiunTujuan = @stasiunTujuan, waktuBerangkat = @waktuBerangkat, waktuTiba = @waktuTiba, tanggal = @tanggal, Harga = @harga where Id_rute = @Id_rute";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Id_rute", Id_rute);
                cmd.Parameters.AddWithValue("@stasiunAsal", rute.stasiunBerangkat);
                cmd.Parameters.AddWithValue("@stasiunTujuan", rute.stasiunTujuan);
                cmd.Parameters.AddWithValue("@waktuBerangkat", rute.waktuBerangkat);
                cmd.Parameters.AddWithValue("@waktuTiba", rute.waktuTiba);
                cmd.Parameters.AddWithValue("@tanggal", rute.tanggal);
                cmd.Parameters.AddWithValue("@harga", rute.harga);
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
    }
}
