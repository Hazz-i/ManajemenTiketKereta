using Guna.UI2.AnimatorNS;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketTrainManagemnet.Controller;
using TicketTrainManagemnet.Model.Entity;

namespace TicketTrainManagemnet.View
{
    public partial class uc_laporan : UserControl
    {
        private List<Tiket> listTiket;
        private TiketController controller;
        private Tiket tiket;

        public static string tanggal;
        public static int jumlahPenjualan;
        public uc_laporan()
        {
            listTiket = new List<Tiket>();
            controller = new TiketController();
            tiket = new Tiket();

            InitializeComponent();
            InisialisasiLaporan();
        }

        private void InisialisasiLaporan()
        {
            lvwTIcket.View = System.Windows.Forms.View.Details;
            lvwTIcket.FullRowSelect = true;
            lvwTIcket.GridLines = true;

            lvwTIcket.Columns.Add("No", 30, HorizontalAlignment.Left);
            lvwTIcket.Columns.Add("Nama", 100, HorizontalAlignment.Center);
            lvwTIcket.Columns.Add("Kereta", 100, HorizontalAlignment.Center);
            lvwTIcket.Columns.Add("Kelas", 100, HorizontalAlignment.Center);
            lvwTIcket.Columns.Add("Stasiun Asal", 110, HorizontalAlignment.Center);
            lvwTIcket.Columns.Add("Stasiun Tujuan", 110, HorizontalAlignment.Center);
            lvwTIcket.Columns.Add("Kursi", 50, HorizontalAlignment.Center);
            lvwTIcket.Columns.Add("Tanggal", 100, HorizontalAlignment.Center);
            lvwTIcket.Columns.Add("Harga", 100, HorizontalAlignment.Center);
        }

        private void LoadDatalaporan()
        {
            lvwTIcket.Items.Clear();
            listTiket = controller.readTiketBymonth(tanggal);

            foreach (var tiket in listTiket)
            {
                var noUrut = lvwTIcket.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(tiket.namaPenumpang);
                item.SubItems.Add(tiket.namaKereta);
                item.SubItems.Add(tiket.kelasKereta);
                item.SubItems.Add(tiket.stasiunBerangkat);
                item.SubItems.Add(tiket.stasiunTujuan);
                item.SubItems.Add(tiket.nomorKursi.ToString());
                item.SubItems.Add(tiket.tanggal);
                item.SubItems.Add(tiket.totalHarga.ToString());
                lvwTIcket.Items.Add(item);
            }
        }

        private void dte_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDateTime = dte.Value;
            string strFormat = "yyyy-MM-dd";
            tanggal = selectedDateTime.ToString(strFormat);

            LoadDatalaporan();
            jumlahPenjualan = controller.JumlahTIketBulan(tanggal);

            txtJumlah.Text = $"Rp. {jumlahPenjualan};";
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string name = txtCari.Text;

            if(txtCari.Text != string.Empty)
            {
                lvwTIcket.Items.Clear();
                listTiket = controller.readTiketNamaMonth(name, tanggal);

                foreach (var tiket in listTiket)
                {
                    var noUrut = lvwTIcket.Items.Count + 1;
                    var item = new ListViewItem(noUrut.ToString());
                    item.SubItems.Add(tiket.namaPenumpang);
                    item.SubItems.Add(tiket.namaKereta);
                    item.SubItems.Add(tiket.kelasKereta);
                    item.SubItems.Add(tiket.stasiunBerangkat);
                    item.SubItems.Add(tiket.stasiunTujuan);
                    item.SubItems.Add(tiket.nomorKursi.ToString());
                    item.SubItems.Add(tiket.tanggal);
                    item.SubItems.Add(tiket.totalHarga.ToString());
                    lvwTIcket.Items.Add(item);
                }
            }
            else
            {
                LoadDatalaporan();
            }


        }
    }
}