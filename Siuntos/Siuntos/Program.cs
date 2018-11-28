using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Siuntos
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            string path = null;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                }
            }
            System.IO.StreamReader reader = new System.IO.StreamReader(path);

            string line = null;
            List<Siunta> siuntos = new List<Siunta>();
            while ((line = reader.ReadLine()) != null)
            {
                var data = line.Split(';');
                Siunta siunta = new Siunta("", new SiuntosSkaiciuokle());
                foreach (var item in data)
                {
                    var duomenys = item.Split('|');
                    Preke preke = new Preke(int.Parse(duomenys[0]), duomenys[1], double.Parse(duomenys[3]))
                    {
                        Aprašymas = duomenys[2]
                    };
                    siunta.PrekiuSarasas.Add(preke);
                }
                siuntos.Add(siunta);
            }

            Siunta laikinaSiunta = new Siunta("", new NaujosSiuntosTaisykles());
            SiuntosSkaiciuokle siuntosSkaiciuokle = new SiuntosSkaiciuokle();
            foreach (var item in siuntos)
            {
                item.SiuntosDydzioSkaiciukle();
                siuntosSkaiciuokle.SiuntosKainosSkaiciuokle(item);
                Console.WriteLine(item.Kaina);

                foreach (var itemai in item.PrekiuSarasas)
                {
                    Console.WriteLine(itemai.Pavadinimas);
                }
            }
        }
    }
}