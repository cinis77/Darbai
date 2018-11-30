using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> skaiciai = new List<int>();

            for (int i = 10; i >= 0; i--)
            {
                skaiciai.Add(i);
            }

            skaiciai.Insert(5, 50000);
            IEnumerable<int> skaiciukai = skaiciai.Where(x => x < 3);

            foreach (var item in skaiciukai)
            {
                Console.WriteLine(item);
            }
            /*  skaiciai.Add(4);
              foreach (var item in skaiciai)
              {
                  Console.WriteLine(item);
              }

              Console.WriteLine(skaiciai.ElementAt(6));
              Console.WriteLine(skaiciai.ElementAtOrDefault(5000));
              var masyvas = skaiciai.ToArray();
              var sarass = masyvas.ToList();
              //skaiciai.Sort()
              skaiciai.Reverse();
              skaiciai.Clear();
              //skaiciai.RemoveAll(x => x == 4); // if(x==4)
              //skaiciai.RemoveAt(9);

              foreach (var item in skaiciai)
              {
                  Console.WriteLine(item);
              }
              */
        }
    }
}