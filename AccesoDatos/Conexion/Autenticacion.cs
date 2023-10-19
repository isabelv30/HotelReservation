using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Conexion
{
    public class Autenticacion
    {
        public string CadenaConexion()
        {
            string connectionString = "server=localhost;user=root;database=hotel;";
            return connectionString;
        }
    }
}
