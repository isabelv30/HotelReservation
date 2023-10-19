using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos
{
    public class HuespedModel
    {
        public int Id { get; set; }
        public string? Documento { get; set; }
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public Generos Genero { get; set; }
    }

    public enum Generos
    {
        Femenino,
        Masculino
    }
}
