using System;
using System.Collections.Generic;

using System.Windows.Forms;
using TicketTrainManagemnet.Controller;
using TicketTrainManagemnet.Model.Entity;

namespace TicketTrainManagemnet.View
{
    public partial class TabahKereta : Form
    {
        // delegete
        public delegate void addKereta(Kereta kereta);

        private Kereta kereta;
        private KeretaController _controller;
        private List<Kereta> _keretaList;

        bool isNewData = true;
        public static int Id_kereta;

        // handler
        public event addKereta onCreate;
        public event addKereta onUpdate;

        public TabahKereta()
        {
            _keretaList = new List<Kereta>();
            _controller = new KeretaController();
            InitializeComponent();
        }

        public TabahKereta(string title, KeretaController controller)
        : this()
        {
            this.Text = title;
            this._controller = controller;
        }
        public TabahKereta(string title, Kereta obj, KeretaController controller)
        : this()
        {
            this.Text = title;
            this._controller = controller;
            isNewData = false;
            kereta = obj;

            Id_kereta = obj.Id_kereta;
            lblKereta.Text = "Update Data";

            _keretaList = controller.readKeretaBById(Id_kereta);
            foreach (var kereta in _keretaList)
            {
                txtNamaKereta.Text = kereta.namaKereta;
                txtKelas.Text = kereta.kelasKereta;
                txtHarga.Text = kereta.Harga.ToString();
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isNewData) kereta = new Kereta();
            kereta.namaKereta = txtNamaKereta.Text;
            kereta.kelasKereta = txtKelas.Text;

            int hargaKereta;
            if (int.TryParse(txtHarga.Text, out hargaKereta))
            {
                kereta.Harga = hargaKereta;
            }
            else
            {
                txtHarga.Text = string.Empty;
            }

            int result = 0;
            if (isNewData)
            {
                result = _controller.addKereta(kereta);
                if (result > 0)
                {
                    onCreate(kereta);
                    this.Close();
                }
            }

            if (isNewData != true)
            {
                 result = _controller.updateKereta(kereta, Id_kereta);

                if (result > 0)
                {
                    onUpdate(kereta);
                    this.Close();
                }
            }
        }
    }
}
