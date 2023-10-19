using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class Theme
    {
        public static Color PrimaryColor() 
        {
            return System.Drawing.Color.FromArgb(7, 37, 65);
        }

        public static Color SecondaryColor()
        {
            return System.Drawing.Color.FromArgb(82, 114, 242);
        }

        public static Color LightColor()
        {
            return System.Drawing.Color.FromArgb(248, 189, 235);
        }

        public static Color AccentureColor()
        {
            return System.Drawing.Color.FromArgb(251, 236, 178);
        }
    }
}
