using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoldunuCempionatas;
using static KoldunuCempionatas.Dalyvis;

namespace KoldunuCempionatas
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
            List<Dalyvis> dalyviai = new List<Dalyvis>();
            using (System.IO.StreamReader reader = new System.IO.StreamReader(path))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    var data = line.Split(' ');
                    try
                    {
                        dalyviai.Add(new Dalyvis(int.Parse(data[0]), data[1], int.Parse(data[2]), int.Parse(data[3])));
                    }
                    catch (Exception)
                    {
                    }
                }
                DuomenuTikrinimas(dalyviai);
            }
        }

        private static void DuomenuTikrinimas(List<Dalyvis> dalyviai)
        {
            foreach (var item in dalyviai)
            {
                try
                {
                    if (item.SkrandzioDydis < item.SuvalgytuKoldunuKiekis)
                    {
                        throw new PersivalgymasException("Persivalge");
                    }

                    double valgymoGreitis = (double)item.SuvalgytuKoldunuKiekis / 60;
                    Console.WriteLine("{0} dalyvio valgymo greitis {1}", item.Name, valgymoGreitis);
                }
                catch (PersivalgymasException e)
                {
                    MessageBox.Show(e.message);
                }
                catch (DivideByZeroException e)
                {
                    MessageBox.Show("Dalyba is nulio negalima");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Unknown error");
                }
            }
        }
    }
}