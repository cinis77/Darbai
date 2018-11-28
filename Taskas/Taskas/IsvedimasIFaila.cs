using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskas
{
    internal class IsvedimasIFaila : IIsvedimascs
    {
        public void Isvedimas(int x, int y)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("Isvedimas.kcs"))
            {
                writer.WriteLine("Taskas: {0}, {1}", x, y);
            }
        }
    }
}