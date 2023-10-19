using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos
{
    internal class FacturaModel
    {
        public int Id { get; set; }
        public string? Documento { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleFactura>? Detalle { get; set; }
    }

    public class DetalleFactura
    {
        public int Id { get; set; }
        public int ArticuloId { get; set; }
        public bool EsServicio { get; set; }
        public int Cantidad { get; set; }
        public decimal Valor { get; set; }
    }
}
