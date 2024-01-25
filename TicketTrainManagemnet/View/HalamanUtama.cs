using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketTrainManagemnet.View
{
    public partial class HalamanUtama : Form
    {
        public HalamanUtama()
        {
            InitializeComponent();
            uc_home home = new uc_home();
            addControll(home);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addControll(UserControl uc)
        {
            pannelContainer.Controls.Clear();
            uc.Dock  = DockStyle.Fill;
            uc.BringToFront();
            pannelContainer.Controls.Add(uc);
        }

        private void HalamanUtama_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            uc_home home = new uc_home();
            addControll(home);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKereta_Click(object sender, EventArgs e)
        {
            uc_kereta kereta = new uc_kereta();
            addControll(kereta);
        }

        private void btnLogin_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRute_Click(object sender, EventArgs e)
        {
            uc_rute rute = new uc_rute();
            addControll(rute);
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            uc_laporan laporan = new uc_laporan();
            addControll(laporan);
        }
    }
}
