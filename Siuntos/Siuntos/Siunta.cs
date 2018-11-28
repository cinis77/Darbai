using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siuntos
{
    public class Siunta
    {
        public readonly List<Preke> PrekiuSarasas;
        private ISiuntosTaisykles siuntosTaisykle;

        /// <summary>
        /// Maximum weight of shipment for S size
        /// </summary>
        private const double SsiuntosSvoris = 0.5;

        /// <summary>
        /// Maximum weight of shipment for M size
        /// </summary>
        private const double MsiuntosSVoris = 2;

        /// <summary>
        /// Maximum weight of shipment for L size
        /// </summary>
        private const double LsiuntosSvoris = 5;

        public string Siuntejas { get; } // Klase
        public string Gavejas { get; set; } //Klase

        public double Kaina { get; set; }

        public DateTime SiuntimoData { get; set; }

        public string SiuntosDydis { get; private set; }

        public Siunta(string siuntejas, ISiuntosTaisykles taisykle)
        {
            Siuntejas = siuntejas;
            PrekiuSarasas = new List<Preke>();
            SiuntimoData = new DateTime();
            siuntosTaisykle = taisykle;
        }

        public void SiuntosDydzioSkaiciukle()
        {
            double svoris = 0;
            ///S - iki 0.5kg
            ///M - iki 2kg
            ///L - iki 5kg;
            ///XL -> inf
            ///
            foreach (var item in PrekiuSarasas)
            {
                svoris += item.Svoris;
            }
            if (svoris <= SsiuntosSvoris)// <- Magic number
            {
                SiuntosDydis = "S";
            }
            else if (svoris <= MsiuntosSVoris)
            {
                SiuntosDydis = "M";
            }
            else if (svoris <= LsiuntosSvoris)
            {
                SiuntosDydis = "L";
            }
            else if (svoris <= 50)
            {
                SiuntosDydis = "XL";
            }
            else
            {
                throw new NotImplementedException();
            }
            siuntosTaisykle.SiuntosKainosSkaiciuokle(this);
        }
    }
}