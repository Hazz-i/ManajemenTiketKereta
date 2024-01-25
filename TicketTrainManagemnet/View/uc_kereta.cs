using System;

using System.Collections.Generic;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using TicketTrainManagemnet.Controller;
using TicketTrainManagemnet.Model.Entity;

namespace TicketTrainManagemnet.View
{
    public partial class uc_kereta : UserControl
    {
        private List<Kereta> listKereta;
        private KeretaController controller;

        public uc_kereta()
        {
            List<Kereta> listKereta = new List<Kereta>();
            controller = new KeretaController();

            InitializeComponent();
            inisialisasiKereta();
            LoadDataKereta(); 
        }

        private void inisialisasiKereta()
        {
            lvwKereta.View = System.Windows.Forms.View.Details;
            lvwKereta.FullRowSelect = true;
            lvwKereta.GridLines = true;

            lvwKereta.Columns.Add("No", 50, HorizontalAlignment.Left);
            lvwKereta.Columns.Add("Id Kereta", 100, HorizontalAlignment.Center);
            lvwKereta.Columns.Add("Nama Kereta", 100, HorizontalAlignment.Center);
            lvwKereta.Columns.Add("Kelas Kereta", 100, HorizontalAlignment.Center);
            lvwKereta.Columns.Add("Harga", 100, HorizontalAlignment.Center);
        }

        private void LoadDataKereta()
        {
            lvwKereta.Items.Clear();
            listKereta = controller.readAllKereta();
            foreach (var kereta in listKereta)
            {
                var noUrut = lvwKereta.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(kereta.Id_kereta.ToString());
                item.SubItems.Add(kereta.namaKereta);
                item.SubItems.Add(kereta.kelasKereta);
                item.SubItems.Add(kereta.Harga.ToString());

                lvwKereta.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(Kereta kereta)
        {
            LoadDataKereta();
        }


        private void OnUpdateEventHandler(Kereta kereta)
        {
            LoadDataKereta();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

            TabahKereta add = new TabahKereta("Tambah Saldo", controller);
            add.onCreate += OnCreateEventHandler;
            add.ShowDialog();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (lvwKereta.SelectedItems.Count > 0)
            {
                Kereta kereta =listKereta[lvwKereta.SelectedIndices[0]];
                TabahKereta updateData = new TabahKereta("Update Data Transaksi", kereta, controller);
                updateData.onUpdate += OnUpdateEventHandler;
                updateData.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwKereta.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau dihapus dari collection
                Kereta kereta = listKereta[lvwKereta.SelectedIndices[0]];

                int result = controller.DeleteKereta(kereta);


                if (result > 0)
                {
                    LoadDataKereta();
                }
            }
            else
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string nama = txtCari.Text;

            if(txtCari.Text == string.Empty)
            {
                LoadDataKereta() ;
            }
            else
            {
                lvwKereta.Items.Clear();
                listKereta = controller.readByNama(nama);
                foreach (var kereta in listKereta)
                {
                    var noUrut = lvwKereta.Items.Count + 1;
                    var item = new ListViewItem(noUrut.ToString());
                    item.SubItems.Add(kereta.Id_kereta.ToString());
                    item.SubItems.Add(kereta.namaKereta);
                    item.SubItems.Add(kereta.kelasKereta);
                    item.SubItems.Add(kereta.Harga.ToString());

                    lvwKereta.Items.Add(item);
                }
            }


        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
