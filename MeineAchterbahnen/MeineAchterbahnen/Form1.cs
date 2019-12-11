using HalloKlassen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MeineAchterbahnen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random ran = new Random();

            List<Achterbahn> meineBahnen = new List<Achterbahn>();

            for (int i = 0; i < 10; i++)
            {
                Achterbahn eineAchterbahn = new Achterbahn();
                eineAchterbahn.Name = $"Olympia Looping #{i:00}";
                eineAchterbahn.Hersteller = "Schwarzkopf";
                eineAchterbahn.Modell = "Klassik Lift";
                eineAchterbahn.Höchstgeschwindigkeit = ran.Next(10, 241);
                eineAchterbahn.Höhe = ran.Next(1, 139);
                eineAchterbahn.Länge = ran.NextDouble() * 10;
                eineAchterbahn.Baujahr = new DateTime(ran.Next(1980, 2019), 1, 1);
                eineAchterbahn.Sitzplätze = 28;

                meineBahnen.Add(eineAchterbahn);
            }

            dataGridView1.DataSource = meineBahnen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Zieldatei für Achterbahnenexport auswählen";
            dlg.Filter = "Achterbahndatei|*.acht|Alle Dateien|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(dlg.FileName);

                //auswählte Achterbahn lesen
                // Achterbahn achterbahn = (Achterbahn)dataGridView1.CurrentRow.DataBoundItem;
                // MessageBox.Show(achterbahn.Höchstgeschwindigkeit.ToString());

                StreamWriter sw = new StreamWriter(dlg.FileName);

                sw.WriteLine("Hersteller|Modell|Höchstgeschwindigkeit|Länge|Höhe|Sitzplätze|Baujahr");

                foreach (Achterbahn item in (List<Achterbahn>)dataGridView1.DataSource) //alle Achterbahnen aus dem Grid
                {
                    string trennzeichen = "|";
                    sw.Write(item.Hersteller);
                    sw.Write(trennzeichen);
                    sw.Write(item.Modell);
                    sw.Write(trennzeichen);
                    sw.Write(item.Höchstgeschwindigkeit);
                    sw.Write(trennzeichen);
                    sw.Write(item.Länge);
                    sw.Write(trennzeichen);
                    sw.Write(item.Höhe);
                    sw.Write(trennzeichen);
                    sw.Write(item.Sitzplätze);
                    sw.Write(trennzeichen);
                    sw.Write(item.Baujahr);
                    sw.Write(trennzeichen);
                    sw.WriteLine();

                }

                sw.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Achterbahndatei|*.acht|Alle Dateien|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlg.FileName);

                sr.ReadLine(); //header überspringen
                List<Achterbahn> bahnen = new List<Achterbahn>();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] teile = line.Split('|');
                    Achterbahn bahn = new Achterbahn();
                    bahn.Hersteller = teile[0];
                    bahn.Modell = teile[1];
                    bahn.Höchstgeschwindigkeit = int.Parse(teile[2]);
                    bahn.Länge = double.Parse(teile[3]);
                    bahn.Höhe = int.Parse(teile[4]);
                    bahn.Sitzplätze = int.Parse(teile[5]);
                    bahn.Baujahr = DateTime.Parse(teile[6]);
                    bahnen.Add(bahn);
                }
                dataGridView1.DataSource = bahnen;
            }
        }
    }
}
