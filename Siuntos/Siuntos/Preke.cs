using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siuntos
{
    public class Preke
    {
        public double Svoris { get; }
        public int ID { get; }
        public string Aprašymas { get; set; }

        public string Pavadinimas { get; }

        public Preke(int id, string pavadinimas, double svoris)
        {
            ID = id;
            Pavadinimas = pavadinimas;
            Svoris = svoris;
        }
    }
}