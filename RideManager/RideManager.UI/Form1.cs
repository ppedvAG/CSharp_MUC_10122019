using RideManager.Model;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RideManager.UI
{
    public partial class Form1 : Form
    {
        BindingList<Fahrgeschäft> liste = new BindingList<Fahrgeschäft>();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = liste;

            Trace.AutoFlush = true;
            Trace.Listeners.Add(new EventLogTraceListener("Application"));
            Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    Fahrgeschäft fg = new Fahrgeschäft()
            //    {
            //        Name = "NEU",
            //        Baujahr = DateTime.Now
            //    };

            //  liste.Add(fg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var acht = new Achterbahn();
            acht.Name = "8terbahn";
            acht.MaxSpeed = 500;

            liste.Add(acht);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var riesen = new Riesenrad() { Name = "Müncher Riesenrad am Ostbahnhof (High Sky)", AnzGondeln = 18 };
            liste.Add(riesen);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var scooter = new Autoscooter()
                {
                    Name = "Hyper hyper",
                    WattDerSoundanlage = 500
                };

                liste.Add(scooter);

            }
            catch (AutoScooterToLessPowerException ex)
            {
                MessageBox.Show($"{ex.Message} es sollten {ex.MinPower} sein");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object selectedDings = dataGridView1.CurrentRow.DataBoundItem;

            if (selectedDings is IAlter alter)
            {
                AlterDialog dlg = new AlterDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (alter.AlterPrüfen(dlg.SelectedDate))
                    {
                        MessageBox.Show("Viel Spaß");
                    }
                    else
                    {
                        MessageBox.Show("Schade");
                    }
                }
                // if (MessageBox.Show($"Bist du schon {alter.MindestAlter}?",
                //                     "Altersprüfung",
                //                     MessageBoxButtons.YesNo,
                //                     MessageBoxIcon.Question) == DialogResult.Yes)
                // {
                //     MessageBox.Show("Ok");
                // }
                // else
                // {
                //     MessageBox.Show("Schade!");
                //     return;
                // }

            }


            if (selectedDings is Achterbahn) //typ prüfung
            {
                Achterbahn achter = (Achterbahn)selectedDings; //casting
                MessageBox.Show($"Das ausgewählte Dings ist eine Achterbahn mit {achter.MaxSpeed} km/h MaxSpeed");
            }

            Riesenrad rad = selectedDings as Riesenrad;    //boxing
            if (rad != null)
                MessageBox.Show($"Das ist ein riesieges Rad mit  {rad.AnzGondeln} Gondeln");

            if (selectedDings is Autoscooter scooter) //pattern matching
            {
                MessageBox.Show($"Scooooter mit {scooter.WattDerSoundanlage}W");
            }

            if (selectedDings is Fahrgeschäft fg)
            {
                MessageBox.Show($"Preis {fg.GetTicketPreis(DateTime.Now):c}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int lala = 7 / int.Parse("0");
                StreamReader sr = new StreamReader("l:\\owregbgewüwegwe.ewgiewbf");

            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show("Nix Folder!");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Nix Datei!");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Da ist was mit der IO Faul!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler :-( {ex.Message}");
                Trace.WriteLine($"ERROR: {ex.Message}");
            }
        }
    }
}
