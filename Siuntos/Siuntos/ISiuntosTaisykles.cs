using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siuntos
{
    public interface ISiuntosTaisykles
    {
        bool IsSent { get; set; }

        void SiuntosKainosSkaiciuokle(Siunta siunta);
    }
}