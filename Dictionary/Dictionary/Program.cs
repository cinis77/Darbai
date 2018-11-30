using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, int> zodynelis = new Dictionary<string, int>();
            zodynelis.Add("Vienas", 1);
            Console.WriteLine(zodynelis["Vienas"]);
        }
    }
}