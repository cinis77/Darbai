using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Sarasas<T>
    {
        private T[] masyvas;

        public Sarasas()
        {
            masyvas = new T[0];
        }

        public void PridetiNumeri(T numeris)
        {
            int ilgis = masyvas.Length;
            ilgis++;
            masyvas = new T[ilgis];
            masyvas[masyvas.Length - 1] = numeris;
        }

        public T[] GrazintiMasyva()
        {
            return masyvas;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var saras = new Sarasas<int>();
            var zodziai = new Sarasas<string>();
            zodziai.PridetiNumeri("Zodis");
            saras.PridetiNumeri(10);
            foreach (var item in saras.GrazintiMasyva())
            {
                Console.WriteLine(item);
            }
        }
    }
}