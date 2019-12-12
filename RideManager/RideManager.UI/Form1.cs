using RideManager.Model;
using System;
using System.ComponentModel;
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
            acht.MaxSpeed = 437634;

            liste.Add(acht);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var riesen = new Riesenrad() { Name = "Müncher Riesenrad am Ostbahnhof (High Sky)", AnzGondeln = 18 };
            liste.Add(riesen);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var scooter = new Autoscooter() { Name = "Hyper hyper", WattDerSoundanlage = 1000 };

            liste.Add(scooter);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object selectedDings = dataGridView1.CurrentRow.DataBoundItem;



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
    }
}
