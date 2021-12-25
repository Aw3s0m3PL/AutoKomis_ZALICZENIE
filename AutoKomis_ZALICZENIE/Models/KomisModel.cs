using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoKomis_ZALICZENIE.Models
{
    public class KomisModel
    {
        public int ID { get; set; }
        public string TytOglo { get; set; }
        public string TypNadwozia { get; set; }
        public string Marka { get; set; }
        public int Model { get; set; }
        public double Cena { get; set; }
        public int RokProd { get; set; }
        public string RodzPaliwa { get; set; }
        public long Przebieg { get; set; }
        public string Kategoria { get; set; }
        public string Opis { get; set; }
        public string Zdjecie{ get; set; }
    }
}
