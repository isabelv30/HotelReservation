using Dapper;
using Dominio.Modelos;
using MySqlConnector;

namespace AccesoDatos.Data
{
    public class HabitacionesData
    {
        public HabitacionesData() 
        {

        }

        public List<HabitacionModel> SelectHabitaciones(string connectionString)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT Nombre, Tipo FROM Personas";

                    List<HabitacionModel> habitaciones = connection.Query<HabitacionModel>(query).ToList();

                    return habitaciones;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

        }


        public List<TipoHabitacionModel> SelectTiposHabitaciones(string connectionString)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT id, nombre, personas, precio FROM tiposhabitaciones;";

                    List<TipoHabitacionModel> habitaciones = connection.Query<TipoHabitacionModel>(query).ToList();

                    return habitaciones;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

        }
    }
}
