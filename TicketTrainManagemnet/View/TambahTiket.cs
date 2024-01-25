using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using System.Windows.Forms;
using TicketTrainManagemnet.Controller;
using TicketTrainManagemnet.Model.Entity;
using static TicketTrainManagemnet.View.TabahKereta;
using static TicketTrainManagemnet.View.TambahRute;

namespace TicketTrainManagemnet.View
{
    public partial class lblTiket : Form
    {
        // delegete
        public delegate void addTiket(Tiket tiket);

        private List<Kereta> listKereta;
        private List<Rute> listRute;
        private List<Tiket> listTiket;

        private KeretaController keretaController;
        private RuteController ruteController;
        private TiketController tiketController;

        private Tiket tiket;

        public static int Id_tiket;
        public string tanggal;
        bool isNewData = true;
        int ruteHarga = 0;
        int keretaharga = 0;
        int totalHarga = 0;

        // event
        public event addTiket onCreate;
        public event addTiket onUpdate;

        public lblTiket()
        {
            keretaController = new KeretaController();
            ruteController = new RuteController();
            tiketController = new TiketController();

            listTiket = new List<Tiket>();
            listKereta = new List<Kereta>();
            listRute = new List<Rute>();

            tiket = new Tiket();

            InitializeComponent();
            comboKereta();

            totalHarga = ruteHarga + keretaharga;
            txtHarga.Enabled = false;
        }

        public lblTiket(string title, TiketController controller)
        : this()
        {
            this.Text = title;
            this.tiketController = controller;

            listKereta = keretaController.readAllKereta();
            listRute = ruteController.readAllRute();
            if(listKereta.Count == 0)
            {
                MessageBox.Show("Silahkan Tambahkan Kereta dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaPengguna.Enabled = false;
                txtKursi.Enabled = false;
                cmbKereta.Enabled = false;
                cmbRute.Enabled = false;
                dte.Enabled = false;
            }
            else if (listRute.Count == 0)
            {
                MessageBox.Show("Silahkan Tambahkan Rute dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamaPengguna.Enabled = false;
                txtKursi.Enabled = false;
                cmbKereta.Enabled = false;
                cmbRute.Enabled = false;
                dte.Enabled = false;
            }
        }
        public lblTiket(string title, Tiket obj, TiketController controller)
        : this()
        {
            this.Text = title;
            this.tiketController = controller;
            isNewData = false;
            tiket = obj;

            Id_tiket = obj.Id_tiket;
            lblTambbahTiket.Text = "Update Data";

            listTiket= tiketController.readById(Id_tiket);

            foreach (var tiket in listTiket)
            {

                string tanggalString = tiket.tanggal;
                // Mengubah string tanggal ke dalam tipe data DateTime dengan format yang sesuai
                if (DateTime.TryParseExact(tanggalString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime tanggalTiket))
                {
                    dte.Value = tanggalTiket;
                }

                txtNamaPengguna.Text = tiket.namaPenumpang;
                txtHarga.Text = tiket.totalHarga.ToString();
                txtKursi.Text = tiket.nomorKursi.ToString();
            }
        }


        // memasukan data kereta dan kelas dari database
        public void comboKereta()
        {
            cmbKereta.Items.Clear();
            listKereta = keretaController.readAllKereta();

            foreach (var kereta in listKereta)
            {
                cmbKereta.Items.Add(kereta.Id_kereta.ToString() + ".\t"+ kereta.namaKereta+ "\t - \t" + kereta.kelasKereta);
                keretaharga = kereta.Harga; 
            }

        }

        // memasukan data rute dari database
        public void comboRute()
        {
            cmbRute.Items.Clear();
            listRute = ruteController.redaRuteByTanggal(tanggal);


            if (listRute.Any())
            {
                foreach (var rute in listRute)
                {
                    cmbRute.Items.Add(rute.Id_rute.ToString() + ".\t" + rute.stasiunBerangkat + "\t - \t" + rute.stasiunTujuan + " : " + rute.waktuBerangkat + " - " + rute.waktuTiba);
                    ruteHarga = rute.harga;
                }

            }
            else
            {
                cmbRute.Items.Clear();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (isNewData) tiket = new Tiket();

            tiket.tanggal = tanggal;
            tiket.namaPenumpang = txtNamaPengguna.Text;

            tiket.totalHarga = int.Parse(txtHarga.Text);

            // konversi no kursi dengan tryParse
            int nomorKursi;
            if (int.TryParse(txtKursi.Text, out nomorKursi))
            {
                tiket.nomorKursi = nomorKursi;
            }
            else
            {
                txtKursi.Text = string.Empty;
            }


            // mengambil id dari combo box
            // rute
            string selectedRute = cmbRute.SelectedItem.ToString();
            string[] partsRute = selectedRute.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries); // Pisahkan teks berdasarkan titik pertama (.)

            if (partsRute.Length > 0)
            {
                string idRute = partsRute[0].Trim(); // Mengambil bagian pertama setelah pemisahan (mengandung ID)
                
                if (int.TryParse(idRute, out int idRuteInt))
                {
                     tiket.Id_rute = idRuteInt;
                }
            }
            // kereta
            string selectedKereta = cmbKereta.SelectedItem.ToString();
            string[] partsKereta = selectedKereta.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            if (partsKereta.Length > 0)
            {
                string idKereta = partsKereta[0].Trim();
                
                if (int.TryParse(idKereta, out int idKeretaInt))
                {
                    tiket.Id_kereta = idKeretaInt;
                }
            }
            // END COMBOBOX //


            int result = 0;
            if (isNewData)
            {
                // validasi kusrsi sudah terisi atau belum
                bool valid = tiketController.validasiKursi(nomorKursi, tiket.Id_rute,tiket.Id_kereta);

                if (valid == false)
                {
                    result = tiketController.addTiket(tiket);
                    if (result > 0)
                    {
                        onCreate(tiket);
                        this.Close();
                    }
                }
            }

            if (isNewData != true)
            {
                result = tiketController.UpdateTiket(tiket, Id_tiket);

                if (result > 0)
                {

                    onUpdate(tiket);
                    this.Close();
                }
            }

        }

        private void dte_ValueChanged(object sender, EventArgs e)
        {
            // Mendapatkan tanggal dan waktu dari DateTimePicker
            DateTime selectedDateTime = dte.Value;
            string strFormat = "yyyy-MM-dd";
            tanggal = selectedDateTime.ToString(strFormat);

            comboRute();
        }

        private void cmbRute_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cek apakah item telah dipilih
            if (cmbRute.SelectedIndex != -1)
            {
                // Ambil jumlah film terpilih dari listRute
                int selectedRuteIndex = cmbRute.SelectedIndex;
                ruteHarga = listRute[selectedRuteIndex].harga;

                // Perbarui nilai totalHarga
                totalHarga = ruteHarga;

                // Tampilkan nilai totalHarga pada txtHarga
                txtHarga.Text = totalHarga.ToString();
            }
        }

        private void cmbKereta_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cek apakah item telah dipilih
            if (cmbKereta.SelectedIndex != -1)
            {
                // Ambil jumlah film terpilih dari listKereta
                int selectedKeretaIndex = cmbKereta.SelectedIndex;
                keretaharga = listKereta[selectedKeretaIndex].Harga;

                // Perbarui nilai totalHarga
                totalHarga = keretaharga;

                // Tampilkan nilai totalHarga pada txtHarga
                txtHarga.Text = totalHarga.ToString();
            }
        }
    }
}
