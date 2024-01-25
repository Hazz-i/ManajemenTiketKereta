using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TicketTrainManagemnet.Controller;
using TicketTrainManagemnet.Model.Entity;

namespace TicketTrainManagemnet.View
{
    public partial class uc_home : UserControl
    {
        private List<Tiket> listTiket; 
        private TiketController controller;

        public uc_home()
        {
            listTiket = new List<Tiket>();
            controller = new TiketController();

            InitializeComponent();
            InisialisasiTiket();
            LoadDataTiket();
        }

        private void InisialisasiTiket()
        {
            lvwTIcket.View = System.Windows.Forms.View.Details;
            lvwTIcket.FullRowSelect = true;
            lvwTIcket.GridLines = true;

            lvwTIcket.Columns.Add("No", 30, HorizontalAlignment.Left);
            lvwTIcket.Columns.Add("Id Tiket", 50, HorizontalAlignment.Center);
            lvwTIcket.Columns.Add("Nama", 100, HorizontalAlignment.Center);
            lvwTIcket.Columns.Add("Kereta", 100, HorizontalAlignment.Center);
            lvwTIcket.Columns.Add("Kelas", 100, HorizontalAlignment.Center);
            lvwTIcket.Columns.Add("Stasiun Asal", 105, HorizontalAlignment.Center);
            lvwTIcket.Columns.Add("Stasiun Tujuan", 105, HorizontalAlignment.Center);
            lvwTIcket.Columns.Add("Kursi", 50, HorizontalAlignment.Center);
            lvwTIcket.Columns.Add("Tanggal", 80, HorizontalAlignment.Center);
            lvwTIcket.Columns.Add("Harga", 80, HorizontalAlignment.Center);
        }

        private void LoadDataTiket()
        {
            lvwTIcket.Items.Clear();
            listTiket = controller.readAllTiket();

            foreach (var tiket in listTiket)
            {
                var noUrut = lvwTIcket.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(tiket.Id_tiket.ToString());
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

        public void OnCreateEventHandler(Tiket tiket)
        {
            LoadDataTiket();
        }

        public void OnUpdateEventHandler(Tiket tiket)
        {
            LoadDataTiket();
        }


        private void btnTambah_Click(object sender, EventArgs e)
        {
            lblTiket add = new lblTiket("Tambah Tiket", controller);
            add.onCreate += OnCreateEventHandler;
            add.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwTIcket.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau dihapus dari collection
                Tiket tiket= listTiket[lvwTIcket.SelectedIndices[0]];

                int result = controller.DeleteTiet(tiket);


                if (result > 0)
                {
                    LoadDataTiket();
                }
            }
            else
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (lvwTIcket.SelectedItems.Count > 0)
            {
                Tiket tiket = listTiket[lvwTIcket.SelectedIndices[0]];
                lblTiket updateData = new lblTiket("Update Tiket", tiket, controller);
                updateData.onUpdate += OnUpdateEventHandler;
                updateData.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string name = txtCari.Text;

            if(txtCari.Text == string.Empty)
            {
                LoadDataTiket();
            }
            else
            {
                lvwTIcket.Items.Clear();
                listTiket = controller.readByName(name);

                foreach (var tiket in listTiket)
                {
                    var noUrut = lvwTIcket.Items.Count + 1;
                    var item = new ListViewItem(noUrut.ToString());
                    item.SubItems.Add(tiket.Id_tiket.ToString());
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
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
