using System;

using System.Collections.Generic;
using System.Windows.Forms;
using TicketTrainManagemnet.Model.Entity;
using TicketTrainManagemnet.Controller;

namespace TicketTrainManagemnet.View
{
    public partial class TambahRute : Form
    {
        // delegete
        public delegate void addRute(Rute rute);

        private Rute rute;
        private RuteController _controller;
        private List<Rute> _ruteList;

        bool isNewData = true;
        public static int Id_rute;

        // handler
        public event addRute onCreate;
        public event addRute onUpdate;


        public TambahRute()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public TambahRute(string title, RuteController controller)
        : this()
        {
            this.Text = title;
            this._controller = controller;
        }
        public TambahRute(string title, Rute obj, RuteController controller)
        : this()
        {
            this.Text = title;
            this._controller = controller;
            isNewData = false;
            rute = obj;

            Id_rute = obj.Id_rute;
            lblRute.Text = "Update Data";

            _ruteList = controller.readRuteById(Id_rute);

            foreach(var rute in _ruteList)
            {
                txtStasiun.Text = rute.stasiunBerangkat;
                txtTujuan.Text = rute.stasiunTujuan;
                txtBerangkat.Text = rute.waktuBerangkat;
                txtSampai.Text = rute.waktuTiba;
                txtHarga.Text = rute.harga.ToString();
            }
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (isNewData) rute = new Rute();

            DateTime selectedDateTime = dte.Value;
            string strFormat = "yyyy-MM-dd";
            rute.tanggal = selectedDateTime.ToString(strFormat);

            rute.stasiunBerangkat = txtStasiun.Text;
            rute.stasiunTujuan = txtTujuan.Text;
            rute.waktuBerangkat = txtBerangkat.Text;
            rute.waktuTiba = txtSampai.Text;

            int hargaRute;
            if (int.TryParse(txtHarga.Text, out hargaRute))
            {
                rute.harga = hargaRute;
            }
            else
            {
                txtHarga.Text = string.Empty;
            }

            int result = 0;
            if (isNewData)
            {
                result = _controller.addRute(rute);
                if (result > 0)
                {
                    onCreate(rute);
                    this.Close();
                }
            }
            if (isNewData != true)
            {
                result = _controller.updateRute(rute, Id_rute);

                if (result > 0)
                {
                    onUpdate(rute);
                    this.Close();
                }
            }
        }

        private void txtSampai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
