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
    public partial class Formchekout : Form
    {
        public Formchekout()
        {
            InitializeComponent();
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInvoice b = new FormInvoice();
            b.ShowDialog();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBooking b = new FormBooking();
            b.ShowDialog();
        }
    }
}
