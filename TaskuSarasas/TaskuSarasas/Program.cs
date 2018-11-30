using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskuSarasas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rng = new Random();
            int centras = rng.Next(100);
            System.Drawing.Point centroTaskas = new System.Drawing.Point(rng.Next(-100, 100), rng.Next(-100, 100));
            int taskuKiekis = rng.Next(1000000);
            List<System.Drawing.Point> visiTaskai = new List<System.Drawing.Point>();
            for (int i = 0; i < taskuKiekis; i++)
            {
                System.Drawing.Point tempTaskas = new System.Drawing.Point(rng.Next(-200, 200), rng.Next(-200, 200));
                visiTaskai.Add(tempTaskas);
            }
            foreach (var item in visiTaskai)
            {
                var d = Math.Sqrt(Math.Pow(centroTaskas.X - item.X, 2) + Math.Pow(centroTaskas.Y - item.Y, 2));
                if (d < centras)
                {
                    Console.WriteLine("Taskas su koordinatemis {0} {1} ieina i apsikritima", item.X, item.Y);
                }
            }
        }
    }
}