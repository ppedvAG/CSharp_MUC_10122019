using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RideManager.UI
{
    public partial class AlterDialog : Form
    {
        public AlterDialog()
        {
            InitializeComponent();
        }

        public DateTime SelectedDate
        {
            get { return dateTimePicker1.Value.Date; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }


    }
}
