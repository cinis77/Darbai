using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teleloto
{
    public partial class Teleloto : Form
    {
        public Teleloto()
        {
            InitializeComponent();
        }

        private void bGenerate_Click(object sender, EventArgs e)
        {
            TextBox[] Melyni = { M1, M2, M3, M4, M5 };
            TextBox[] Juodi = { J1, J2, J3, J4, J5 };
            TextBox[] Geltoni = { G1, G2, G3, G4, G5 };
            TextBox[] Raudoni = { R1, R2, R3, R4, R5 };
            TextBox[] Zali = { Z1, Z2, Z3, Z4, Z5 };
            GenerateRandomColumn(Melyni, 1, 16);
            GenerateRandomColumn(Juodi, 16, 31);
            GenerateRandomColumn(Geltoni, 31, 46);
            GenerateRandomColumn(Raudoni, 46, 61);
            GenerateRandomColumn(Zali, 61, 76);
        }

        private void GenerateRandomColumn(TextBox[] column, int start, int finish)
        {
            Random rng = new Random();
            int i = 0;
            while (i < column.Length)
            {
                string skaicius = rng.Next(start, finish).ToString();
                bool vienodi = false;
                foreach (var item in column)
                {
                    if (item.Text == skaicius)
                    {
                        vienodi = true;
                        break;
                    }
                }
                if (!vienodi)
                {
                    column[i].Text = skaicius;
                    i++;
                }
            }
        }

        private void bplay_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            TextBox[] _textboxContainer = { M1, M2, M3, M4, M5,
                J1, J2, J3, J4, J5,
                G1, G2, G3, G4, G5,
                R1, R2, R3, R4, R5,
                Z1, Z2, Z3, Z4, Z5
        };
            List<int> skaiciai = new List<int>();
            int i = 0;
            while (i < 49)
            {
                int temp = rng.Next(1, 76);
                bool vienodas = false;

                foreach (var item in skaiciai)
                {
                    if (item == temp)
                    {
                        vienodas = true;
                        break;
                    }
                }
                if (!vienodas)
                {
                    textNumbers.Text += temp + " ";
                    skaiciai.Add(temp);
                    CheckNumberOnTicket(_textboxContainer, temp.ToString());
                    i++;
                }
            }
        }

        private void CheckNumberOnTicket(TextBox[] container, string skaicius)
        {
            foreach (var item in container)
            {
                if (item.Text == skaicius)
                {
                    item.BackColor = Color.Green;
                }
            }
        }
    }
}