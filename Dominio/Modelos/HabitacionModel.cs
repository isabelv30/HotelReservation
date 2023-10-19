using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos
{
    public class HabitacionModel
    {
        public int Id { get; set; }
        public TipoHabitacionModel? TipoHabitacion { get; set; }
        public bool Estado { get; set; }
    }

    public class TipoHabitacionModel
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Personas { get; set; }
    }
}
