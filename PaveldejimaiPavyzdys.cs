using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07092018_vartotojai
{
    class Vartotojas
    {
        public string Vardas { get; }
        public string Tipas { get; set; }
        public int Mokestis { get; set; }
        public int MokejimoSuma { get; set; }

        public Vartotojas(string vardas, string tipas)
        {
            Vardas = vardas;
            Tipas = tipas;
        }

        public virtual int SaskaitosMokejimas(int kiekis, int kaina)
        {
            return (kiekis * kaina);
        }
    }

    class VIP: Vartotojas
    {
        public VIP(string vardas, string tipas): base(vardas, tipas)
        {

        }

        public override int SaskaitosMokejimas(int kiekis, int kaina)
        {
            int suma = base.SaskaitosMokejimas(kiekis, kaina) / 2;
            return suma;
        }
    }

    class Silver: Vartotojas
    {
        public Silver(string vardas, string tipas) : base(vardas, tipas)
        {

        }

        public override int SaskaitosMokejimas(int kiekis, int kaina)
        {
            int suma = base.SaskaitosMokejimas(kiekis, kaina) / 2 + kaina;
            return suma;
        }
    }

    class Standard : Vartotojas
    {
        public Standard(string vardas, string tipas) : base(vardas, tipas)
        {

        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            VIP vipinis = new VIP("Nieko", "VIP");
            Silver silveris = new Silver("Tomas", "Silver");
            Standard standartinis = new Standard("Jonas", "Standartinis");
            Console.WriteLine("Vipinis klientas mokes: " + vipinis.SaskaitosMokejimas(10, 10));
            Console.WriteLine("Silver klientas mokes: " + silveris.SaskaitosMokejimas(10, 10));
            Console.WriteLine("Standard klientas mokes: " + standartinis.SaskaitosMokejimas(10, 10));
            List<Vartotojas> vartotojai = new List<Vartotojas>();
            vartotojai.Add(vipinis);
            vartotojai.Add(silveris);
            vartotojai.Add(standartinis);
            foreach (var item in vartotojai)
            {
                Console.WriteLine("{0} mokes: {1}", item.Tipas, item.SaskaitosMokejimas(20,20));
            }
        }
    }
}
