using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoldunuCempionatas
{
    public class PersivalgymasException : Exception
    {
        public string message { get; set; }

        public PersivalgymasException(string message)
        {
            this.message = message;
        }

        public PersivalgymasException()
        {
        }
    }

    internal class Dalyvis
    {
        public int ID { get; }
        public string Name { get; }
        public int SuvalgytuKoldunuKiekis { get; set; }
        public int SkrandzioDydis { get; set; }

        public Dalyvis(int ID, string Name, int SuvalgytuKoldunuKiekis, int SkrandzioDydis)
        {
            this.ID = ID;
            this.Name = Name;
            this.SuvalgytuKoldunuKiekis = SuvalgytuKoldunuKiekis;
            this.SkrandzioDydis = SkrandzioDydis;
        }
    }
}