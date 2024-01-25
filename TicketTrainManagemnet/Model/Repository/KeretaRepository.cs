using System;

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using TicketTrainManagemnet.Model.Context;
using TicketTrainManagemnet.Model.Entity;

namespace TicketTrainManagemnet.Model.Repository
{
    public class KeretaRepository
    {
        // deklarsi objek connection
        private SQLiteConnection _conn;

        // constructor
        public KeretaRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }

        //Query menambah kereta
        public int InsertKereta(Kereta kereta)
        {
            int result = 0;
            string sql = "insert into Kereta (namaKereta, kelasKereta, harga) values (@namaKereta, @kelasKereta, @harga)";

            using (SQLiteCommand cmd = new SQLiteCommand( sql, _conn))
            {
                cmd.Parameters.AddWithValue("@namaKereta", kereta.namaKereta);
                cmd.Parameters.AddWithValue("@kelasKereta", kereta.kelasKereta);
                cmd.Parameters.AddWithValue("@harga", kereta.Harga);

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

        //Query membaca kereta
        public List<Kereta> ReadKereta()
        {
            List<Kereta> list = new List<Kereta>();
            try
            {
                string sql = @"select *from Kereta ";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Kereta kereta = new Kereta();
                            kereta.Id_kereta = int.Parse(reader["Id_kereta"].ToString());
                            kereta.namaKereta = reader["namaKereta"].ToString();
                            kereta.kelasKereta = reader["kelasKereta"].ToString();
                            kereta.Harga = int.Parse(reader["harga"].ToString());
                            list.Add(kereta);
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
        public List<Kereta> ReadKeretabyId(int id_kereta)
        {
            List<Kereta> list = new List<Kereta>();
            try
            {
                string sql = @"select *from Kereta where id_kereta = @id_kereta";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@id_kereta", id_kereta);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Kereta kereta = new Kereta();
                            kereta.namaKereta = reader["namaKereta"].ToString();
                            kereta.kelasKereta = reader["kelasKereta"].ToString();
                            kereta.Harga = int.Parse(reader["harga"].ToString());
                            list.Add(kereta);
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

        //Query membaca kereta ByNama
        public List<Kereta> ReadkeretaBByNama(string namaKereta)
        {
            List<Kereta> list = new List<Kereta>();
            try
            {
                string sql = @"select *from Kereta WHERE namaKereta COLLATE Latin1_General_CS_AS LIKE @namaKereta COLLATE Latin1_General_CS_AS";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@namaKereta", namaKereta);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Kereta kereta = new Kereta();
                            kereta.Id_kereta = int.Parse(reader["Id_kereta"].ToString());
                            kereta.namaKereta = reader["namaKereta"].ToString();
                            kereta.kelasKereta = reader["kelasKereta"].ToString();
                            kereta.Harga = int.Parse(reader["harga"].ToString());
                            list.Add(kereta);
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
        public int DeleteKereta(Kereta kereta)
        {
            int result = 0;
            string sql = @"delete from kereta where Id_kereta = @Id_kereta";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Id_kereta", kereta.Id_kereta);
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
        public int Update(Kereta kereta, int Id_kereta)
        {
            int result = 0;
            string sql = @"update kereta set  namaKereta = @namaKereta, kelasKereta = @kelasKereta, Harga = @harga where Id_kereta = @Id_kereta";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Id_kereta", Id_kereta);
                cmd.Parameters.AddWithValue("@namaKereta", kereta.namaKereta);
                cmd.Parameters.AddWithValue("@kelasKereta", kereta.kelasKereta);
                cmd.Parameters.AddWithValue("@harga", kereta.Harga);
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
