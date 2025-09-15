using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B241210088_Proje
{
    class Daire : Mekan
    {
        public string DaireNo { get; set; }
        public string BlokNo { get; set; }
        public bool Durum { get; set; } // Boş/Dolu
        public string DaireSahibi { get; set; }
    }
}
