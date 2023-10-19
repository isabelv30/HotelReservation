using System;
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
    public partial class FrmCheckIn : Form
    {
        public FrmCheckIn()
        {
            InitializeComponent();
        }

        private void FrmCheckIn_Load(object sender, EventArgs e)
        {
            this.BackColor = Theme.PrimaryColor();

            //lblTitulo.Color = Theme.PrimaryColor();
        }
    }
}
