using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10092018_teleloto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generuoti_Click(object sender, EventArgs e)
        {
            
            TextBox[] MelynuEilute = { M1, M2, M3, M4, M5 };
            TextBox[] JuodaEilute = { J1, J2, J3, J4, J5 };
            TextBox[] GeltonaEilute = { G1, G2, G3, G4, G5 };
            TextBox[] RaudonaEilute = { R1, R2, R3, R4, R5 };
            TextBox[] ZaliaEilute = { Z1, Z2, Z3, Z4, Z5 };

            List<int> MelyniSkaiciai = new List<int>();
            List<int> JuodiSkaiciai = new List<int>();
            List<int> RaudoniSkaiciai = new List<int>();
            List<int> GeltoniSkaiciai = new List<int>();
            List<int> ZaliSkaiciai = new List<int>();

            SudeliojaSkaicius(MelynuEilute, 1, 16, ref MelyniSkaiciai);
            SudeliojaSkaicius(JuodaEilute, 16, 31, ref JuodiSkaiciai);
            SudeliojaSkaicius(RaudonaEilute, 31, 46, ref RaudoniSkaiciai);
            SudeliojaSkaicius(GeltonaEilute, 46, 61, ref GeltoniSkaiciai);
            SudeliojaSkaicius(ZaliaEilute, 61, 76, ref ZaliSkaiciai);

        }

        private void SudeliojaSkaicius(TextBox[] SpalvaEilute, 
            int apatineRiba, int virsutineRiba, ref List<int> SkaiciuSarasas)
        {
            Random rng = new Random();
            int i = 0;
            while (i < 5)
            {
                int skaicius = rng.Next(apatineRiba, virsutineRiba);
                int pozymis = 0;
                foreach (var item in SkaiciuSarasas)
                {
                    if (item == skaicius)
                    {
                        pozymis++;
                    }
                }
                if (pozymis == 0)
                {
                    SpalvaEilute[i].Text = skaicius.ToString();
                    SkaiciuSarasas.Add(skaicius);
                    i++;
                }
            }
        }
    }
}
