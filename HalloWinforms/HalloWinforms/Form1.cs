using System;
using System.Drawing;
using System.Windows.Forms;

namespace HalloWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int klickCount = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            klickCount++;

            textBox1.BackColor = Color.DarkMagenta;
            textBox1.Left += 3;

            button1.Text = klickCount + " klicks";

            //MessageBox.Show("Hallo " + textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            DateTime heute = DateTime.Now;

            TimeSpan ts = heute - dt;

            //todo: Messagebox: Das Ausgewählte Datum ist in der Zukunft/Vergangenheit
            if (dt.Date > heute.Date)
                MessageBox.Show("Das ausgewählte Datum ist in der Zukunft");
            if (dt.Date < heute.Date)
                MessageBox.Show("Das ausgewählte Datum ist in der Vergangenheit");
            else
                MessageBox.Show("Das ausgewählte Datum ist heute");


            MessageBox.Show(ts.ToString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
