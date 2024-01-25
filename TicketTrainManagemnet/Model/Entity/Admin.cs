using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTrainManagemnet.Model.Entity
{
    public class Admin
    {
        public int Id_admin{ get; set; }
        public string namaAdmin{ get; set; }
        public string jenisKelamin { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
