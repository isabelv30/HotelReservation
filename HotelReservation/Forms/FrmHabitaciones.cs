﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation.Forms
{
    public partial class FrmHabitaciones : Form
    {
        public FrmHabitaciones()
        {
            InitializeComponent();
        }

        private void FrmHabitaciones_Load(object sender, EventArgs e)
        {
            this.BackColor = Theme.PrimaryColor();

        }

        public void ShowHabitaciones()
        {
            var hab = Data.GetHabitaciones();

        }

    }
}
