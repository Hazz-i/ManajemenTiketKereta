using System;
using System.Collections.Generic;

using System.Windows.Forms;
using TicketTrainManagemnet.Model.Context;
using TicketTrainManagemnet.Model.Entity;
using TicketTrainManagemnet.Model.Repository;

namespace TicketTrainManagemnet.Controller
{
    public class KeretaController
    {
        private KeretaRepository _repository;

        //Read Kereta
        public List<Kereta> readAllKereta()
        {
            List<Kereta> list = new List<Kereta>();
            using (DbContext context = new DbContext())
            {
                _repository = new KeretaRepository(context);
                list = _repository.ReadKereta();
            }

            return list;
        }

        //Read Kereta ById
        public List<Kereta> readKeretaBById(int id_kereta)
        {
            List<Kereta> list = new List<Kereta>();
            using (DbContext context = new DbContext())
            {
                _repository = new KeretaRepository(context);
                list = _repository.ReadKeretabyId(id_kereta);
            }

            return list;
        }

        //Read Kereta ByNama
        public List<Kereta> readByNama(string namaKereta)
        {
            List<Kereta> list = new List<Kereta>();
            using (DbContext context = new DbContext())
            {
                _repository = new KeretaRepository(context);
                list = _repository.ReadkeretaBByNama(namaKereta);
            }

            if (list.Count == 0)
            {
                MessageBox.Show("Data yang anda cari tidak tersedia", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            return list;
        }

        //Menambahkan Kereta
        public int addKereta(Kereta kereta)
        {
            int result = 0;

            if (string.IsNullOrEmpty(kereta.namaKereta))
            {
                MessageBox.Show("Nama Kereta tidak boleh kosong!!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (string.IsNullOrEmpty(kereta.kelasKereta))
            {
                MessageBox.Show("Kelas Kereta tidak boleh kosong!!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (kereta.Harga == 0)
            {
                MessageBox.Show("Harga tidak boleh kosong!!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new KeretaRepository(context);
                result = _repository.InsertKereta(kereta);
            }

            if (result > 0)
            {
                MessageBox.Show("Kereta berhasil ditambahkan !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Kereta gagal ditambahkan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }

        //Menghapus Kereta
        public int DeleteKereta(Kereta kereta)
        {
            int result = 0;

            var konfirmasi = MessageBox.Show("Apakah anda yakin untuk menghapus data ini ??", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                using (DbContext context = new DbContext())
                {
                    _repository = new KeretaRepository(context);
                    result = _repository.DeleteKereta(kereta);
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

        //Memperbarui Kereta
        public int updateKereta(Kereta kereta, int id_kereta)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new KeretaRepository(context);
                result = _repository.Update(kereta, id_kereta);
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
