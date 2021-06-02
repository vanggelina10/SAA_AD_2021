using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAA_AD_2021
{
    public partial class FormBooking : Form
    {
        public FormBooking()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formchekout check = new Formchekout();
            check.ShowDialog();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard check = new FormDashboard();
            check.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
