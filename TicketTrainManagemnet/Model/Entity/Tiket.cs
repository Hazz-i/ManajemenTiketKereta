using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTrainManagemnet.Model.Entity
{
    public class Tiket
    {
        public int Id_tiket { get; set; }
        public string namaPenumpang { get; set; }
        public string tanggal { get; set; }
        public int nomorKursi { get; set; }
        public int totalHarga { get; set; }

        // menyimpan hasil join
        public int Id_rute { get; set; }
        public string stasiunBerangkat { get; set; }
        public string stasiunTujuan { get; set; }
        public string waktuBerangkat { get; set; }
        public string waktuTiba { get; set; }
        public int Id_kereta { get; set; }
        public string namaKereta { get; set; }
        public string kelasKereta { get; set; }

    }
}
