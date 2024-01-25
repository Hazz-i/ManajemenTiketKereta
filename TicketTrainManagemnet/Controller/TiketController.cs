using System;
using System.Collections.Generic;

using System.Windows.Forms;
using TicketTrainManagemnet.Model.Context;
using TicketTrainManagemnet.Model.Entity;
using TicketTrainManagemnet.Model.Repository;
using static TicketTrainManagemnet.View.lblTiket;

namespace TicketTrainManagemnet.Controller
{
    public class TiketController
    {
        private TiketRepository _repository;

        //membaca Tiket
        public List<Tiket> readAllTiket()
        {
            List<Tiket> list = new List<Tiket>();
            using (DbContext context = new DbContext())
            {
                _repository = new TiketRepository(context);
                list = _repository.ReadTiket();
            }

            return list;
        }

        //membaca TIket ByName
        public List<Tiket> readByName(string name)
        {
            List<Tiket> list = new List<Tiket>();
            using (DbContext context = new DbContext())
            {
                _repository = new TiketRepository(context);
                list = _repository.readByName(name);
            }
            if (list.Count == 0)
            {
                MessageBox.Show("Data yang anda cari tidak tersedia", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            return list;
        }

        //membaca TIket ById
        public List<Tiket> readById(int id_tiket)
        {
            List<Tiket> list = new List<Tiket>();
            using (DbContext context = new DbContext())
            {
                _repository = new TiketRepository(context);
                list = _repository.ReadTiketById(id_tiket);
            }

            return list;
        }

        //membaca Tiket perbulan
        public List<Tiket> readTiketBymonth(string tanggal)
        {
            List<Tiket> list = new List<Tiket>();
            using (DbContext context = new DbContext())
            {
                _repository = new TiketRepository(context);
                list = _repository.readTiektByMonth(tanggal);
            }

            return list;
        }

        //Menambahkan Tiket
        public int addTiket(Tiket tiket)
        {
            int result = 0;

            if (string.IsNullOrEmpty(tiket.namaPenumpang))
            {
                MessageBox.Show("Nama Penumpang tidak boleh kosong!!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            if (string.IsNullOrEmpty(tiket.nomorKursi.ToString()))
            {
                MessageBox.Show("Nomor Kursi tidak boleh kosong!!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new TiketRepository(context);
                result = _repository.InsertTiket(tiket);
            }

            if (result > 0)
            {
                MessageBox.Show("Data berhasil ditambahkan !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data gagal ditambahkan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }

        //Menghapus Tiket
        public int DeleteTiet(Tiket tiket)
        {
            int result = 0;

            var konfirmasi = MessageBox.Show("Apakah anda yakin untuk menghapus data ini ??", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                using (DbContext context = new DbContext())
                {
                    _repository = new TiketRepository(context);
                    result = _repository.DeleteTiket(tiket);
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

        //Memperbarui Tiket
        public int UpdateTiket(Tiket tiket, int id_tiket)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new TiketRepository(context);
                result = _repository.Update(tiket, id_tiket);
            }

            if (result > 0)
            {
                MessageBox.Show("Data berhasil diperbarui !!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data gagal diperbarui !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }

        //Validasi Kursi masi tersedia atau tidak
        public bool validasiKursi(int nomorKursi, int id_rute, int id_kereta) 
        {
            bool valid = false;
            using (DbContext context = new DbContext())
            {
                _repository = new TiketRepository(context);
                valid = _repository.validasiNomorKursi(nomorKursi, id_rute, id_kereta);
            }

            if (valid == true) 
            {
                MessageBox.Show("Kursi tidak tersedia", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return valid;
            }

            return valid;
        }

        //menjumlah penjualan dalam sebulan
        public int JumlahTIketBulan(string tanggal)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                _repository = new TiketRepository(context);
                result = _repository.JumlahTIketBulan(tanggal);
            }

            return result;
        }

        //mencari data tiket berdasarkan nama dan bulan 
        public List<Tiket> readTiketNamaMonth(string nama, string tanggal)
        {
            List<Tiket> list = new List<Tiket>();
            using (DbContext context = new DbContext())
            {
                _repository = new TiketRepository(context);
                list = _repository.readTiketByNamMonth(nama,tanggal);
            }

            if(list.Count == 0)
            {
                MessageBox.Show("Data yang anda cari tidak tersedia", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return list;
            }

            return list;
        }

    }
}
