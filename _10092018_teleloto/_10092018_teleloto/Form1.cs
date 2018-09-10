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

        private void Zaisti_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            Valymas();
            List<int> skaiciai = new List<int>();
            int i = 0;
            while (i < 45)
            {
                int skaicius = rng.Next(1, 76);
                int pozymis = 0;
                foreach (var item in skaiciai)
                {
                    if(item == skaicius)
                    {
                        pozymis++;
                    }
                }
                if (pozymis == 0)
                {
                    skaiciai.Add(skaicius);
                    BraukoSkaicius(skaicius);

                    textBox1.Text += skaicius.ToString() + " ";
                    i++;
                }
            }
        }

        private void Valymas()
        {
            TextBox[] TekstiniaiLaukai = { M1, M2, M3, M4, M5,
                J1, J2, J3, J4, J5,
             G1, G2, G3, G4, G5,
             R1, R2, R3, R4, R5,
           Z1, Z2, Z3, Z4, Z5 };
            textBox1.Text = "";
            foreach (var item in TekstiniaiLaukai)
            {
                item.BackColor = Color.White;
            }
        }

        private void BraukoSkaicius(int skaiciu)
        {
            if (skaiciu.ToString() == M1.Text)
            {
                M1.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == M2.Text)
            {
                M2.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == M3.Text)
            {
                M3.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == M4.Text)
            {
                M4.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == M5.Text)
            {
                M5.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == J1.Text)
            {
                J1.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == J2.Text)
            {
                J2.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == J3.Text)
            {
                J3.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == J4.Text)
            {
                J4.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == J5.Text)
            {
                J5.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == R1.Text)
            {
                R1.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == R2.Text)
            {
                R2.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == R3.Text)
            {
                R3.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == R4.Text)
            {
                R4.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == R5.Text)
            {
                R5.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == G1.Text)
            {
                G1.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == G2.Text)
            {
                G2.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == G3.Text)
            {
                G3.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == G4.Text)
            {
                G4.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == G5.Text)
            {
                G5.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == Z1.Text)
            {
                Z1.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == Z2.Text)
            {
                Z2.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == Z3.Text)
            {
                Z3.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == Z4.Text)
            {
                Z4.BackColor = Color.Green;
            }
            else if (skaiciu.ToString() == Z5.Text)
            {
                Z5.BackColor = Color.Green;
            }
        }
    }
}
