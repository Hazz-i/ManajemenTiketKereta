using System;
using System.Windows.Forms;

using TicketTrainManagemnet.Controller;
using TicketTrainManagemnet.View;

namespace TicketTrainManagemnet
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            chckPass.Checked = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AdminController controller = new AdminController();

            bool isValidUser = controller.IsValidUser(txtNaame.Text, txtPassword.Text);
            if (isValidUser)
            {
                HalamanUtama halamanUtama = new HalamanUtama();
                halamanUtama.Show();
                this.Visible = false;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chckPass_CheckedChanged(object sender, EventArgs e)
        {
            if(chckPass.Checked){
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
