using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;

using System.Windows.Forms;
using TicketTrainManagemnet.Controller;
using TicketTrainManagemnet.Model.Entity;

namespace TicketTrainManagemnet.View
{
    public partial class uc_rute : UserControl
    {
        private List<Rute> listRute;
        private Rute rute;
        private RuteController controller;

        public uc_rute()
        {
            controller = new RuteController();
            listRute = new List<Rute>();

            InitializeComponent();
            inisialisasiRute();
            LoadDataRute();

        }


        private void inisialisasiRute()
        {
            lvwRute.View = System.Windows.Forms.View.Details;
            lvwRute.FullRowSelect = true;
            lvwRute.GridLines = true;

            lvwRute.Columns.Add("No", 50, HorizontalAlignment.Left);
            lvwRute.Columns.Add("Id Rute", 80, HorizontalAlignment.Center);
            lvwRute.Columns.Add("Stasiun", 100, HorizontalAlignment.Center);
            lvwRute.Columns.Add("Tujuan Stasiun", 100, HorizontalAlignment.Center);
            lvwRute.Columns.Add("Berangkat", 100, HorizontalAlignment.Center);
            lvwRute.Columns.Add("Sampai", 100, HorizontalAlignment.Center);
            lvwRute.Columns.Add("Tanggal", 150, HorizontalAlignment.Center);
            lvwRute.Columns.Add("Harga", 100, HorizontalAlignment.Center);
        }

        private void LoadDataRute()
        {
            lvwRute.Items.Clear();
            listRute = controller.readAllRute();

            foreach (var rute in listRute)
            {
                var noUrut = lvwRute.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(rute.Id_rute.ToString());
                item.SubItems.Add(rute.stasiunBerangkat);
                item.SubItems.Add(rute.stasiunTujuan);
                item.SubItems.Add(rute.waktuBerangkat.ToString());
                item.SubItems.Add(rute.waktuTiba.ToString());
                item.SubItems.Add(rute.tanggal);
                item.SubItems.Add(rute.harga.ToString());

                lvwRute.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(Rute rute)
        {
            LoadDataRute();
        }

        private void OnUpdateEventHandler(Rute rute)
        {
            LoadDataRute();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (lvwRute.SelectedItems.Count > 0)
            {
                Rute rute = listRute[lvwRute.SelectedIndices[0]];
                TambahRute updateData = new TambahRute("Update Data Transaksi", rute, controller);
                updateData.onUpdate += OnUpdateEventHandler;
                updateData.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahRute add = new TambahRute("Tambah Rute", controller);
            add.onCreate += OnCreateEventHandler;
            add.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwRute.SelectedItems.Count > 0)
            {

                // ambil objek mhs yang mau dihapus dari collection
                Rute rute = listRute[lvwRute.SelectedIndices[0]];

                int result = controller.DeleteRute(rute);


                if (result > 0)
                {
                    LoadDataRute();
                }
            }
            else
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string namaStasiun = txtCari.Text;

            if(txtCari.Text == string.Empty)
            {
                LoadDataRute();
            }
            else
            {
                lvwRute.Items.Clear();
                listRute = controller.readyStasiun(namaStasiun);

                foreach (var rute in listRute)
                {
                    var noUrut = lvwRute.Items.Count + 1;
                    var item = new ListViewItem(noUrut.ToString());
                    item.SubItems.Add(rute.Id_rute.ToString());
                    item.SubItems.Add(rute.stasiunBerangkat);
                    item.SubItems.Add(rute.stasiunTujuan);
                    item.SubItems.Add(rute.waktuBerangkat.ToString());
                    item.SubItems.Add(rute.waktuTiba.ToString());
                    item.SubItems.Add(rute.tanggal);
                    item.SubItems.Add(rute.harga.ToString());

                    lvwRute.Items.Add(item);
                }
            }
        }
    }
}
