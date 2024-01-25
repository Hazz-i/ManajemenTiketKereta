
using System;

using System.Windows.Forms;
using TicketTrainManagemnet.Model.Repository;
using TicketTrainManagemnet.Model.Context;

namespace TicketTrainManagemnet.Controller
{
    public class AdminController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private AdminRepository _repository;

        public bool IsValidUser(string userName, string password)
        {
            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("User name harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            bool isValidUser = false;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new AdminRepository(context);

                // panggil method Create class repository untuk menambahkan data
                isValidUser = _repository.IsValidUser(userName, password);
            }

            if (!isValidUser)
            {
                MessageBox.Show("User name atau password salah !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }
    }
}
