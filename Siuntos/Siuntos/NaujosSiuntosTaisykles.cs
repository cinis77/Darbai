using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siuntos
{
    internal class NaujosSiuntosTaisykles : ISiuntosTaisykles
    {
        public bool IsSent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SiuntosKainosSkaiciuokle(Siunta siunta)
        {
            if (siunta.SiuntosDydis == "XL")
            {
                siunta.Kaina = 3;
            }
        }
    }
}