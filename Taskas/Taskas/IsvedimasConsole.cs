using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskas
{
    internal class IsvedimasConsole : IIsvedimascs
    {
        public void Isvedimas(int x, int y)
        {
            Console.WriteLine("Tasko x koordinate: {0} ir y koordinate: {1}", x, y);
        }
    }
}