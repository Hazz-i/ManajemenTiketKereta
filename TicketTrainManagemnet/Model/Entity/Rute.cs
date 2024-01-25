using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTrainManagemnet.Model.Entity
{
    public class Rute
    {
        public int Id_rute { get; set; } 
        public string stasiunBerangkat { get; set; } 
        public string stasiunTujuan { get; set; } 
        public string tanggal { get; set; }
        public string waktuBerangkat { get; set; }
        public string waktuTiba { get; set; }
        public int harga { get; set; }
    }
}
