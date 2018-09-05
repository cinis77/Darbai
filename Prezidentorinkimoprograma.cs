using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace _05092018_prezidentas
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            OpenFileDialog ofd = new OpenFileDialog(); //=> Open lango sukurimas
            string path = null; // Saugojamas kelias iki failo
            if(ofd.ShowDialog() == DialogResult.OK) // Atidaromas open langas
            {
                path = ofd.FileName; // nusiskaitomas kelias iki failo
            }
            //Console.WriteLine("Iveskite kandidatu vardus");
            StreamReader skaitytuvas = new StreamReader(path); // Sukuriamas skaitytuvas
            string duomenys = skaitytuvas.ReadLine();// Nuskaitomi duomenys is skaitytuvo
            string[] vardai = duomenys.Split(' '); // Zodziu eilute isskaidoma kad tarpa
            int max = int.MinValue;
            int maxValueIndex = -1;
            for (int i = 0; i < vardai.Length; i++)
            {
                char[] raides = vardai[i].ToLower().ToCharArray();
                int laikinas = UnikaliuRaidziuKiekisVarde(raides);
                if(laikinas > max)
                {
                    max = laikinas;
                    maxValueIndex = i;
                }
            }
            SaveFileDialog sfd = new SaveFileDialog(); // Sukuriamas saugojimo langas
            if (sfd.ShowDialog() == DialogResult.OK) // Atidaromas saugojimo langas
            {
                path = sfd.FileName; // Nusiskaitomas kelias iki sagojamo lango
            }
            StreamWriter rasytuvas = new StreamWriter(path); // sukuriamas skaitytuvas ir failas kuriame bus saugoma informacija
            rasytuvas.WriteLine("Prezidentu tapo: " + vardai[maxValueIndex]); // Paruosiama informacija rasymui
            rasytuvas.Flush(); // Informacijas parasoma
        }

        static int UnikaliuRaidziuKiekisVarde(char[] raidziu)
        {
            int unikaliosRaides = 0;
            for (int i = 0; i < raidziu.Length; i++)
            {
                int pozymis = 0;
                for (int j = (i+1); j < raidziu.Length; j++)
                {
                    if (raidziu[i] == raidziu[j])
                    {
                        pozymis++;
                    }
                }
                if (pozymis == 0)
                {
                    unikaliosRaides++;
                }
            }
            return unikaliosRaides;
        }
    }
}
