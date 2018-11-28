using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Point taskas = new Point(new IsvedimasIFaila());
            taskas.x = 5;
            taskas.y = 6;
            taskas.IsvestiKoordinate();
        }
    }
}