using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MokiniuPazymiai
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<int>> StudentaiSuPazymiais;

        public Form1()
        {
            InitializeComponent();

            DataToLoad();
            foreach (var item in StudentaiSuPazymiais)
            {
                comboMokinys.Items.Add(item.Key);
            }
            Show();
        }

        private void DataToLoad()
        {
            string path = null;
            StudentaiSuPazymiais = new Dictionary<string, List<int>>();
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                }
            }

            // Name mark mark mark mark mark mark
            using (System.IO.StreamReader reader = new System.IO.StreamReader(path))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    var data = line.Split(' ');
                    string name = data.First();
                    var dataArray = data.ToList();
                    dataArray.Remove(name);
                    List<int> pazymiai = new List<int>();
                    foreach (var item in dataArray)
                    {
                        pazymiai.Add(int.Parse(item));
                    }
                    StudentaiSuPazymiais.Add(name, pazymiai);
                }
            }
        }

        private void comboMokinys_SelectedIndexChanged(object sender, EventArgs e)
        {
            textVidurkis.Text = StudentaiSuPazymiais[comboMokinys.SelectedItem.ToString()].Average().ToString("F2");
            StudentaiSuPazymiais[comboMokinys.SelectedItem.ToString()].Sort();
            textPazymiuMasyvai.Text = string.Empty;
            foreach (var item in StudentaiSuPazymiais[comboMokinys.SelectedItem.ToString()])
            {
                if (item < 5)
                {
                    textPazymiuMasyvai.ForeColor = Color.Red;
                }
                else
                {
                    textPazymiuMasyvai.ForeColor = Color.Black;
                }
                textPazymiuMasyvai.Text += item.ToString() + " ";
            }
            textVidurkis.BackColor = Color.White;
            if (StudentaiSuPazymiais[comboMokinys.SelectedItem.ToString()].Average() < 5)
            {
                textVidurkis.BackColor = Color.Red;
            }
            textVisiPazymiai.Text = string.Empty;
            foreach (var item in StudentaiSuPazymiais)
            {
                item.Value.Sort();
                foreach (var items in item.Value)
                {
                    textVisiPazymiai.Text += items.ToString() + " ";
                }
                textVisiPazymiai.Text += Environment.NewLine;
            }
        }
    }
}