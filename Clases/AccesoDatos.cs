using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto.Digests;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;

namespace Clases
{
    public class AccesoDatos
    {
        string connectionString;
        private static MySqlCommand command;
        private static MySqlConnection conection;
        Barco barco;

        public AccesoDatos(string server, string db)
        {
            connectionString = $"Server={server}; DataBase={db}; User ID=root; Password=;SslMode=none;";
            conection = new MySqlConnection(connectionString);
        }
        private MySqlConnection ConectarBD()
        {
            return new MySqlConnection(connectionString);
        }

        public List<Barco> SeleccionarEmpleados()
        {
            List<Barco> listaBarcos = new List<Barco>();

            using (var coneccion = ConectarBD())
            {
                coneccion.Open();
                string query = "SELECT * FROM barcos";

                MySqlCommand cmd = new MySqlCommand(query, coneccion);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string tipoBarco = reader.GetString("tipoBarco");
                    if (tipoBarco == "Pirata")
                    {
                        barco = new Pirata
                        {
                            Nombre = reader.GetString("nombreBarco"),
                            Tipo = (ETipoBarco)Enum.Parse(typeof(ETipoBarco), reader.GetString("tipoBarco")),
                            OPeracion = (EOperacion)Enum.Parse(typeof(EOperacion), reader.GetString("operacionHecha")),
                            Tripulacion = reader.GetInt32("cantidadTripulacion"),
                            Id = reader.GetInt32("id")
                        };

                    }
                    else if (tipoBarco == "Marina")
                    {

                        barco = new Marina
                        {
                            Nombre = reader.GetString("nombreBarco"),
                            Tipo = (ETipoBarco)Enum.Parse(typeof(ETipoBarco), reader.GetString("tipoBarco")),
                            OPeracion = (EOperacion)Enum.Parse(typeof(EOperacion), reader.GetString("operacionHecha")),
                            Tripulacion = reader.GetInt32("cantidadTripulacion"),
                            Id = reader.GetInt32("id")
                        };

                    }

                    listaBarcos.Add(barco);
                }
            }
            return listaBarcos;
        }

        public bool Guardar(Barco b)
        { 
            using (var conexion = ConectarBD())
            {
                conexion.Open();
                string query = "INSERT INTO barcos(mensaje,alumno,tipoBarco,nombreBarco,operacionHecha,cantidadTripulacion)"
                + $"VALUES (@mensaje, @alumno, @tipoBarco, @nombreBarco, @operacionHecha, @cantidadTripulacion)";

                command = new MySqlCommand(query, conexion);

                command.Parameters.AddWithValue("@mensaje", $"se reparo el {b.Nombre} a un costo de {b.Costo}");
                command.Parameters.AddWithValue("@alumno", "JosueDamacio");

                command.Parameters.AddWithValue("@tipoBarco", b.Tipo.ToString());
                command.Parameters.AddWithValue("@nombreBarco", b.Nombre);
                command.Parameters.AddWithValue("@operacionHecha", b.OPeracion.ToString());
                command.Parameters.AddWithValue("@cantidadTripulacion", b.Tripulacion);
                command.ExecuteNonQuery();
                return true;
            }
        }
        public void Modificar(Barco unBarco)
        {
            //ARREGLAR ESTO ANTES DE EJECUTAR
            using (var conexion = ConectarBD())
            {
                conexion.Open();

                string query = "UPDATE barcos SET nombreBarco = @nombreBarco, tipoBarco = @tipoBarco," +
                    " cantidadTripulacion = @cantidadTripulacion " +
                    "WHERE id = @id";
                MySqlCommand comando = new MySqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@nombreBarco", unBarco.Nombre);
                comando.Parameters.AddWithValue("@tipoBarco", unBarco.Tipo.ToString());
                comando.Parameters.AddWithValue("@cantidadTripulacion", unBarco.Tripulacion);
                comando.Parameters.AddWithValue("@id", unBarco.Id);

                comando.ExecuteNonQuery();

            }
        }
        public void Eliminar(int id, string nombreBarco)
        {
            using (var connection = ConectarBD())
            {
                connection.Open();
                string query = "DELETE FROM barcos WHERE id = @id AND nombre = @nombreBarco";
                MySqlCommand commando = new MySqlCommand(query, connection);
                commando.CommandText = query;

                commando.Parameters.AddWithValue("@id", id);
                commando.Parameters.AddWithValue("@nombre", nombreBarco);
                commando.ExecuteNonQuery();
            }
        }

    }
}
