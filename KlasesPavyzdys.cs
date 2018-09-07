using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07092018_klases
{
    class Automobilis
    {
        //Atributai/ Kintamieji
        //<access specifier> <tipas> Pavadinimas;
        public string Marke;
        public string Tipas;
        public int GamybosMetai;
        public int Rida;

        //Algoritmu/ Metodu
        //<access specifier> <return type> Pavadinima (parametru sarasa)
        public int KiekKilometruNuvaziaPerMetus()
        {
            return (Rida / (DateTime.Today.Year - GamybosMetai));
        }

        public Automobilis(string marke, string tipas, int gamybosMetai, int rida)
        {
            Marke = marke;
            Tipas = tipas;
            GamybosMetai = gamybosMetai;
            Rida = rida;
        }
    }

    class Pastatai
    {
        #region Public Kintamieji
        private int Aukstis;
        private int Plotas;
        private int KambariuSkaicius;
        private string Spalva;
        private int _gatvesNumeris;

        public string Gatve { get; }
        public int GatvesNumeris
        {
            get { return _gatvesNumeris; }
            set
            {
                if (value < 23 && value > 1)
                {
                    if (value != _gatvesNumeris)
                    {
                        _gatvesNumeris = value;
                    }
                }
            }
        }
        public int ButuKiekis { get; private set; }
        #endregion

        #region Kontruktorius
        public Pastatai(int aukstis, int plotas, int kambariuSkaicius, 
            string spalva, string gatve)
        {
            Aukstis = aukstis;
            Plotas = plotas;
            KambariuSkaicius = kambariuSkaicius;
            Spalva = spalva;
            Gatve = gatve;
        }
        #endregion

        public void Informacija()
        {
            Console.WriteLine("Tai yra pastatas, kurio aukstis yra {0}, plotas yra {1}"
                +" galimas kambariu skaicius {2}, spalva: {3}", Aukstis, Plotas, 
                KambariuSkaicius, Spalva);
        }

        public void AukstisSet(int aukstis)
        {
            Aukstis = aukstis;
        }

        public int AukstisGet()
        {
            return Aukstis;
        }

        public void ButuKiekisSet(int butuKiekis)
        {
            ButuKiekis = butuKiekis;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Objektas
            Automobilis auto = new Automobilis("Audi", "A4", 2005, 25000);
            Automobilis auto1 = new Automobilis("Tesla", "S", 2014, 15000);
            Console.WriteLine(auto.KiekKilometruNuvaziaPerMetus());
            Console.WriteLine(auto1.KiekKilometruNuvaziaPerMetus());
            Pastatai pastatas = new Pastatai(300, 20000, 5, "Zalia", "Basanaviciaus");
            pastatas.Informacija();
            pastatas.AukstisSet(400);
            Console.WriteLine(pastatas.AukstisGet());
            Console.WriteLine(pastatas.Gatve);
            pastatas.GatvesNumeris = 23;
            pastatas.ButuKiekisSet(10);
        }
    }
}
