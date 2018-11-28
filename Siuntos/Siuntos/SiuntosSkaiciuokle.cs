using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siuntos
{
    internal class SiuntosSkaiciuokle : ISiuntosTaisykles
    {
        private List<double> Ikainiai;
        private int SMonthCounter;

        public bool IsSent
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public SiuntosSkaiciuokle()
        {
            Ikainiai = new List<double>()
            {
                3,
                5,
                10,
                50
            };
        }

        public void SiuntosKainosSkaiciuokle(Siunta siunta)
        {
            switch (siunta.SiuntosDydis)
            {
                case "S":
                    siunta.Kaina = SSiuntosTaisykle(siunta.SiuntosDydis, siunta.SiuntimoData);
                    break;

                case "M":
                    siunta.Kaina = Ikainiai[1];
                    break;

                case "L":
                    siunta.Kaina = Ikainiai[2];
                    break;

                case "XL":
                    siunta.Kaina = XLSiuntosTaisykle(siunta.SiuntosDydis);

                    break;

                default:
                    siunta.Kaina = double.MaxValue;
                    break;
            }
        }

        private double XLSiuntosTaisykle(string SiuntosDydis)
        {
            if (SiuntosDydis == "XL")
            {
                return 0;
            }

            return Ikainiai[3];
        }

        private double SSiuntosTaisykle(string SiuntosDydis, DateTime siuntimoData)
        {
            if (SiuntosDydis == "S")
            {
                if (DateTime.Today.Month == siuntimoData.Month)
                {
                    SMonthCounter++;
                }
                else
                {
                    SMonthCounter = 0;
                }

                if (SMonthCounter <= 3)
                {
                    return Ikainiai[0] * 0.9;
                }
                else
                {
                    return Ikainiai[0];
                }
            }
            return Ikainiai[0];
        }
    }
}