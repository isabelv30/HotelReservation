using HotelReservation.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace HotelReservation
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            this.BackColor = Theme.PrimaryColor();

            pnlHabitaciones.BackColor = Theme.SecondaryColor();
            lblMenuHabitaciones.ForeColor = Theme.PrimaryColor();
        }

        private void pnlHabitaciones_Click(object sender, EventArgs e)
        {
            FrmHabitaciones frmHab = new FrmHabitaciones();
            frmHab.TopLevel = false;
            frmHab.Parent = pnlFondo;
            frmHab.Show();
        }
    }
}
