﻿using System;
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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBooking booking = new FormBooking();
            booking.ShowDialog();
        }

        private void btnstorage_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStoreInfo info = new FormStoreInfo();
            info.ShowDialog();
        }

        private void btnContactus_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormContactus contact = new FormContactus();
            contact.ShowDialog();
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formpurchase purchase = new Formpurchase();
            purchase.ShowDialog();
        }
    }
}
