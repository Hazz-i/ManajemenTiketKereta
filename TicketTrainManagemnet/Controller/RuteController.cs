using System;
using System.Collections.Generic;

using System.Windows.Forms;
using TicketTrainManagemnet.Model.Context;
using TicketTrainManagemnet.Model.Entity;
using TicketTrainManagemnet.Model.Repository;

namespace TicketTrainManagemnet.Controller
{
    public class RuteController
    {
        private RuteRepository _repository;

        //Read Rute
        public List<Rute> readAllRute()
        {
            List<Rute> list = new List<Rute>();
            using (DbContext context = new DbContext())
            {
                _repository = new RuteRepository(context);
                list = _repository.ReadRuteAll();
            }

            return list;
        }

        //Read Rute ById
        public List<Rute> readRuteById(int Id_rute)
        {
            List<Rute> list = new List<Rute>();
            using (DbContext context = new DbContext())
            {
                _repository = new RuteRepository(context);
                list = _repository.ReadRutebyId(Id_rute);
            }

            return list;
        }

        //Read Rute ByTnggal
        public List<Rute> redaRuteByTanggal(string tanggal)
        {
            List<Rute> list = new List<Rute>();
            using (DbContext context = new DbContext())
            {
                _repository = new RuteRepository(context);
                list = _repository.readByTanggal(tanggal);
            }

            return list;
        }


        //Read Rute ByNameStasiun
        public List<Rute> readyStasiun(string namaStasiun)
        {
            List<Rute> list = new List<Rute>();
            using (DbContext context = new DbContext())
            {
                _repository = new RuteRepository(context);
                list = _repository.readByName(namaStasiun);
            }

            if(list.Count == 0)
            {
                MessageBox.Show("Data yang anda cari tidak tersedia", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return list;
        }

        //Menambahkan Rute
        public int addRute(Rute rute)
        {
            int result = 0;

            if (string.IsNullOrEmpty(rute.stasiunBerangkat))
            {
                MessageBox.Show("Nama Stasiun tidak boleh kosong!!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (string.IsNullOrEmpty(rute.stasiunTujuan))
            {
                MessageBox.Show("Nama Stasiun Tujuan tidak boleh kosong!!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (string.IsNullOrEmpty(rute.waktuBerangkat) || string.IsNullOrEmpty(rute.waktuTiba))
            {
                MessageBox.Show("Waktu tidak boleh kosong!!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (rute.harga == 0)
            {
                MessageBox.Show("Harga tidak boleh kosong!!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new RuteRepository(context);
                result = _repository.InsertRute(rute);
            }

            if (result > 0)
            {
                MessageBox.Show("Data berhasil ditambahkan !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data gagal ditambahkan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }

        //Menghapus Rute
        public int DeleteRute(Rute rute)
        {
            int result = 0;

            var konfirmasi = MessageBox.Show("Apakah anda yakin untuk menghapus data ini ??", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                using (DbContext context = new DbContext())
                {
                    _repository = new RuteRepository(context);
                    result = _repository.DeleteRute(rute);
                }
            }

            if (result > 0)
            {
                MessageBox.Show("Data berhasil di hapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data gagal di hapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return result;
        }

        //Memperbarui Rute
        public int updateRute(Rute rute, int id_rute)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new RuteRepository(context);
                result = _repository.UpdateRute(rute, id_rute);
            }

            if (result > 0)
            {
                MessageBox.Show("Data berhasil diperbarui !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data gagal diperbarui !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }
    }
}
