using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskas
{
    internal class Point
    {
        public int x;
        public int y;

        private IIsvedimascs Isvedimas;

        public Point(IIsvedimascs isvedimas)
        {
            Isvedimas = isvedimas;
        }

        public void IsvestiKoordinate()
        {
            Isvedimas.Isvedimas(x, y);
        }
    }
}