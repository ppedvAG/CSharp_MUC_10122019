using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDScreensaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int nachLinks = 3;
        int nachOben = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Right >= ClientRectangle.Right || button1.Left <= 0)
                nachLinks *= -1;

            if (button1.Bottom >= ClientRectangle.Bottom || button1.Top <= 0)
                nachOben *= -1;

            button1.Left += nachLinks;
            button1.Top += nachOben;

        }
    }
}
