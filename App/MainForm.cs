using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_chambres_Click(object sender, EventArgs e)
        {
            ChambresForm chambresform = new ChambresForm();
            chambresform.Show();
        }

        private void btn_clients_Click(object sender, EventArgs e)
        {
            ClientsForm clientsform = new ClientsForm();
            clientsform.Show();
        }

        private void btn_reservations_Click(object sender, EventArgs e)
        {
            ReservationsForm reservationsform = new ReservationsForm();
            reservationsform.Show();
        }
    }
}
