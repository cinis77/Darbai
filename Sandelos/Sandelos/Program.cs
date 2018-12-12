using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandelos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Preke preke = new Preke();
            DataContext data = new DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\mokymai\repos\Sandelos\Sandelos\Database1.mdf;Integrated Security=True");
            var table = data.GetTable<Preke>();
            var vieta = data.GetTable<Vieta>();
            var sujungimas = table.Join(vieta, x => x.Name, y => y.PrekesPavadinimas,
                (a, b) => b.VietosPavadinimas);
            // preke.Name = "Braskes";
            Console.WriteLine(sujungimas.First().ToString());
            //preke.Id = 2;
            //table.InsertOnSubmit(preke);
            //data.SubmitChanges();
            // table.DeleteOnSubmit(preke);
            //  data.SubmitChanges();
            var sujungimas2 =
                from eilute in table
                join eil in vieta
                on eilute.Name equals eil.PrekesPavadinimas
                select eil.VietosPavadinimas;

            var uzklausa =
                from prek in table
                where prek.Name == "Vinys"
                select prek;
            Action metoda = () => Console.WriteLine("");
            Func<int, int, int> func = (x, y) => x + y;
            var uzklausa2 = table.Where(x => x.Name == "Vinys").OrderByDescending(x => x.Id);
        }
    }
}